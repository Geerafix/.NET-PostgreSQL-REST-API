using Microsoft.EntityFrameworkCore;

namespace rest_api {
    public class DBContext : DbContext {

        public DbSet<User> Users { get; set; }
        public DbSet<Puzzle> Puzzles { get; set; }

        public DBContext(DbContextOptions<DBContext> options) : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}
