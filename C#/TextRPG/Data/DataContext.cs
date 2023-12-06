
using System.Text.Json.Serialization;

namespace textrpg.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        [JsonPropertyName("characters")]
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<User> Users => Set<User>();
    }
}
