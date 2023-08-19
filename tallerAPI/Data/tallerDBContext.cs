using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tallerAPI.Data.Models;

namespace tallerAPI.Data
{
    public class tallerDBContext : DbContext
    {
        public tallerDBContext (DbContextOptions<tallerDBContext> options)
            : base(options)
        {
        }

        public DbSet<tallerAPI.Data.Models.Client> Clients { get; set; } = default!;
        public DbSet<tallerAPI.Data.Models.UserRole> UserRoles { get; set; }
        public DbSet<tallerAPI.Data.Models.User> Users { get; set; }
        public DbSet<tallerAPI.Data.Models.Vehicle> Vehicles { get; set; }
        public DbSet<tallerAPI.Data.Models.Storie> Stories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().ToTable(nameof(Client));
            modelBuilder.Entity<UserRole>().ToTable(nameof(UserRole));
            modelBuilder.Entity<User>().ToTable(nameof(User));
            modelBuilder.Entity<Vehicle>().ToTable(nameof(Vehicle));

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<tallerAPI.Data.Models.Vehicle>? Vehicle { get; set; }


    }
}
