using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn;
            StringBuilder sb = new StringBuilder();
            sb.Append(fornavn);
            sb.Append(" ");
            sb.Append(efternavn);
            Console.WriteLine(sb);

            samletNavn = fornavn + " " + efternavn;
            string navnStort;
            navnStort = samletNavn.ToUpper();
            string navnLille;
            navnLille = samletNavn.ToLower();
            int s = samletNavn.IndexOf("Cron", 0);
            string navnDel;
            navnDel = samletNavn.Substring(s, 4);
            
            string tab = "\t";
            string newLine = "\r\n";
            Console.WriteLine(tab + samletNavn);
            Console.WriteLine(newLine + navnDel);
            Console.WriteLine(s);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press and key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
