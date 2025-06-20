namespace Baim.Identity.Data.Entities;

public class InvitedUser
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }

    public Guid UserProgressId { get; set; }
    public UserProgress UserProgress { get; set; }
}
