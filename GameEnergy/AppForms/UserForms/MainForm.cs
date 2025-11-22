using GameEnergy.Classes.Customization;
using GameEnergy.Classes.Messages;
using GameEnergy.CustomControls;
using GameEnergy.Models;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace GameEnergy.AppForms.UserForms
{
    public partial class MainForm : Form
    {
        public event EventHandler WindowStateChanged = delegate { };
        private List<GameSlideControl> _slides = new List<GameSlideControl>();
        private Timer _autoSlideTimer;
        private int _currentIndex = 0;
        private int categoryButtonsPanelWidth = 427;
        private string _currentSortMode = "Новинки";

        public MainForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);
            topPanel.Height = 352;
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;

            SetActiveButton(newGamesButton);
        }

        private void LoadPromoSlider()
        {
            try
            {
                // Желаемый порядок ID
                var desiredOrder = new[] { 18, 23, 8, 2, 7 };

                // Получаем игры по ID, сохраняя порядок
                var promoGames = Program.context.Games
                    .Where(g => desiredOrder.Contains(g.GameID))
                    .ToList()
                    .OrderBy(g => Array.IndexOf(desiredOrder, g.GameID))
                    .ToList();

                // Очищаем панель
                gamesSlidePanel.Controls.Clear();
                _slides.Clear();

                // Словарь заголовков (можно расширить)
                string[] titles = {
                    "ОБЪЕДИНЯЙТЕСЬ С ВЫЖИВШИМИ В ARC RAIDERS",
                    "СОЗДАЙТЕ ИМПЕРИЮ В EUROPA UNIVERSALIS V",
                    "РАЗГРОМИ ОРДУ В DAYS GONE",
                    "ПОКАЖИ СВОИ СТАЛЬНЫЕ НЕРВЫ В RESIDENT EVIL 7",
                    "ЗАХВАТИ ВЕСЬ МИР В MANOR LORDS"
                };

                for (int i = 0; i < promoGames.Count; i++)
                {
                    var game = promoGames[i];
                    string title = i < titles.Length ? titles[i] : "Акция!";

                    var slide = new GameSlideControl(game.GameID, title);
                    slide.Visible = false; // скрыты по умолчанию
                    slide.GameClicked += GameControl_GameClicked;
                    gamesSlidePanel.Controls.Add(slide);
                    _slides.Add(slide);
                }

                // Показываем первый слайд
                if (_slides.Count > 0)
                {
                    _slides[0].Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage($"Ошибка загрузки слайдера: {ex.Message}");
            }
        }

        private void ShowGames(Func<IQueryable<Games>, IQueryable<int>> filterFunction = null)
        {
            categoryGamesPanel.Controls.Clear();

            var gamesQuery = Program.context.Games;

            IQueryable<int> gameCategory = filterFunction != null ? filterFunction(gamesQuery) : gamesQuery
                .Where(g => g.CategoryID == 2)
                .Select(g => g.GameID);

            List<Games> games = Program.context.Games.Where(game => gameCategory.Contains(game.GameID)).ToList();

            foreach (Games game in games)
            {
                var mainControl = new MainGameControl(game);
                mainControl.Margin = new Padding(10);
                mainControl.GameClicked += GameControl_GameClicked;
                categoryGamesPanel.Controls.Add(mainControl);
            }
        }

        private void StartAutoSlide()
        {
            _autoSlideTimer = new Timer();
            _autoSlideTimer.Interval = 3000; // 3 секунды
            _autoSlideTimer.Tick += OnAutoSlideTick;
            _autoSlideTimer.Start();
        }

        private void OnAutoSlideTick(object sender, EventArgs e)
        {
            if (_slides.Count == 0) return;

            // Скрываем текущий
            _slides[_currentIndex].Visible = false;

            // Переходим к следующему (зацикленно)
            _currentIndex = (_currentIndex + 1) % _slides.Count;

            // Показываем новый
            _slides[_currentIndex].Visible = true;
        }

        private void SetActiveButton(Guna2Button activeButton)
        {
            foreach (var control in categoryButtonsPanel.Controls)
            {
                if (control is Guna2Button button)
                {
                    if (button == activeButton)
                    {
                        button.Checked = true;
                    }
                    else
                    {
                        button.Checked = false;
                    }
                }
            }
        }

        private void ShowNewGames()
        {
            ShowGames(query => query.Where(g => g.CategoryID == 2).Select(g => g.GameID));
        }

        private void ShowTopSellersGames()
        {
            ShowGames(query => query.Where(g => g.CategoryID == 3).Select(g => g.GameID));
        }

        private void ShowLatestArrivalsGames()
        {
            ShowGames(query => query.Where(g => g.CategoryID == 4).Select(g => g.GameID));
        }

        private void newGamesButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "Новинки") return;
            SetActiveButton(newGamesButton);
            _currentSortMode = "Новинки";
            ShowNewGames();
        }

        private void topSellersButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "Лидеры продаж") return;
            SetActiveButton(topSellersButton);
            _currentSortMode = "Лидеры продаж";
            ShowTopSellersGames();
        }

        private void latestArrivalsButton_Click(object sender, EventArgs e)
        {
            if (_currentSortMode == "Последние поступления") return;
            SetActiveButton(latestArrivalsButton);
            _currentSortMode = "Последние поступления";
            ShowLatestArrivalsGames();
        }

        private void GameControl_GameClicked(object sender, Games game)
        {
            var gameInfoForm = new GameInfoForm(game);
            VisibilityHelper.ShowNewForm(this, gameInfoForm);
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPromoSlider();
            StartAutoSlide();
            ShowGames();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _autoSlideTimer?.Stop();
            _autoSlideTimer?.Dispose();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            navigationControl.HandleFormResize(this);
            WindowStateChanged?.Invoke(this, EventArgs.Empty);

            int width = (delimiterPanel4.Width - categoryButtonsPanel.Width) / 2;
            categoryButtonsPanel.Location = new Point(width, 20);

            //if (this.WindowState == FormWindowState.Maximized)
            //{
                
            //}
        }
    }
}
