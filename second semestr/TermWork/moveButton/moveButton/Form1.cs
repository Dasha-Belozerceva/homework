using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moveButton
{
    public partial class MoveButtonApplication : Form
    {
        public MoveButtonApplication()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Enter the window when mouse click button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вам незачет:)", "No Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Move button when mouth enter it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MoveButton_MouseEnter(object sender, EventArgs e)
        {
            Random r = new Random();
            MoveButton.Left = r.Next(0, this.ClientSize.Width - MoveButton.Width);
            MoveButton.Top = r.Next(0, this.ClientSize.Height - MoveButton.Height);
        }
    }
}
