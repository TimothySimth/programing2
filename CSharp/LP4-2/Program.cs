using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP4_2 {
    class Program {
        static void Main(string[] args)
        {
            Console.Write("Enter weight"); int weight = int.Parse(Console.ReadLine());
            Console.Write("Enter length"); int length = int.Parse(Console.ReadLine());
            Console.Write("Enter width");  int width = int.Parse(Console.ReadLine());
            Console.Write("Enter hight");  int hight = int.Parse(Console.ReadLine());

            int volume = length * width * hight;

            if (weight > 27 && volume > 100000) Console.WriteLine("Package is to heavy and to large");
            else if (weight > 27)               Console.WriteLine("Package is to heavy");
            else if (weight > 27)               Console.WriteLine("Package is to large");
            else                                Console.WriteLine("Package is to Okay");

            Console.ReadKey();

            
        }
    }
}
