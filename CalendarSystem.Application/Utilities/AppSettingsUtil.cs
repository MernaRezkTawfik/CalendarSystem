using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem.Application.Utilities
{
   public static class AppSettingsUtil
    {
        public static string MonthJsonPath
        {
            get
            {
                return ConfigurationManager.AppSettings["MonthJsonPath"];
            }
        }
        public static string AppointmentsJsonPath
        {
            get
            {
                return ConfigurationManager.AppSettings["AppointmentsJsonPath"];
            }
        }
    }
}
