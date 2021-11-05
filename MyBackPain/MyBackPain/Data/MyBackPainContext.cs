using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBackPain.Models;

namespace MyBackPain.Data
{
    public class MyBackPainContext : DbContext
    {
        public MyBackPainContext (DbContextOptions<MyBackPainContext> options)
            : base(options)
        {
        }

        public DbSet<MyBackPain.Models.BackPain> BackPain { get; set; }
    }
}
