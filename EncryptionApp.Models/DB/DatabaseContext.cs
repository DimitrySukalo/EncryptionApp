using EncryptionApp.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace EncryptionApp.Models.DB
{
    public class DatabaseContext : DbContext
    {
        public virtual DbSet<LogMessage> LogMessages { get; set; }

        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS01;Database=encryptionDb;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
