using Microsoft.EntityFrameworkCore;
using Task = Task_Manager.Models.Task;

namespace Task_Manager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
