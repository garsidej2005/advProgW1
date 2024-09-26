using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advProgW1
{
    internal class Program
    {
        static Random randomGenerator = new Random();

        static void Main(string[] args)
        {
            List<double> listofDoubles = new List<double>();

            PopulateListWithRandomDoubles(ref listofDoubles, 10);
            PrintList(listofDoubles);

            Console.ReadKey();
        }

        static void RequestSearch(List<double> list)
        {
            Double searchValue;
            Console.WriteLine("What value would you like to search for? ");

            if(Double.TryParse(Console.ReadLine(), out searchValue))
            {
                int index = BinarySearch.Perform(searchValue, list);
                if (index < 0)
                {
                    Console.WriteLine("NOT FOUND");
                }
                else
                {
                    Console.WriteLine("Found at: " + index);
                }
            }
        }

        static void PopulateListWithRandomDoubles(ref List<double> list, int size)
        {
            for (int i = 0; i < size; i++)
            {
                double twoDigitDouble = Double.Parse(randomGenerator.NextDouble().ToString("0.00"));
                list.Add(twoDigitDouble);
            }

            list.Sort();
        }

        static void PrintList(List<double> list)
        {
            Console.WriteLine("\n\nLIST PRINT: \n");

            for(int i = 0; i < list.Count;i++)
            {
                Console.WriteLine("  " + list[i].ToString());
            }

           Console.WriteLine("\nEND \n");
        }
        
    }
}
