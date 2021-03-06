﻿namespace RealizationOfTheHashTable
{
    using System;
    using TemplateOfList;
    using _2._3._2;

    public class Hash
    {
        public const int HashSize = 1000;
        /// <summary>
        /// type of elements of the hash table is lists
        /// </summary>
        private List[] hash = new List[HashSize];
        private GeneralFunction hashFunction;
        /// <summary>
        /// fill the hash table is empty lists
        /// </summary>
        public Hash(GeneralFunction hashFunction)
        {
            for (int i = 0; i < HashSize; ++i)
            {
                hash[i] = new List();
            }
            this.hashFunction = hashFunction;
        }
        /// <summary>
        /// function to switch Hash Function
        /// </summary>
        /// <param name="hashFunction">hash Function in variable</param>
        public void ChangeHashFunction(GeneralFunction hashFunction)
        {
            List list = new List();
            for (int i = 0; i < 1000; ++i)
            {
                List element = hash[i];
                
                while (!element.IsEmpty())
                {
                    list.InsertElementToHead(element.getValue(0));
                    element.RemoveElementFromPosition(0);
                 }
                 
                this.hashFunction = hashFunction;
                while (!list.IsEmpty())
                {
                    string value = list.getValue(0);
                    list.RemoveElementFromPosition(0);
                    hash[hashFunction.HashFunction(value)].InsertElementToHead(value);
                }
            }
        }
        /// <summary>
        /// add element to hashtable
        /// </summary>`
        /// <param name="element">value of the element</param>
        public void InsertElementToHashTable(string element)
        {
            hash[hashFunction.HashFunction(element)].InsertElementToHead(element);
        }
        /// <summary>
        /// check existence of element on hashtable
        /// </summary>
        /// <param name="element">value of element</param>
        /// <returns>"true" if element is in hashtable, "false" if element is not exist in hashtable</returns>
        public bool AvailabilityOFElementInHashTable(string element)
        {
            return hash[hashFunction.HashFunction(element)].availabilityOFValue(element);
        }
        /// <summary>
        /// delete element from hashtable
        /// </summary>
        /// <param name="element">value of element</param>
        public void RemoveElementFromHashTable(string element)
        {
            hash[hashFunction.HashFunction(element)].removeElementByValue(element);
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
