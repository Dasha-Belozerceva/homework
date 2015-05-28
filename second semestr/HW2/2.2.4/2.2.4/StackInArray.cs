using System;
using _2._2._4;

namespace StackInArrayNamespace
{
    public class StackInArray : InterfaceStack
    {
        private const int maxSize = 100;
        private int[] array = new int[maxSize];
        private int head = -1;

        public bool IsEmpty()
        {
            return head == -1;
        }

        public void Push(int value)
        {
            ++head;
            array[head] = value;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                return;
            }
            array[head] = 0;
            --this.head;
        }

        public int Top()
        {
            return this.array[head];
        }

        public int ReturnPopElement()
        {
            int number = Top();
            Pop();
            return number;
        }

    }
}
