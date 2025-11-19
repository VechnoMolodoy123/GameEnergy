using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnergy.Classes.DataAccess
{
    internal class UserAvatarDataHelper
    {
        public static string GetBase64ImageFromDatabase(int currentUserAvatar)
        {
            var currentUser = Program.context.Users.FirstOrDefault(user => user.UserID == currentUserAvatar);

            if (currentUser != null)
            {
                return currentUser.Avatar;
            }

            return null;
        }
    }
}
