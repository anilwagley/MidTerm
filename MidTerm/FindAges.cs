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
                DisplayScore(youngerOneAge, elderOneAge);
            }
            else
            {
                Feedback.Text = "Enter valid values in the ages fields";
                Feedback.ForeColor = System.Drawing.Color.Orange;
            }
            Feedback.Visible = true;
        }

        private void DisplayScore(int elderOneAge, int youngerOneAge)
        {
            if (youngerOneAge == 2 && elderOneAge == 9)
            {
                Feedback.Text = "That's correct answer. Your score is 10/10";
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else if (youngerOneAge == 2 || elderOneAge == 9)
            {
                Feedback.Text = "You got one correct. Your score is 5/10.";
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
            } else
            {
                Feedback.Text = "Oops! That's incorrect. Your score is 0/10";
                Feedback.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
