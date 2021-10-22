using System;


namespace Aufgabe6
{
    class Program
    {
        static void Main(string[] args)
        {
            static void AddStudent()
            {
                using (var context = new OOP2SchoolDBContext())
                {
                    var student = new Student(1, "Hans", "Nötig", 19, "Sport");

                    context.Persons.Add(student);
                    context.SaveChanges();
                }
            }
        }
    }
}
