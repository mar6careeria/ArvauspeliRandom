using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvauspeliRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arvaukset = new List<int>();
            int rLuku = 0, i = 0;
            Random rNumero = new Random();
            int arvaus = 0;

            rLuku = rNumero.Next(1, 100);
            Console.WriteLine("Arvaa mikä luku väliltä 1 - 100?");

            while (arvaus != rLuku)
            {
                arvaus = int.Parse(Console.ReadLine());
                arvaukset.Add(arvaus);

                if (arvaus > rLuku)
                {
                    Console.WriteLine("Luku on pienempi kuin arvaus. Yritä uudelleen");
                }
                else if (arvaus < rLuku)
                {
                    Console.WriteLine("Luku on suurempi kuin arvaus. Yritä uudelleen");
                }
                i++;
            }
            
            Console.WriteLine("Nyt osui, onnittelut! Luku oli {0} ja arvauksia tarvitsit {1}.", rLuku.ToString(), i.ToString());
            for (i = 0; i < arvaukset.Count; i++)
            {
                Console.WriteLine("Arvaus " + (i+1) + " oli " + arvaukset[i]);
            }
            Console.ReadLine();

        }
    }
}
