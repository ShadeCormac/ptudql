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

        public static bool checkEmail(string mail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            return checkWithRegex(mail, strRegex);
        }

        public static bool checkName(string name)
        {
            string strRegex = @"(\d+|[.+-=_{}[\]|\"+"';:!@#$%^&*()`~?.,<>/\\])";
            return checkWithRegex(name, strRegex);
        }

        public static bool checkPassWord(string passWordchange, string passWordchanged)
        {
            return (passWordchange == passWordchanged) ? true : false;
        }
    }
}
