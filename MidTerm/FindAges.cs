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

        /// <summary>
        /// Gets invoked on the click of the Find out button. This function checks for valid values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindOut_Click(object sender, System.EventArgs e)
        {
            int youngerOneAge;
            int elderOneAge;

            // check if the user enters integer values
            if (int.TryParse(youngerKidAge.Text, out youngerOneAge) && int.TryParse(elderKidAge.Text, out elderOneAge))
            {
                DisplayScore(youngerOneAge, elderOneAge);
            }
            else
            {
                Feedback.Text = "Enter valid values in the ages fields";
                Feedback.ForeColor = System.Drawing.Color.Orange;
            }

            //Set the visibility of the feedback message to true
            Feedback.Visible = true;
        }

        /// <summary>
        /// Function that displays scores based on the user answers
        /// </summary>
        /// <param name="elderOneAge"></param>
        /// <param name="youngerOneAge"></param>
        private void DisplayScore(int elderOneAge, int youngerOneAge)
        {
            //If both are correct, display score to be 10
            if (youngerOneAge == 2 && elderOneAge == 9)
            {
                Feedback.Text = "That's correct answer. Your score is 10/10";
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
            }
            //If only one of the answer is correct
            else if (youngerOneAge == 2 || elderOneAge == 9)
            {
                Feedback.Text = "You got one correct. Your score is 5/10.";
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
            } else
            {
                //If both the answers are wrong
                Feedback.Text = "Oops! That's incorrect. Your score is 0/10";
                Feedback.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
