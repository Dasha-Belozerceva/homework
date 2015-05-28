using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._6._2
{
    public partial class DigitalClock : Form
    {
        Timer t = new Timer();
        public DigitalClock()
        {
            InitializeComponent();
        }

        /// <summary>
        /// set the interval timing and add Event Handler to our t timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DigitalClock_Load(object sender, EventArgs e)
        {
            //timer interval in milliseconds
            t.Interval = 1000;

            t.Tick += new EventHandler(this.T_Tick);

            //start timer when form loads whith using T_Tick() method
            t.Start();
        
        
        }

        /// <summary>
        /// timer eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void T_Tick(object sender, EventArgs e)
        {

            //get current time
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            //string of time
            string time = "";

            if (hour < 10)
            {
                time += "0" + hour;
            }
            else
                time += hour;
            time += ":";
            if (minute < 10)
            {
                time += "0" + minute;
            }
            else
                time += minute;
            time += ":";
            if (second < 10)
            {
                time += "0" + second;
            }
            else
                time += second;
            
            //update label
            Time.Text = time;
        }
    }
}
