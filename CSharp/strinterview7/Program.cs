﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strinterview7 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Enter A STRING: ");
            string word = Console.ReadLine().ToLower();

            int vowels = 0;
            int cons   = 0;
            for (int lcv = 0; lcv < word.Length; lcv++) {
                char ltr = word[lcv];
                if (ltr == 'a' || ltr == 'e' || ltr == 'i' || ltr == 'o' || ltr == 'u') { vowels++; }
                else if (ltr >= 'a' && ltr <= 'z') { cons++; }
            Console.WriteLine(word + " contains " + vowels + " vowels, and " + cons + " consonats");
            Console.ReadKey();
                
                
            }












































































































































        }
    }
}
