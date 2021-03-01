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
            if (Option1.Checked)
            {
                Feedback.Text = "Congrats! That's the correct answer";
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                Feedback.Text = "That's an incorrect answer. Try again.";
                Feedback.ForeColor = System.Drawing.Color.Red;
            }
            Feedback.Visible = true;
        }
    }
}
