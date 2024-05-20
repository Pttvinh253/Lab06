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
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 180);
            panel1.TabIndex = 0;
            // 
            // btnMailfr
            // 
            btnMailfr.Location = new Point(434, 192);
            btnMailfr.Margin = new Padding(4, 5, 4, 5);
            btnMailfr.Name = "btnMailfr";
            btnMailfr.Size = new Size(141, 38);
            btnMailfr.TabIndex = 1;
            btnMailfr.Text = "Mời bạn bè...";
            btnMailfr.UseVisualStyleBackColor = true;
            btnMailfr.Click += btnMailfr_Click;
            // 
            // ShowMonAn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 250);
            Controls.Add(btnMailfr);
            Controls.Add(panel1);
            Name = "ShowMonAn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowMonAn";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMailfr;
    }
}