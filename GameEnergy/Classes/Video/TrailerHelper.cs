using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
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

        private static string GetSafeFileName(string title)
        {
            return string.Join("_", title.Split(Path.GetInvalidFileNameChars(), StringSplitOptions.RemoveEmptyEntries)).Trim('_');
        }

        public static async Task<bool> DownloadAndSaveThumbnail(string videoId, string gameTitle)
        {
            if (string.IsNullOrWhiteSpace(videoId) || string.IsNullOrWhiteSpace(gameTitle))
                return false;

            string safeTitle = GetSafeFileName(gameTitle);
            string trailerFolder = Path.Combine(Application.StartupPath, "trailerImages");
            Directory.CreateDirectory(trailerFolder);
            string fullPath = Path.Combine(trailerFolder, $"{safeTitle}.jpg");

            using (var client = new HttpClient())
            {
                foreach (string quality in ThumbnailQualities)
                {
                    try
                    {
                        string url = $"https://img.youtube.com/vi/{videoId}/{quality}";

                        // Проверяем HEAD-запросом, существует ли изображение
                        using (var headRequest = new HttpRequestMessage(HttpMethod.Head, url))
                        {
                            var headResponse = await client.SendAsync(headRequest);
                            if (!headResponse.IsSuccessStatusCode)
                                continue;
                        }

                        // Загружаем изображение
                        byte[] bytes = await client.GetByteArrayAsync(url);

                        // YouTube возвращает "заглушку" размером ~2 КБ, если превью нет
                        if (bytes.Length < 5000)
                            continue;

                        // Сохраняем как есть (без Play-иконки — это для превью, а не для хранения)
                        File.WriteAllBytes(fullPath, bytes);
                        return true;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            return false; // не удалось скачать
        }

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
                        using (var headRequest = new HttpRequestMessage(HttpMethod.Head, url))
                        {
                            var headResponse = await client.SendAsync(headRequest);
                            if (!headResponse.IsSuccessStatusCode)
                                continue;
                        }

                        var bytes = await client.GetByteArrayAsync(url);
                        using (var ms = new MemoryStream(bytes))
                        {
                            using (var baseImage = Image.FromStream(ms) as Bitmap)
                            {
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
                                return;
                            }
                        }
                    }
                }
                catch
                {
                    continue;
                }
            }

            pictureBox.Image = Properties.Resources.DefaultTrailerImage;
        }

        public static void LoadLocalOrOnlinePreview(PictureBox pictureBox, string gameTitle, string videoId)
        {
            if (string.IsNullOrWhiteSpace(gameTitle))
            {
                pictureBox.Image = Properties.Resources.DefaultTrailerImage;
                return;
            }

            // Формируем безопасное имя файла
            string safeTitle = string.Join("_", gameTitle.Split(Path.GetInvalidFileNameChars(), StringSplitOptions.RemoveEmptyEntries)).Trim('_');
            string localPath = Path.Combine(Application.StartupPath, "trailerImages", $"{safeTitle}.jpg");

            if (File.Exists(localPath))
            {
                try
                {
                    // Загружаем локальную обложку и накладываем Play-иконку
                    using (var baseImage = Image.FromFile(localPath) as Bitmap)
                    {
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
                    }
                }
                catch
                {
                    // Если не удалось загрузить локальную — используем заглушку
                    pictureBox.Image = Properties.Resources.DefaultTrailerImage;
                }
            }
            else
            {
                // Локальной нет — грузим с YouTube
                LoadTrailerPreview(pictureBox, videoId);
            }
        }

        public static void ShowTrailer(string videoId)
        {
            if (string.IsNullOrWhiteSpace(videoId)) return;
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo($"https://www.youtube.com/watch?v={videoId}&t=1s")
            {
                UseShellExecute = true
            });
        }
    }
}
