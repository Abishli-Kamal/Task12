using System;


namespace task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine( Max());
        }
        public static int Max()
        {
            int[] arr = { 10, 8, 49, 17, 5 };
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

    }
}

