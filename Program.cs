
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("*****Permulation by using Iterative method*****");
            String str = "DOG";
            int n = str.Length;
            Console.Write("\nAll possible strings are : \n");
            PermutationOfString.usingIterativeMethod(str, 0, n - 1);

            Console.Write("*****Permulation by using Recursion*****");
            String s = "ABC";
            String answer = "";

            Console.WriteLine("\nAll possible strings are : ");
            PermutationOfStringUsingRecursiveApproach.RecursiveApproach(s, answer);
        }
    }
}
