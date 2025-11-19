using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEnergy.Classes.Images.InstallingImages
{
    internal class ImageLoader
    {
        private static readonly string _path = "C:\\Users\\lamki\\OneDrive\\Документы\\GameEnergyRes\\";

        public static Image LoadBookImage(string imagePath)
        {
            string fullImagePath = _path + imagePath;

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
                string logPath = "errorBookImages_log.txt";
                File.AppendAllText(logPath, $"[{DateTime.Now}] Ошибка при загрузке изображения: {ex.Message}\n");
                return Properties.Resources.DefaultGameImage;
            }
        }
    }
}
