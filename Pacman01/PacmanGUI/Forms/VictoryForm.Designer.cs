﻿namespace PacmanGUI
{
    partial class VictoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VictoryForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.victoryTitlePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.BackToMenuBtn = new System.Windows.Forms.Button();
            this.generalScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.victoryTitlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::PacmanGUI.Resources.victoryGif;
            this.pictureBox1.Location = new System.Drawing.Point(91, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // victoryTitlePictureBox
            // 
            this.victoryTitlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.victoryTitlePictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.victoryTitlePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.victoryTitlePictureBox.Location = new System.Drawing.Point(187, 238);
            this.victoryTitlePictureBox.Name = "victoryTitlePictureBox";
            this.victoryTitlePictureBox.Size = new System.Drawing.Size(433, 126);
            this.victoryTitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.victoryTitlePictureBox.TabIndex = 1;
            this.victoryTitlePictureBox.TabStop = false;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExitBtn.BackColor = System.Drawing.Color.Teal;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.ExitBtn.FlatAppearance.BorderSize = 3;
            this.ExitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExitBtn.Location = new System.Drawing.Point(53, 635);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(268, 62);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // BackToMenuBtn
            // 
            this.BackToMenuBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BackToMenuBtn.BackColor = System.Drawing.Color.Teal;
            this.BackToMenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMenuBtn.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.BackToMenuBtn.FlatAppearance.BorderSize = 3;
            this.BackToMenuBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackToMenuBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackToMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMenuBtn.Font = new System.Drawing.Font("Lucida Console", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BackToMenuBtn.Location = new System.Drawing.Point(419, 635);
            this.BackToMenuBtn.Name = "BackToMenuBtn";
            this.BackToMenuBtn.Size = new System.Drawing.Size(268, 62);
            this.BackToMenuBtn.TabIndex = 11;
            this.BackToMenuBtn.Text = "Back to Menu";
            this.BackToMenuBtn.UseVisualStyleBackColor = false;
            this.BackToMenuBtn.Click += new System.EventHandler(this.BackToMenuBtn_Click);
            // 
            // generalScoreLabel
            // 
            this.generalScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.generalScoreLabel.AutoSize = true;
            this.generalScoreLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generalScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.generalScoreLabel.Location = new System.Drawing.Point(40, 507);
            this.generalScoreLabel.Name = "generalScoreLabel";
            this.generalScoreLabel.Size = new System.Drawing.Size(359, 65);
            this.generalScoreLabel.TabIndex = 13;
            this.generalScoreLabel.Text = "General score: ";
            // 
            // VictoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PacmanGUI.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 831);
            this.Controls.Add(this.generalScoreLabel);
            this.Controls.Add(this.BackToMenuBtn);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.victoryTitlePictureBox);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VictoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Victory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VictoryForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.victoryTitlePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PictureBox pictureBox1;
        public PictureBox victoryTitlePictureBox;
        public Button ExitBtn;
        public Button BackToMenuBtn;
        public Label generalScoreLabel;
    }
}