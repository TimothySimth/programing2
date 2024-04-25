using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youstupid
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Enter num1");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter num2");
            int b = int.Parse(Console.ReadLine());


            int c = a + b;
            if (c >= 13 && c <= 19) ;
                Console.Write(19);
            else Console.Write(c);

        }
    }
}
