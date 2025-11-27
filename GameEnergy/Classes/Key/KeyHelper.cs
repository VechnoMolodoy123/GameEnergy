using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEnergy.Classes.Key
{
    internal class KeyHelper
    {
        private static readonly Random _random = new Random();
        private static readonly string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        public static string GenerateGameKey()
        {
            string[] parts = new string[3];
            for (int i = 0; i < 3; i++)
            {
                char[] part = new char[5];
                for (int j = 0; j < 5; j++)
                {
                    part[j] = _chars[_random.Next(_chars.Length)];
                }
                parts[i] = new string(part);
            }
            return string.Join("-", parts);
        }
    }
}
