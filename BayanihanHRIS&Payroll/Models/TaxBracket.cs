using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BayanihanHRIS_Payroll.Models
{
    public class TaxBracket
    {
        [Key]
        public int Id { get; set; }

        [Precision(18, 2)]
        public decimal MinimumIncome { get; set; }

        [Precision(18, 2)]
        public decimal MaximumIncome { get; set; }

        [Precision(18, 2)]
        public decimal BaseTax { get; set; }

        [Precision(18, 2)]
        public decimal PercentageOverMinimum { get; set; }
    }
}
