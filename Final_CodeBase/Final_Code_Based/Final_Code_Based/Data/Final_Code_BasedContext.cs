using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Final_Code_Based.Models;

namespace Final_Code_Based.Data
{
    public class Final_Code_BasedContext : DbContext
    {
        public Final_Code_BasedContext (DbContextOptions<Final_Code_BasedContext> options)
            : base(options)
        {
        }

        public DbSet<Final_Code_Based.Models.Employee> Employee { get; set; }
    }
}
