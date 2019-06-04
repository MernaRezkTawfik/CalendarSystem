using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSystem.Domain
{
    
    /// <summary>
    /// /Month
    /// </summary>
   public class Month
    {
        #region Properites
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        #endregion
    }
}
