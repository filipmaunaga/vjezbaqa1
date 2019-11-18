using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaqa1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napisati funkciju koja će kao ulazne parametre ima dva stringa. 
            //  Funkcija treba da vrati broj razlika između dva stringa.Napomena.Oba stringa su iste dužine.

            int[] niz = new int[3] { 3, 7, 3 };
            int d = Avg(niz);
            Console.WriteLine("Aritmeticka sredina je {0} ", d);
            Console.ReadKey();


        }
        static int Avg(int[] niz)
        {
            int sum = 0;
            int a = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                sum = sum + niz[i];
                a = sum / niz.Length;
            }
            return a;


        }
    }
}

