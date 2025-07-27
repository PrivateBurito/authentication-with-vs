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
            label2 = new Label();
            UserInfoPanel = new Panel();
            WelcomePanel = new Label();
            LogoutButton = new Button();
            label1 = new Label();
            BirthdayLabel = new Label();
            UserLabel = new Label();
            FullnameLabel = new Label();
            gradientPanel1.SuspendLayout();
            UserInfoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 225F;
            gradientPanel1.BackColor = Color.White;
            gradientPanel1.BottomColor = Color.FromArgb(237, 50, 240);
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(UserInfoPanel);
            gradientPanel1.Location = new Point(-1, -5);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(806, 457);
            gradientPanel1.TabIndex = 0;
            gradientPanel1.TopColor = Color.FromArgb(2, 80, 247);
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
            // UserInfoPanel
            // 
            UserInfoPanel.Controls.Add(WelcomePanel);
            UserInfoPanel.Controls.Add(LogoutButton);
            UserInfoPanel.Controls.Add(label1);
            UserInfoPanel.Controls.Add(BirthdayLabel);
            UserInfoPanel.Controls.Add(UserLabel);
            UserInfoPanel.Controls.Add(FullnameLabel);
            UserInfoPanel.Location = new Point(13, 17);
            UserInfoPanel.Name = "UserInfoPanel";
            UserInfoPanel.Size = new Size(265, 275);
            UserInfoPanel.TabIndex = 5;
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.DarkGray;
            WelcomePanel.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomePanel.Location = new Point(18, 16);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(229, 21);
            WelcomePanel.TabIndex = 24;
            WelcomePanel.Text = "WELCOME";
            WelcomePanel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.Firebrick;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogoutButton.ForeColor = SystemColors.Control;
            LogoutButton.Location = new Point(172, 238);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 23);
            LogoutButton.TabIndex = 23;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = false;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 137);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 5;
            label1.Text = "Account Created:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.BackColor = Color.DarkGray;
            BirthdayLabel.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BirthdayLabel.Location = new Point(18, 158);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(229, 21);
            BirthdayLabel.TabIndex = 4;
            BirthdayLabel.Text = "Birthday";
            BirthdayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UserLabel
            // 
            UserLabel.BackColor = Color.DarkGray;
            UserLabel.Font = new Font("Trebuchet MS", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserLabel.Location = new Point(18, 37);
            UserLabel.Name = "UserLabel";
            UserLabel.Size = new Size(229, 37);
            UserLabel.TabIndex = 1;
            UserLabel.Text = "Username";
            UserLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FullnameLabel
            // 
            FullnameLabel.BackColor = Color.DarkGray;
            FullnameLabel.Font = new Font("Trebuchet MS", 10F);
            FullnameLabel.Location = new Point(18, 74);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(229, 18);
            FullnameLabel.TabIndex = 2;
            FullnameLabel.Text = "Fullname";
            FullnameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gradientPanel1);
            Name = "Form3";
            ShowInTaskbar = false;
            Text = "Form3";
            Load += Form3_Load;
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            UserInfoPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GradientPanel gradientPanel1;
        private Label UserLabel;
        private Label label2;
        private Label FullnameLabel;
        private Label BirthdayLabel;
        private Panel UserInfoPanel;
        private Label label1;
        private Button LogoutButton;
        private Label WelcomePanel;
    }
}