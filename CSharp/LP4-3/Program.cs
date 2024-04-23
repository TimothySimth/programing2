using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP4_3 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter Grade Percentage: ");
            double grade = double.Parse(Console.ReadLine());
            char letgrade = ' ';
            if (grade >= 90) letgrade = 'A';
            else if (grade >= 80) letgrade = 'B';
            else if (grade >= 70) letgrade = 'C';
            else if (grade >= 60) letgrade = 'D';
            else letgrade = 'F';

            Console.WriteLine("Your Grade is: " + letgrade);
            Console.ReadKey();
        
        
        
        }}}
