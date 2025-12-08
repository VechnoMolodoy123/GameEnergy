using GameEnergy.Classes.DataAccess;
using GameEnergy.Classes.Images.StoreImages;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GameEnergy.Classes.Images.InstallingImages
{
    internal class ImageLoader
    {
        private static readonly string _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GameEnergyRes");

        public static Image LoadGameImage(string imagePath)
        {
            string fullImagePath = Path.Combine(_path, imagePath + ".jpg");

            if (string.IsNullOrEmpty(fullImagePath) || !File.Exists(fullImagePath))
            {
                return Properties.Resources.DefaultGameImage;
            }

            try
            {
                return Image.FromFile(fullImagePath);
            }
            catch (Exception ex)
            {
                string logPath = "errorGameImages_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при загрузке изображения: {ex.Message}\n");
                return Properties.Resources.DefaultGameImage;
            }
        }

        public static void LoadAvatarImage(PictureBox avatarImage)
        {
            int currentUserId = Program.CurrentUser.UserID;

            try
            {
                string base64Image = UserAvatarDataHelper.GetBase64ImageFromDatabase(currentUserId);

                CodingOrDecoding.SetImageFromBase64(avatarImage, base64Image);
            }
            catch (Exception ex)
            {
                string logPath = "errorUserImages.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при загрузке изображения из базы данных:{ex.Message}\n");
            }
        }

        public static void LoadAvatarImageFromUserID(int currentUserId, PictureBox avatarImage)
        {
            try
            {
                string base64Image = UserAvatarDataHelper.GetBase64ImageFromDatabase(currentUserId);

                CodingOrDecoding.SetImageFromBase64(avatarImage, base64Image);
            }
            catch (Exception ex)
            {
                string logPath = "errorUserImages.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при загрузке изображения из базы данных:{ex.Message}\n");
            }
        }

        public static void LoadAvatarImageFromString(string base64Image, PictureBox avatarImage)
        {
            try
            {
                CodingOrDecoding.SetImageFromBase64(avatarImage, base64Image);
            }
            catch (Exception ex)
            {
                string logPath = "errorUserImages.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при загрузке изображения из строки base64:{ex.Message}\n");
            }
        }
    }
}
