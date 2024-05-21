namespace Lab06
{
    partial class checkmail
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
            fromLb = new Label();
            toLb = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button1 = new Button();
            messageRtb = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // fromLb
            // 
            fromLb.AutoSize = true;
            fromLb.Location = new Point(54, 29);
            fromLb.Name = "fromLb";
            fromLb.Size = new Size(43, 20);
            fromLb.TabIndex = 2;
            fromLb.Text = "From";
            // 
            // toLb
            // 
            toLb.AutoSize = true;
            toLb.Location = new Point(54, 58);
            toLb.Name = "toLb";
            toLb.Size = new Size(25, 20);
            toLb.TabIndex = 2;
            toLb.Text = "To";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(54, 81);
            webView21.Name = "webView21";
            webView21.Size = new Size(744, 218);
            webView21.TabIndex = 3;
            webView21.ZoomFactor = 1D;
            // 
            // button1
            // 
            button1.Location = new Point(689, 495);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Reply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // messageRtb
            // 
            messageRtb.Location = new Point(54, 326);
            messageRtb.Name = "messageRtb";
            messageRtb.Size = new Size(744, 147);
            messageRtb.TabIndex = 5;
            messageRtb.Text = "";
            // 
            // checkmail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lab3_NT132;
            ClientSize = new Size(856, 559);
            Controls.Add(messageRtb);
            Controls.Add(button1);
            Controls.Add(webView21);
            Controls.Add(toLb);
            Controls.Add(fromLb);
            Name = "checkmail";
            Text = "checkmail";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label fromLb;
        private Label toLb;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
        private RichTextBox messageRtb;
    }
}