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
    public partial class OpenLockers : Form
    {
        public OpenLockers()
        {
            InitializeComponent();
            Feedback.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choicesCorrect = Convert.ToInt32(checkBox1.Checked) + 
                        Convert.ToInt32(checkBox2.Checked) + 
                        Convert.ToInt32(!checkBox3.Checked) +
                        Convert.ToInt32(checkBox4.Checked);

            double score = choicesCorrect * 2.5;
            if(choicesCorrect == 4)
            {
                Feedback.Text = "Congratulations! You got all of them correct. \n Your score is 10.";
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
            } else if(choicesCorrect == 0)
            {
                Feedback.Text = "You got none of them correct. Your score is 0";
                Feedback.ForeColor = System.Drawing.Color.Red;
            } else
            {
                Feedback.Text = "You got few of them correct. Your score is " + score;
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;

            }
            Feedback.Visible = true;
        }

    }
}
