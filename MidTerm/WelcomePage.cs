﻿using System;
using System.Windows.Forms;

namespace MidTerm
{
    public partial class WelcomePage : Form
    {
        public WelcomePage()
        {
            InitializeComponent();
        }


        private void Level1_Click(object sender, EventArgs e)
        {
            //Level2Panel.Visible = false;
            //Level3Panel.Visible = false;
            welcomepanel.Visible = false;
            Level1Panel.Visible = true;
            Level1Panel.BringToFront();
        }

    

        private void Back_Click(object sender, EventArgs e)
        {
            Level1Panel.Visible = false;
            Level2Panel.Visible = false;
            Level3Panel.Visible = false;
            welcomepanel.Visible = true;
        }

        private void WelcomePage_Load(object sender, EventArgs e)
        {
            Level1Panel.Visible = false;
            Level2Panel.Visible = false;
            Level3Panel.Visible = false;
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            welcomepanel.Visible = false;
            Level2Panel.Visible = true;
            Level2Panel.BringToFront();

        }

        private void Level3Btn_Click(object sender, EventArgs e)
        {
            welcomepanel.Visible = false;
            Level3Panel.Visible = true;
            Level3Panel.BringToFront();

        }

        private void MagicSquareBtn_Click(object sender, EventArgs e)
        {
            Form magicSquareGame = new MagicSquare();
            magicSquareGame.Show();
        }

        private void FindAgesBtn_Click(object sender, EventArgs e)
        {
            Form findAges = new FindAges();
            findAges.Show();
        }

        private void OpenLockersBtn_Click(object sender, EventArgs e)
        {
            Form openLockers = new OpenLockers();
            openLockers.Show();
        }

        private void BeerGameBtn_Click(object sender, EventArgs e)
        {
            Form BeerGame = new BeerGame();
            BeerGame.Show();
        }

        private void BucketGameBtn_Click(object sender, EventArgs e)
        {
            Form BucketGame = new BucketGame();
            BucketGame.Show();
        }

        private void RememberFlagBtn_Click(object sender, EventArgs e)
        {
            Form RememberFlag = new RememberFlag();
            RememberFlag.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form Hangman = new HangMan();
            Hangman.Show();
        }

        private void FormOrder_Click(object sender, EventArgs e)
        {
            Form formOrder = new FormOrder();
            formOrder.Show();
        }
    }
}
