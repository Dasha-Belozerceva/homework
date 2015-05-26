using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._6._1
{
    public partial class calculator : Form
    {
        double value = 0;
        String operation = "";
        bool operationPressed = false;


        public calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        ///enter the value 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operationPressed))
            {
                result.Clear();
            }
            operationPressed = false;
            Button buttonNumber = (Button)sender;
            if (buttonNumber.Text == ",")
             {
                 if (!result.Text.Contains(","))
                 {
                     result.Text = result.Text + buttonNumber.Text;
                 }
             }
             else
                 result.Text = result.Text + buttonNumber.Text;
        }

        /// <summary>
        /// enter the operation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operation_Click(object sender, EventArgs e)
        {
            Button operationButton = (Button)sender;
            if (value != 0)
            {
                resultButton.PerformClick();
                operationPressed = true;
                operation = operationButton.Text;
                equation.Text = value + " " + operation;
            }
            else
            {
                operation = operationButton.Text;
                value = Double.Parse(result.Text);
                operationPressed = true;
                equation.Text = value + " " + operation;
            }
        }

        /// <summary>
        /// calculate expression
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResultButton_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (Double.Parse(result.Text) + value).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (Double.Parse(result.Text) * value).ToString();
                    break;
                case "/":
                    if (result.Text == "0")
                    {
                        result.Text = "division by zero is impossible";
                    }
                    else
                    {
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                    }
                    break;
                default:
                    break;

            }
            if (result.Text == "division by zero is impossible")
                value = 0;
            else
                value = Double.Parse(result.Text);
            operation = "";
        }

        /// <summary>
        /// clear all
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
            equation.Text = "";
        }

        /// <summary>
        /// delete value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }
    }
}
