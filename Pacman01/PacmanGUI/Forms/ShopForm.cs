﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGUI
{
    public partial class ShopForm : Form
    {
        public ShopForm()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(800, 850);
            BackBtn.Click += new EventHandler(BackBtn_Click);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
    }
}
