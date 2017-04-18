using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Task6
{
    class Employee:IE_Person
    {
        private string  _profession;


        
        public Employee(string name, int age, string profession):this(name,age)
        {
            if (string.IsNullOrWhiteSpace(profession)) throw new ArgumentException("You cant be empty", nameof(profession));
            
            _profession = profession;
        }


        [JsonConstructor]
        public Employee(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("You cant be empty", nameof(name));
            Name = name;

            if (age == 0) throw new ArgumentException("You cant be 0 years old.", nameof(age));
            Age = age;


        }


        public string Name { get; }
       public int Age { get; }


        public int Salary(int age)
        {


            if (age > 30)
            {

                return 2500;

            }

            else
            {
                return 1300;
            }
        }

    }
}
