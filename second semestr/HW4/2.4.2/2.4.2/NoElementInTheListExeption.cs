using System;

namespace uniqueListNamespace
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
