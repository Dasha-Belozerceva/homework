using System;
using StackInArrayNamespace;
using StackInListNamespace;

namespace _2._2._4
{
    public class Calculator
    {
        private InterfaceStack Stack;

        public Calculator(InterfaceStack stack)
        {
            this.Stack = stack;
        }
        

        /// <summary>
        /// Calculate sum.
        /// </summary>
        /// <returns></returns>
        public int Sum()
        {
            int firstNumber = Stack.ReturnPopElement();
            int secondNumber = Stack.ReturnPopElement();
            int sum = firstNumber + secondNumber;
            return sum;
        }

        /// <summary>
        /// Calculate difference.
        /// </summary>
        /// <returns></returns>
        public int Difference()
        {
            int firstNumber = Stack.ReturnPopElement();
            int secondNumber = Stack.ReturnPopElement();
            int difference = firstNumber - secondNumber;
            return difference;
        }

        /// <summary>
        /// Difference quotient.
        /// </summary>
        /// <returns></returns>
        public int Quotient()
        {
            int firstNumber = Stack.ReturnPopElement();
            int secondNumber = Stack.ReturnPopElement();
            int quotient = firstNumber / secondNumber;
            return quotient;
        }

        /// <summary>
        /// Quotient product.
        /// </summary>
        /// <returns></returns>
        public int Product()
        {
            int firstNumber = Stack.ReturnPopElement();
            int secondNumber = Stack.ReturnPopElement();
            int product = firstNumber * secondNumber;
            return product;
        }
    }
}
