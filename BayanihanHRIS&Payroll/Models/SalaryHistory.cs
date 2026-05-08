using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BayanihanHRIS_Payroll.Models
{
    public class SalaryHistory
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }

        [Required]
        [Precision(18, 2)]
        [Display(Name = "Monthly Basic Salary")]
        public decimal MonthlyBasicSalary { get; set; }

        [Precision(18, 2)]
        [Display(Name = "Daily Rate")]
        public decimal DailyRate { get; set; }

        [Precision(18, 2)]
        [Display(Name = "Hourly Rate")]
        public decimal HourlyRate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateOnly EffectiveDate { get; set; }

        [StringLength(255)]
        public string? Remarks { get; set; } // e.g., "Annual Increase", "Promotion"

        public bool IsActive { get; set; }
    }
}
