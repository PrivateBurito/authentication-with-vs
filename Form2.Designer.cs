namespace LoginForm
{
    partial class RegisterForm
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
            LastNameIn = new TextBox();
            FirstNameIn = new TextBox();
            MiddleNameIn = new TextBox();
            UsernameIn = new TextBox();
            PhoneIn = new TextBox();
            EmailIn = new TextBox();
            PasswordIn = new TextBox();
            BirthdayIn = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            RegisterButton = new Button();
            label10 = new Label();
            BackButton = new Button();
            gradientPanel1 = new GradientPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // LastNameIn
            // 
            LastNameIn.Location = new Point(123, 17);
            LastNameIn.Name = "LastNameIn";
            LastNameIn.Size = new Size(221, 21);
            LastNameIn.TabIndex = 0;
            // 
            // FirstNameIn
            // 
            FirstNameIn.Location = new Point(123, 46);
            FirstNameIn.Name = "FirstNameIn";
            FirstNameIn.Size = new Size(221, 21);
            FirstNameIn.TabIndex = 1;
            // 
            // MiddleNameIn
            // 
            MiddleNameIn.Location = new Point(123, 75);
            MiddleNameIn.Name = "MiddleNameIn";
            MiddleNameIn.Size = new Size(221, 21);
            MiddleNameIn.TabIndex = 2;
            // 
            // UsernameIn
            // 
            UsernameIn.Location = new Point(125, 17);
            UsernameIn.Name = "UsernameIn";
            UsernameIn.Size = new Size(221, 21);
            UsernameIn.TabIndex = 3;
            UsernameIn.TextChanged += textBox4_TextChanged;
            // 
            // PhoneIn
            // 
            PhoneIn.Location = new Point(123, 22);
            PhoneIn.Name = "PhoneIn";
            PhoneIn.Size = new Size(221, 21);
            PhoneIn.TabIndex = 4;
            // 
            // EmailIn
            // 
            EmailIn.Location = new Point(123, 51);
            EmailIn.Name = "EmailIn";
            EmailIn.Size = new Size(221, 21);
            EmailIn.TabIndex = 5;
            // 
            // PasswordIn
            // 
            PasswordIn.Location = new Point(125, 46);
            PasswordIn.Name = "PasswordIn";
            PasswordIn.Size = new Size(221, 21);
            PasswordIn.TabIndex = 6;
            // 
            // BirthdayIn
            // 
            BirthdayIn.Location = new Point(123, 104);
            BirthdayIn.Name = "BirthdayIn";
            BirthdayIn.Size = new Size(221, 21);
            BirthdayIn.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 8;
            label1.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 48);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 9;
            label2.Text = "First name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(104, 21);
            label3.TabIndex = 10;
            label3.Text = "Middle name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(71, 21);
            label4.TabIndex = 11;
            label4.Text = "Birthday:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 20);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 12;
            label5.Text = "Phone number:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 53);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 13;
            label6.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 17);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 19);
            label8.Name = "label8";
            label8.Size = new Size(84, 21);
            label8.TabIndex = 15;
            label8.Text = "Username:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 48);
            label9.Name = "label9";
            label9.Size = new Size(79, 21);
            label9.TabIndex = 16;
            label9.Text = "Password:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(LastNameIn);
            groupBox1.Controls.Add(FirstNameIn);
            groupBox1.Controls.Add(MiddleNameIn);
            groupBox1.Controls.Add(BirthdayIn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(353, 137);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PhoneIn);
            groupBox2.Controls.Add(EmailIn);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(24, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(353, 85);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Contact Information";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(UsernameIn);
            groupBox3.Controls.Add(PasswordIn);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label7);
            groupBox3.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(24, 301);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(353, 85);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Account Information";
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.MediumTurquoise;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterButton.ForeColor = SystemColors.Control;
            RegisterButton.Location = new Point(306, 392);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 20;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(24, 9);
            label10.Name = "label10";
            label10.Size = new Size(102, 32);
            label10.TabIndex = 21;
            label10.Text = "Register";
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.MediumTurquoise;
            BackButton.FlatAppearance.BorderSize = 0;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Trebuchet MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackButton.ForeColor = SystemColors.Control;
            BackButton.Location = new Point(24, 392);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(75, 23);
            BackButton.TabIndex = 22;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 30F;
            gradientPanel1.BackColor = Color.White;
            gradientPanel1.BottomColor = Color.FromArgb(128, 255, 128);
            gradientPanel1.Location = new Point(-5, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(408, 432);
            gradientPanel1.TabIndex = 23;
            gradientPanel1.TopColor = Color.FromArgb(128, 255, 255);
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(401, 428);
            Controls.Add(BackButton);
            Controls.Add(label10);
            Controls.Add(RegisterButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(gradientPanel1);
            Name = "RegisterForm";
            Text = "Form2";
            Load += RegisterForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LastNameIn;
        private TextBox FirstNameIn;
        private TextBox MiddleNameIn;
        private TextBox UsernameIn;
        private TextBox PhoneIn;
        private TextBox EmailIn;
        private TextBox PasswordIn;
        private DateTimePicker BirthdayIn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button RegisterButton;
        private Label label10;
        private Button BackButton;
        private GradientPanel gradientPanel1;
    }
}