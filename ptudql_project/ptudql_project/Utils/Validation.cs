using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ptudql_project.Utils
{
    class Validation
    {
        public static bool minLength(string text, int min)
        {
            return text.Length >= min;
        }

        public static bool maxLength(string text, int max)
        {
            return text.Length <= max;
        }

        public static bool checkWithRegex(string text, string regex)
        {
            text = text ?? string.Empty;
            string strRegex = regex;
            Regex re = new Regex(strRegex);
            return (re.IsMatch(text));
        }

        public static bool isEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        public static bool checkName(string name)
        {
            string strRegex = @"(\d+|[.+-=_{}[\]|\"+ @"';:!@#$%^&*()`~?.,<>/\\])";
            return !checkWithRegex(name, strRegex);
        }

        public static bool checkPassWord(string passWordchange, string passWordchanged)
        {
            return (passWordchange == passWordchanged) ? true : false;
        }
    }
}
