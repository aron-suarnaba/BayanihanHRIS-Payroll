using System.ComponentModel.DataAnnotations;

namespace BayanihanHRIS_Payroll.Models
{
    public class LeaveRequest
    {
        [Key]
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int LeaveTypeId { get; set; }

        [DataType(DataType.Date)]
        public DateOnly StartDate {  get; set; }

        [DataType(DataType.Date)]
        public DateOnly EndDate { get; set; }

        public LeaveStatus LeaveStatus { get; set; }
    }

    public enum LeaveStatus
    {
        Pending,
        Approved,
        Rejected
    }
}
