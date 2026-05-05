using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BayanihanHRIS_Payroll.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeNumber { get; set; }

        [Required, StringLength(50)]
        public required string FirstName { get; set; }

        [StringLength(50)]
        public string? LastName { get; set; }

        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }

        public int? DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public virtual Department? Department { get; set; }

        public virtual ICollection<AttendanceLog> AttendanceLogs { get; set; } = new List<AttendanceLog>();
        public virtual ICollection<Payslip> Payslips { get; set; } = new List<Payslip>();
    }

    public enum EmploymentStatus
    {
        Probationary,
        Regular,
        Contractual
    }
}
