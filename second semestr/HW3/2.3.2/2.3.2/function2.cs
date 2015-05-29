using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._2
{
    public class hashFunction2 : GeneralFunction
    {
        /// <summary>
        /// index the elements of the hash table
        /// </summary>
        /// <param name="element">value of element</param>
        /// <returns>index</returns>
        public int HashFunction(string element)
        {
            const int invariable = 88;
            int index = element[0];
            int length = element.Length;
            for (int i = 0; i < length - 1; ++i)
            {
                index = (index * invariable + element[i]) % 1000;
            }
            return index;
        }
    }
}
