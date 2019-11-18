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
            
            string [] niz = new string[3] {"jedan","dv", "o" };
            int d = Duzina(niz);
            Console.WriteLine("Najduzi string ima {0} karaktera", d);
            Console.ReadKey();
          

        }
        static int Duzina(string [] niz)
        {
            int d = 0;
            int k = 0;
            for(int i = 0; i < niz.Length; i++)
            {
                k = niz[i].Length;
                if (d < k)
                {
                    d = k;
                }
                
            }
            return d;
            
        }
    }
}
