using Microsoft.AspNetCore.Identity;

namespace TaskFlow.Data;

public class ApplicationUser : IdentityUser
{
    public string? SecurityQuestion { get; set; }
    public string? SecurityAnswerHash { get; set; }
}
