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
    public partial class HangMan : Form
    {
        // Determine the class level variables
        List<string> States = new List<string> { "Mississippi", "Connecticut", "Louisiana", "Minnesota", "California", "Washington", "Arkansas", "Colorado", "Delaware", "Illinois", "Kentucky", "Maryland", "Michigan", "Missouri", "Nebraska", "Pennsylvania", "Oklahoma", "Virginia" };
        List<char> Alphabets = new List<char>();
        List<char> StateAlpha = new List<char>();
        int totalMistakes = 0;
        int boxSize = 40;
        string selectedState = "";
        int score = 0;

        public HangMan()
        {
            // Initialize the component
            InitializeComponent();
        }

        private void SetAlphabets()
        {
            // Determine the alhabets as a character array
            char[] alpha = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();

            // Shuffe the list
            Alphabets = ShuffleMe(new List<char>(alpha));

            // Instantiate the random object
            Random random = new Random();

            // Select a state randomly
            selectedState = States[random.Next(States.Count)].ToUpper();

            // Break down the state-name into a character array
            StateAlpha = new List<char>(selectedState.ToArray());  
            
            // Determine the positions
            int positionX = 300;
            int positionY = 230;

            // Create an array of labels
            Label[] labels = new Label[Alphabets.Count];

            // Determine j to break the line
            int j = 0;

            // Iterate through the alphabets
            for (int i = 0; i < Alphabets.Count; i++)
            {
                // After 10 alphabets, list them one line below
                if (i == 10)
                {
                    j = 10;
                    positionY = positionY + boxSize;
                }

                // After 20 alphabets, list them two lines below
                if (i == 20)
                {
                    j = 20;
                    positionY = positionY + boxSize;
                }

                // After 30 alphabets, list them three line below
                if (i == 30)
                {
                    j = 30;
                    positionY = positionY + boxSize;
                }

                // Create a new label and assign attributes
                labels[i] = new Label();
                labels[i].Text = Alphabets[i].ToString();
                labels[i].ForeColor = Color.Black;
                labels[i].BorderStyle = BorderStyle.FixedSingle;
                labels[i].Font = new Font("Arial", 15,FontStyle.Bold);
                labels[i].Size = new System.Drawing.Size(boxSize - 2, boxSize - 2);
                labels[i].Location = new Point(positionX+(boxSize * (i-j)), positionY);
                labels[i].Name = "alpha"+i;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].Cursor = Cursors.Hand;
                labels[i].Click += Alphabet_ClickedEvent;
            }

            // Iterate through all alphabets and add the labels for them
            for (int i = 0; i < Alphabets.Count; i++)
            {
                this.Controls.Add(labels[i]);
            }
        }

        private void SetStateAplphabets()
        {
            // Create an array of labels
            Label[] labels = new Label[StateAlpha.Count];

            // Assign the positions
            int positionX = 300;
            int positionY = 100;

            // Iterate through each state name alphabets
            for (int i = 0; i < StateAlpha.Count; i++)
            {
                // Create a new label and assign attributes to them
                labels[i] = new Label();
                labels[i].Text = "_";
                labels[i].ForeColor = Color.Black;
                labels[i].BorderStyle = BorderStyle.FixedSingle;
                labels[i].Font = new Font("Arial", 15, FontStyle.Bold);
                labels[i].Size = new System.Drawing.Size(boxSize - 2, boxSize - 2);
                labels[i].Location = new Point(positionX + (boxSize*i), positionY);
                labels[i].Name = "stateAlpha" + i;
                labels[i].TextAlign = ContentAlignment.MiddleCenter;
                labels[i].Click += Alphabet_ClickedEvent;
            }

            // Iterate through state name alphabets and add the labels for each
            for (int i = 0; i < StateAlpha.Count; i++)
            {
                this.Controls.Add(labels[i]);
            }
            
        }

        private bool HasWon()
        {
            // Determine if the user selected all alphabets correctly
            int remainingAlphabets = 0;

            // Iterate through all controls
            foreach (Control i in this.Controls)
            {
                // Make sure it's a label
                if (i is Label)
                {
                    // Make sure that the label is the state alphabet label
                    if ((i as Label).Name.ToString().Contains("stateAlpha"))
                    {
                        remainingAlphabets++;
                    }
                }
            }

            // Calculate the score
            score = remainingAlphabets > 0 ? 
                (int)(((((StateAlpha.Count - remainingAlphabets)*100) / StateAlpha.Count)*15)/100) : 
                15;

            // Return the final result
            return remainingAlphabets > 0 ? false : true;
        }

        private void Alphabet_ClickedEvent(object sender, EventArgs e)
        {
            // Check if total mistakes is 8 (complete hang); if so terminate here
            if (totalMistakes >= 8 || HasWon())
            {
                return;
            }

            // Find the clicked character
            char clickedChar = (sender as Label).Text.ToCharArray()[0];

            // Make sure the clicked character in included in the current state characters
            if (StateAlpha.Contains(clickedChar))
            {
                // Find the character
                char position = StateAlpha.Where(i => i == clickedChar).First();

                // Find the index
                int indexPosition = StateAlpha.FindIndex(i => i == clickedChar);

                // Iterate through all the controls
                foreach (Control i in this.Controls)
                {
                    // Make sure it's a label
                    if (i is Label)
                    {
                        // Make sure that the label is the state alphabet label
                        if ((i as Label).Name.ToString() == "stateAlpha" + indexPosition)
                        {
                            // Make sure that the label name is valid
                            if ((i as Label).Name.ToString().Contains("stateAlpha")) {

                                // Change the character in the box
                                (i as Label).Text = clickedChar.ToString();

                                // Rename it to something different to avoid selecting next time
                                (i as Label).Name = "taken" + i;

                                // Replace that character with dash sign to exclude next time
                                StateAlpha[indexPosition] = "-".ToCharArray()[0];

                                // Check if already won
                                if (HasWon())
                                {
                                    Hang(true);
                                }

                                // Terminate right here
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                // Increment the total mistakes
                totalMistakes = totalMistakes + 1;

                // Check if it's already hung
                Hang();
            }
        }

        private void Hang(bool win = false)
        {
            // Make sure the mistakes are already 8 OR has already won
            if (totalMistakes >= 8 || win == true)
            {
                // It's hung so lets reveal the answer
                Label label = new Label();
                label.ForeColor = Color.Black;
                label.Font = new Font("Arial", 15, FontStyle.Bold);
                label.Location = new Point(340, 150);
                label.Name = "answer";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.AutoSize = true;

                if (win == true)
                {
                    label.Text = "Congratulations !\n Score: " + score + "/15";

                    // Add the label
                    this.Controls.Add(label);

                    // Show the game restart button
                    button1.Show();

                    return;
                } else
                {
                    label.Text = "Answer: " + selectedState.ToString() + "\n Score: " + score + "/15";

                    // Add the label
                    this.Controls.Add(label);

                    // Show the game restart button
                    button1.Show();
                }
            }

            // Otherwise, increase the higher steps of hangman 
            pictureBox1.ImageLocation = "hm_" + totalMistakes + ".png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void HangMan_Load(object sender, EventArgs e)
        {
            // Hide the restart game button at the beginning
            button1.Hide();

            // Lay out the all alphabets
            SetAlphabets();

            // Lay out the state alphabets
            SetStateAplphabets();
        }

        List<char> ShuffleMe(List<char> list)
        {
            // Create a random object
            Random random = new Random();

            // Iterate through the list
            for (int i = list.Count - 1; i > 1; i--)
            {
                // Determine a random number
                int rnd = random.Next(i + 1);

                // Determine the value and assign to the list
                char value = list[rnd];
                list[rnd] = list[i];
                list[i] = value;
            }

            // Return the shuffled list
            return list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Restart the application
            Application.Restart();

            // Prevent it from being closed
            Environment.Exit(0);
        }
    }
}