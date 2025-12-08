using System.Windows.Forms;

namespace GameEnergy.Classes.Messages
{
    internal class MessageHelper
    {
        public static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowCustomTitleErrorMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformationMessage(string message, string caption)
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
