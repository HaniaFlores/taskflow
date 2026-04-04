namespace TaskFlow.Data;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Category { get; set; } = "Personal";
    public bool IsCompleted { get; set; } = false;

    // Foreign key to the logged-in user
    public string UserId { get; set; } = string.Empty;
}
