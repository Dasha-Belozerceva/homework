﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._4._2
{
    [Serializable]
    public class ContainedValueInListException : Exception
    {
        public ContainedValueInListException() { }
        public ContainedValueInListException(string message) : base(message) { }
        public ContainedValueInListException(string message, Exception inner) : base(message, inner) { }
        protected ContainedValueInListException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}
