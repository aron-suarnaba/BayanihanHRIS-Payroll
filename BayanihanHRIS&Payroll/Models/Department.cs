using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BayanihanHRIS_Payroll.Models
{
public class Department
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(50)]
    public string Name { get; set; }

    [StringLength(100)]
    public string? Description { get; set; }

    // If a department belongs to a parent department (e.g., "HR" under "Admin")
    public int? ParentDepartmentId { get; set; }
    
    [ForeignKey("ParentDepartmentId")]
    public virtual Department? ParentDepartment { get; set; }

    // This links to Employees
    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
}
