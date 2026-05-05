using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace BayanihanHRIS_Payroll.Models
{
    public class Payslip
    {
        [Key]
        public int Id { get; set; }

        public int PayrollRunId { get; set; }

        public int EmployeeId { get; set; }

        [Precision(18, 2)]
        public decimal BasicPay {  get; set; }

        [Precision(18, 2)]
        public decimal OvertimePay { get; set; }

        [Precision(18, 2)]
        public decimal NightDiffPay { get; set; }

        [Precision(18, 2)]
        public decimal HolidayPay { get; set; }

        [Precision(18, 2)]
        public decimal SSS_Contribution { get; set; }

        [Precision(18, 2)]
        public decimal PhilHealth_Contribution { get; set; }

        [Precision(18, 2)]
        public decimal PagIBIG_Contribution { get; set; }

        [Precision(18, 2)]
        public decimal WithholdingTax { get; set; }

        [Precision(18, 2)]
        public decimal NetPay { get; set; }

    }
}
