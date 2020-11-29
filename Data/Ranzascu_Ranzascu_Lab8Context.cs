using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ranzascu_Ranzascu_Lab8.Models;

namespace Ranzascu_Ranzascu_Lab8.Data
{
    public class Ranzascu_Ranzascu_Lab8Context : DbContext
    {
        public Ranzascu_Ranzascu_Lab8Context (DbContextOptions<Ranzascu_Ranzascu_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Ranzascu_Ranzascu_Lab8.Models.Book> Book { get; set; }

        public DbSet<Ranzascu_Ranzascu_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Ranzascu_Ranzascu_Lab8.Models.Category> Category { get; set; }
    }
}
