using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KissAdam10251
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem, adja meg a személyazonosító jel első 10 jegyét:");
            string szemSzam = Console.ReadLine();
            char nem = szemSzam[0];
            if (nem == '1' || nem == '3')
            {
                Console.WriteLine("A személy férfi.");
            }
            else if (nem == '2' || nem == '4')
            {
                Console.WriteLine("A személy nő.");
            }
            else
            {
                Console.WriteLine("Hibás nem azonosító!");
            }

            string szuletesSorszam = szemSzam.Substring(7, 3);
            Console.WriteLine($"A születési sorszám: {szuletesSorszam}");

            var sz =19 +  szemSzam.Substring(2, 2);
            int cd = Convert.ToInt32(sz);
            var ev = DateTime.Now.Year;
            var szulev = ev - cd;
            Console.WriteLine(szulev);

            Console.Write("Kérem, adjon meg egy másik személyazonosító jelet szintén csak első 10 jegyét:");
            string szemSzam2 = Console.ReadLine();

            var sz2 = 19 + szemSzam2.Substring(2, 2);
            int cd2 = Convert.ToInt32(sz2);
            var ev2 = DateTime.Now.Year;
            var szulev2 = ev2 - cd2;
            if (szulev > szulev2)
            {
                Console.WriteLine($"{szemSzam} az idősebb");
                var korlunb = cd2 - cd;
                Console.WriteLine($"A kor különbség {korlunb}");
            }
            else 
            {
                Console.WriteLine($"{szemSzam2} az idősebb.");
                var korlunb = cd - cd2;
                Console.WriteLine($"A kor különbség {korlunb}");
            }
            int vegeredmeny = 0;
            int szorzo = 1;
            for (int i = 0;i < 10 ;i++)
            {
                vegeredmeny = szorzo * szemSzam2[i];
                szorzo++;
            }
            string st = Convert.ToString(vegeredmeny);
            string szemgs = szemSzam2 + st;
            Console.WriteLine($"Ez a 11 számmal {szemgs}");

            string fileName = "szemszam.txt";
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(szemSzam2);
                writer.WriteLine(szemSzam);
            }  
        }
    }
}
