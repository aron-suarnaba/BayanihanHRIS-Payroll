using System.ComponentModel.DataAnnotations;

namespace BayanihanHRIS_Payroll.Models
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }
    }
}
