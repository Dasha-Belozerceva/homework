using System;


namespace ListNamespace
{
    public class List
    {
        /// <summary>
        /// Pointer to the first list element. if the list is empty, the first element is null
        /// </summary>
        public  ListElement head = null;
        /// <summary>
        /// describe list element
        /// </summary>
        public class ListElement
        {
            /// <summary>
            /// value of the list element
            /// </summary>
            public int Value { get; set; }
            /// <summary>
            /// link to the next element
            /// </summary>
            public ListElement Next { get; set; }
        }
        /// <summary>
        /// check list to the existence of elements in it
        /// </summary>
        /// <returns>"true" if list is empty and "false" if there are elements in the list</returns>
        public bool IsEmpty()
        {
            return head == null;
        }
        /// <summary>
        /// show on the screen the count of elements in list
        /// </summary>
        /// <returns>So unexpectedly...the count of elements in list</returns>
        public int SizeOfList()
        {
            ListElement newListElement = head;
            int size = 0;
            while (newListElement != null)
            {
                newListElement = newListElement.Next;
                ++size;
            }
            return size;
        }
        /// <summary>
        /// show ont the screen value of element on this position
        /// </summary>
        /// <param name="position"></param>
        /// <returns>value of element</returns>
        public int getValue(int position)
        {
            if (position < 0 || position > SizeOfList() + 1)
            {
                Console.WriteLine("error!\n");
                return -88888;
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
        /// add element to the top of list
        /// </summary>
        /// <param name="value">value of this element</param>
        public void InsertElementToHead(int value)
        {
            ListElement newElement = new ListElement()
            {
                Next = head,
                Value = value
            };
            head = newElement;
        }
        /// <summary>
        /// add element to the end of list
        /// </summary>
        /// <param name="value">value of this element</param>
        public void InsertElementToTail(int value)
        {
            //если список пуст, то элемент добавляем в голову
            if (IsEmpty())
            {
                InsertElementToHead(value);
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
        }
        /// <summary>
        /// add element on this position
        /// </summary>
        /// <param name="value">value of this element</param>
        /// <param name="position">position of this element</param>
        public void InsertElementToPosition(int value, int position)
        {
            //проверка корректности заданной позиции
            if(position < 0 || position > SizeOfList() + 1)
            {
                Console.WriteLine("Error!");
                return;
            }
            //если позиция равна нулю, то добавляем элемент в начало списка
            else if (position == 0)
            {
                InsertElementToHead(value);
            }
            //если номер позиции равен длине списка, то добавляем элемент в конец списка
            else if(position == SizeOfList())
            {
                InsertElementToTail(value);
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
        }
        /// <summary>
        /// delete element from this position
        /// </summary>
        /// <param name="position">position of this element</param>
        /// <returns></returns>
        public void RemoveElementFromPosition(int position)
        {
            //проверка на корректность заданной позиции
            if (position < 0 || position > SizeOfList() + 1)
            {
                Console.WriteLine("Error!");
                return;
            }
            //если позиция равна нулю, удаляем из начала списка
            if (position == 0)
            {
                head = head.Next;
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
            return;
        }
        /// <summary>
        /// checks for element value in the list
        /// </summary>
        /// <param name="value">value of checked element</param>
        /// <returns></returns>
        public bool availabilityOFValue(int value)
        {
            ListElement currentElement = head;
            while (currentElement != null)
            {
                if (currentElement.Value == value)
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
        public void removeElementByValue(int value)
        {
            //проверим есть ли элемент с данным значением в списке
            if (!availabilityOFValue(value))
            {
                Console.WriteLine("Error!");
                return;
            }
            ListElement currentElement = head;
            ListElement previousElement = head;
            if (currentElement.Value == value)
            {
                head = head.Next;
                return;
            }
            while (currentElement.Value != value)
            {
                currentElement = currentElement.Next;
                if (currentElement.Next.Value != value)
                {
                    previousElement = previousElement.Next;
                }
            }
            previousElement.Next = currentElement.Next;
        }
        /// <summary>
        /// and finally...print this list (show its on the screen)
        /// </summary>
        public void printList()
        {
            ListElement currentElement = head;
            while(currentElement != null)
            {
                Console.WriteLine(currentElement.Value + " ");
                currentElement = currentElement.Next;
            }

        }
    }
}
