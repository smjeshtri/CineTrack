namespace CineTrack.Client.Data.Models
{
    public class User
    {
        public User()
        {
            Movies = new List<Movie>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public List<Movie> Movies { get; set; }
    }
}