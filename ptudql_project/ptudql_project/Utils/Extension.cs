using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptudql_project.Utils
{
  static class Extension
  {
    public static string toTimeString(this long seconds)
    {
      var hours = seconds / 3600;
      seconds -= hours * 3600;
      var minutes = seconds / 60;
      seconds -= minutes * 60;
      return $"{hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}";
    }
  }
}
