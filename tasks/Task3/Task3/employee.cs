using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class employee:Person
    {
        private string  profession;


        public employee(string e_name, int e_age, string e_profession)
        {
            name = e_name;
            age = e_age;
            profession = e_profession;
        }



       public string name { get; }
       public int age { get; }


        public int salary(int age)
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
