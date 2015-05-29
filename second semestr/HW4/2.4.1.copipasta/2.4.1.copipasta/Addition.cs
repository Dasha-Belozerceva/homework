namespace _2._4._1
{
    using System;

    /// <summary>
    /// Addition operation
    /// </summary>
    public class Addition : Operator
    {
        public override double Calculate()
        {
            return Left.Calculate() + Right.Calculate();
        }

        public override string PrintSymbol()
        {
            return "+";
        }
    }
}
