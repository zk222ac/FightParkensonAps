using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightParkensonAps
{
    internal class StorageBroker : DbContext
    {
        public StorageBroker() => this.Database.Migrate();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;DataBase=FightParkinson");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .ToTable(name: "Students", studentTable => studentTable.IsTemporal());
        }
        public DbSet<Student> Students { get; set; }

    }
}
