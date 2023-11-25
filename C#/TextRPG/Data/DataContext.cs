
namespace textrpg.Data
{
    public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
    {
        public DbSet<Character> Characters => Set<Character>();
    }
}
