using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        delegate int Operation(int a, int b);

        static void Main(string[] args)
        {

            Dictionary<string, Operation> op = new Dictionary<string, Operation>();

            op["add"] = (a, b) => a + b;

            op["mult"] = (a, b) => a * b;

            Console.WriteLine(op["add"](5, 3));

            Console.WriteLine(op["mult"](6, 7));

        }
    }
}
