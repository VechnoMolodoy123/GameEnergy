using GameEnergy.AppForms.AdminForms;
using GameEnergy.Classes.Customization;
using GameEnergy.CustomControls;
using GameEnergy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Guna.UI2.Native.WinApi;

namespace GameEnergy.AppForms.UserForms
{
    public partial class GameСatalogForm : Form
    {
        int _sortIndex = 0;
        int _priceIndex = 0;
        int _genreIndex = 0;
        int _developerIndex = 0;

        public GameСatalogForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);

            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
            addGameButton.Visible = IsAdmin();

            ApplyFiltersAndSort();
        }

        private bool IsAdmin()
        {
            if (Program.CurrentUser.UserRoleID == 2)
            {
                addGamePanel.Height = 76;
                return true;
            }
            addGamePanel.Height = 20;
            return false;
        }

        private void ApplyFiltersAndSort()
        {
            IQueryable<Games> query = Program.context.Games.AsNoTracking();

            // Применяем сортировку
            switch (_sortIndex)
            {
                case 0: // По популярности (кол-во отзывов)
                    query = query
                        .GroupJoin(Program.context.Reviews, g => g.GameID, r => r.GameID, 
                            (g, reviews) => new { Game = g, ReviewCount = reviews.Count() })
                        .OrderByDescending(x => x.ReviewCount)
                        .Select(x => x.Game);
                    break;

                case 1: // Сначала дешевые
                    query = query.OrderBy(g => g.DiscountedPrice);
                    break;

                case 2: // Сначала дорогие
                    query = query.OrderByDescending(g => g.DiscountedPrice);
                    break;

                case 3: // По величине скидки
                    query = query.OrderByDescending(g => g.Discount);
                    break;

                case 4: // По дате выхода
                    query = query.OrderByDescending(g => g.ReleaseDate);
                    break;

                case 5: // По дате добавления
                    query = query.OrderByDescending(g => g.AddedDate);
                    break;

                case 6: // По алфавиту
                    query = query.OrderBy(g => g.Title);
                    break;

                case 7: // По рейтингу критиков
                    query = query.OrderByDescending(g => g.AverageRating);
                    break;
            }

            // Применяем фильтр по цене (если выбран)
            if (_priceIndex > 0)
            {
                switch (_priceIndex)
                {
                    case 1: query = query.Where(g => g.DiscountedPrice < 100); break;
                    case 2: query = query.Where(g => g.DiscountedPrice >= 100 && g.DiscountedPrice <= 500); break;
                    case 3: query = query.Where(g => g.DiscountedPrice >= 500 && g.DiscountedPrice <= 1000); break;
                    case 4: query = query.Where(g => g.DiscountedPrice >= 1000 && g.DiscountedPrice <= 1500); break;
                    case 5: query = query.Where(g => g.DiscountedPrice >= 1500 && g.DiscountedPrice <= 2000); break;
                    case 6: query = query.Where(g => g.DiscountedPrice >= 2000 && g.DiscountedPrice <= 3000); break;
                    case 7: query = query.Where(g => g.DiscountedPrice >= 3000); break;
                }
            }

            // Применяем фильтр по жанру (если выбран)
            if (_genreIndex > 0)
            {
                query = query.Where(g => g.GameGenres.Any(gg => gg.GenreID == _genreIndex));
            }

            // Применяем фильтр по разработчику (если выбран)
            if (_developerIndex > 0)
            {
                query = query.Where(g => g.DeveloperID == _developerIndex);
            }

            UpdateGamesList(query.ToList());
        }

        private void UpdateGamesList(List<Games> games)
        {
            gamesPanel.Controls.Clear();

            foreach (Games game in games)
            {
                var gamesControl = new MainGameControl(game);
                gamesControl.Margin = new Padding(10);
                gamesControl.GameClicked += GameControl_GameClicked;
                gamesPanel.Controls.Add(gamesControl);
            }
        }

        private void GameСatalogForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                navigationControl.LeftPanelWidth = 500;
                navigationControl.RightPanelWidth = 500;
                sortComboBox.Width = 190;
                priceComboBox.Width = 115;
                genreComboBox.Width = 140;
                developerComboBox.Width = 221;
            }
            else
            {
                navigationControl.LeftPanelWidth = 100;
                navigationControl.RightPanelWidth = 100;
                sortComboBox.Width = 155;
                priceComboBox.Width = 110;
                genreComboBox.Width = 100;
                developerComboBox.Width = 125;
            }

            navigationControl.UpdatePanelsWidth();
        }

        private void GameСatalogForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _sortIndex = sortComboBox.SelectedIndex;
            ApplyFiltersAndSort();
        }

        private void priceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _priceIndex = priceComboBox.SelectedIndex;
            ApplyFiltersAndSort();
        }

        private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _genreIndex = genreComboBox.SelectedIndex;
            ApplyFiltersAndSort();
        }

        private void developerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _developerIndex = developerComboBox.SelectedIndex;
            ApplyFiltersAndSort();
        }

        private void GameControl_GameClicked(object sender, Games game)
        {
            var form = new GameInfoForm(game);
            VisibilityHelper.ShowNewForm(this, form);
            this.Hide();
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            var form = new CreateOrUpdateGameForm();
            form.ShowDialog();
            ApplyFiltersAndSort();
        }
    }
}
