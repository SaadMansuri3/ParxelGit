using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Entities
{
   public class DeveloperDbContext : DbContext
   {
        public DeveloperDbContext(DbContextOptions<DeveloperDbContext> options): base(options)
        {

        }

        public DbSet<User> Users { get; set; }

   }
}
