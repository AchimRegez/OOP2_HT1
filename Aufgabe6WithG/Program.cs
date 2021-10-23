using System;

namespace Aufgabe6WithG
{
    partial class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PersonContext())
            {
                Person hans = new Person
                {
                    FirstName = "Hans",
                    SecondName = "Nötig",
                    Age = 21,
                };

                context.Persons.Add(hans);
                context.SaveChanges();
            }
        }
    }
}
