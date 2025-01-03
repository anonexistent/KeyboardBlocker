﻿namespace KeyboardBlocker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxKeyboard = new TextBox();
            buttonActions = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBoxBlock = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlock).BeginInit();
            SuspendLayout();
            // 
            // textBoxKeyboard
            // 
            textBoxKeyboard.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(textBoxKeyboard, 3);
            textBoxKeyboard.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKeyboard.Location = new Point(15, 25);
            textBoxKeyboard.Margin = new Padding(15);
            textBoxKeyboard.Name = "textBoxKeyboard";
            textBoxKeyboard.ReadOnly = true;
            textBoxKeyboard.Size = new Size(410, 36);
            textBoxKeyboard.TabIndex = 1;
            // 
            // buttonActions
            // 
            buttonActions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonActions.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(buttonActions, 3);
            buttonActions.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonActions.Location = new Point(25, 199);
            buttonActions.Margin = new Padding(25);
            buttonActions.Name = "buttonActions";
            buttonActions.Size = new Size(390, 37);
            buttonActions.TabIndex = 0;
            buttonActions.Text = "Block Keys";
            buttonActions.UseVisualStyleBackColor = true;
            buttonActions.Click += buttonActions_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(textBoxKeyboard, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonActions, 0, 2);
            tableLayoutPanel1.Controls.Add(panel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(440, 261);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBoxBlock);
            panel1.Location = new Point(149, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(140, 81);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(10);
            pictureBox1.MinimumSize = new Size(140, 81);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBoxBlock
            // 
            pictureBoxBlock.Dock = DockStyle.Fill;
            pictureBoxBlock.Image = (Image)resources.GetObject("pictureBoxBlock.Image");
            pictureBoxBlock.InitialImage = (Image)resources.GetObject("pictureBoxBlock.InitialImage");
            pictureBoxBlock.Location = new Point(0, 0);
            pictureBoxBlock.Margin = new Padding(10);
            pictureBoxBlock.Name = "pictureBoxBlock";
            pictureBoxBlock.Size = new Size(140, 81);
            pictureBoxBlock.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBlock.TabIndex = 2;
            pictureBoxBlock.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 261);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(456, 300);
            Name = "Form1";
            Text = "KeyboardBlocker1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBlock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxKeyboard;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonActions;
        private PictureBox pictureBoxBlock;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
