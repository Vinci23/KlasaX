using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaX
{
    class KlasaX
    {
        public int Arr(int[] niz)
        {
            int arr = 0;
            for (int brojac = 0; brojac < niz.Length; brojac++)
            {
                arr += niz[brojac];
            }
            return arr;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] niz = new int[100];
            int broj = 1;
            Console.WriteLine("Unos polja");
            for (int brojac = 0; brojac < niz.Length; brojac++)
            {
                Console.WriteLine(niz);
                niz[brojac] = broj;

            }

            KlasaX x = new KlasaX();
            Console.WriteLine("Niz je: " + x.Arr(niz));

            Console.ReadKey();
        }
    }
}
