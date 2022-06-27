using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication_Code_based_exam.Models;

namespace WebApplication_Code_based_exam.Data
{
    public class WebApplication_Code_based_examContext : DbContext
    {
        public WebApplication_Code_based_examContext (DbContextOptions<WebApplication_Code_based_examContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication_Code_based_exam.Models.Student> Student { get; set; }
    }
}
