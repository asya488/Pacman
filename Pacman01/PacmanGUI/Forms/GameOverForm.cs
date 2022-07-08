﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeBase.GameProcess;

namespace PacmanGUI
{
    public partial class GameOverForm : Form
    {
        public GameOverForm(Game game)
        {
            this.Size = new Size(800, 870);
            InitializeComponent();
            LanguageChanger.GameOver(this, game.Language);
            generalScoreLabel.Text += game.GeneralScore.ToString();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameOverForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
