namespace Bai07
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbSignup = new Label();
            tbPassword = new TextBox();
            tbUsername = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(67, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(355, 54);
            label1.TabIndex = 0;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 227);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(226, 25);
            label4.TabIndex = 0;
            label4.Text = "Don't have an account yet?";
            // 
            // lbSignup
            // 
            lbSignup.AutoSize = true;
            lbSignup.ForeColor = SystemColors.MenuHighlight;
            lbSignup.Location = new Point(354, 227);
            lbSignup.Margin = new Padding(4, 0, 4, 0);
            lbSignup.Name = "lbSignup";
            lbSignup.Size = new Size(73, 25);
            lbSignup.TabIndex = 4;
            lbSignup.Text = "Sign up";
            lbSignup.Click += lbSignup_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(143, 155);
            tbPassword.Margin = new Padding(4, 5, 4, 5);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(195, 31);
            tbPassword.TabIndex = 5;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(143, 107);
            tbUsername.Margin = new Padding(4, 5, 4, 5);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(195, 31);
            tbUsername.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(349, 107);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 88);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 287);
            Controls.Add(btnLogin);
            Controls.Add(tbUsername);
            Controls.Add(tbPassword);
            Controls.Add(lbSignup);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            Text = "Hôm nay ăn gì? Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbSignup;
        private TextBox tbPassword;
        private TextBox tbUsername;
        private Button btnLogin;
    }
}
