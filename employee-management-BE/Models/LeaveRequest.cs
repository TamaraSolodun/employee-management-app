
using Microsoft.EntityFrameworkCore;

public class LeaveRequest
{
    public int LeaveRequestId { get; set; }
    public int EmployeeId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string LeaveType { get; set; }
    public string Status { get; set; }
    public DateTime AppliedDate { get; set; }
    public int? ApprovedBy { get; set; }
}