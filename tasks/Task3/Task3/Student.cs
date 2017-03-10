using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Student :Person
    {
        private string Studienrichtung;


        public int semester {
            get;
        }

        public Student(string S_name, int S_age, string study, int sem)
            
        {
            name = S_name;
            age = S_age;

            Studienrichtung = study;
            semester = sem;
            
        }



        public string name {
            get;
        }

        public int age { get; }

        public int salary(int age)
        {
            Console.WriteLine("No salary");
            return 0;
        }
        
    }
}
