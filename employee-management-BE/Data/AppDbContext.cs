using Microsoft.EntityFrameworkCore;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
public class AppDbContext : IdentityDbContext<ApplicationUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    // public DbSet<User> Users { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<PerformanceReview> PerformanceReviews { get; set; }
    public DbSet<TokenInfo> TokenInfos { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }

}
