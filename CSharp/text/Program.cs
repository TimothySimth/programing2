using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 80;
            int b = 15;
            int c = 2;
            int g = a - b / (3 * c) * (a + c);
            Console.WriteLine(g.ToString());
            Console.ReadKey();
        }
    }
}
