using System;
using MyList;

namespace uniqueListNamespace
{
    public class UniqueList : List
    {
        public UniqueList()
        {
        }

        /// <summary>
        /// add element to the top of list
        /// </summary>
        /// <param name="value">value of this element</param>
        public override void InsertElementToHead(int value)
        {
            if (availabilityOFValue(value))
            {
                throw new ContainedValueInListException("This value is already contained in the list");
            }
            else
            {
                base.InsertElementToHead(value);
            }
        }
        
        /// <summary>
        /// add element to the end of list
        /// </summary>
        /// <param name="value">value of this element</param>
        public override void InsertElementToTail(int value)
        {
            if (availabilityOFValue(value))
            {
                throw new ContainedValueInListException("This value is already contained in the list");
            }
            else
            {
                base.InsertElementToTail(value);    
            }
        }
        
        /// <summary>
        /// add element on this position
        /// </summary>
        /// <param name="value">value of this element</param>
        /// <param name="position">position</param>
        public override void InsertElementToPosition(int value, int position)
        {
            if (availabilityOFValue(value))
            {
                throw new ContainedValueInListException("This value is already contained in the list");
            }
            else
            {
                base.InsertElementToPosition(value, position);
            }

        }
        
        /// <summary>
        /// delete element from position
        /// </summary>
        /// <param name="position">this position</param>
        public override void RemoveElementFromPosition(int position)
        {
            if (position < 0 || position > this.SizeOfList() - 1)
            {
                throw new NoElementInTheListExeption("this value is not in the list");
            }
            else
            {
                base.RemoveElementFromPosition(position);
            }
        }
        
        /// <summary>
        /// delete element with this value
        /// </summary>
        /// <param name="value">value of deleted element</param>
        public override void removeElementByValue(int value)
        {
            if (!availabilityOFValue(value))
            {
                throw new NoElementInTheListExeption("this value is not in the list");
            }
            else
            {
                base.removeElementByValue(value);
            }
        }
    }
}
