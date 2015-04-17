using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String mark = "X";

        bool checkWin()
        {
            if (button1.Text == button2.Text && button1.Text == button3.Text)
            {
                return true;
            }

            if (button4.Text == button5.Text && button4.Text == button6.Text)
            {
                return true;
            }

            if (button7.Text == button8.Text && button7.Text == button9.Text)
            {
                return true;
            }

            if (button1.Text == button4.Text && button1.Text == button7.Text)
            {
                return true;
            }

            if (button2.Text == button5.Text && button2.Text == button8.Text)
            {
                return true;
            }

            if (button3.Text == button6.Text && button3.Text == button9.Text)
            {
                return true;
            }

            if (button1.Text == button5.Text && button1.Text == button9.Text)
            {
                return true;
            }

            if (button3.Text == button5.Text && button3.Text == button7.Text)
            {
                return true;
            }
            else if (button1.Enabled == false && button2.Enabled == false && button3.Enabled == false && button4.Enabled == false && button5.Enabled == false && button6.Enabled == false && button7.Enabled == false && button8.Enabled == false && button9.Enabled == false)
            {
                MessageBox.Show("friendship is won:)", "NO WINNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                button1.Text = " ";
                button2.Text = "  ";
                button3.Text = "   ";
                button4.Text = "    ";
                button5.Text = "     ";
                button6.Text = "      ";
                button7.Text = "       ";
                button8.Text = "        ";
                button9.Text = "         ";
            }
            return false;
        }

        void result()
        {
            MessageBox.Show("Winner:" + mark, "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button1.Text = " ";
            button2.Text = "  ";
            button3.Text = "   ";
            button4.Text = "    ";
            button5.Text = "     ";
            button6.Text = "      ";
            button7.Text = "       ";
            button8.Text = "        ";
            button9.Text = "         ";
        }

        void ClickedButton(Button button)
        {
            button.Text = mark;
            button.Enabled = false;

            if (checkWin())
            {
                result();
            }

           if (mark == "X")
           {
               mark = "O";
           }
           else if (mark == "O")
           {
               mark = "X";
           }
        }

        private void ClickButton1(object sender, EventArgs e)
        {
            ClickedButton(button1);
        }

        private void ClickButton2(object sender, EventArgs e)
        {
            ClickedButton(button2);
        }

        private void ClickButton3(object sender, EventArgs e)
        {
            ClickedButton(button3);
        }

        private void ClickButton4(object sender, EventArgs e)
        {
            ClickedButton(button4);
        }

        private void ClickButton5(object sender, EventArgs e)
        {
            ClickedButton(button5);
        }

        private void ClickButton6(object sender, EventArgs e)
        {
            ClickedButton(button6);
        }

        private void ClickButton7(object sender, EventArgs e)
        {
            ClickedButton(button7);
        }

        private void ClickButton8(object sender, EventArgs e)
        {
            ClickedButton(button8);
        }

        private void ClickButton9(object sender, EventArgs e)
        {
            ClickedButton(button9);
        }
    }
}
