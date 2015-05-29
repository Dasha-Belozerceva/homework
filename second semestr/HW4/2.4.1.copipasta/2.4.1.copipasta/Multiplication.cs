namespace _2._4._1
{
    using System;

    /// <summary>
    /// Multiplication operation
    /// </summary>
    class Multiplication : Operator
    {
        public override double Calculate()
        {
            return Left.Calculate() * Right.Calculate();
        }

        public override string PrintSymbol()
        {
            return "*";
        }
    }
}
