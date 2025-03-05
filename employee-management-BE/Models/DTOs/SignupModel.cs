using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models.DTOs;

public class SignupModel
{
    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required]
    [MaxLength(30)]
    public string Password { get; set; } = string.Empty;
}