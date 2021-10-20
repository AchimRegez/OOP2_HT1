using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    public enum Gender { Male, Female}
    class Person
    {
        Gender privateObj;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        //public Person(int id, string firstName, string secondName, int age)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    SecondName = secondName;
        //    Age = age;
        //}

        public Person()
        {
        }

        public Gender GenderProperty { get; set; }        
    }
}
