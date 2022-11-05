using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sirb_Maria_Lab2.Models;

namespace Sirb_Maria_Lab2.Data
{
    public class Sirb_Maria_Lab2Context : DbContext
    {
        public Sirb_Maria_Lab2Context (DbContextOptions<Sirb_Maria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sirb_Maria_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Sirb_Maria_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Sirb_Maria_Lab2.Models.Author> Author { get; set; }

        public DbSet<Sirb_Maria_Lab2.Models.Category> Category { get; set; }
    }
}
