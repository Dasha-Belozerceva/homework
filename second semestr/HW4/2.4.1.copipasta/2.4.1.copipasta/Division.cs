namespace _2._4._1
{
    using System;

    /// <summary>
    /// Division operation
    /// </summary>
    public class Division : Operator
    {
        public override double Calculate()
        {
            // exception when maked division by zero
            if (Right.Calculate() == 0)
                throw new Exception("Division by zero is impossible");

            return Left.Calculate() / Right.Calculate();
        }

        public override string PrintSymbol()
        {
            return "/";
        }
    }
}

