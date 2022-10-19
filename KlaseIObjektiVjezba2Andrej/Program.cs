using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjektiVjezba2Andrej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaC objekt1 = new KlasaC();
            int[] niz = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Unesi " + (i + 1) + ". broj: ");
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Zbroj: " + objekt1.Zbroj(niz));
            Console.WriteLine("Prosjek: " + objekt1.Prosjek(niz));
            Console.ReadKey();
        }

    }
    class KlasaC
    {

        //metode
        public int Zbroj(int[] polje)
        {
            int zbroj = 0;
            for(int i = 0; i < polje.Length; i++)
            {
                zbroj += polje[i];
            }
            return zbroj;
        }
        public double Prosjek(int[] polje)
        {
            double prosjek = 0;
            for(int j = 0; j < polje.Length; j++)
            {
                prosjek += polje[j];
            }
            prosjek /= polje.Length;
            return prosjek;
        }
        
    }
}
