using System;


namespace _2._1._2
{
    public static class Fibonacci
    {
        /// <summary>
        /// The function calculates the fibonacci number of the input value
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int fibonacci(int number)
        {
            int number1 = 0;
            int number2 = 1;
            int exchange = 0;
            if (number < 0)
                return -1;
            if (number == 0 || number == 1)
            {
                return number;
            }
            else
            {
                for (int i = 2; i <= number; ++i)
                {
                    exchange = number1 + number2;
                    number1 = number2;
                    number2 = exchange;
                }
                return exchange;
            }
        }
        /// <summary>
        /// input argument with a keyboard and realization of fibonacci function
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fibonacci(number));

        }
    }
}
