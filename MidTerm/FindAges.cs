using System.Windows.Forms;

namespace MidTerm
{
    public partial class FindAges : Form
    {
        public FindAges()
        {
            InitializeComponent();
            Feedback.Visible = false;
        }

        private void FindOut_Click(object sender, System.EventArgs e)
        {
            int youngerOneAge;
            int elderOneAge;

            if (int.TryParse(youngerKidAge.Text, out youngerOneAge) && int.TryParse(elderKidAge.Text, out elderOneAge))
            {
                if(youngerOneAge == 2 && elderOneAge == 9)
                {
                    Feedback.Text = "That's correct answer. You're awesome";
                    Feedback.ForeColor = System.Drawing.Color.DarkGreen;
                } else
                {
                    Feedback.Text = "Oops! That's incorrect. Try again";
                    Feedback.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                Feedback.Text = "Enter valid values in the ages fields";
                Feedback.ForeColor = System.Drawing.Color.Orange;
            }
            Feedback.Visible = true;
        }
    }
}
