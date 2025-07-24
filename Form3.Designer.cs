namespace LoginForm
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
            UserLabel = new Label();
            Fullname = new Label();
            label2 = new Label();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 0F;
            gradientPanel1.BackColor = Color.White;
            gradientPanel1.BottomColor = Color.Tomato;
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(Fullname);
            gradientPanel1.Controls.Add(UserLabel);
            gradientPanel1.Location = new Point(-1, -5);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(806, 457);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.PaleGreen;
            // 
            // UserLabel
            // 
            UserLabel.AutoSize = true;
            UserLabel.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(13, 14);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(104, 27);
            UserLabel.TabIndex = 1;
            UserLabel.Text = "Username";
            // 
            // Fullname
            // 
            Fullname.AutoSize = true;
            Fullname.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Fullname.Location = new Point(13, 54);
            Fullname.Name = "Fullname";
            Fullname.Size = new Size(95, 27);
            Fullname.TabIndex = 2;
            Fullname.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(123, 54);
            label2.Name = "label2";
            label2.Size = new Size(0, 27);
            label2.TabIndex = 3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gradientPanel1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label UserLabel;
        private Label label2;
        private Label Fullname;
    }
}