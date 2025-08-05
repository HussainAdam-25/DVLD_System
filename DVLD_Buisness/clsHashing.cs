using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Buisness
{
    public static class clsHashing
    {
        public static string ComputeHash(string input)
        {
            StringBuilder stringBuilder = new StringBuilder();
            using (SHA256 sHA = SHA256.Create())
            {
                byte[] ArrayBytes = sHA.ComputeHash(Encoding.UTF8.GetBytes(input));
                foreach (var item in ArrayBytes)
                {
                    stringBuilder.Append(item.ToString("x2"));
                }

                return stringBuilder.Replace("-", "").ToString();
            }
        }

    }
}
