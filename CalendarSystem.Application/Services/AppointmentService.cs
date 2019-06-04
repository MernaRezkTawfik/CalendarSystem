using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using CalendarSystem.Application.Interfaces;
using CalendarSystem.Application.Utilities;
using CalendarSystem.Domain;

namespace CalendarSystem.Application
{
    class AppointmentService : IAppointmentService
    {
        //   public static List<Appointment> appointments = new List<Appointment>

        //{new Appointment() { Id = 1, DateOfAppointment = new DateTime(2019, 1, 22),Description="TeamMeeting",Organizer="Ahmed" ,Subject="A",Attendees = { "omar","aml","madonna"} },
        //   new Appointment() { Id = 2, DateOfAppointment = new DateTime(2019, 1, 22),Description = "Lunch with joe",Organizer = "omar",Subject = "B", Attendees = { "micho", "mohmed", "aliaa" } } ,
        //    new Appointment() { Id = 3, DateOfAppointment = new DateTime(2019, 4, 22),Description="Project Meeting",Organizer="Merna",Subject="c", Attendees = { "manar", "noran", "mostafa" } } }; 

        #region Fields
        private readonly IJsonService _JsonService = null;
        #endregion
        #region Constructors

        public AppointmentService(IJsonService jsonService)
        {
            _JsonService = jsonService;

        }
       
        #endregion
        public List<Appointment> GetAppointments(string path = "")
        {
            var AppointmentsJsonPath = path;
            if (string.IsNullOrEmpty(AppointmentsJsonPath))
                AppointmentsJsonPath = HttpContext.Current.Server.MapPath(AppSettingsUtil.AppointmentsJsonPath);
            var Appointments = _JsonService.ReadJsonFile<List<Appointment>>(AppointmentsJsonPath);
            return Appointments;
        }
    }
}
