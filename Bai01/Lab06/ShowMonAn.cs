using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class ShowMonAn : Form
    {
        /*public ShowMonAn()
        {
            InitializeComponent();
        }*/
        private JToken monan;
        public ShowMonAn(JToken monan)
        {
            InitializeComponent();
            this.monan = monan;

            Panel panel = new Panel();
            panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel.Location = new Point(3, 3);
            panel.Size = new Size(490, 100);
            panel.TabIndex = 3;

            Label lbGia = new Label();
            lbGia.AutoSize = true;
            lbGia.Location = new Point(181, 34);
            lbGia.Size = new Size(38, 15);
            lbGia.Text = monan.Value<float>("gia").ToString();
            panel.Controls.Add(lbGia);
            //
            Label lbDiaChi = new Label();
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(181, 55);
            lbDiaChi.Size = new Size(38, 15);
            lbDiaChi.Text = monan.Value<string>("dia_chi").ToString();
            panel.Controls.Add(lbDiaChi);
            // 
            Label lbDongGopTxt = new Label();
            lbDongGopTxt.AutoSize = true;
            lbDongGopTxt.Location = new Point(112, 76);
            lbDongGopTxt.Size = new Size(63, 15);
            lbDongGopTxt.Text = "Đóng góp:";
            panel.Controls.Add(lbDongGopTxt);
            // 
            Label lbGiaTxt = new Label();
            lbGiaTxt.AutoSize = true;
            lbGiaTxt.Location = new Point(112, 34);
            lbGiaTxt.Size = new Size(27, 15);
            lbGiaTxt.Text = "Giá:";
            panel.Controls.Add(lbGiaTxt);
            // 
            Label lbNguoiDongGop = new Label();
            lbNguoiDongGop.AutoSize = true;
            lbNguoiDongGop.ForeColor = Color.LimeGreen;
            lbNguoiDongGop.Location = new Point(181, 76);
            lbNguoiDongGop.Size = new Size(40, 15);
            lbNguoiDongGop.Text = monan.Value<string>("nguoi_dong_gop").ToString();
            panel.Controls.Add(lbNguoiDongGop);
            // 
            Label lbDiaChiTxt = new Label();
            lbDiaChiTxt.AutoSize = true;
            lbDiaChiTxt.Location = new Point(112, 55);
            lbDiaChiTxt.Size = new Size(46, 15);
            lbDiaChiTxt.Text = "Địa chỉ:";
            panel.Controls.Add(lbDiaChiTxt);
            // 
            Label lbMonAn = new Label();
            lbMonAn.AutoSize = true;
            lbMonAn.Font = new Font("Segoe UI", 15F);
            lbMonAn.ForeColor = Color.Chocolate;
            lbMonAn.Location = new Point(109, 3);
            lbMonAn.Size = new Size(46, 28);
            lbMonAn.Text = monan.Value<string>("ten_mon_an").ToString();
            panel.Controls.Add(lbMonAn);
            // 
            try
            {
                PictureBox hinhMonAn = new PictureBox();
                hinhMonAn.Location = new Point(3, 3);
                hinhMonAn.Name = "pictureBox1";
                hinhMonAn.Size = new Size(100, 92);
                hinhMonAn.SizeMode = PictureBoxSizeMode.StretchImage;
                hinhMonAn.Load(monan.Value<string>("hinh_anh").ToString());
                panel.Controls.Add(hinhMonAn);
            }
            catch
            {

            }
            panel1.Controls.Add(panel);
            this.Text = $"Ăn {lbMonAn.Text} đi!!!!";
        }

        private void btnMailfr_Click(object sender, EventArgs e)
        {
            /*Invite invite = new Invite(monan);
			invite.ShowDialog();
			this.Close();*/
        }
    }
}
