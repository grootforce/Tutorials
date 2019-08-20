using BookStoreApp.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApp.Data
{
    public class EfBookStoreContext: DbContext
    {
        public EfBookStoreContext (DbContextOptions<EfBookStoreContext> options)
            :base(options)
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Printer> Printers { get; set; }
    }
}
