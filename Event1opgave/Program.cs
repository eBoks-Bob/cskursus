using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Event1opgave
{
    class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher w = new FileSystemWatcher(@"C:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.Changed += W_Changed;
            w.Changed += (s, e) => Console.WriteLine($"Oprettet {e.FullPath}");

            do { } while (true);
        }               

        public static void W_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }
    }
}
