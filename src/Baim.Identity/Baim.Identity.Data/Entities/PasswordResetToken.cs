namespace Baim.Identity.Data.Entities;

public class PasswordResetToken
{
    public Guid Id { get; set; }
    public string Token { get; set; }
    public DateTime ExpiryDate { get; set; }

    public Guid UserId { get; set; }
    public virtual ApplicationUser User { get; set; }
}
