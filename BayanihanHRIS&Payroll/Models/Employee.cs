using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BayanihanHRIS_Payroll.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EmployeeNumber { get; set; }

        [Required, StringLength(50)]
        public required string FirstName { get; set; }

        [Required, StringLength(50)] 
        public string LastName { get; set; } = string.Empty;

        public string? MiddleName { get; set; }

        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }

        [DataType(DataType.Date)]
        public DateOnly DateHired { get; set; }

        public EmploymentStatus Status { get; set; }

        [StringLength(20)] public string? SSSNumber { get; set; }
        [StringLength(20)] public string? PhilHealthNumber { get; set; }
        [StringLength(20)] public string? TINNumber { get; set; }
        [StringLength(20)] public string? PagIbigNumber { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal MonthlyRate { get; set; }

        public string? BankBranch { get; set; }
        public string? BankAccountName { get; set; }
        public string? BankAccountNumber { get; set; }

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
