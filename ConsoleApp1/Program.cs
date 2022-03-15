using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] djob1 = new int[] { 5, 10, 20, 50, 100, 1 };

            //var sum = SumLoop(djob1);

            //Console.WriteLine(sum);

            var sum2 = Sum(djob1, 0);

            Console.WriteLine(sum2);
        }

        public static int Sum(int[] arr, int index)
        {
            if(index == arr.Length)
            {
                return 0;
            }

            int currentElement = arr[index];

            return currentElement + Sum(arr, index + 1);
        }

        public static int SumLoop(int[] kolekciq)
        {
            int sum = 0;

            for (int i = 0; i < kolekciq.Length; i++)
            {
                sum += kolekciq[i];
            }

            return sum;
        }
    }
}
