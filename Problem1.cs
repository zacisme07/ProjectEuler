using System;

namespace ProjectEulerProblem1
{
    class Problem1
    {
        static void Main(string[] args)
        {
            // Find the sum of all the multiples of 3 and 5 below 1000

            int total = 0;
            

            for (int counter = 1; counter < 1000; counter++)
            {
                if (counter % 3 == 0)
                {
                    total = total + counter;
                }
                else if (counter % 5 == 0)
                {
                    total = total + counter;
                }
                Console.WriteLine($"{counter} {total}");
            }
            Console.WriteLine(total);
        }
    }
}
