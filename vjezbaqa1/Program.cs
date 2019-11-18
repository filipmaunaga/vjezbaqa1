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
            
            int[] niz = new int[8] { -2,-4,1, 2, 3,6,7,8 };
            int dif=Razlika(niz);
            Console.WriteLine("Razlika izmedju najveceg i najmanjeg clana niza je {0}", dif);
            Console.ReadKey();
           // Napisati funkciju koja će kao ulazni parametar
             //   imati niz brojeva. Vratiti razliku između najvećeg i najmanjeg broja.

        }
        static int Razlika(int [] niz)
        {
            int max=niz[0];
            int min = niz[0];
            int dif = 0;
            for (int i = 0; i < niz.Length; i++)
            {
                if (max < niz[i])
                {
                    max = niz[i];
                }
                else
                    max = min;
                dif = max - min;
            }
            return dif;
            
        }
    }
}
