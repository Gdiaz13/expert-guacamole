namespace textrpg.Models
{
    public class User
    {
        public int Id { get; set; } // This is the primary key for the User table
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = [];
        public byte[] PasswordSalt { get; set; } = [];
        public virtual Character Character { get; set; }
    }
}
