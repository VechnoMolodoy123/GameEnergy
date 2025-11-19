using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnergy.Classes.Hash
{
    /// <summary>
    /// Хэширование и верификация данных.
    /// </summary>
    internal class HachHelper
    {
        /// <summary>
        /// Хэширование данных.
        /// </summary>
        /// <param name="field"></param>
        /// <returns>хэшированное значение</returns>
        public static string HashData(string field)
        {
            return BCrypt.Net.BCrypt.HashPassword(field);
        }

        /// <summary>
        /// Верификация данных.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="storedHash"></param>
        /// <returns>сравнение данных</returns>
        public static bool VerifyData(string field, string storedHash)
        {
            return BCrypt.Net.BCrypt.Verify(field, storedHash);
        }
    }
}
