namespace _2._4._1
{
    using System;

    /// <summary>
    /// Class for tree
    /// </summary>
    public class Tree
    {
        private Node TreeHead;

        private int index;

        /// <summary>
        /// Parse Tree
        /// </summary>
        /// <param name="str"></param>
        public Tree(string str)
        {
            index = 0;
            TreeHead = ConstructTree(str);
        }

        /// <summary>
        /// Calculate tree
        /// </summary>
        /// <returns></returns>
        public double CalculateTree()
        {
            return TreeHead.Calculate();
        }

        /// <summary>
        /// Output tree
        /// </summary>
        /// <returns></returns>
        public string PrintTree()
        {
            return TreeHead.Print();
        }

        /// <summary>
        /// build a tree
        /// </summary>
        /// <param name="str"> string from which to build the tree </param>
        /// <returns></returns>
        private Node ConstructTree(string str)
        {
            while (IsBracket(str[index]) || IsSpace(str[index]))
                index++;

            if (!IsOperator(str[index]) && !(str[index] >= '0' && str[index] <= '9'))
                throw new Exception("incorrect expression");

            if (IsOperator(str[index]))
            {
                var newNode = NewOperator(str[index]);
                index++;

                newNode.Left = ConstructTree(str);
                newNode.Right = ConstructTree(str);

                return newNode;
            }
            else
            {
                string currentElement = Convert.ToString(str[index]);

                index++;
                if (index < str.Length)
                    while (str[index] >= '0' && str[index] <= '9')
                    {
                        currentElement += str[index];
                        index++;
                    }

                var operand = NewOperand(currentElement);
                return operand;
            }
        }

        /// <summary>
        /// create new operator
        /// </summary>
        /// <param name="symbol">symbol from which create new operator</param>
        /// <returns>operator</returns>
        private Operator NewOperator(char symbol)
        {
            if (symbol == '-')
                return new Subtraction();
            else if (symbol == '+')
                return new Addition();
            else if (symbol == '/')
                return new Division();
            else
                return new Multiplication();
        }

        /// <summary>
        /// create new operand
        /// </summary>
        /// <param name="str">string from which create operand</param>
        /// <returns>left or right operand</returns>
        private Operand NewOperand(string str)
        {
            return new Operand(str);
        }

        /// <summary>
        /// check symbol for bracket
        /// </summary>
        /// <param name="symbol">this symbol</param>
        /// <returns>"true" if symbol is space, else "false"</returns>
        private bool IsBracket(char symbol)
        {
            return symbol == '(' || symbol == ')';
        }

        /// <summary>
        /// check symbol for space
        /// </summary>
        /// <param name="symbol">this symbol</param>
        /// <returns>"true" if symbol is space, else "false"</returns>
        private bool IsSpace(char symbol)
        {
            return symbol == ' ';
        }

        /// <summary>
        /// check symbol for operator
        /// </summary>
        /// <param name="symbol">this symbol</param>
        /// <returns>"true" if symbol is operator, else "false"</returns>
        private bool IsOperator(char symbol)
        {
            return symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/';
        }
    }
}
