using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DolgozatBatonyi
{
    class Program
    {

        static double atlag(List<Solsys> a)
        {

            return a.Average(x => x.holdSzam);
        
        }

        

        static void Main(string[] args)
        {
            var solsys = new List<Solsys>();
            using (var sr = new StreamReader(@"..\..\src\solsys.txt"))
            {
                while (!sr.EndOfStream)
                {
                    solsys.Add(new Solsys(sr.ReadLine()));

                }
            
            }

            Console.WriteLine($"3.1: {solsys.Count} bolygó van a naprendszerben");
            Console.WriteLine($"3.2: A naprendszerben egy bolygónak átlagosan {atlag(solsys)} holdja van");

            var f3 = solsys.OrderBy(x => x.terfogat).Last();
            Console.WriteLine($"3.3: A legnagyobb térfogatú bolygó: {f3.bolygo}");
            Console.Write("3.4: Írd be a keresett bolygó nevét: ");
            string nev = Console.ReadLine();
            var f4 = solsys.SingleOrDefault(x => x.bolygo == nev);
            Console.WriteLine(f4 != null ? "Van ilyen bolygó a naprendszerben." : "sajnos nincs ilyen nevű bolygó a naprendszerben");
            Console.Write("3.5: Írj be egy egész számot: ");
            int szam = Convert.ToInt32(Console.ReadLine());
            var f5 = solsys.Where(x => x.holdSzam > szam);
            Console.WriteLine($"A következő bolygónak van {szam}-nál/nél több holdja: ");
            foreach (var item in f5)
            {
                Console.Write($"[{item.bolygo}]");
            }

            Console.ReadKey();

        }
    }
}
