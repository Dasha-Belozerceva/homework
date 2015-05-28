using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._2
{
    /// <summary>
    /// class of multiplicity
    /// </summary>
    public  class multiplicity<T>
    {
        /// <summary>
        /// List element
        /// </summary>
        private class MultiplicityElement
        {
            /// <summary>
            /// value of list element
            /// </summary>
            public T Value { get; set; }

            /// <summary>
            /// move point to the next element
            /// </summary>
            public MultiplicityElement Next { get; set; }
        }

        /// <summary>
        /// the first list element
        /// </summary>
        private MultiplicityElement head = null;

        /// <summary>
        /// Chek of existence elements in List.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        /// <summary>
        /// insert element to multiplicity
        /// </summary>
        /// <param name="value"></param>
        public void AddElement(T value)
        {
            var newElement = new MultiplicityElement()
            {
                Value = value,
                Next = null,
            };

            if (IsEmpty())
            {
                head = newElement;
                return;
            }

            MultiplicityElement currentElement = head;

            while (currentElement.Next != null)
            {
                if (currentElement.Next == null)
                {
                    return;
                }
                if (currentElement.Value.Equals(value))
                {
                    return;
                }
                currentElement = currentElement.Next;
            }
            currentElement.Next = newElement;
        }

        /// <summary>
        /// remove element from multiplicity
        /// </summary>
        /// <param name="value"></param>
        public void DeleteElement(T value)
        {
            MultiplicityElement currentElement = head;
            MultiplicityElement previousElement = head;

            while (currentElement != null)
            {
                if (head.Value.Equals(value))
                {
                    head = head.Next;
                    currentElement = null;
                    return;
                }
                if (!currentElement.Value.Equals(value))
                {
                    previousElement = currentElement;
                    currentElement = currentElement.Next;
                }
                else
                {
                    previousElement.Next = currentElement.Next;
                    currentElement = null;
                    return;
                }
            }
        }


        /// <summary>
        /// check element for existence in multiplicity
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool availabilityOFValue(T value)
        {
            if (IsEmpty())
            {
                return false;
            }

            MultiplicityElement currentElement = head;

            while (currentElement != null)
            {
                if (!currentElement.Value.Equals(value))
                {
                    currentElement = currentElement.Next;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Getting result of intersection of two multiplicity.
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Second"></param>
        public void Intersection(multiplicity<T> FirstMultiplicity, multiplicity<T> SecondMultiplicity)
        {
            this.head = null;

            if ((FirstMultiplicity.IsEmpty()) || (SecondMultiplicity.IsEmpty()))
            {
                this.head = null;
                return;
            }

            MultiplicityElement currentFirst = FirstMultiplicity.head;
            MultiplicityElement currentSecond = SecondMultiplicity.head;

            while (currentFirst != null)
            {
                while (currentSecond != null)
                {
                    if (currentFirst.Value.Equals(currentSecond.Value))
                    {
                        this.AddElement(currentFirst.Value);
                    }
                    currentSecond = currentSecond.Next;
                }
                currentFirst = currentFirst.Next;
                currentSecond = SecondMultiplicity.head;
            }
        }

        /// <summary>
        /// Getting result of union of two multiplicity.
        /// </summary>
        /// <param name="First"></param>
        /// <param name="Second"></param>
        public void Union(multiplicity<T> FirstMultiplicity, multiplicity<T> SecondMultiplicity)
        {
            this.head = null;

            MultiplicityElement currentFirst = FirstMultiplicity.head;
            MultiplicityElement currentSecond = SecondMultiplicity.head;

            while (currentFirst != null)
            {
                this.AddElement(currentFirst.Value);
                currentFirst = currentFirst.Next;
            }

            while (currentSecond != null)
            {
                this.AddElement(currentSecond.Value);
                currentSecond = currentSecond.Next;
            }
        }
    }
}
