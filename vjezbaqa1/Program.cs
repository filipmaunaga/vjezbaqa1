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

            SumOfUserEntries();
            //UsingClass();
            Console.ReadKey();

        }

        static void UsingClass()
        {
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(10);
            numbers.Add(0);
            foreach(int num in numbers)
            {
                FileClass.Log("Entered number is: " + Convert.ToString(num));
            }
        }
      
static void SumOfUserEntries()
        {
            List<int> numbers = new List<int>();
            bool stayinloop = true;
            string userentry;
            int entry;
            do
            {
                Console.WriteLine("Enter an int value to add to the List, for break do not enter anything");
                userentry = Console.ReadLine();
                if (string.IsNullOrEmpty(userentry))
                {
                    stayinloop = false;
                    break;
                }
                entry = Convert.ToInt32(userentry);
                numbers.Add(entry);
            } while (stayinloop);
            Console.WriteLine("Sum of every entered int on the List is: {0}", SumCalc.CalculateSum(numbers));

        }        
            
        static int SumOfList(List<int> anylist)
        {
            
            int sum = 0;
            foreach(int i in anylist)
            {
                sum = sum + i;
            }
            return sum;
        }
        
    }
}


