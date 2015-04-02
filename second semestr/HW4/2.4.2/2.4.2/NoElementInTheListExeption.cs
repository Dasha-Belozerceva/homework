using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._2
{
    [Serializable]
    public class NoElementInTheListExeption : Exception
    {
        public NoElementInTheListExeption() { }
        public NoElementInTheListExeption(string message) : base(message) { }
        public NoElementInTheListExeption(string message, Exception inner) : base(message, inner) { }
        protected NoElementInTheListExeption(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
     }
}
