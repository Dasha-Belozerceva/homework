using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._2
{
    public class hashFunction1 : GeneralFunction
    {
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
    }
}
