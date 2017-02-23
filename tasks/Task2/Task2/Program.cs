using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            try
            {
                switch (a)
                {
                    case 0:
                        Console.WriteLine("a is 0");

                    case 5:
                        Console.WriteLine("a is 5");
                        break;
                    default:
                        Console.WriteLine("a is something else");
                        break;
                }
            }
            catch (Exception )
            {
                Console.WriteLine("Something happend");
            }
        }

    }
}
