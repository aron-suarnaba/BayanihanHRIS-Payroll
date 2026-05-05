using System.ComponentModel.DataAnnotations;

namespace BayanihanHRIS_Payroll.Models
{
    public class ShiftSchedule
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime StartTime { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndTime { get; set; }

        [Display(Name = "Grace Period (Minutes)")]
        [Required(ErrorMessage = "Please specify the grace period.")]
        [Range(0, 1440, ErrorMessage = "Grace period must be between 0 and 1440 minutes (24 hours).")]
        public int GracePeriodMinutes { get; set; }

        public bool IsNightDifferentialEligible { get; set; }
    }
}
