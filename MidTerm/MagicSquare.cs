﻿using System;
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
    public partial class MagicSquare : Form
    {
        Button buttonBeingDragged;
        private int counter = 300; // (seconds)
        private Timer timer = null;
        bool firstTimeClick = true;
        public MagicSquare()
        {
            InitializeComponent();
            ComputeSumOfAllLabels();
            Feedback.Visible = false;

            scoreDisplay.Visible = false;
            counterDisplay.Visible = false;
            // Instantiate a new Timer
            timer = new Timer();
        }

        /// <summary>
        /// Computes the sum of all rows, columns and diagonals on every button drag and drop
        /// </summary>
        private void ComputeSumOfAllLabels()
        {
            CalculateSumOfRow1();
            CalculateSumOfRow2();
            CalculateSumOfRow3();
            CalculateSumOfCol1();
            CalculateSumOfCol2();
            CalculateSumOfCol3();
            CalculateSumOfTopleftdiagonal();
            CalculateSumOfBottomLeftDiagonal();
            if(row1sum.Text == row2sum.Text && row1sum.Text == row3sum.Text && row1sum.Text == col1sum.Text
                && row1sum.Text == col2sum.Text && row1sum.Text == col3sum.Text && row1sum.Text == topleftdiagonal.Text
                && row1sum.Text == bottomleftdiagonal.Text)
            {
                //Display the feedback message
                Feedback.Text = "Great job! You won.";
                Feedback.ForeColor = System.Drawing.Color.DarkGreen;
                Feedback.Visible = true;

                //Display the score
                double score = (counter < 280) ? (counter / 280.0) * 15 : 15;
                scoreDisplay.Text = "Score: " + Math.Floor(score);
                scoreDisplay.Visible = true;

                //Stop the timer
                timer.Stop();
                counterDisplay.Visible = false;
            }
        }

        #region sum computation
        private void CalculateSumOfRow1()
        {
            row1sum.Text = Convert.ToString(Convert.ToInt32(row1col1.Text) + Convert.ToInt32(row1col2.Text) +
                Convert.ToInt32(row1col3.Text));
        }

        private void CalculateSumOfRow2()
        {
            row2sum.Text = Convert.ToString(Convert.ToInt32(row2col1.Text) + Convert.ToInt32(row2col2.Text) +
                Convert.ToInt32(row2col3.Text));
        }

        private void CalculateSumOfRow3()
        {
            row3sum.Text = Convert.ToString(Convert.ToInt32(row3col1.Text) + Convert.ToInt32(row3col2.Text) +
                Convert.ToInt32(row3col3.Text));
        }

        private void CalculateSumOfCol1()
        {
            col1sum.Text = Convert.ToString(Convert.ToInt32(row1col1.Text) + Convert.ToInt32(row2col1.Text) +
                Convert.ToInt32(row3col1.Text));
        }

        private void CalculateSumOfCol2()
        {
            col2sum.Text = Convert.ToString(Convert.ToInt32(row1col2.Text) + Convert.ToInt32(row2col2.Text) +
                Convert.ToInt32(row3col2.Text));
        }

        private void CalculateSumOfCol3()
        {
            col3sum.Text = Convert.ToString(Convert.ToInt32(row1col3.Text) + Convert.ToInt32(row2col3.Text) +
                Convert.ToInt32(row3col3.Text));
        }

        private void CalculateSumOfTopleftdiagonal()
        {
            topleftdiagonal.Text = Convert.ToString(Convert.ToInt32(row1col1.Text) + Convert.ToInt32(row2col2.Text) +
                Convert.ToInt32(row3col3.Text));
        }

        private void CalculateSumOfBottomLeftDiagonal()
        {
            bottomleftdiagonal.Text = Convert.ToString(Convert.ToInt32(row3col1.Text) + Convert.ToInt32(row2col2.Text) +
                Convert.ToInt32(row1col3.Text));
        }
        #endregion

        #region MouseDown Handlers
        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            buttonBeingDragged = button;
            button.DoDragDrop(button.Text, DragDropEffects.Copy);

            // Display and start the timer on first time user click on any of the buttons
            if(firstTimeClick)
            {
                firstTimeClick = false;
                counterDisplay.Visible = true;
                Countdown();
            }
        }

        #endregion

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


        #region DragEnter Handler
        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
        #endregion


        #region DragDrop Handler
        private void DragDropHandler(object sender, DragEventArgs e)
        {
            //Swaps the text of the button being dragged and button that gets dropped onto
            Button button = sender as Button;
            buttonBeingDragged.Text = button.Text;
            button.Text = e.Data.GetData(DataFormats.Text).ToString();
            ComputeSumOfAllLabels();
        }


        #endregion

      
    }
}
