﻿using System;
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
        private double guthaben = 100;


        public double Guthaben
        {
            get
            {
                return guthaben;
            }

        }



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
             new Vapiano("Bar", "Wein", -45),
            };

            foreach (var b in Vapiano)
            {
                Console.WriteLine("{0} {1} {2} Guthaben : {3}", b.station, b.gericht, b.preis, b.guthaben);

            }

            var p_name = Vapiano.Select(x => x.gericht).OrderBy(x => x);

            Console.WriteLine();
            Console.WriteLine("Gekaufte Gerichte");
            foreach (var x in p_name) Console.WriteLine(x);
            








        }
    }
}
