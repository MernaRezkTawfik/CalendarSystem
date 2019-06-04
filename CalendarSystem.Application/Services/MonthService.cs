using CalendarSystem.Application.Interfaces;
using CalendarSystem.Application.Utilities;
using CalendarSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CalendarSystem.Application
{
    class MonthService:IMonthService
    {
        //public static List<Month> months = new List<Month>
        //{
        //    new Month(){Id=1,Name="January"},
        //    new Month(){Id=1,Name="February"},
        //    new Month(){Id=1,Name="March"},
        //    new Month(){Id=1,Name="April"},
        //    new Month(){Id=1,Name="May"},
        //    new Month(){Id=1,Name="June"},
        //    new Month(){Id=1,Name="July"},
        //    new Month(){Id=1,Name="August"},
        //    new Month(){Id=1,Name="September"},
        //    new Month(){Id=1,Name="October"},
        //    new Month(){Id=1,Name="November"},
        //    new Month(){Id=1,Name="December"},
        //};
        #region Fields
        private readonly IJsonService _JsonService = null;

        private readonly MyContext myContext = null;
        #endregion
        #region Constructors
        public MonthService(IJsonService jsonService,MyContext context)
        {
            _JsonService = jsonService;
            myContext = context;
        }
        #endregion
        public List<Month> GetMonths(string path = "")
        {
            var MonthJsonPath = path;
            if (string.IsNullOrEmpty(MonthJsonPath))
                MonthJsonPath = HttpContext.Current.Server.MapPath(AppSettingsUtil.MonthJsonPath);
            var Months = _JsonService.ReadJsonFile<List<Month>>(MonthJsonPath);
            return Months;
        }
        public List<Month> Months()
        {
            return myContext.months.ToList();
        }
    }
}
