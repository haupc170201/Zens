using System;
using System.Linq;

namespace Backend___Solution
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter five positive integers:");
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            long sum = 0;

            foreach (int num in array)
            {
                sum += num;
                if (num < min)
                    min = num;
                if (num > max)
                    max = num;
            }

            long minSum = sum - max;
            long maxSum = sum - min;
            Console.WriteLine(minSum + " " + maxSum);
        }
    }
}
