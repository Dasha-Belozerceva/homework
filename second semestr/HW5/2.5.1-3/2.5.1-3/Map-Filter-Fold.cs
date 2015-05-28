using System;


namespace _2._5._1_3
{
    public class Map_Filter_Fold
    {
        /// <summary>
        /// function that change elements of list
        /// </summary>
        /// <param name="list">this list</param>
        /// <param name="thisFunction">this function</param>
        public void Map(List list, Func<int, int> thisFunction)
        {
            int endOfList = list.SizeOfList();
            var elementForChange = list.Head();
            for (int i = 0; i < endOfList; ++i)
            {
                elementForChange.Value = thisFunction(elementForChange.Value);
                elementForChange = elementForChange.Next;
            }
        }

        /// <summary>
        /// function that add to new list true element
        /// </summary>
        /// <param name="list">this list</param>
        /// <param name="checkFunction">this function</param>
        /// <returns></returns>
        public List Filter(List list, Func<int, bool> checkFunction)
        {
            List trueList = new List();
            int endOfList = list.SizeOfList();
            var checkedElement = list.Head();
            for (int i = 0; i < endOfList; ++i)
            {
                if (checkFunction(checkedElement.Value))
                {
                    trueList.InsertElementToTail(checkedElement.Value);
                }
                checkedElement = checkedElement.Next;
            }
            return trueList;
        }

        /// <summary>
        /// function that finds and returns value corresponding this list
        /// </summary>
        /// <param name="list">this list</param>
        /// <param name="currentAccValue">value by which function find value corrensponding this list</param>
        /// <param name="returningFunction">this function</param>
        /// <returns></returns>
        public int Fold(List list, int currentAccValue, Func<int, int, int>returningFunction)
        {
            int endOfList = list.SizeOfList();
            var runElement = list.Head();
            for (int i = 0; i < endOfList; ++i)
            {
                currentAccValue = returningFunction(currentAccValue, runElement.Value);
                runElement = runElement.Next;
            }
            return currentAccValue;
        }
    }
}
