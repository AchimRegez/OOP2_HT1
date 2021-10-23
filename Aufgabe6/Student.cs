using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6
{
    class Student : Person
    {
        public string MajorSubject { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite()
        }

        public Student(int id, string firstName, string secondName, int age, string majorSubject) : base(id, firstName, secondName, age)
        {
            MajorSubject = majorSubject;
        }
    }
}
