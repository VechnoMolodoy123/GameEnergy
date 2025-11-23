using GameEnergy.Classes.Animations;
using GameEnergy.Classes.Images.InstallingImages;
using GameEnergy.Classes.Messages;
using GameEnergy.Classes.Validation;
using GameEnergy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;

namespace GameEnergy.AppForms.AdminForms
{
    public partial class CreateOrUpdateGameForm : Form
    {
        public event Action GameUpdated;
        private string _selectedImagePath;
        private Games _editingGame;

        public CreateOrUpdateGameForm(Games game = null)
        {
            InitializeComponent();

            _editingGame = game;

            LoadGameInfo();
        }

        private void LoadGameInfo()
        {
            if (_editingGame != null)
            {
                titleLabel.Text = "Изменить книгу";
                addGameButton.Text = "Изменить книгу";

                nameTextBox.Text = _editingGame.Title;
                trailerNameTextBox.Text = _editingGame.TrailerImage;
                descriptionTextBox.Text = _editingGame.Description ?? string.Empty;

                priceTextBox.Text = _editingGame.Price.ToString();
                discountTextBox.Text = _editingGame.Discount?.ToString() ?? string.Empty;

                releaseDateTextBox.Text = _editingGame.ReleaseDate?.ToString("dd.MM.yyyy");

                if (_editingGame.DeveloperID.HasValue)
                    developerComboBox.SelectedIndex = _editingGame.DeveloperID.Value;

                if (_editingGame.CategoryID.HasValue)
                    categoryComboBox.SelectedIndex = _editingGame.CategoryID.Value;

                Image image = ImageLoader.LoadGameImage(_editingGame.GameImage);

                if (image != null) gamePictureBox.Image = image;

                var gameGenreIds = _editingGame.GameGenres.Select(g => g.GenreID).ToHashSet();
                for (int i = 0; i < genreCheckedList.Items.Count; i++)
                {
                    var genreName = genreCheckedList.Items[i].ToString();
                    var genre = Program.context.Genres.First(g => g.GenreName == genreName);
                    genreCheckedList.SetItemChecked(i, gameGenreIds.Contains(genre.GenreID));
                }
            }
        }

        private void ValidateAndSubmit()
        {
            bool isValid = true;

            // Название
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.BorderColor = Color.Red;
                isValid = false;
            }
            else
                nameTextBox.BorderColor = Color.FromArgb(251, 187, 67);

            // Разработчик
            if (developerComboBox.SelectedIndex == 0)
            {
                developerComboBox.BorderColor = Color.Red;
                isValid = false;
            }
            else
                developerComboBox.BorderColor = Color.FromArgb(251, 187, 67);

            // Цена
            int price;
            if (!int.TryParse(priceTextBox.Text, out price) || price <= 0)
            {
                priceTextBox.BorderColor = Color.Red;
                isValid = false;
            }
            else
            {
                priceTextBox.BorderColor = Color.FromArgb(251, 187, 67);
            }

            // Скидка (может быть пустой)
            int? discount = null;
            if (!string.IsNullOrWhiteSpace(discountTextBox.Text))
            {
                if (!int.TryParse(discountTextBox.Text, out int d) || d < 0 || d > 100)
                {
                    discountTextBox.BorderColor = Color.Red;
                    isValid = false;
                }
                else
                {
                    discount = d;
                    discountTextBox.BorderColor = Color.FromArgb(251, 187, 67);
                }
            }
            else
            {
                discountTextBox.BorderColor = Color.FromArgb(251, 187, 67);
            }

            // Дата релиза (может быть пустой)
            DateTime? releaseDate = null;
            if (!string.IsNullOrWhiteSpace(releaseDateTextBox.Text))
            {
                // Попытка распарсить дату в формате "дд.ММ.гггг" (например, 11.09.2024)
                if (!DateTime.TryParseExact(releaseDateTextBox.Text, "dd.MM.yyyy", null,
                    System.Globalization.DateTimeStyles.None, out DateTime parsedDate))
                {
                    MessageHelper.ShowErrorMessage("Неверный формат даты релиза.\nПример правильного формата: 11.09.2024");
                    isValid = false;
                }
                else
                {
                    releaseDate = parsedDate;
                }
            }

            // Описание
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionTextBox.BorderColor = Color.Red;
                isValid = false;
            }
            else
                descriptionTextBox.BorderColor = Color.FromArgb(251, 187, 67);

            // Жанры — хотя бы один
            bool hasGenre = false;
            for (int i = 0; i < genreCheckedList.Items.Count; i++)
            {
                if (genreCheckedList.GetItemChecked(i))
                {
                    hasGenre = true;
                    break;
                }
            }
            if (!hasGenre)
            {
                MessageHelper.ShowErrorMessage("Пожалуйста укажите хотя бы 1 жанр");
                isValid = false;
            }

            if (!isValid) return;

            // Подтверждение
            var message = _editingGame != null
                ? "Сохранить изменения?"
                : "Добавить новую игру?";
            if (MessageBox.Show(message, "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveGameToDatabase(price, discount, releaseDate);
            }
        }

        private void SaveGameToDatabase(int price, int? discount, DateTime? releaseDate)
        {
            try
            {
                string imageName = _editingGame?.GameImage; // сохраняем старое имя, если не меняли

                // Сохранение изображения, если выбрано новое
                if (!string.IsNullOrEmpty(_selectedImagePath))
                {
                    string fileName = Path.GetFileName(_selectedImagePath);
                    string imgDir = Path.Combine(Application.StartupPath, "gameImg");
                    Directory.CreateDirectory(imgDir);
                    string destPath = Path.Combine(imgDir, fileName);
                    File.Copy(_selectedImagePath, destPath, overwrite: true);
                    imageName = fileName;
                }

                if (_editingGame == null)
                {
                    // Создание новой игры
                    var newGame = new Games
                    {
                        Title = nameTextBox.Text,
                        Description = descriptionTextBox.Text,
                        Price = price,
                        Discount = discount,
                        TrailerImage = trailerNameTextBox.Text ?? string.Empty,
                        GameImage = imageName ?? string.Empty,
                        DeveloperID = developerComboBox.SelectedIndex,
                        CategoryID = categoryComboBox.SelectedIndex == 0 ? (int?)null : categoryComboBox.SelectedIndex,
                        AverageRating = 0,
                        AddedDate = DateTime.Now,
                        ReleaseDate = releaseDate
                    };

                    Program.context.Games.Add(newGame);
                    Program.context.SaveChanges(); // нужно ID игры для связей

                    // Связь с жанрами
                    SaveGameGenres(newGame.GameID);
                }
                else
                {
                    // Обновление существующей
                    var gameToUpdate = Program.context.Games.Find(_editingGame.GameID);
                    if (gameToUpdate == null) throw new Exception("Игра не найдена.");

                    gameToUpdate.Title = nameTextBox.Text;
                    gameToUpdate.Description = descriptionTextBox.Text;
                    gameToUpdate.Price = price;
                    gameToUpdate.Discount = discount;
                    gameToUpdate.TrailerImage = trailerNameTextBox.Text ?? string.Empty;
                    gameToUpdate.GameImage = imageName ?? string.Empty;
                    gameToUpdate.DeveloperID = developerComboBox.SelectedIndex;
                    gameToUpdate.CategoryID = categoryComboBox.SelectedIndex == 0 ? (int?)null : categoryComboBox.SelectedIndex;
                    gameToUpdate.ReleaseDate = releaseDate;

                    // Удаляем старые жанры и добавляем новые
                    var existingGenres = Program.context.GameGenres.Where(gg => gg.GameID == gameToUpdate.GameID);
                    Program.context.GameGenres.RemoveRange(existingGenres);
                    Program.context.SaveChanges();

                    SaveGameGenres(gameToUpdate.GameID);
                }

                Program.context.SaveChanges();
                if (_editingGame != null)
                {
                    GameUpdated?.Invoke();
                }
                MessageBox.Show(_editingGame == null ? "Игра добавлена!" : "Игра обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveGameGenres(int gameId)
        {
            for (int i = 0; i < genreCheckedList.Items.Count; i++)
            {
                if (genreCheckedList.GetItemChecked(i))
                {
                    var genreName = genreCheckedList.Items[i].ToString();
                    var genre = Program.context.Genres.First(g => g.GenreName == genreName);
                    Program.context.GameGenres.Add(new GameGenres
                    {
                        GameID = gameId,
                        GenreID = genre.GenreID
                    });
                }
            }
        }

        private void GamePictureBox_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                dlg.Title = "Выберите обложку игры";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = dlg.FileName;
                    gamePictureBox.Image = Image.FromFile(_selectedImagePath);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void collapseButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void navigationPanel_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(this);
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            ValidateAndSubmit();
        }
    }
}
