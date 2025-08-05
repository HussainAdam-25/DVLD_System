using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Buisness;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DVLD.Classes
{
    internal static class clsGlobal
    {
        public static clsUser CurrentUser;

        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware\DVLDAppInfo";
            string valueName = "CurrentUserinDVLDApp";
            string valueData = $"{Username}#{Password}";

            try
            {
                Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\YourSoftware\DVLDAppInfo";
            string valueName = "CurrentUserinDVLDApp";

            try
            {
                string value = Registry.GetValue(keyPath, valueName, null) as string;

                if (value == null)
                {
                    return false;
                }
                else
                {
                    string[] currentuser = value.Split('#');

                    Username = currentuser[0];
                    Password = currentuser[1];
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
