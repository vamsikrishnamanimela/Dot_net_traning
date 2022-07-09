using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniProjectNo2.Models;

namespace MiniProjectNo2.Data
{
    public class MiniProjectNo2Context : DbContext
    {
        public MiniProjectNo2Context (DbContextOptions<MiniProjectNo2Context> options)
            : base(options)
        {
        }

        public DbSet<MiniProjectNo2.Models.Product> Product { get; set; }
    }
}
