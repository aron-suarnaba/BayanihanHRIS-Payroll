using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


        namespace BayanihanHRIS_Payroll.Models
    {
        public class EmploymentDetails
        {
            [Key]
            public int Id { get; set; }

            public int EmployeeId { get; set; }
            [ForeignKey("EmployeeId")]
            public virtual Employee? Employee { get; set; }

            [Required]
            [DataType(DataType.Date)]
            public DateOnly DateHired { get; set; }

            [DataType(DataType.Date)]
            public DateOnly? DateResigned { get; set; }

            [Required]
            public EmploymentStatus Status { get; set; }

            // Government IDs (Stored as strings to preserve leading zeros/dashes)
            [StringLength(20)]
            public string? SSSNumber { get; set; }

            [StringLength(20)]
            public string? PhilHealthNumber { get; set; }

            [StringLength(20)]
            public string? PagIBIGNumber { get; set; }

            [StringLength(20)]
            public string? TIN { get; set; }

            // Payroll specific
            public bool IsTaxExempt { get; set; } = false;

            [StringLength(50)]
            public string? BankAccountNumber { get; set; }
        }
    }
