using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem.Domain
{
    /// <summary>
    /// /Appointments in month
    /// </summary>
    public class Appointment
    {
        #region Properites
        [Key]
        public int Id { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public string Description { get; set; }
        public string Organizer { get; set; }
        public string Subject { get; set; }
        public List<string> Attendees { get; set; }
        public Month month { get; set; }
        [ForeignKey("month")]
        public int MonthID { get; set; }
        #endregion
    }
}
