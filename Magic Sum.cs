using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to magic sum!");
            Console.WriteLine();

            Console.WriteLine("Enter your numbers: ");
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine();

            Console.WriteLine("Enter magic sum: ");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Pairs of numbers equal to your magic sum: ");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == sum)
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} = {sum}");
                    }
                }
            }
        }
    }
}
