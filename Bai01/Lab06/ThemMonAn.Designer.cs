namespace Lab06
{
    partial class ThemMonAn
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbTenMonAn = new TextBox();
            tbGia = new TextBox();
            tbDiaChi = new TextBox();
            tbHinhAnh = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 35);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 91);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 1;
            label2.Text = "Giá";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 161);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 224);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 3;
            label4.Text = "Hình ảnh";
            // 
            // tbTenMonAn
            // 
            tbTenMonAn.Location = new Point(197, 35);
            tbTenMonAn.Name = "tbTenMonAn";
            tbTenMonAn.Size = new Size(439, 31);
            tbTenMonAn.TabIndex = 4;
            // 
            // tbGia
            // 
            tbGia.Location = new Point(197, 91);
            tbGia.Name = "tbGia";
            tbGia.Size = new Size(439, 31);
            tbGia.TabIndex = 5;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Location = new Point(197, 155);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(439, 31);
            tbDiaChi.TabIndex = 6;
            // 
            // tbHinhAnh
            // 
            tbHinhAnh.Location = new Point(197, 224);
            tbHinhAnh.Name = "tbHinhAnh";
            tbHinhAnh.Size = new Size(439, 31);
            tbHinhAnh.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(573, 324);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 59);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ThemMonAn
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(tbHinhAnh);
            Controls.Add(tbDiaChi);
            Controls.Add(tbGia);
            Controls.Add(tbTenMonAn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ThemMonAn";
            Text = "ThemMonAn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTenMonAn;
        private TextBox tbGia;
        private TextBox tbDiaChi;
        private TextBox tbHinhAnh;
        private Button btnAdd;
    }
}