using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6
{
    class Adress
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public Adress(int id, string street, string city)
        {
            Id = id;
            Street = street;
            City = city;
        }
    }
}
