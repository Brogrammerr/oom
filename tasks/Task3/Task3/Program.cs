using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new Person[]
            {
                new Student("Max",23,"Informatics",2),
                new Student("Filz",27,"Software_engineering",4),
                new Student("Kranthi",23,"Information and communication Systems", 2),

                new employee("Hans", 45, "Network_Admin"),
                new employee("Michi", 19, "Junior_Programmer"),


            };


            foreach (var x in people)
            {
                Console.WriteLine("Name:{0} , age: {1}", x.name, x.age);


                Console.WriteLine("salary = {0}", x.salary(x.age));
            }
        }

    }
}
