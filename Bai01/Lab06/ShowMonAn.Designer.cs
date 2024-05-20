namespace Bai07
{
    partial class ShowMonAn
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
            panel1 = new Panel();
            btnMailfr = new Button();
            mail = new Label();
            MailTb = new TextBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(474, 144);
            panel1.TabIndex = 0;
            // 
            // btnMailfr
            // 
            btnMailfr.Location = new Point(347, 154);
            btnMailfr.Margin = new Padding(3, 4, 3, 4);
            btnMailfr.Name = "btnMailfr";
            btnMailfr.Size = new Size(113, 30);
            btnMailfr.TabIndex = 1;
            btnMailfr.Text = "Mời bạn bè...";
            btnMailfr.UseVisualStyleBackColor = true;
            btnMailfr.Click += btnMailfr_Click;
            // 
            // mail
            // 
            mail.AutoSize = true;
            mail.Location = new Point(12, 159);
            mail.Name = "mail";
            mail.Size = new Size(38, 20);
            mail.TabIndex = 2;
            mail.Text = "Mail";
            // 
            // MailTb
            // 
            MailTb.Location = new Point(56, 154);
            MailTb.Name = "MailTb";
            MailTb.Size = new Size(285, 27);
            MailTb.TabIndex = 3;
            MailTb.Text = "22521387@gm.uit.edu.vn";
            // 
            // ShowMonAn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 200);
            Controls.Add(MailTb);
            Controls.Add(mail);
            Controls.Add(btnMailfr);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "ShowMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowMonAn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnMailfr;
        private Label mail;
        private TextBox MailTb;
    }
}