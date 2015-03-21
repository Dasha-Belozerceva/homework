using System;

namespace _2._1._1
{
    public static class Factorial
    {
        /// <summary>
        /// The function calculates the factorial of the input value
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int factorial(int number)
        {
            if (number < 0)
                return 0;
            if (number < 2)
                return 1;
            else
            {
                int multiplication = 1;
                for (int i = 1; i <= number; ++i)
                {
                    multiplication *= i;
                }
                return multiplication;
            }
        }
        /// <summary>
        /// input argument with a keyboard and realization of factorial function
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(number));
        }
    }
}
