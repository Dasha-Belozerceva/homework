using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._1
{
    public class Stack<T>
    {
        /// <summary>
        /// set the stack element
        /// </summary>
        private class StackElement
        {
            public T Value { get; set; } 
            public StackElement Next { get; set; }
        }

        /// <summary>
        /// head of stack
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// check the stack for empty
        /// </summary>
        /// <returns>"true" if stack is empty, else "false"</returns>
        public bool IsEmpty()
        {
            return (head == null);
        }

        /// <summary>
        /// add element in stack
        /// </summary>
        /// <param name="value">value of element</param>
        public void Push(T value)
        {
            StackElement newElement = new StackElement();
            newElement.Value = value;
            newElement.Next = head;
            head = newElement;
        }

        /// <summary>
        /// delete element from stack
        /// </summary>
        /// <returns>value of deleted element</returns>
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Error! No elements in stack");
            }
            T value = head.Value;
            head = head.Next;
            return value;
        }

        /// <summary>
        /// outputs to the console elements of stack
        /// </summary>
        public void PrintStack()
        {
            StackElement current = head;
            while (current != null)
            {
                Console.WriteLine(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
