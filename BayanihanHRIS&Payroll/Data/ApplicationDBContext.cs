using Microsoft.EntityFrameworkCore;
using BayanihanHRIS_Payroll.Models;

namespace BayanihanHRIS_Payroll.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<AttendanceLog> AttendanceLogs { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<Payslip> Payslips { get; set; }
        public DbSet<PayrollRun> PayrollRuns { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; } // Added this DbSet
        public DbSet<ContributionTable> ContributionTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // 1. Seed Departments
            modelBuilder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "IT Department", Description = "Software and Infrastructure" },
                new Department { Id = 2, Name = "Human Resources", Description = "Personnel and Payroll" },
                new Department { Id = 3, Name = "Operations", Description = "Daily Business Operations" }
            );

            // 2. Seed Leave Types
            modelBuilder.Entity<LeaveType>().HasData(
                new LeaveType { Id = 1, Name = "Sick Leave" },
                new LeaveType { Id = 2, Name = "Vacation Leave" },
                new LeaveType { Id = 3, Name = "Emergency Leave" }
            );

            // 3. Seed Basic Holidays for 2026 (Philippines Sample)
            modelBuilder.Entity<Holiday>().HasData(
                new Holiday { Id = 1, Date = new DateOnly(2026, 1, 1), Name = "New Year's Day", HolidayType = HolidayType.Regular },
                new Holiday { Id = 2, Date = new DateOnly(2026, 4, 9), Name = "Araw ng Kagitingan", HolidayType = HolidayType.Regular },
                new Holiday { Id = 3, Date = new DateOnly(2026, 5, 1), Name = "Labor Day", HolidayType = HolidayType.Regular },
                new Holiday { Id = 4, Date = new DateOnly(2026, 8, 21), Name = "Ninoy Aquino Day", HolidayType = HolidayType.SpecialNonWorking }
            );

            // 4. Seed a Sample Contribution Table (PhilHealth/SSS placeholder)
            modelBuilder.Entity<ContributionTable>().HasData(
                new ContributionTable
                {
                    Id = 1,
                    EffectivityDate = new DateOnly(2026, 1, 1),
                    SalaryRangeMin = 0,
                    SalaryRangeMax = 10000,
                    EmployeeShare = 250.00m,
                    EmployerShare = 250.00m
                }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    EmployeeNumber = 1001,
                    FirstName = "Juan",
                    LastName = "Dela Cruz",
                    MonthlyRate = 25000.00m,
                    Status = EmploymentStatus.Regular,
                    DateHired = new DateOnly(2024, 1, 1)
                }
            );
        }
    }
}