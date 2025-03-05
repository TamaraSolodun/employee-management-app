using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
namespace EmployeeManagement.Models;
public class ApplicationUser : IdentityUser
{
    public string Name { get; set; } = string.Empty;
}