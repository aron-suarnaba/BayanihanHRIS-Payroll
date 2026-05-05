using System.ComponentModel.DataAnnotations;

namespace BayanihanHRIS_Payroll.Models
{
    public class PayrollRun
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateOnly PeriodStart { get; set; }

        [DataType(DataType.Date)]
        public DateOnly PeriodEnd { get; set; }

        [DataType(DataType.Date)]
        public DateOnly PayoutDate { get; set; }

        public PayrollStatus PayrollStatus { get; set; }
    }

    public enum PayrollStatus
    {
        Draft,
        Approved,
        Paid
    }
}
