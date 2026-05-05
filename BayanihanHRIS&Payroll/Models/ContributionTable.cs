using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BayanihanHRIS_Payroll.Models
{
    public class ContributionTable
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateOnly EffectivityDate { get; set; }

        [Precision(18, 2)]
        public decimal SalaryRangeMin { get; set; }

        [Precision(18, 2)]
        public decimal SalaryRangeMax { get; set; }

        [Precision(18, 2)]
        public decimal EmployeeShare { get; set; }

        [Precision(18, 2)]
        public decimal EmployerShare { get; set; }
    }
}
