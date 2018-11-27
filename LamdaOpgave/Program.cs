﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 5, 1, 51, 7, 1, 56, 36, 5 };
            Console.WriteLine();
            Console.WriteLine(a.FindIndex(FindVærdi));
            Console.WriteLine(a.FindIndex((i) => { return i == 50; }));
            Console.WriteLine(a.FindIndex(i => i == 50 ));
            
            a.ForEach(ListVærdi);
            a.ForEach(i => { Console.WriteLine(i); });

            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        static bool FindVærdi(int i)
        {
            return i == 51;
        }

        static void ListVærdi(int i)
        {
            Console.WriteLine(i);
        }
    }
}
