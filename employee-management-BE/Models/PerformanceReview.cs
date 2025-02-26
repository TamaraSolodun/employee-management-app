using Microsoft.EntityFrameworkCore;

public class PerformanceReview
{
    public int PerformanceReviewId { get; set; }
    public int EmployeeId { get; set; }
    public int ReviewerId { get; set; }
    public DateTime ReviewDate { get; set; }
    public int Rating { get; set; }
    public string Comments { get; set; }
}