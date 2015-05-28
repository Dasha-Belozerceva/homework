using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._3._2
{
    public interface GeneralFunction
    {
        /// <summary>
        /// interface to switch hash function
        /// </summary>
        /// <param name="element">elemend which index hash function calculates</param>
        /// <returns>index of element</returns>
        int HashFunction(string element);
    }
}
