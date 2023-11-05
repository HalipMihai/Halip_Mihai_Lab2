using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Halip_Mihai_Lab2.Models;

namespace Halip_Mihai_Lab2.Data
{
    public class Halip_Mihai_Lab2Context : DbContext
    {
        public Halip_Mihai_Lab2Context (DbContextOptions<Halip_Mihai_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Halip_Mihai_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Halip_Mihai_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Halip_Mihai_Lab2.Models.Author>? Author { get; set; }

        public DbSet<Halip_Mihai_Lab2.Models.Category>? Category { get; set; }
    }
}
