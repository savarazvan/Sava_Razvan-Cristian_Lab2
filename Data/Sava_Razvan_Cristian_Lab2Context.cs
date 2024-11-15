using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sava_Razvan_Cristian_Lab2.Models;

namespace Sava_Razvan_Cristian_Lab2.Data
{
    public class Sava_Razvan_Cristian_Lab2Context : DbContext
    {
        public Sava_Razvan_Cristian_Lab2Context (DbContextOptions<Sava_Razvan_Cristian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sava_Razvan_Cristian_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Sava_Razvan_Cristian_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Sava_Razvan_Cristian_Lab2.Models.Author> Author { get; set; } = default!;
        public DbSet<Sava_Razvan_Cristian_Lab2.Models.Category> Category { get; set; } = default!;
    }
}
