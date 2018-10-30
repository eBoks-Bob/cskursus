using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForIfOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    string tal = (i * j).ToString();

                    if ((i * j) > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.Write(tal.PadLeft(4));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press and key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
