namespace _2._4._1
{
    using System;

    /// <summary>
    /// Node of arifmetic tree
    /// </summary>
    public abstract class Node
    {
        /// <summary>
        /// Calculate node of tree
        /// </summary>
        /// <returns></returns>
        public abstract double Calculate();

        /// <summary>
        /// Print node of tree
        /// </summary>
        public abstract string Print();
    }
}
