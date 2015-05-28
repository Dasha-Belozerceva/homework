using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._4
{
    /// <summary>
    /// List
    /// </summary>
    public class List<T> : IEnumerable<T>
    {
        public class ListElement
        {
            public T Value { get; set; }
            public ListElement (T value)
            {
                Value = value;
            }
            public ListElement Next { get; set; }
        }

        private ListElement head = null;

        /// <summary>
        /// checking list for empty
        /// </summary>
        /// <returns>"true" if list is empty, else false</returns>
        public bool  IsEmpty()
        {
            return head == null;
        }

        public void InsertElementToHead(T value)
        {
            ListElement newElement = new ListElement(value);
            {
                ListElement Next = head;
                T Value = value;
            };
        }


    }
}
