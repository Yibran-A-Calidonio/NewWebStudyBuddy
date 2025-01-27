namespace StudyPalAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;// Store hashed passwords
    }
}
