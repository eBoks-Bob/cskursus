using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariabelDemo
{
    class Program
    {        
        static void Main(string[] args)
        {

            int a;
            a = 10;
            long b;
            b = 10000;

            string f;

            bool c = true;

            byte d = 50;

            f = Convert.ToString(b);            

            
            Console.WriteLine(Convert.ToSingle(a));
            Console.WriteLine(f);

            Console.ReadKey();
        }
    }
}
