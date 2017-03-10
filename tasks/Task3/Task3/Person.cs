using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface Person
    {
        string name { get; }
        int age { get; }


        int salary(int age);
    }
}
