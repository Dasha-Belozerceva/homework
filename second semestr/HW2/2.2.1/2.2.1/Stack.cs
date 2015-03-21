using System;

namespace StackNamespace
{
    public class Stack
    {
        /// <summary>
        /// describe stack element
        /// </summary>
        private class StackElement
        {
            /// <summary>
            /// value of the stack element 
            /// </summary>
            public int value { get; set; }

            /// <summary>
            /// link to the next element
            /// </summary>
            public StackElement Next { get; set; }
        }

        /// <summary>
        /// Pointer to the first stack element. if the stack is empty, the first element is null
        /// </summary>
        private StackElement head = null;

        /// <summary>
        /// adding a new element in the stack
        /// </summary>
        /// <param name="value">value of the pushed element</param>
        public void Push (int value)
        {
            StackElement NewElement = new StackElement();
            NewElement.Next = head;
            NewElement.value = value;
            head = NewElement;
        }
        /// <summary>
        /// remove element from the stack
        /// </summary>
        public void Pop()
        {
            if (head == null)
            {
                return;
            }
            head = head.Next;
        }

        /// <summary>
        /// get the value of the head of stack
        /// </summary>
        /// <returns>the desired value</returns>
        public int Top()
        {
            if (head == null)
            {
                return -88888;
            }
            return head.value;
        }
        /// <summary>
        /// check Stack to the existence of elements in it
        /// </summary>
        /// <returns>"true" if stack is empty and "false" if there are elements in the stack</returns>
        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
