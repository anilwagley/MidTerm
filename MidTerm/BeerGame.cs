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
    public partial class BeerGame : Form
    {
        // Determine the class level variables
        private Color BeerColor = Color.SandyBrown;
        private Color EmptyColor = Color.Transparent;
        private List<int> current = new List<int> { 0, 0 };

        public BeerGame()
        {
            // Initialize the component
            InitializeComponent();

            // Let the label size for question text be bigger
            label2.MaximumSize = new Size(400, 100);
            label2.AutoSize = true;
            label2.Text = "A bartender has a three-pint glass and a five-pint glass. A customer walks in and orders four pints of beer. Without a measuring cup but with an unlimited supply of beer how does he get a single pint in either glass?";
        }

        private void fillThree_Click(object sender, EventArgs e)
        {
            // Change the color of the container
            threePint.BackColor = BeerColor;

            // Assign the current amount
            current[0] = GetNumericPint("three");

            // Check if the goal has achieved
            HasWon();
        }

        private void fillFive_Click(object sender, EventArgs e)
        {
            // Change the color of the container
            fivePint.BackColor = BeerColor;

            // Assign the current amount
            current[1] = GetNumericPint("five");

            // Check if the goal has achieved
            HasWon();
        }

        private void emptyThree_Click(object sender, EventArgs e)
        {
            // Remove the color of the container
            threePint.BackColor = EmptyColor;

            // Assign the current amount
            current[0] = 0;

            // Check if the container is filled with any amount
            if (this.Controls.Find("innerThree", true).Length > 0)
            {
                // Determine the layers (filled) element
                var element = this.Controls.Find("innerThree", true).First();

                // Remove the color
                element.BackColor = EmptyColor;

                // Send that to back
                element.SendToBack();
            }

            // Check if the goal has achieved
            HasWon();
        }

        private void emptyFive_Click(object sender, EventArgs e)
        {
            // Remove the color of the container
            fivePint.BackColor = EmptyColor;

            // Assign the current amount
            current[1] = 0;

            // Check if the container is filled with any amount
            if (this.Controls.Find("innerFive", true).Length > 0)
            {
                // Determine the layers (filled) element
                var element = this.Controls.Find("innerFive", true).First();

                // Remove the color
                element.BackColor = EmptyColor;

                // Send that to back
                element.SendToBack();
            }

            // Check if the goal has achieved
            HasWon();
        }

        private void pourToFive_Click(object sender, EventArgs e)
        {
            // Check the capacity of target
            int targetCapacity = GetNumericPint("five") - current[1];

            // If the origin container is empty, trigger an error message
            if (current[0] == 0)
            {
                MessageBox.Show("Three is empty. Fill that before pouring.");
            }

            // If the target container is full, trigger an error message
            if (targetCapacity <= 0)
            {
                MessageBox.Show("Five is full. Empty that before pouring.");
                
            }

            // If target capacity is smaller that origin, assign amounts on containers
            else if (targetCapacity < GetNumericPint("three"))
            {
                current[1] = GetNumericPint("five");
                current[0] = current[0] - targetCapacity;
            }

            // Otherwise, assign amounts on containers
            else
            {
                current[1] = current[0] + current[1];
                current[0] = (current[0] - targetCapacity) < 0 
                    ? 0 
                    : (current[0] - targetCapacity);
            }

            // Update the amounts with visual representation on both containers
            PourBeer(GetNumericPint("three"));
            PourBeer(GetNumericPint("five"));

            // Check if the goal has achieved
            HasWon();
        }

        private void pourToThree_Click(object sender, EventArgs e)
        {
            // Check the capacity of target
            int targetCapacity = GetNumericPint("three") - current[0];

            // If the origin container is empty, trigger an error message
            if (current[1] == 0)
            {
                MessageBox.Show("Five is empty. Fill that before pouring.");
            }

            // If the target container is full, trigger an error message
            if (targetCapacity <= 0)
            {
                MessageBox.Show("Three is full. Empty that before pouring.");
            }

            // If target capacity is bigger that origin, assign amounts on containers
            else if (targetCapacity >= current[1])
            {
                current[0] = current[1] + current[0];
                current[1] = 0;
            } else
            {
                current[0] = targetCapacity + current[0];
                current[1] = current[1] - targetCapacity;
            }

            // Update the amounts with visual representation on both containers
            PourBeer(GetNumericPint("three"));
            PourBeer(GetNumericPint("five"));

            // Check if the goal has achieved
            HasWon();
        }

        private int GetNumericPint(string pint)
        {
            return pint == "three" ? 3 : 5;
        }

        private void PourBeer(int target)
        {
            // Check if the container is 3
            if (target == GetNumericPint("three"))
            {
                // Check if it has the hidden container that visually shows it has amunt in it
                if (this.Controls.Find("innerThree", true).Length > 0)
                {
                    // If found, remove that
                    this.Controls.Find("innerThree", true).First().Dispose();
                }

                // Remove the color of the container
                threePint.BackColor = EmptyColor;

                // Create a new panel and assign some properties to it
                Panel panel = new Panel();
                panel.Name = "innerThree";
                panel.Size = new System.Drawing.Size(70, current[0] * 50);
                panel.Location = new Point(79, 131+((GetNumericPint("three") - current[0]) * 50));
                panel.BackColor = BeerColor;

                // Add the panel to the form
                this.Controls.Add(panel);

                // If the panel has been successfully added, bring that to front
                if (this.Controls.Find("innerThree", true).Length > 0)
                {
                    this.Controls.Find("innerThree", true).First().BringToFront();
                }
            }

            // Check if the container is 5
            if (target == GetNumericPint("five"))
            {
                // Check if it has the hidden container that visually shows it has amunt in it
                if (this.Controls.Find("innerFive", true).Length > 0)
                {
                    this.Controls.Find("innerFive", true).First().Dispose();
                }

                // If found, remove that
                fivePint.BackColor = EmptyColor;

                // Remove the color of the container
                Panel panel = new Panel();
                panel.Name = "innerFive";
                panel.Size = new System.Drawing.Size(70, current[1] * 50);
                panel.Location = new Point(218, 31+((GetNumericPint("five") - current[1])*50));
                panel.BackColor = BeerColor;

                // Add the panel to the form
                this.Controls.Add(panel);

                // If the panel has been successfully added, bring that to front
                if (this.Controls.Find("innerFive", true).Length > 0)
                {
                    this.Controls.Find("innerFive", true).First().BringToFront();
                }
            }

            // Check if the goal has achieved
            HasWon();
        }

        private void HasWon()
        {
            // If container 5 has amount 4, then call it success
            if (current[1] == 4)
            {
                label1.Text = "Congratulations !";
            } else
            {
                label1.Text = "Three-Pint: " + current[0] + ", Five-Pint: " + current[1];
            }
        }
    }
}
