using GameEnergy.Classes.Hash;
using GameEnergy.Classes.Images.StoreImages;
using GameEnergy.Classes.Messages;
using GameEnergy.Models;
using Guna.UI2.WinForms;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private static readonly Regex _onlyEnglishChars = new Regex(@"^[A-Za-z\d\W_]+$");

        public static bool ValidationRegistration(MaterialSingleLineTextField LoginField, MaterialSingleLineTextField MailField, MaterialSingleLineTextField PasswordField, MaterialSingleLineTextField ConfirmPasswordField)
        {
            string originalUsername = LoginField.Text;
            string newUsername = originalUsername?.Replace(" ", "");
            string originalMail = MailField.Text;
            string newMail = originalMail?.Replace(" ", "");
            string originalPassword = PasswordField.Text;
            string newPassword = originalPassword?.Replace(" ", "");

            bool hadSpaces = originalUsername.Contains(" ") || originalMail.Contains(" ") || originalPassword.Contains(" ");

            if (_onlyEnglishChars.IsMatch(newUsername))
            {
                if (!IsUsernameOrMailTaken(newUsername, newMail))
                {
                    string passwordHash = HashHelper.HashData(newPassword);
                    string base64Avatar = CodingOrDecoding.ImageCoding(null);

                    Users newUser = new Users
                    {
                        Username = newUsername,
                        Email = newMail,
                        PasswordHash = passwordHash,
                        UserRoleID = 1,
                        RegistrationDate = DateTime.Now,
                        Avatar = base64Avatar
                    };

                    LoginField.Clear();
                    MailField.Clear();
                    PasswordField.Clear();
                    ConfirmPasswordField.Clear();

                    Program.context.Users.Add(newUser);
                    Program.context.SaveChanges();

                    string registrationMessage = hadSpaces
                        ? $"Пробелы в полях были удалены.\n\nПриветствуем, {newUsername}!"
                        : $"Приветствуем, {newUsername}!";

                    MessageHelper.ShowInformationMessage(registrationMessage, "Регистрация прошла успешно");

                    return true;
                }
                MessageHelper.ShowErrorMessage("Имя пользователя или почта уже существуют.");
                return false;
            }
            MessageHelper.ShowErrorMessage("Имя пользователя должно содержать только английские буквы, символы или цифры.");
            return false;
        }

        public static bool IsUsernameOrMailTaken(string login, string mail)
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(mail))
                return true;

            // Используем запрос к базе данных без загрузки всех пользователей
            return Program.context.Users
                .Any(u => u.Username == login || u.Email == mail);
        }

        public static bool ValidationPasswordFields(Users user, string PasswordField)
        {
            string passwordHash = HashHelper.HashData(PasswordField);

            bool isPasswordValid = HashHelper.VerifyData(PasswordField, user.PasswordHash);

            if (isPasswordValid)
            {
                MessageHelper.ShowErrorMessage("Новый пароль должен отличаться от старого");
                return false;
            }
            else if (user != null)
            {
                user.PasswordHash = passwordHash;
                Program.context.SaveChanges();
                return true;
            }
            else
            {
                MessageHelper.ShowErrorMessage("Пользователь не найден");
                return false;
            }
        }

        public static async Task<bool> ValidateFieldIsEmpty(MaterialSingleLineTextField[] fields)
        {
            Color errorColor = ColorTranslator.FromHtml("#b71c1c");
            bool allFieldsFilled = true;

            var tasks = fields.Select(async field =>
            {
                Color originalColor = field.BackColor;

                if (field.Text == "")
                {
                    field.BackColor = errorColor;
                    await Task.Delay(500);
                    field.BackColor = originalColor;
                    allFieldsFilled = false;
                }
            });

            await Task.WhenAll(tasks);
            return allFieldsFilled;
        }

        public static bool ValidateMailField(string mail)
        {
            try
            {
                if (!Regex.IsMatch(mail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageHelper.ShowErrorMessage("Неверный формат email. Пример: example@domain.com");
                    return false;
                }

                return true;
            }
            catch (ArgumentException)
            {
                MessageHelper.ShowErrorMessage("Некорректный email.");
                return false;
            }
            catch (RegexMatchTimeoutException)
            {
                MessageHelper.ShowErrorMessage("Слишком сложный email. Попробуйте ещё раз.");
                return false;
            }
        }

        public static bool ValidateNewMail(Guna2TextBox newMail)
        {
            string mail = newMail.Text?.Trim();
            int currentUserId = Program.CurrentUser.UserID;

            Users currentUser = Program.context.Users.FirstOrDefault(u => u.UserID == currentUserId);

            if (mail != currentUser.Email)
            {
                currentUser.Email = mail;
                Program.context.SaveChanges();
                return true;
            }
            else
            {
                MessageHelper.ShowErrorMessage("Новая почта должна отличаться от старой");
                return false;
            }
        }

        private static readonly Regex _hasUpperChar = new Regex(@"[A-Z]");
        private static readonly Regex _hasLowerChar = new Regex(@"[a-z]");
        private static readonly Regex _hasDigit = new Regex(@"\d");
        private static readonly Regex _hasSpecialChar = new Regex(@"[\W_]");

        public static bool ValidatePasswords(string password, string confirmPassword)
        {
            if (!_onlyEnglishChars.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать только английские буквы.");
                return false;
            }

            if (password.Contains(" "))
            {
                MessageHelper.ShowErrorMessage("Пароль не должен содержать пробелов.");
                return false;
            }

            if (!_hasUpperChar.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать хотя бы одну заглавную букву.");
                return false;
            }

            if (!_hasLowerChar.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать хотя бы одну строчную букву.");
                return false;
            }

            if (!_hasDigit.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать хотя бы одну цифру.");
                return false;
            }

            if (!_hasSpecialChar.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать хотя бы один специальный символ.");
                return false;
            }

            if (password.Length < 8)
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать минимум 8 символов.");
                return false;
            }

            if (password.Length > 32)
            {
                MessageHelper.ShowErrorMessage("Пароль не должен превышать 32 символа.");
                return false;
            }

            if (password != confirmPassword)
            {
                MessageHelper.ShowErrorMessage("Пароли не совпадают.");
                return false;
            }
            return true;
        }

        public static bool ValidationResetPassword(Guna2TextBox OldPasswordField, Guna2TextBox PasswordField)
        {
            string newPassword = PasswordField.Text;
            string oldPassword = OldPasswordField.Text;

            int currentUserId = Program.CurrentUser.UserID;

            Users currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == currentUserId);

            if (ValidationOldPassword(currentUser, oldPassword))
            {
                if (ValidationPasswordFields(currentUser, newPassword))
                {
                    OldPasswordField.Clear();
                    PasswordField.Clear();
                    return true;
                }
            }

            return false;
        }

        public static bool ValidationOldPassword(Users user, string OldPasswordField)
        {
            string passwordHash = HashHelper.HashData(OldPasswordField);

            bool isPasswordCorrect = HashHelper.VerifyData(OldPasswordField, user.PasswordHash);

            if (isPasswordCorrect)
            {
                return true;
            }
            else
            {
                MessageHelper.ShowErrorMessage("Неверный пароль");
                return false;
            }
        }

        public static bool ValidatePassword(string password)
        {
            if (!_onlyEnglishChars.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать только английские буквы.");
                return false;
            }

            if (password.Contains(" "))
            {
                MessageHelper.ShowErrorMessage("Пароль не должен содержать пробелов.");
                return false;
            }

            if (!_hasUpperChar.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать хотя бы одну заглавную букву.");
                return false;
            }

            if (!_hasLowerChar.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать хотя бы одну строчную букву.");
                return false;
            }

            if (!_hasDigit.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать хотя бы одну цифру.");
                return false;
            }

            if (!_hasSpecialChar.IsMatch(password))
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать хотя бы один специальный символ.");
                return false;
            }

            if (password.Length < 8)
            {
                MessageHelper.ShowErrorMessage("Пароль должен содержать минимум 8 символов.");
                return false;
            }

            if (password.Length > 32)
            {
                MessageHelper.ShowErrorMessage("Пароль не должен превышать 32 символа.");
                return false;
            }
            return true;
        }

        public static bool ValidationPasswordFields(MaterialSingleLineTextField passwordField, MaterialSingleLineTextField confirmPasswordField)
        {
            return ValidatePasswords(passwordField.Text, confirmPasswordField.Text);
        }

        public static bool ValidationPasswordField(Guna2TextBox passwordField)
        {
            return ValidatePassword(passwordField.Text);
        }
    }
}
