using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;

namespace GameEnergy.Classes.Video
{
    internal class TrailerHelper
    {
        private static readonly string[] ThumbnailQualities =
        {
            "maxresdefault.jpg", // 1280×720
            "sddefault.jpg",     // 640×480
            "hqdefault.jpg",     // 480×360
            "mqdefault.jpg"      // 320×180
        };

        public static async void LoadTrailerPreview(PictureBox pictureBox, string videoId)
        {
            if (string.IsNullOrWhiteSpace(videoId))
            {
                pictureBox.Image = Properties.Resources.DefaultTrailerImage;
                return;
            }

            foreach (var quality in ThumbnailQualities)
            {
                try
                {
                    string url = $"https://img.youtube.com/vi/{videoId}/{quality}";
                    using (var client = new HttpClient())
                    {
                        // Проверяем, существует ли изображение (без загрузки всего тела)
                        using (var headRequest = new HttpRequestMessage(HttpMethod.Head, url))
                        {
                            var headResponse = await client.SendAsync(headRequest);
                            if (!headResponse.IsSuccessStatusCode)
                                continue; // пропускаем, если 404 или другая ошибка
                        }

                        // Загружаем изображение
                        var bytes = await client.GetByteArrayAsync(url);
                        using (var ms = new MemoryStream(bytes))
                        {
                            using (var baseImage = Image.FromStream(ms) as Bitmap)
                            {
                                // Накладываем Play-кнопку
                                var compositeImage = new Bitmap(baseImage.Width, baseImage.Height);
                                using (var g = Graphics.FromImage(compositeImage))
                                {
                                    g.DrawImage(baseImage, 0, 0);

                                    var playIcon = Properties.Resources.PlayTrailer;
                                    double iconAspectRatio = (double)playIcon.Width / playIcon.Height;
                                    int targetWidth = (int)(baseImage.Width * 0.14);
                                    int targetHeight = (int)(targetWidth / iconAspectRatio);
                                    int x = (baseImage.Width - targetWidth) / 2;
                                    int y = (baseImage.Height - targetHeight) / 2;

                                    g.DrawImage(playIcon, x, y, targetWidth, targetHeight);
                                }

                                pictureBox.Image?.Dispose();
                                pictureBox.Image = compositeImage;
                                return; // Успешно — выходим
                            }
                        }
                    }
                }
                catch
                {
                    // Игнорируем ошибку и пробуем следующее качество
                    continue;
                }
            }

            // Если ни один не загрузился — ставим дефолт
            pictureBox.Image = Properties.Resources.DefaultTrailerImage;
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
