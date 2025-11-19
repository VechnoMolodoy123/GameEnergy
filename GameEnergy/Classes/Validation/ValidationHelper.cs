using GameEnergy.Classes.Hash;
using GameEnergy.Classes.Messages;
using GameEnergy.Models;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnergy.Classes.Validation
{
    internal class ValidationHelper
    {
        public static bool ValidateLogIn(MaterialSingleLineTextField loginField, MaterialSingleLineTextField passwordField)
        {
            List<Users> users = Program.context.Users.ToList();
            string login = loginField.Text;
            string password = passwordField.Text;

            Users verification = users.FirstOrDefault(user => user.Username == login || user.Email == login);

            if (verification != null)
            {
                bool isPasswordValid = HashHelper.VerifyData(password, verification.PasswordHash);

                if (isPasswordValid)
                {
                    Program.CurrentUser = verification;
                    loginField.Clear();
                    passwordField.Clear();
                    return true;
                }
            }
            MessageHelper.ShowErrorMessage("Логин/почта или пароль введены неверно");
            return false;
        }
    }
}
