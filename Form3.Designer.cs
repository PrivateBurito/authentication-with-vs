﻿namespace LoginForm
{
    partial class Form3
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
            gradientPanel1 = new GradientPanel();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 0F;
            gradientPanel1.BackColor = Color.LightCoral;
            gradientPanel1.BottomColor = Color.Tomato;
            gradientPanel1.Location = new Point(-1, -5);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(806, 457);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.PaleGreen;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gradientPanel1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
    }
}