using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
            size = 4;
            Feedback.Visible = false;
        }

        public int size { get; set; }
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int tabIndex = Convert.ToInt32(b.Tag);
            int rightIndex = ((tabIndex % size) < size - 1) ? tabIndex+1 : -1;
            int leftIndex = ((tabIndex % size > 0)) ? tabIndex - 1 : 0;
            int upIndex = ((tabIndex > size - 1)) ? tabIndex - size : -1;
            int downIndex = ((tabIndex < size*(size - 1))) ? tabIndex + size : -1;

            PerformSwap(tabIndex, rightIndex,b);
            PerformSwap(tabIndex, leftIndex, b);
            PerformSwap(tabIndex, upIndex, b);
            PerformSwap(tabIndex, downIndex, b);
            ValidateWin();
        }

        private void ValidateWin()
        {
            if(button1.Text == "1" && button5.Text == "2" && button8.Text == "3" && button11.Text == "4"
                && button2.Text == "5" && button6.Text == "6" && button9.Text == "7" && button12.Text == "8"
                && button3.Text == "9" && button7.Text == "10" && button10.Text =="11" && button15.Text == "12"
                && button4.Text == "13" && button13.Text == "14" && button14.Text == "15" && button16.Text == "16")
            {
                Feedback.Text = "Excellent! That was fun.";
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
                Feedback.Visible = true;
            }
        }

        /// <summary>
        /// Validates the adjacent button and swaps it if it is an empty one
        /// </summary>
        /// <param name="tabIndex"></param>
        /// <param name="adjIndex"></param>
        /// <param name="b"></param>
        private void PerformSwap(int tabIndex, int adjIndex, Button b)
        {
            if(adjIndex >= 0)
            {
           

                Button adjButton = this.Controls.OfType<Button>()
                                    .Where(btn => Convert.ToInt32(btn.Tag) == adjIndex)
                                    .FirstOrDefault();
                                    
                if(String.IsNullOrEmpty(adjButton.Text))
                {
                    Console.WriteLine(adjButton.Text);
                    adjButton.Text = b.Text;
                    b.Text = "";
                } 
            }
        }
    }
}
