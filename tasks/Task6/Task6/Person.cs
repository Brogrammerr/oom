using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    interface IE_Person
    {
        string Name { get; }
        int Age { get; }

        int Salary(int age);
    }
    interface Person:IE_Person
    {
        string Studienrichtung { get; }

    }
}
