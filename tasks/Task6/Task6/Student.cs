using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Student :Person
    {
       


        public int Semester {
            get;
        }

        public Student(string name, int age, string studienrichtung, int semester)
            
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("You cant be empty", nameof(name));
            Name = name;

            if (age == 0) throw new ArgumentException("You cant be 0 years old.", nameof(age));
            Age = age;

            if (string.IsNullOrWhiteSpace(studienrichtung)) throw new ArgumentException("Your Course cant be empty", nameof(studienrichtung));
            Studienrichtung = studienrichtung;

            if (semester == 0) throw new ArgumentException("You could only be in Semester 0", nameof(semester));
            Semester = semester;
            
        }



        public string Name {
            get;
        }

        public int Age { get; }

        public string Studienrichtung { get;}

        public int Salary(int age)
        {
            Console.WriteLine("No salary");
            return 0;
        }
        
    }
}
