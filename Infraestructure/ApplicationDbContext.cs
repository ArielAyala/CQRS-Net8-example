using CQRS.Example.Domain;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Example.Infraestructure
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<TaskItem> TaskItem { get; set; }
    }
}
