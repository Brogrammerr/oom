using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Vapiano
    {
        private string station;
       
       
        static private double guthaben = 100;
        
      
      public double preis
            {
            get;
            }

        public string Gericht
        {
            get;
        }

        public double updateGuthaben(double[] x)
        {
            double erg = guthaben;
            foreach (var y in x) { erg = erg - y; }

            return erg;

           
        }

        public Vapiano(String Station, String GerichtName, double Gerichtpreis)
        {

            if ((Station == null) || (GerichtName == null)) throw new Exception("Kannst kein Gericht ohne Name erstellen");
            station = Station;
            Gericht = GerichtName;
            preis = Gerichtpreis;
            
        }


        public static void Main(string[] args)
        {
            var Vapn = new[]
            {
             new Vapiano("Pasta","Pomodoro", 10.30),
             new Vapiano("Pizza", "Salami", 6.70),
             new Vapiano("Bar", "Wein", 45),
            };

            foreach (var b in Vapn)
            {
                
                Console.WriteLine("{0} {1} {2} ", b.station, b.Gericht, b.preis);
                

            }
            Console.WriteLine("Guthaben vor dem Kaufen: {0}", guthaben);
            var p_name = Vapn.Select(x => x.Gericht);

            Console.WriteLine();
            Console.WriteLine("Gekaufte Gerichte");
            foreach (var x in p_name) Console.WriteLine(x);

            var p_preis= Vapn.Select(y => y.preis);

            foreach (var x in p_preis) { guthaben = guthaben - x; }

           
            Console.WriteLine("Guthaben nach dem Kaufen: {0}", guthaben);







        }
    }
}
