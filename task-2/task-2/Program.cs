using System;

namespace task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 4500;
            int count = 0;
            int result = 0;
            int input = 3;
            while (num > 0)
            {

                num = num / 10;
                count++;
                result = input * 10 * 10 * 10 * 10;

            }
            
            Console.WriteLine(result + 4500);
        }
    }
}
