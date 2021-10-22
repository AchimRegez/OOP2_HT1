using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6
{
    class OOP2SchoolDBContext : DbContext
    {
        public OOP2SchoolDBContext()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
}
