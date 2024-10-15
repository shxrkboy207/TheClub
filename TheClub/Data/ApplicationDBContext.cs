using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheClub.Models;

namespace TheClub.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<TheClub.Models.Produto> Produto { get; set; }
        public DbSet<TheClub.Models.Cliente> Cliente { get; set; }
    }
}
