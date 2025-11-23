using GameEnergy.Classes.Customization;
using GameEnergy.Classes.DataAccess;
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
        private Timer _autoSlideTimer;
        private int _currentIndex = 0;
        private string _currentSortMode = "Новинки";
        private GameSlideControl _currentSlide;
        private List<GameSlideData> _slideData;

        public MainForm()
        {
            InitializeComponent();

            SetFormStyle();
        }

        private void SetFormStyle()
        {
            AutoScrollHelper.ConfigureScrollbars(mainPanel, disableHorizontal: true, disableVertical: true);
            AutoScrollHelper.ConfigureScrollbars(hitGamesPanel, disableHorizontal: true, disableVertical: true);
            AutoScrollHelper.ConfigureScrollbars(categoryGamesPanel, disableHorizontal: true, disableVertical: true);

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

                // Словарь заголовков (можно расширить)
                string[] titles = {
                    "ОБЪЕДИНЯЙСЯ С ВЫЖИВШИМИ В ARC RAIDERS",
                    "СОЗДАЙ СВОЮ ИМПЕРИЮ В EUROPA UNIVERSALIS V",
                    "РАЗГРОМИ ОРДУ В DAYS GONE",
                    "ПОКАЖИ СВОИ СТАЛЬНЫЕ НЕРВЫ В RESIDENT EVIL 7",
                    "ЗАХВАТИ ВЕСЬ МИР В MANOR LORDS"
                };

                _slideData = new List<GameSlideData>();
                for (int i = 0; i < promoGames.Count; i++)
                {
                    _slideData.Add(new GameSlideData
                    {
                        GameID = promoGames[i].GameID,
                        TitleOverride = i < titles.Length ? titles[i] : "Акция!"
                    });
                }

                // Создаём ОДИН слайд
                _currentSlide = new GameSlideControl(0, "");
                gamesSlidePanel.Controls.Clear();
                _currentSlide.GameClicked += GameControl_GameClicked;
                gamesSlidePanel.Controls.Add(_currentSlide);

                // Показываем первый
                if (_slideData.Count > 0)
                {
                    _currentSlide.UpdateContent(_slideData[0].GameID, _slideData[0].TitleOverride);
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

        private void ShowHitGames()
        {
            List<Games> games = Program.context.Games.Where(game => game.CategoryID == 1).ToList();

            foreach (Games game in games)
            {
                var mainControl = new MainGameControl(game);
                mainControl.Margin = new Padding(10);
                mainControl.GameClicked += GameControl_GameClicked;
                hitGamesPanel.Controls.Add(mainControl);
            }
        }

        private void StartAutoSlide()
        {
            _autoSlideTimer = new Timer();
            _autoSlideTimer.Interval = 4000; // 4 секунды
            _autoSlideTimer.Tick += OnAutoSlideTick;
            _autoSlideTimer.Start();
        }

        private void OnAutoSlideTick(object sender, EventArgs e)
        {
            if (_slideData == null || _slideData.Count == 0) return;

            _currentIndex = (_currentIndex + 1) % _slideData.Count;
            var next = _slideData[_currentIndex];
            _currentSlide.UpdateContent(next.GameID, next.TitleOverride);
        }

        private void categoryButtonsLocation()
        {
            int width = (delimiterPanel4.Width - categoryButtonsPanel.Width) / 2;
            categoryButtonsPanel.Location = new Point(width, 20);
        }

        private void mainImageLocation()
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                bannerPanel.Height = 230;
                mainImage1.Width = 330;
                mainImage2.Width = 330;
                mainImage3.Width = 330;
                mainImage4.Width = 330;
                mainImagePanel1.Visible = false;
                mainImagePanel2.Visible = false;
                mainImagePanel3.Visible = false;
                mainImagePanel4.Visible = false;
            }
            else
            {
                bannerPanel.Height = 92;
                mainImage1.Width = 132;
                mainImage2.Width = 131;
                mainImage3.Width = 131;
                mainImage4.Width = 132;
                mainImagePanel1.Visible = true;
                mainImagePanel2.Visible = true;
                mainImagePanel3.Visible = true;
                mainImagePanel4.Visible = true;
            }
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
            ShowHitGames();
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

            mainImageLocation();
            categoryButtonsLocation();
        }
    }
}
