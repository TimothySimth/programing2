﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog52a {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter length: ");
            int len = int.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            int wid = int.Parse(Console.ReadLine());
            int area = len * wid;
            int prim = 2 * len + 2 * wid;
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + prim);
            Console.ReadKey();
        }
    }
}
