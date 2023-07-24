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

        public DbSet<tallerAPI.Data.Models.Cliente> Cliente { get; set; } = default!;
    }
}
