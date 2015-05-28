using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7._1
{
    public class MyList<T> : IEnumerable
    {
        /// <summary>
        /// description of List's element
        /// </summary>
        public class ListElement
        {
            /// <summary>
            /// Meaning of List's element
            /// </summary>
            public T Value { get; set; }

            /// <summary>
            /// move to the next element
            /// </summary>
            public ListElement Next { get; set; }
        }

        /// <summary>
        /// Pointer of the first List's element
        /// </summary>
        private ListElement head = null;

        /// <summary>
        /// Counter of number of elements in List
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// check list to the existence of elements in it
        /// </summary>
        /// <returns>"true" if list is empty and "false" if there are elements in the list</returns>
        public bool IsEmpty()
        {
            return GetHead() == null;
        }

        /// <summary>
        /// Push element to head
        /// </summary>
        /// <param name="value">meaning of this element</param>
        public void AddElementToHead(T value)
        {
            ListElement newElement = new ListElement();
            newElement.Value = value;
            newElement.Next = head;
            head = newElement;
            ++Length;
        }

        /// <summary>
        /// insert element to the end of list
        /// </summary>
        /// <param name="value">meaning of this element</param>
        public void AddElementInTail(T value)
        {
            //если список пуст, то элемент добавляем в голову
            if (IsEmpty())
            {
                AddElementToHead(value);
                ++Length;
                return;
            }
            ListElement currentElement = head;
            while (currentElement.Next != null)
            {
                currentElement = currentElement.Next;
            }
            ListElement newElement = new ListElement();
            newElement.Value = value;
            currentElement.Next = newElement;
            ++Length;
            return;
        }

        /// <summary>
        /// add element on this position
        /// </summary>
        /// <param name="value">value of this element</param>
        /// <param name="position">position of this element</param>
        public void InsertElementToPosition(T value, int position)
        {
            //проверка корректности заданной позиции
            if (position < 0 || position > Length + 1)
            {
                throw new Exception("no exist this position");
            }
            //если позиция равна нулю, то добавляем элемент в начало списка
            else if (position == 0)
            {
                AddElementToHead(value);
                ++Length;
                return;
            }
            //если номер позиции равен длине списка, то добавляем элемент в конец списка
            else if (position == Length)
            {
                AddElementInTail(value);
                ++Length;
                return;
            }
            else
            {
                ListElement currentElement = head;
                ListElement newElement = new ListElement();
                newElement.Value = value;
                int countOfPosition = 0;
                while (countOfPosition != position - 1)
                {
                    currentElement = currentElement.Next;
                    ++countOfPosition;
                }
                newElement.Next = currentElement.Next;
                currentElement.Next = newElement;
            }
            ++Length;
            return;
        }

        /// <summary>
        /// delete element from this position
        /// </summary>
        /// <param name="position">position of this element</param>
        /// <returns></returns>
        public void RemoveElementFromPosition(int position)
        {
            //проверка на корректность заданной позиции
            if (position < 0 || position > Length + 1)
            {
                throw new Exception("incorrect position!");
            }
            //если позиция равна нулю, удаляем из начала списка
            if (position == 0)
            {
                head = head.Next;
                Length--;
                return;
            }
            ListElement currentElement = head;
            int countOfPosition = 0;
            while (countOfPosition != position - 1)
            {
                currentElement = currentElement.Next;
                ++countOfPosition;
            }
            currentElement.Next = currentElement.Next.Next;
            Length--;
            return;
        }

        /// <summary>
        /// show ont the screen value of element on this position
        /// </summary>
        /// <param name="position"></param>
        /// <returns>value of element</returns>
        public T getValue(int position)
        {
            if (position < 0 || position > Length + 1)
            {
                throw new Exception("incorrect position!");
            }
            ListElement positionElement = head;
            int countOfPosition = 0;
            while (countOfPosition != position)
            {
                positionElement = positionElement.Next;
                ++countOfPosition;
            }
            return positionElement.Value;
        }

        /// <summary>
        /// checks for element value in the list
        /// </summary>
        /// <param name="value">value of checked element</param>
        /// <returns></returns>
        public bool availabilityOFValue(T value)
        {
            ListElement currentElement = head;
            while (currentElement != null)
            {
                if (Equals(currentElement.Value, value))
                {
                    return true;
                }
                currentElement = currentElement.Next;
            }
            return false;
        }

        /// <summary>
        /// delete element with this value from list
        /// </summary>
        /// <param name="value">value of this element</param>
        public void removeElementByValue(T value)
        {
            //проверим есть ли элемент с данным значением в списке
            if (!availabilityOFValue(value))
            {
                throw new Exception("Element is not exist");
            }
            ListElement currentElement = head;
            ListElement previousElement = head;
            if (Equals(currentElement.Value, value))
            {
                head = head.Next;
                --Length;
                return;
            }
            while (!Equals(currentElement.Value, value))
            {
                currentElement = currentElement.Next;
                if (!Equals(currentElement.Next.Value, value))
                {
                    previousElement = previousElement.Next;
                }
            }
            previousElement.Next = currentElement.Next;
            --Length;
        }

        /// <summary>
        /// get the first element in list
        /// </summary>
        /// <returns>head</returns>
        public ListElement GetHead()
        {
            return head;
        }

        /// <summary>
        /// Reilized for IEnumerable
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        /// <summary>
        /// Realized for IEnumerator
        /// </summary>
        private class Enumerator : IEnumerator
        {
            private int position = -1;
            private MyList<T> list;
            private ListElement current;

            public Enumerator(MyList<T> myList)
            {
                list = myList;
            }

            public void Reset()
            {
                position = -1;
            }

            public object Current
            {
                get { return current; }
            }

            public bool MoveNext()
            {
                if (position == -1)
                {
                    current = list.head;
                }
                else
                {
                    current = current.Next;
                }
                position++;

                return current != null;
            }

            public void Dispose()
            {

            }
        }
    }
}
