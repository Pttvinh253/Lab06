using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace Bai07
{
    public partial class ShowMonAn : Form
    {
        private JToken monan;
        private SmtpClient client;
        private string userMail;

        public ShowMonAn(JToken monan, SmtpClient client, string userMail)
        {
            this.client = client;
            this.userMail = userMail;
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

            Label lbDiaChi = new Label();
            lbDiaChi.AutoSize = true;
            lbDiaChi.Location = new Point(181, 55);
            lbDiaChi.Size = new Size(38, 15);
            lbDiaChi.Text = monan.Value<string>("dia_chi").ToString();
            panel.Controls.Add(lbDiaChi);

            Label lbDongGopTxt = new Label();
            lbDongGopTxt.AutoSize = true;
            lbDongGopTxt.Location = new Point(112, 76);
            lbDongGopTxt.Size = new Size(63, 15);
            lbDongGopTxt.Text = "Đóng góp:";
            panel.Controls.Add(lbDongGopTxt);

            Label lbGiaTxt = new Label();
            lbGiaTxt.AutoSize = true;
            lbGiaTxt.Location = new Point(112, 34);
            lbGiaTxt.Size = new Size(27, 15);
            lbGiaTxt.Text = "Giá:";
            panel.Controls.Add(lbGiaTxt);

            Label lbNguoiDongGop = new Label();
            lbNguoiDongGop.AutoSize = true;
            lbNguoiDongGop.ForeColor = Color.LimeGreen;
            lbNguoiDongGop.Location = new Point(181, 76);
            lbNguoiDongGop.Size = new Size(40, 15);
            lbNguoiDongGop.Text = monan.Value<string>("nguoi_dong_gop").ToString();
            panel.Controls.Add(lbNguoiDongGop);

            Label lbDiaChiTxt = new Label();
            lbDiaChiTxt.AutoSize = true;
            lbDiaChiTxt.Location = new Point(112, 55);
            lbDiaChiTxt.Size = new Size(46, 15);
            lbDiaChiTxt.Text = "Địa chỉ:";
            panel.Controls.Add(lbDiaChiTxt);

            Label lbMonAn = new Label();
            lbMonAn.AutoSize = true;
            lbMonAn.Font = new Font("Segoe UI", 15F);
            lbMonAn.ForeColor = Color.Chocolate;
            lbMonAn.Location = new Point(109, 3);
            lbMonAn.Size = new Size(46, 28);
            lbMonAn.Text = monan.Value<string>("ten_mon_an").ToString();
            panel.Controls.Add(lbMonAn);

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
                // Handle error
            }

            panel1.Controls.Add(panel);
            this.Text = $"Ăn {lbMonAn.Text} đi!!!!";
        }

        private async void btnMailfr_Click(object sender, EventArgs e)
        {
            string from, to, subject, ten, gia, diachi, nguoidonggop, body, hinh;

            ten = "<strong>Tên món:</strong> " + monan.Value<string>("ten_mon_an").ToString();
            gia = "<br/><strong>Giá món:</strong> " + monan.Value<float>("gia").ToString();
            diachi = "<br/><strong>Địa chỉ:</strong> " + monan.Value<string>("dia_chi").ToString();
            nguoidonggop = "<br/><strong>Người đóng góp:</strong> " + monan.Value<string>("nguoi_dong_gop").ToString();

            hinh = monan.Value<string>("hinh_anh").ToString();
            body = ten + gia + diachi + nguoidonggop;
            from = userMail;
            to = MailTb.Text.Trim();
            subject = "Người bạn mời ăn";

            try
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("",from));
                message.To.Add(new MailboxAddress("",to));
                message.Subject = subject;
                message.Body = await BuildBodyAsync(body, hinh);

                await client.SendAsync(message);
                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private async Task<MimeEntity> BuildBodyAsync(string text, string fileUrl)
        {
            var multipart = new Multipart("related");

            // HTML part
            var htmlBody = new TextPart("html")
            {
                Text = $"<html><body>{text}<br/><img src=\"cid:image1\"/></body></html>"
            };

            multipart.Add(htmlBody);

            // Image part
            if (!string.IsNullOrEmpty(fileUrl))
            {
                using (var httpClient = new HttpClient())
                {
                    var imageBytes = await httpClient.GetByteArrayAsync(fileUrl);
                    var imagePart = new MimePart("image", "jpeg")
                    {
                        Content = new MimeContent(new MemoryStream(imageBytes)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Inline),
                        ContentTransferEncoding = ContentEncoding.Base64,
                        ContentId = "image1", // Must match the cid in the HTML
                        FileName = Path.GetFileName(fileUrl)
                    };

                    multipart.Add(imagePart);
                }
            }

            return multipart;
        }
    }
}
