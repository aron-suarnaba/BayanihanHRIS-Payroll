using System.ComponentModel.DataAnnotations;

namespace BayanihanHRIS_Payroll.Models
{
    public class Holiday
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Holiday Date")]
        public DateOnly Date { get; set; }

        [Required]
        [StringLength(100)]
        public required string Name { get; set; }

        [Required]
        [Display(Name = "Type of Holiday")]
        public HolidayType HolidayType { get; set; } 
    }

    public enum HolidayType
    {
        [Display(Name = "Regular Holiday")]
        Regular,

        [Display(Name = "Special Non-working Holiday")]
        SpecialNonWorking, 

        [Display(Name = "Double Holiday")]
        DoubleHoliday
    }
}