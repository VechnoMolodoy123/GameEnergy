using GameEnergy.AppForms.UserForms;
using GameEnergy.Classes.Messages;
using GameEnergy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            if (!context.Database.Exists())
            {
                MessageHelper.ShowErrorMessage("Не удалось подключиться к базе данных");
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegistrationOrAuthorizationForm());
        }
    }
}
