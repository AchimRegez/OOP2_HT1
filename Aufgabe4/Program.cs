using System;
using System.Collections.Generic;
using System.Linq;

namespace Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person collection
            IList<Person> _personsList = new List<Person>()
            {
                new Person()
                {
                    Id = 1, FirstName = "Hans", SecondName = "Nötig", Age = 30, GenderProperty = Gender.Male
                },

                new Person()
                {
                    Id = 2, FirstName = "Vreni", SecondName = "Meier", Age = 18, GenderProperty = Gender.Female
                },

                new Person()
                {
                    Id = 3, FirstName = "Franz", SecondName = "Lustig", Age = 25, GenderProperty = Gender.Male
                },

                new Person()
                {
                    Id = 4, FirstName = "Denise", SecondName = "Kant", Age = 40, GenderProperty = Gender.Female
                },

                new Person()
                {
                    Id = 5, FirstName = "Vanessa", SecondName = "Schuhmacher", Age = 50, GenderProperty = Gender.Female
                },

                new Person()
                {
                    Id = 5, FirstName = "Reto", SecondName = "Schuhmacher", Age = 16, GenderProperty = Gender.Male
                }
            };

            // LING Query

            // Geben Sie alle Personen aus welche älter als 18 Jahre sind
            var persons = from p in _personsList
                          where p.Age > 17
                          select p;

            Console.WriteLine("Personen älter als 18 Jahre:");

            foreach (var person in persons)
            {                
                Console.WriteLine("Vorname: {0} Nachname: {1} Alter: {2} Geschlecht: {3}", person.FirstName, person.SecondName, person.Age, person.GenderProperty);                
            }

            Console.WriteLine();


            //Geben Sie die Anzahl Personen aus, welche zwischen 50 und 90 Jahren alt sind            
            var persons2 = (from p in _personsList
                           where p.Age > 49 || p.Age < 91
                           select p).Count();


            Console.WriteLine("Personen zwischen 50 und 90 Jahren:");
            Console.WriteLine(persons2);


            //Geben Sie alle weiblichen Personen aus, welche ein ‚e‘ im FirstName haben, sortiert nach aufsteigendem SecondName
            var persons2 = from p in _personsList
                           where (p.GenderProperty = Gender.Female) && (p.FirstName = "%e%")
                           orderby p.SecondName;


            // Geben Sie alle männlichen Personen aus, welche zwischen 20 und 40 Jahren alt sind und deren Nachnahmen ein ‚a‘ enthält, sortiert nach absteigendem Alter


            Console.ReadKey();
        }        
    }
}
