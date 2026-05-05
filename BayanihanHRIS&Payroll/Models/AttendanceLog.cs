using System.ComponentModel.DataAnnotations;

namespace BayanihanHRIS_Payroll.Models
{
    public class AttendanceLog
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ClockIn { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime ClockOut { get; set; }

        public string? DeviceThumbprint { get; set; }
    }
}
