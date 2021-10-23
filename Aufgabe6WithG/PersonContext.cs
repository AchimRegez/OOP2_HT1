using Microsoft.EntityFrameworkCore;

namespace Aufgabe6WithG
{
    class PersonContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-IHTH2P4V;Initial Catalog=OOP2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Person> Persons { get; set; }
    }
}
