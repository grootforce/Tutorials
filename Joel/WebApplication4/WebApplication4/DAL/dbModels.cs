using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.DAL
{

    public class Personlist
    {
        public int personID { get; set; }

        public int Name { get; set; }
    }



    public class PersonContext : DbContext
    {
        public PersonContext(DbContextOptions options)
            : base(options)
        {

        }

        public virtual DbSet<Personlist> person { get; set; }

    }
}
