using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog54cConsle {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter Radius: ");
            double rad = double.Parse(Console.ReadLine());
            double area = 3.14159 * (rad * rad);
            double cric = 2 * rad * 3.14159;
            int itit = 100;
            Console.WriteLine(itit);


            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference" + cric);
             // this is pointless
            Console.ReadKey();

        }
    }
}
