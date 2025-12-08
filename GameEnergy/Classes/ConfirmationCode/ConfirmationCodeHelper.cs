using GameEnergy.Classes.Hash;
using GameEnergy.Models;
using System;

namespace GameEnergy.Classes.ConfirmationCode
{
    /// <summary>
    /// Создание кода верификации
    /// </summary>
    internal class ConfirmationCodeHelper
    {
        /// <summary>
        /// Генерация рандомного кода
        /// </summary>
        /// <returns>Шестизначный код</returns>
        public static string GenerateConfirmationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        /// <summary>
        /// Метод для генерации и установки кода
        /// </summary>
        /// <param name="user">Пользователь, которому будет установлен код подтверждения</param>
        public static string GenerateAndSetConfirmationCode(Users user)
        {
            string confirmationCode = GenerateConfirmationCode();
            string confirmationCodeHash = HashHelper.HashData(confirmationCode);
            user.ConfirmationCodeHash = confirmationCodeHash;
            user.ConfirmationCodeExpiration = DateTime.Now.AddMinutes(5);
            Program.context.SaveChanges();
            return confirmationCode;
        }
    }
}
