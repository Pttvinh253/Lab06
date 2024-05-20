namespace Bai07
{
    partial class MainForm
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
            label1 = new Label();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            panelAllDishes = new Panel();
            tabPage2 = new TabPage();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripStatusLabelLogout = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            btnAnGi = new Button();
            btnThemMA = new Button();
            label2 = new Label();
            label3 = new Label();
            comboBoxPage = new ComboBox();
            comboBoxPageSize = new ComboBox();
            panelMyDished = new Panel();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(17, 15);
            label1.Name = "label1";
            label1.Size = new Size(355, 54);
            label1.TabIndex = 0;
            label1.Text = "HÔM NAY ĂN GÌ?";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.ItemSize = new Size(72, 30);
            tabControl.Location = new Point(17, 107);
            tabControl.Margin = new Padding(4, 5, 4, 5);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(729, 797);
            tabControl.TabIndex = 1;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panelAllDishes);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Margin = new Padding(4, 5, 4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(4, 5, 4, 5);
            tabPage1.Size = new Size(721, 759);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "All";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelAllDishes
            // 
            panelAllDishes.AutoScroll = true;
            panelAllDishes.Dock = DockStyle.Fill;
            panelAllDishes.Location = new Point(4, 5);
            panelAllDishes.Margin = new Padding(4, 5, 4, 5);
            panelAllDishes.Name = "panelAllDishes";
            panelAllDishes.Size = new Size(713, 749);
            panelAllDishes.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panelMyDished);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Margin = new Padding(4, 5, 4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(4, 5, 4, 5);
            tabPage2.Size = new Size(721, 759);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tôi đóng góp";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripStatusLabelLogout, toolStripStatusLabel1, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 962);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(763, 32);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(72, 25);
            toolStripStatusLabel.Text = "            ";
            // 
            // toolStripStatusLabelLogout
            // 
            toolStripStatusLabelLogout.IsLink = true;
            toolStripStatusLabelLogout.LinkBehavior = LinkBehavior.HoverUnderline;
            toolStripStatusLabelLogout.Name = "toolStripStatusLabelLogout";
            toolStripStatusLabelLogout.Size = new Size(37, 25);
            toolStripStatusLabelLogout.Text = "     ";
            toolStripStatusLabelLogout.Click += toolStripStatusLabelLogout_Click;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(16, 25);
            toolStripStatusLabel1.Text = "|";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(143, 24);
            // 
            // btnAnGi
            // 
            btnAnGi.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAnGi.BackColor = Color.NavajoWhite;
            btnAnGi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnGi.Location = new Point(360, 55);
            btnAnGi.Name = "btnAnGi";
            btnAnGi.Size = new Size(189, 82);
            btnAnGi.TabIndex = 8;
            btnAnGi.Text = "Ăn gì giờ?";
            btnAnGi.UseVisualStyleBackColor = false;
            btnAnGi.Click += btnAnGi_Click;
            // 
            // btnThemMA
            // 
            btnThemMA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThemMA.BackColor = Color.PapayaWhip;
            btnThemMA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThemMA.Location = new Point(557, 55);
            btnThemMA.Margin = new Padding(4, 5, 4, 5);
            btnThemMA.Name = "btnThemMA";
            btnThemMA.Size = new Size(189, 82);
            btnThemMA.TabIndex = 9;
            btnThemMA.Text = "Thêm món ăn";
            btnThemMA.UseVisualStyleBackColor = false;
            btnThemMA.Click += btnThemMA_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(482, 933);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 0;
            label2.Text = "Page";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(599, 933);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 4;
            label3.Text = "Page size";
            // 
            // comboBoxPage
            // 
            comboBoxPage.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxPage.FormattingEnabled = true;
            comboBoxPage.Location = new Point(539, 928);
            comboBoxPage.Margin = new Padding(4, 5, 4, 5);
            comboBoxPage.Name = "comboBoxPage";
            comboBoxPage.Size = new Size(47, 33);
            comboBoxPage.TabIndex = 3;
            comboBoxPage.Text = "1";
            comboBoxPage.SelectedIndexChanged += comboBoxPage_SelectedIndexChanged;
            // 
            // comboBoxPageSize
            // 
            comboBoxPageSize.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            comboBoxPageSize.FormattingEnabled = true;
            comboBoxPageSize.Items.AddRange(new object[] { "5", "10", "15", "20", "50" });
            comboBoxPageSize.Location = new Point(685, 928);
            comboBoxPageSize.Margin = new Padding(4, 5, 4, 5);
            comboBoxPageSize.Name = "comboBoxPageSize";
            comboBoxPageSize.Size = new Size(53, 33);
            comboBoxPageSize.TabIndex = 3;
            comboBoxPageSize.TabStop = false;
            comboBoxPageSize.Text = "5";
            // 
            // panelMyDished
            // 
            panelMyDished.Dock = DockStyle.Fill;
            panelMyDished.Location = new Point(4, 5);
            panelMyDished.Margin = new Padding(4, 5, 4, 5);
            panelMyDished.Name = "panelMyDished";
            panelMyDished.Size = new Size(713, 749);
            panelMyDished.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 994);
            Controls.Add(comboBoxPageSize);
            Controls.Add(comboBoxPage);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnThemMA);
            Controls.Add(btnAnGi);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hôm nay ăn gì?";
            Load += MainForm_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panelAllDishes;
        private StatusStrip statusStrip1;
        public ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripStatusLabel toolStripStatusLabelLogout;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button btnAnGi;
        private Button btnThemMA;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxPage;
        private ComboBox comboBoxPageSize;
        private Panel panelMyDished;
    }
}