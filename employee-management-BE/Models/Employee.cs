using Microsoft.EntityFrameworkCore;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public DateTime DateOfJoining { get; set; }
    public string Department { get; set; } = string.Empty;
    public int? ManagerId { get; set; }
}
