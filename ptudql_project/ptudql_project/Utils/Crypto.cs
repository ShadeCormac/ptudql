using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.Utils
{
    public class Crypto
    {


        private static int _iteration = 690; 
        public static string hashPassword(string pass)
        {
            //implementing PBKDF2 hashing algorithm
            byte[] salt;
            using (var rngCrypto = new RNGCryptoServiceProvider())
            {
                rngCrypto.GetBytes(salt = new byte[16]);
                using (var pbkdf2 = new Rfc2898DeriveBytes(pass, salt, _iteration))
                {
                    byte[] hash = pbkdf2.GetBytes(20);
                    //20 bytes from hash pass + 16 bytes from salt
                    byte[] hashBytes = new byte[36];
                    Array.Copy(salt, 0, hashBytes, 0, 16);
                    Array.Copy(hash, 0, hashBytes, 16, 20);
                    string hashedPassword = Convert.ToBase64String(hashBytes);
                    return hashedPassword;
                }
               
            }
        }

        public static bool passwordCompare(string pass, string hashedPass)
        {
            bool flag = true;
            byte[] hashBytes = Convert.FromBase64String(hashedPass);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);
            using (var pbkdf2 = new Rfc2898DeriveBytes(pass, salt, _iteration))
            {
                byte[] hash = pbkdf2.GetBytes(20);
                for (int i = 0; i < hash.Length; ++i)
                {
                    if (hashBytes[i + 16] != hash[i])
                    {
                        flag = false;
                        break;
                    }
                        
                }
            }
            return flag;
        }
    }
}
