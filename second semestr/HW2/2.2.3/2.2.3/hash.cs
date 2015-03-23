namespace RealizationOfTheHashTable
{
    using System;
    using TemplateOfList;

    public class Hash
    {
        public const int HashSize = 1000;
        /// <summary>
        /// type of elements of the hash table is lists
        /// </summary>
        private List[] hash = new List[HashSize];
        /// <summary>
        /// fill the hash table is empty lists
        /// </summary>
        public Hash()
        {
            for (int i = 0; i < HashSize; ++i)
            {
                hash[i] = new List();
            }
        }
        /// <summary>
        /// index the elements of the hash table
        /// </summary>
        /// <param name="element">value of element</param>
        /// <returns>index</returns>
        public int HashFunction(string element)
        {
            int index = 0;
            for (int i = 0; i < element.Length; ++i)
            {
                index += Convert.ToInt32(element[i]);
            }
            if (index == 0)
            {
                return index;
            }
            else
                index /= element.Length;
            return index;
        }
        /// <summary>
        /// add element to hashtable
        /// </summary>
        /// <param name="element">value of the element</param>
        public void InsertElementToHashTable(string element)
        {
            hash[HashFunction(element)].InsertElementToHead(element);
        }
        /// <summary>
        /// check existence of element on hashtable
        /// </summary>
        /// <param name="element">value of element</param>
        /// <returns>"true" if element is in hashtable, "false" if element is not exist in hashtable</returns>
        public bool AvailabilityOFElementInHashTable(string element)
        {
            return hash[HashFunction(element)].availabilityOFValue(element);
        }
        /// <summary>
        /// delete element from hashtable
        /// </summary>
        /// <param name="element">value of element</param>
        public void RemoveElementFromHashTable(string element)
        {
            hash[HashFunction(element)].removeElementByValue(element);
        }
        /// <summary>
        /// check hashtable for existance of element
        /// </summary>
        /// <returns>"true" if there are not elements in hashtable, else "false"</returns>
        public bool HashIsEmpty()
        {
            for (int i = 0; i < HashSize; ++i)
            {
                if (!hash[i].IsEmpty())
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Console Writeline elements of hashtable
        /// </summary>
        public void PrintHash()
        {
            for (int i = 0; i < HashSize; ++i)
            {
                hash[i].printList();
                Console.WriteLine();
            }
        }
    }
}
