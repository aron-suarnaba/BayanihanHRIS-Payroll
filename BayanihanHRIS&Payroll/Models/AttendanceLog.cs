using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BayanihanHRIS_Payroll.Models
{
    public class AttendanceLog
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }

        public DateTime ClockIn { get; set; }
        public DateTime? ClockOut { get; set; } 

    }
}
