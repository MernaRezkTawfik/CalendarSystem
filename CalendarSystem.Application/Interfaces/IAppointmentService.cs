using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalendarSystem.Domain;

namespace CalendarSystem.Application
{
   public interface IAppointmentService
    {
        List<Appointment> GetAppointments(string path = "");
    }
}
