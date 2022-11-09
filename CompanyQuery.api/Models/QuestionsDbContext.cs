using Microsoft.EntityFrameworkCore;

namespace CompanyQuery.api.Models
{
    public class QuestionsDbContext:DbContext
    {
        public QuestionsDbContext(DbContextOptions<QuestionsDbContext> options):base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Company> Companies { get; set; }

    }
}
