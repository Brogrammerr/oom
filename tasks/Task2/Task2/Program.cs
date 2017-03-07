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
        private string gericht;
        private double preis;

        public Vapiano(String Station, String GerichtName, double Gerichtpreis)
        {

            if ((Station == null) || (GerichtName == null)) throw new Exception("Kannst kein Gericht ohne Name erstellen"); 
            station = Station;
            gericht = GerichtName;
            preis = Gerichtpreis;
        }


        public static void Main(string[] args)
        {
            var Vapiano = new[]
            {
             new Vapiano("Pasta","Pomodoro", 10.30),
             new Vapiano("Pizza", "Salami", 6.70),
            };

            foreach (var b in Vapiano)
            {
                Console.WriteLine("{0} {1} {2}", b.station, b.gericht, b.preis);
            }
        }

        
 

       


    }
}
