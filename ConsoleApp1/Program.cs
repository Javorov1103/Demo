using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

            var sum = SumLoop(numbers);

            Console.WriteLine(sum);

            var sum2 = SumRecursivly(numbers, 0);

            Console.WriteLine(sum2);
        }

        public static int SumRecursivly(int[] arr, int index)
        {
            if(index == arr.Length)
            {
                return 0;
            }

            return arr[index] + SumRecursivly(arr, index + 1);
        }

        public static int SumLoop(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }
    }
}
