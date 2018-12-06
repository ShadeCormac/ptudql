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
        private static string _salt = "ahihidongok";
        
       
        public static string hashPassword(string pass)
        {
            var passBytes = Encoding.ASCII.GetBytes(string.Format($"{pass}{_salt}"));
            var sha1 = SHA1.Create();
            var hashedBytes = sha1.ComputeHash(passBytes);
            return BitConverter.ToString(hashedBytes).Replace("-", "");

        }

        public static bool passwordCompare(string pass, string hashedPass)
        {
            return (hashPassword(pass).CompareTo(hashedPass) == 0) ? true : false;
        }
    }
}
