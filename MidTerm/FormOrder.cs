using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class FormOrder : Form
    {

        private int counter = 180; // (seconds)
        private Timer timer = null;
        bool firstTimeClick = true;
        public FormOrder()
        {
            InitializeComponent();
            size = 4;
            Feedback.Visible = false;
            scoreDisplay.Visible = false;
            counterDisplay.Visible = false;
            // Instantiate a new Timer
            timer = new Timer();
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

            if(firstTimeClick)
            {
                firstTimeClick = false;
                counterDisplay.Visible = true;
                Countdown();
            }

            PerformSwap(tabIndex, rightIndex,b);
            PerformSwap(tabIndex, leftIndex, b);
            PerformSwap(tabIndex, upIndex, b);
            PerformSwap(tabIndex, downIndex, b);
            ValidateWin();
        }

        private void DisplayTimer(object sender, EventArgs e)
        {
            // Decrease the counter
            counter--;

            // Display the counter value on the label 
            counterDisplay.Text = counter.ToString();

            // Check if the counter has reached to zero (0)
            if (counter == 0)
            {
                // Stop the timer
                timer.Stop();

                Feedback.Visible = true;
                scoreDisplay.Text = "Score: 0";
                scoreDisplay.Visible = true;
            }
        }

        void Countdown()
        {
            // Increament the tick
            timer.Tick += new EventHandler(DisplayTimer);

            // Determine the interval
            timer.Interval = 1000;

            // Start the counter
            timer.Start();

            // Display the counter value on the label
            counterDisplay.Text = counter.ToString();
        }   

       

        private void ValidateWin()
        {
            if(button1.Text == "1" && button5.Text == "2" && button8.Text == "3" && button11.Text == "4"
                && button2.Text == "5" && button6.Text == "6" && button9.Text == "7" && button12.Text == "8"
                && button3.Text == "9" && button7.Text == "10" && button10.Text =="11" && button15.Text == "12"
                && button4.Text == "13" && button13.Text == "14" && button14.Text == "15" && button16.Text == "16")
            {
                int score = counter < 140 ? (counter/140.0)*10  : 10;
                Feedback.Text = "Excellent! That was fun.";
                scoreDisplay.Text = "Score: " + score;
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
                Feedback.Visible = true;
                scoreDisplay.Visible = true;

                timer.Stop();
                counterDisplay.Visible = false;
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
