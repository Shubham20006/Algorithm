using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            {

                SortingString d = new SortingString();
                d.List();
                Console.WriteLine("\nEnter word do you want to search : ");
                string W = Console.ReadLine();
                d.Searching(W);
            }
        }
    }
}