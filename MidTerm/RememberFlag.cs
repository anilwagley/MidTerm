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
    public partial class RememberFlag : Form
    {
        // Determine the class variables and objects
        private List<int> imagePositions = new List<int>();
        private List<int> imagePositionsSetOne = new List<int>();
        private List<int> imagePositionsSetTwo = new List<int>();
        private Random random = new Random();
        private List<int> immediatePosition = new List<int>();
        private int counter = 30; // (seconds)
        private Timer timer = null;

        public RememberFlag()
        {
            // Initialize the component
            InitializeComponent();

            // Let the label size for question text be bigger
            label1.MaximumSize = new Size(280, 100);
            label1.AutoSize = true;
            label1.Text = "Click on mask-images to reveal the flag inside. At one time, two images can be revealed. Click to pair up to the another un-revealed flag. Finish that within the given time to win the game.";

            // Instantiate a new Timer
            timer = new Timer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the hidden images
            GetImagesHidden();

            // Assign image positions
            setImagePositions();
        }

        private void setImagePositions()
        {
            // Break down the image positions into two parts
            imagePositionsSetOne = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            imagePositionsSetTwo = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

            // Determine the immediate positions
            immediatePosition = new List<int> { 0, 0, 0 };

            // If the timer has been created, stop the timer
            if (timer!=null)
            {
                timer.Stop();
            }

            // Shuffle both image positions to spead those pairs in random positions
            ShuffleMe(imagePositionsSetOne);
            ShuffleMe(imagePositionsSetTwo);

            // Merge both sets and shuffle again
            imagePositions = ShuffleMe(imagePositionsSetOne.Concat(imagePositionsSetTwo).ToList());
        }

        void GetImagesHidden()
        {
            // Iterate through all the controls
            foreach (Control i in this.Controls)
            {
                // Make sure it's a picture-box
                if (i is PictureBox)
                {
                    // Make it visible
                    (i as PictureBox).Show();

                    // Assign mask image
                    (i as PictureBox).Image = Image.FromFile("0.png");
                }
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            // Restart the application
            Application.Restart();

            // Prevent it from being closed
            Environment.Exit(0);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            // If the picture is revealed, do nothing
            if ((sender as PictureBox).ImageLocation != null && (sender as PictureBox).ImageLocation != "0.png")
            {
                return;
            }

            // If user clicks on the first image-box, start the countdown
            if (immediatePosition[0] == 0 && winorloss.Text == "")
            {
                Countdown();
            }

            // Find the name of the clicked picture-box
            var nameOnly = (sender as PictureBox).Name.ToString();

            // Find the length of the name
            var length = nameOnly.Length;

            // Find the position of the clicked picture-box
            var imagePosition = Convert.ToInt32(nameOnly.Substring(10, length - 10));

            // Set the immediate position
            setImmediatePosition(imagePosition);

            // Make sure if the images are matched, if so, remove that pair
            if (immediatePosition[0] != 0 && immediatePosition[1] != 0 && imagePositions[immediatePosition[0] - 1] == imagePositions[immediatePosition[1] - 1])
            {
                (sender as PictureBox).ImageLocation = imagePositions[imagePosition - 1] + ".png";                
                MatchBox();
            }
            else
            {

                // Make sure that bottom immediate picture-box position is already set
                if (immediatePosition[2] != 0)
                {   
                    // Hide that picture-box
                    HideBox();
                }

                // Reveal the image
                (sender as PictureBox).ImageLocation = imagePositions[imagePosition - 1] + ".png";
            }
        }

        private void MatchBox()
        {
            // Determine the pair boxes
            var boxToHide1 = this.Controls.Find("pictureBox" + (immediatePosition[0]), false);
            var boxToHide2 = this.Controls.Find("pictureBox" + (immediatePosition[1]), false);
            
            // If they are still visible,
            if (boxToHide1.Length > 0 && boxToHide2.Length > 0)
            {
                // Hide both boxes
                boxToHide1.First().Hide();
                boxToHide2.First().Hide();

                // Update the immediate positions
                immediatePosition[0] = immediatePosition[2];
                immediatePosition[1] = 0;
                immediatePosition[2] = 0;
            }

            // If there are no remaining picture-boxes to reveal
            if (Remaining()==false)
            {
                // Display the message
                DisplayMessage();
            }
        }

        private void HideBox()
        {
            // Determine the name of the picture-box
            var pictureBoxName = "pictureBox" + immediatePosition[2];

            // Make sure the box exists
            if (this.Controls.Find(pictureBoxName, false).Length > 0)
            {
                // Determine the box
                var theImageBox = this.Controls.Find(pictureBoxName, true).First();

                // Make sure that it's a picture-box
                if (theImageBox is PictureBox)
                {
                    // Assign the mask image to it
                    (theImageBox as PictureBox).ImageLocation = "0.png";
                }
            }
        }

        List<int> ShuffleMe(List<int> list)
        {
            // Iterate through the list
            for (int i = list.Count - 1; i > 1; i--)
            {
                // Determine a random number
                int rnd = random.Next(i + 1);

                // Determine the value and assign to the list
                int value = list[rnd];
                list[rnd] = list[i];
                list[i] = value;
            }

            // Return the shuffled list
            return list;
        }

        private void setImmediatePosition(int position)
        {
            // Mae sure the position is not set already
            if (position != immediatePosition[1])
            {
                // Update the positions
                immediatePosition[2] = immediatePosition[1];
                immediatePosition[1] = immediatePosition[0];
                immediatePosition[0] = position;
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
            displaycounter.Text = counter.ToString();
        }

        private void DisplayTimer(object sender, EventArgs e)
        {
            // Decrease the counter
            counter--;

            // Display the counter value on the label 
            displaycounter.Text = counter.ToString();

            // Check if the counter has reached to zero (0)
            if (counter == 0)
            {
                // Stop the timer
                timer.Stop();

                // Display the message
                DisplayMessage();
            }
        }

        private void DisplayMessage()
        {
            // Make sure that the label is empty
            if (winorloss.Text == "")
            {
                // If there are some remaining picture-boxes, display lost message
                if (Remaining())
                {
                    winorloss.Text = "You Lost!";
                    winorloss.ForeColor = Color.Red;
                }

                // Otherwise, display win message
                else
                {
                    winorloss.Text = "You Won!";
                    winorloss.ForeColor = Color.Green;
                }
            }
        }

        private bool Remaining()
        {
            // Initialize the variable as false
            bool isRemaining = false;

            // Iterate through each controls
            foreach (Control i in this.Controls)
            {
                // Make sure that the control is picture-box
                if (i is PictureBox)
                {
                    // Check if there are any picture-boxes remaining
                    if ((i as PictureBox).ImageLocation == "0.png" || (i as PictureBox).ImageLocation == null)
                    {
                        // If so, update the remaining as true
                        isRemaining = true;
                    }
                }
            }

            // Return the remaing
            return isRemaining;
        }
    }

}