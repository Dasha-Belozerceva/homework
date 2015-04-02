using System;
using MyList;

namespace _2._4._2
{
    public class UniqueList : List
    {
        /// <summary>
        /// add element to the top of list
        /// </summary>
        /// <param name="value">value of this element</param>
        public void InsertElementToHead(int value)
        {
            if (this.availabilityOFValue(value))
            {
                throw new ContainedValueInListException("This value is already contained in the list");
            }
            else
            {
                this.InsertElementToHead(value);
            }
        }
        /// <summary>
        /// add element to the end of list
        /// </summary>
        /// <param name="value">value of this element</param>
        public void InsertElementToTail(int value)
        {
            if (this.availabilityOFValue(value))
            {
                throw new ContainedValueInListException("This value is already contained in the list");
            }
            else
            {
                this.InsertElementToTail(value);    
            }
        }
        /// <summary>
        /// add element on this position
        /// </summary>
        /// <param name="value">value of this element</param>
        /// <param name="position">position</param>
        public void InsertElementToPosition(int value, int position)
        {
            if (this.availabilityOFValue(value))
            {
                throw new ContainedValueInListException("This value is already contained in the list");
            }
            else
            {
                this.InsertElementToPosition(value, position);
            }

        }
        /// <summary>
        /// delete element from position
        /// </summary>
        /// <param name="position">this position</param>
        public void RemoveElementFromPosition(int position)
        {
            if (position < 0 || position > this.SizeOfList() + 1)
            {
                throw new NoElementInTheListExeption("this value is not in the list");
            }
            else
            {
                this.RemoveElementFromPosition(position);
            }
        }
        /// <summary>
        /// delete element with this value
        /// </summary>
        /// <param name="value">value of deleted element</param>
        public void removeElementByValue(int value)
        {
            if (!this.availabilityOFValue(value))
            {
                throw new NoElementInTheListExeption("this value is not in the list");
            }
            else
            {
                this.removeElementByValue(value);
            }
        }
    }
}
