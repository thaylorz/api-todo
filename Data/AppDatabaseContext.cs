using ApiTodo.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTodo.Data
{
    public class AppDatabaseContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
    }
}
