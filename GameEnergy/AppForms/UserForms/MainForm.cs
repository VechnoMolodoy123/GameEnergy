using GameEnergy.Classes.Messages;
using GameEnergy.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEnergy.AppForms.UserForms
{
    public partial class MainForm : Form
    {
        public event EventHandler WindowStateChanged = delegate { };
        private List<GameSlideControl> _slides = new List<GameSlideControl>();
        private Timer _autoSlideTimer;
        private int _currentIndex = 0;

        public MainForm()
        {
            InitializeComponent();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetFormStyle();
            LoadPromoSlider();
            StartAutoSlide();
        }

        private void SetFormStyle()
        {
            navigationControl.leftPanel = leftPanel;
            navigationControl.rightPanel = rightPanel;
            topPanel.Height = 262;
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
        }
    }
}
