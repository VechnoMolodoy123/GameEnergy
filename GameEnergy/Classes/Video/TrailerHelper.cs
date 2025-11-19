using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEnergy.Classes.Video
{
    internal class TrailerHelper
    {
        public static async void LoadTrailerPreview(PictureBox pictureBox, string videoId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var imageUrl = $"https://img.youtube.com/vi/{videoId}/mqdefault.jpg";
                    var bytes = await client.GetByteArrayAsync(imageUrl);
                    using (var ms = new MemoryStream(bytes))
                    {
                        using (var baseImage = Image.FromStream(ms) as Bitmap)
                        {
                            var compositeImage = new Bitmap(baseImage.Width, baseImage.Height);
                            using (var g = Graphics.FromImage(compositeImage))
                            {
                                g.DrawImage(baseImage, 0, 0);

                                // Пропорции твоей иконки Play: 783x550
                                const double iconAspectRatio = 783.0 / 550.0; // ≈ 1.424

                                // Определяем желаемую ширину иконки (например, 40% от ширины превью)
                                int targetWidth = (int)(baseImage.Width * 0.25);
                                int targetHeight = (int)(targetWidth / iconAspectRatio);

                                // Центрируем иконку
                                int x = (baseImage.Width - targetWidth) / 2;
                                int y = (baseImage.Height - targetHeight) / 2;

                                // Загружаем иконку из ресурсов (должна быть с прозрачным фоном)
                                var playIcon = Properties.Resources.PlayTrailer; // Image или Bitmap

                                // Рисуем с сохранением пропорций
                                g.DrawImage(playIcon, x, y, targetWidth, targetHeight);
                            }

                            pictureBox.Image?.Dispose();
                            pictureBox.Image = compositeImage;
                        }
                    }
                }
            }
            catch
            {
                pictureBox.Image = Properties.Resources.DefaultTrailerImage;
            }
        }

        public static void ShowTrailer(string videoId)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo($"https://www.youtube.com/watch?v={videoId}&t=1s")
            {
                UseShellExecute = true
            });
        }
    }
}
