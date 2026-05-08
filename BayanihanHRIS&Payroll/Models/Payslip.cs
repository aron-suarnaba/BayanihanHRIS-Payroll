using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BayanihanHRIS_Payroll.Models
{
    public class Payslip
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Payroll Run")]
        public int PayrollRunId { get; set; }
        [ForeignKey("PayrollRunId")]
        public virtual PayrollRun? PayrollRun { get; set; }

        [Display(Name = "Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee? Employee { get; set; }

        // --- Earnings ---
        [Precision(18, 2)]
        [DataType(DataType.Currency)]
        public decimal BasicPay { get; set; }

        [Precision(18, 2)]
        [Display(Name = "OT Pay")]
        public decimal OvertimePay { get; set; }

        [Precision(18, 2)]
        [Display(Name = "Gross Pay")]
        public decimal GrossPay { get; set; }

        // --- Statutory Deductions (Bayanihan/PH) ---
        [Precision(18, 2)]
        [Display(Name = "SSS")]
        public decimal SSS_Contribution { get; set; }

        [Precision(18, 2)]
        [Display(Name = "PhilHealth")]
        public decimal PhilHealth_Contribution { get; set; }

        [Precision(18, 2)]
        [Display(Name = "Pag-IBIG")]
        public decimal PagIBIG_Contribution { get; set; }

        [Precision(18, 2)]
        [Display(Name = "Tax")]
        public decimal WithholdingTax { get; set; }

        // --- Net ---
        [Precision(18, 2)]
        [Display(Name = "Net Pay")]
        [DataType(DataType.Currency)]
        public decimal NetPay { get; set; }
    }
}