using GameEnergy.Classes.Messages;
using GameEnergy.Classes.Services;
using GameEnergy.Models;
using System;
using System.Windows.Forms;

namespace GameEnergy
{
    internal static class Program
    {
        public static Users CurrentUser { get; set; }
        public static readonly GameEnergyModel context = new GameEnergyModel();

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path
                .GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));

            try
            {
                using (var testContext = new GameEnergyModel())
                {
                    if (!testContext.Database.Exists())
                    {
                        MessageHelper.ShowErrorMessage("База данных не найдена.\nУбедитесь, что файл GameEnergy.mdf находится рядом с GameEnergy.exe.");
                        return;
                    }
                }

                CleanupService.CleanupExpiredConfirmationCodes();
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage($"Ошибка подключения к БД:\n{ex.Message}");
                return;
            }

            Application.Run(new RegistrationOrAuthorizationForm());
        }
    }
}
