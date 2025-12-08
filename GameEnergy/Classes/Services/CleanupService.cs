using System;
using System.Linq;

namespace GameEnergy.Classes.Services
{
    internal class CleanupService
    {
        public static void CleanupExpiredConfirmationCodes()
        {
            var expiredUsers = Program.context.Users
                .Where(u => u.ConfirmationCodeExpiration < DateTime.Now)
                .ToList();

            foreach (var user in expiredUsers)
            {
                user.ConfirmationCodeHash = null;
                user.ConfirmationCodeExpiration = null;
            }

            Program.context.SaveChanges();
        }
    }
}
