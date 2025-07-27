namespace LoginForm
{
    partial class LoginForm
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
            usernameIn = new TextBox();
            passwordIn = new TextBox();
            label1 = new Label();
            RegisterLabel = new LinkLabel();
            LoginButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            gradientPanel1 = new GradientPanel();
            SuspendLayout();
            // 
            // usernameIn
            // 
            usernameIn.Cursor = Cursors.IBeam;
            usernameIn.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameIn.Location = new Point(32, 146);
            usernameIn.Name = "usernameIn";
            usernameIn.PlaceholderText = " Username";
            usernameIn.Size = new Size(291, 30);
            usernameIn.TabIndex = 0;
            // 
            // passwordIn
            // 
            passwordIn.Cursor = Cursors.IBeam;
            passwordIn.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordIn.Location = new Point(32, 196);
            passwordIn.Name = "passwordIn";
            passwordIn.PlaceholderText = " Password";
            passwordIn.Size = new Size(291, 30);
            passwordIn.TabIndex = 1;
            passwordIn.UseSystemPasswordChar = true;
            passwordIn.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(292, 62);
            label1.TabIndex = 2;
            label1.Text = "Welcome back! Good to see you again!";
            label1.Click += label1_Click;
            // 
            // RegisterLabel
            // 
            RegisterLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RegisterLabel.AutoSize = true;
            RegisterLabel.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterLabel.Location = new Point(145, 393);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(85, 18);
            RegisterLabel.TabIndex = 3;
            RegisterLabel.TabStop = true;
            RegisterLabel.Text = "Register Now!";
            RegisterLabel.LinkClicked += RegisterLabel_LinkClicked;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DarkGreen;
            LoginButton.FlatAppearance.BorderSize = 0;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginButton.ForeColor = SystemColors.ButtonFace;
            LoginButton.Location = new Point(117, 253);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(121, 36);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 393);
            label2.Name = "label2";
            label2.Size = new Size(136, 18);
            label2.TabIndex = 7;
            label2.Text = "Don't have an account?";
            label2.Click += label2_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 225F;
            gradientPanel1.BackColor = Color.White;
            gradientPanel1.BottomColor = Color.FromArgb(237, 50, 240);
            gradientPanel1.Location = new Point(-1, -1);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(362, 425);
            gradientPanel1.TabIndex = 8;
            gradientPanel1.TopColor = Color.FromArgb(2, 80, 247);
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(360, 420);
            Controls.Add(label2);
            Controls.Add(LoginButton);
            Controls.Add(RegisterLabel);
            Controls.Add(label1);
            Controls.Add(passwordIn);
            Controls.Add(usernameIn);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginForm";
            Text = "Login";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameIn;
        private TextBox passwordIn;
        private Label label1;
        private LinkLabel RegisterLabel;
        private Button LoginButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private GradientPanel gradientPanel1;
    }
}
