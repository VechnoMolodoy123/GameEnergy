using GameEnergy.AppForms.UserForms;
using GameEnergy.Classes.Animations;
using GameEnergy.Classes.Customization;
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

namespace GameEnergy.CustomControls
{
    public partial class NavigationControl : UserControl
    {
        private FlowLayoutPanel _searchResultsPanel;
        public event EventHandler<string> SearchTextChanged;
        // Дефолтный размер панелей
        private int _leftPanelDefaultWidth = 100;
        private int _rightPanelDefaultWidth = 100;

        public NavigationControl()
        {
            InitializeComponent();

            // Привязка событий кнопок
            HideOrClose();
            minimizeButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Minimized;
            maximizeButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Maximized;
            restoreButton.Click += (s, e) => FindForm().WindowState = FormWindowState.Normal;

            // Навигация по формам
            mainButton.Click += (s, e) => OpenForm<MainForm>();
            catalogButton.Click += (s, e) => OpenForm<GameСatalogForm>();
            notificationsButton.Click += (s, e) => OpenForm<NotifyForm>();
            notifiPanel.Click += (s, e) => OpenForm<NotifyForm>();
            profileButton.Click += (s, e) => OpenForm<ProfileForm>();
            libraryButton.Click += (s, e) => OpenForm<LibraryForm>();
            cartButton.Click += (s, e) => OpenForm<CartForm>();
            cartNotifiPanel.Click += (s, e) => OpenForm<CartForm>();
            searchTextBox.TextChanged += searchTextBox_TextChanged;
        }

        private void HideOrClose()
        {
            if (IsHide)
            {
                closeButton.Click += (s, e) => FindForm().Hide();
            }
            else
            {
                closeButton.Click += (s, e) => Application.Exit();
            }
        }

        private void NavigationControl_Load(object sender, EventArgs e)
        {
            if (!this.DesignMode) // ← Только во время выполнения!
            {
                UpdateNotificationsCount();
            }
        }

        private void OpenForm<T>() where T : Form, new()
        {
            var parentForm = this.FindForm();
            var newForm = new T();

            if (parentForm != null)
            {
                newForm.Owner = parentForm;
                parentForm.Hide();
            }

            VisibilityHelper.ShowNewForm(parentForm, newForm);
        }

        public void UpdateNotificationsCount()
        {
            var currentUser = Program.context.Users.FirstOrDefault(user =>
                user.UserID == Program.CurrentUser.UserID && user.UserRoleID != 1);

            int notificationsCount = 0;
            int cartNotificationsCount = 0;
            bool hasNotifications = false;
            bool hasCartNotifications = false;

            if (currentUser != null) // Администратор
            {
                notificationsCount = CountAdminNotifications();
            }
            else // Обычный пользователь
            {
                notificationsCount = CountUserNotifications();
            }

            cartNotificationsCount = CountCartNotifications();

            // Обновляем интерфейс
            hasNotifications = notificationsCount > 0;
            hasCartNotifications = cartNotificationsCount > 0;
            notifiPanel.Visible = hasNotifications;
            cartNotifiPanel.Visible = hasCartNotifications;
        }

        private int CountAdminNotifications()
        {
            try
            {
                // Считаем все типы жалоб и обратной связи
                int gameReports = Program.context.GameReports.Count();

                return gameReports;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подсчета уведомлений для админа: {ex.Message}");
                return 0;
            }
        }

        private int CountUserNotifications()
        {
            try
            {
                // Получаем список уведомлений для текущего пользователя
                var hiddenNotificationIds = Program.context.SystemNotifications
                    .Where(n => n.UserID == Program.CurrentUser.UserID)
                    .Select(n => n.NotifyID)
                    .ToList();

                // Считаем уведомления
                return hiddenNotificationIds.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подсчета уведомлений для пользователя: {ex.Message}");
                return 0;
            }
        }

        private int CountCartNotifications()
        {
            try
            {
                // Получаем список уведомлений для текущего пользователя
                var hiddenNotificationIds = Program.context.Cart
                    .Where(n => n.UserID == Program.CurrentUser.UserID)
                    .ToList();

                // Считаем уведомления
                return hiddenNotificationIds.Count();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка подсчета уведомлений для пользователя: {ex.Message}");
                return 0;
            }
        }

        public void HandleFormResize(Form form)
        {
            var borderlessForm = form.GetType()
                .GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .FirstOrDefault(f => f.FieldType == typeof(Guna2BorderlessForm))?
                .GetValue(form) as Guna2BorderlessForm;


            if (form.WindowState == FormWindowState.Maximized)
            {
                if (borderlessForm != null)
                    borderlessForm.BorderRadius = 0;
                maximizeButton.Visible = false;
                restoreButton.Visible = true;
                if (leftPanel != null) leftPanel.Width = 300;
                if (rightPanel != null) rightPanel.Width = 300;
                topLeftPanel.Width = 300;
                topRightPanel.Width = 300;
            }
            else
            {
                if (borderlessForm != null)
                    borderlessForm.BorderRadius = 11;
                maximizeButton.Visible = true;
                restoreButton.Visible = false;
                if (leftPanel != null) leftPanel.Width = 100;
                if (rightPanel != null) rightPanel.Width = 100;
                topLeftPanel.Width = 100;
                topRightPanel.Width = 100;
            }
        }

        public void UpdatePanelsWidth()
        {
            if (leftPanel != null)
                leftPanel.Width = LeftPanelWidth > 0 ? LeftPanelWidth : _leftPanelDefaultWidth;

            if (rightPanel != null)
                rightPanel.Width = RightPanelWidth > 0 ? RightPanelWidth : _rightPanelDefaultWidth;
        }

        private void PerformSearch(string query)
        {
            try
            {
                _searchResultsPanel.Controls.Clear();

                // 🔍 Поиск по названию ИЛИ имени разработчика
                var games = (from g in Program.context.Games
                             join dev in Program.context.GameDevelopers
                                 on g.DeveloperID equals dev.DeveloperID into devGroup
                             from dev in devGroup.DefaultIfEmpty()
                             where g.Title.Contains(query) ||
                                   (dev != null && dev.DeveloperName.Contains(query))
                             select g)
                            .Take(20)
                            .ToList();

                foreach (var game in games)
                {
                    var gameControl = new MainGameControl(game);
                    gameControl.Margin = new Padding(10);
                    gameControl.GameClicked += GameControl_GameClicked;
                    _searchResultsPanel.Controls.Add(gameControl);
                }

                _searchResultsPanel.Visible = games.Any();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка поиска: {ex.Message}");
                _searchResultsPanel.Visible = false;
            }
        }

        private void GameControl_GameClicked(object sender, Games game)
        {
            var gameInfoForm = new GameInfoForm(game);
            VisibilityHelper.ShowNewForm(this.FindForm(), gameInfoForm);
            this.FindForm().Hide();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string query = searchTextBox.Text;

            if (_searchResultsPanel == null)
            {
                _searchResultsPanel = new FlowLayoutPanel
                {
                    AutoSize = false,
                    WrapContents = true,
                    FlowDirection = FlowDirection.LeftToRight,
                    Visible = false,
                    BackColor = Color.FromArgb(20, 17, 17), // чуть светлее для контраста
                    BorderStyle = BorderStyle.None
                };
                AutoScrollHelper.ConfigureScrollbars(_searchResultsPanel, disableHorizontal: true, disableVertical: true);
                this.FindForm().Controls.Add(_searchResultsPanel);
            }
            if (string.IsNullOrEmpty(query))
            {
                _searchResultsPanel.Visible = false;
                return;
            }

            // Находим mainPanel
            var mainPanel = this.FindForm().Controls.Find("mainPanel", true).FirstOrDefault() as Panel;
            if (mainPanel != null && mainPanel.Width > 100 && mainPanel.Height > 100)
            {
                _searchResultsPanel.Size = mainPanel.Size;
                _searchResultsPanel.Location = new Point(mainPanel.Left, this.Bottom);
            }
            else
            {
                // Резерв: ширина формы, высота 400
                _searchResultsPanel.Size = new Size(this.ClientSize.Width - 40, 400);
                _searchResultsPanel.Location = new Point(20, this.Bottom);
            }

            PerformSearch(query);

            // Принудительное обновление
            _searchResultsPanel.BringToFront();
            this.FindForm().Refresh();
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            FormDrag.DragingForm(FindForm());
        }

        public Panel leftPanel { get; set; }
        public Panel rightPanel { get; set; }

        public int LeftPanelWidth { get; set; }
        public int RightPanelWidth { get; set; }

        public static bool IsHide { get; set; } = false;
    }
}
