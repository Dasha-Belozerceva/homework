using System;

namespace _2._2._4
{
    public interface InterfaceStack
    {
        /// <summary>
        /// check stack to elements in it
        /// </summary>
        /// <returns>"true" if stack is empty</returns>
        bool IsEmpty();
        
        /// <summary>
        /// add element to stack
        /// </summary>
        /// <param name="value">the value of element</param>
        void Push(int value);
        
        /// <summary>
        /// delete element from stack
        /// </summary>
        void Pop();
        
        /// <summary>
        /// get value of head of stack
        /// </summary>
        /// <returns>value</returns>
        int Top();

        int ReturnPopElement();
    }
}
