using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;

namespace Task6
{
    class Program
    {

        static void Main(string[] args)
        {

            var StudentsList = new List <Student>()
                {

                new Student("Max",23,"Informatics",2),
                new Student("Filz",23,"Software_engineering",4),
                new Student("dennis",23,"Information and communication Systems", 2),
                new Student("pawel",23,"Information and communication Systems", 2),
                new Student("Nik",23,"Information and communication Systems", 2),
                new Student("Franz",24,"Information and communication Systems", 6),
                new Student("Alex",23,"Informatik", 5)


                };

            var Studs = new Subject<Student>();
            Console.WriteLine("Information and communication Systems---- STUDENTS");
            Studs.Subscribe(x =>
                                {
                                    
                                    Console.WriteLine($"Name: {x.Name}    Alter:{x.Age}  Studienrichtung: {x.Studienrichtung}");
                                    Thread.Sleep(TimeSpan.FromSeconds(3));
                                });

            var help = from x in StudentsList
                       where x.Age != 0 && x.Studienrichtung.Contains("Information and communication Systems")
                       select x;

            foreach (var Stud in help)
            {
                Studs.OnNext(Stud);
            }



            var StudsWithSameAge = StudentsList.Where(a => a.Age == 23).ToObservable();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Students with same Age");

            StudsWithSameAge.Subscribe(
                a => { Console.WriteLine($"Name :{a.Name}  Alter: {a.Age}  Studienrichtung: {a.Studienrichtung}");
                    Thread.Sleep(TimeSpan.FromSeconds(2));
                }
                
                );




        }

    }
}
