using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            var people = new IE_Person[]
            {
                new Student("Max",23,"Informatics",2),
                new Student("Filz",27,"Software_engineering",4),
                new Student("Kranthi",23,"Information and communication Systems", 2),

                new Employee("Hans", 45, "Network_Admin"),
                new Employee("Michi", 19, "Junior_Programmer"),

            };

            
          

            var settings = new JsonSerializerSettings() {TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
            var jsonp = JsonConvert.SerializeObject(people, settings);
            var cwd = Directory.GetCurrentDirectory();
            var filename = Path.Combine(cwd, "people.json");
            File.WriteAllText(filename, jsonp);
            //Console.WriteLine(jsonp);

            var djson = File.ReadAllText(filename);
            var deser = JsonConvert.DeserializeObject<IE_Person[]>(djson, settings);

      
            
            foreach (var x in deser)
            {
                Console.WriteLine("Name:{0} , age: {1}",x.Name , x.Age);


                
            }
            

    



        }

    }
}
