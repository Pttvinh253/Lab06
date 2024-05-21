using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MailKit;
using MailKit.Search;
using Lab06;

namespace Bai07
{
    public partial class MainForm : Form
    {
        private string access_token;

        private ImapClient imapClient;
        private SmtpClient smtpClient;
        private List<MimeMessage> emails = new List<MimeMessage>();
        private readonly TimeSpan checkInterval = TimeSpan.FromMinutes(1); // Kiểm tra mỗi phút
        public MainForm(string tokentype, string accesstoken)
        {
            InitializeComponent();
            InitializeNotifier();
            this.access_token = $"{tokentype} {accesstoken}";

        }
        private void InitializeNotifier()
        {
            lblNotification.Text = "Đang kiểm tra email...";
        }

        //private async void StartEmailCheckLoop()
        //{
        //    while (true)
        //    {
        //        CheckEmails();
        //        await Task.Delay(checkInterval);
        //    }
        //}


        private JObject user = new JObject();
        private JToken danhSachMonAn;
        //private string access_token = "Bearer ";
        public static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };

        private class Pagination
        {
            public int current { get; set; }
            public int pageSize { get; set; }
        }

        private Pagination pagination = new Pagination
        {
            current = 1,
            pageSize = 50
        };

        private async void GetDishes(bool myDishes = false)
        {
            string uri = myDishes ? "api/v1/monan/my-dishes" : "api/v1/monan/all";
            Panel panel = myDishes ? panelMyDished : panelAllDishes;
            panel.Controls.Clear();

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", access_token);

            using HttpResponseMessage response = await httpClient.PostAsJsonAsync(
                uri,
                pagination
            );

            var res = await response.Content.ReadAsStringAsync();
            JObject keyValuePairs = JObject.Parse(res);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(keyValuePairs["detail"].ToString());
            }
            else
            {
                JToken paginationRes = keyValuePairs["pagination"];
                int total = paginationRes.Value<int>("total");
                double totalPage = Math.Ceiling((float)total / (float)pagination.pageSize);
                comboBoxPage.Items.Clear();
                for (int i = 1; i <= totalPage; i++)
                {
                    comboBoxPage.Items.Add(i);
                }
                danhSachMonAn = keyValuePairs["data"];
                DisplayMonAn(danhSachMonAn, panel);
                /*DisplayMonAn(keyValuePairs["data"], panel);*/
            }
        }
        private void DisplayMonAn(JToken dishes, Panel panel)
        {
            foreach (var dish in dishes)
            {
                Panel dishPanel = new Panel();
                dishPanel.Size = new Size(480, 100);
                dishPanel.BorderStyle = BorderStyle.FixedSingle;

                Label lbMonAn = new Label();
                lbMonAn.Text = dish.Value<string>("ten_mon_an");
                lbMonAn.Font = new Font("Segoe UI", 15F);
                lbMonAn.ForeColor = Color.Chocolate;
                lbMonAn.Location = new Point(120, 10);
                dishPanel.Controls.Add(lbMonAn);

                Label lbGia = new Label();
                lbGia.Text = "Giá: " + dish.Value<float>("gia").ToString();
                lbGia.Location = new Point(120, 40);
                dishPanel.Controls.Add(lbGia);

                Label lbDiaChi = new Label();
                lbDiaChi.Text = "Địa chỉ: " + dish.Value<string>("dia_chi");
                lbDiaChi.Location = new Point(120, 60);
                dishPanel.Controls.Add(lbDiaChi);

                try
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Load(dish.Value<string>("hinh_anh"));
                    pictureBox.Size = new Size(100, 80);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    dishPanel.Controls.Add(pictureBox);
                }
                catch
                {
                    // Handle image load failure
                }

                Button btnDelete = new Button();
                btnDelete.Text = "Xóa";
                btnDelete.Tag = dish.Value<int>("id");
                btnDelete.Location = new Point(400, 70);
                btnDelete.Click += async (s, e) => await DeleteDish((int)btnDelete.Tag);
                dishPanel.Controls.Add(btnDelete);

                panel.Controls.Add(dishPanel);
            }
        }

        private async Task DeleteDish(int dishId)
        {
            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", access_token);

            using HttpResponseMessage response = await httpClient.DeleteAsync($"api/v1/monan/{dishId}");

            var res = await response.Content.ReadAsStringAsync();
            JObject keyValuePairs = JObject.Parse(res);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                MessageBox.Show("Xóa món ăn thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDishes();
            }
            else
            {
                MessageBox.Show(keyValuePairs["detail"].ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnAnGi_Click(object sender, EventArgs e)
        {
            /*int soMonAn = danhSachMonAn.ToArray().Length;
            var rand = new Random();
            int monAnIndex = rand.Next(soMonAn);
            var monan = danhSachMonAn.ElementAt(monAnIndex);

            ShowMonAn showMonAn = new ShowMonAn(monan);
            showMonAn.ShowDialog();*/
            Random rand = new Random();
            int index = rand.Next(danhSachMonAn.Count());
            ShowMonAn showMonAn = new ShowMonAn(danhSachMonAn.ElementAt(index), smtpClient, userTb.Text.Trim());
            showMonAn.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /*try
            {
                //if (await CheckAuthorization())
                //{
                comboBoxPageSize.Text = pagination.pageSize.ToString();
                GetDishes();
                //}
            }
            catch
            {
                Login login = new Login();
                login.ShowDialog();
            }*/
            comboBoxPageSize.Text = pagination.pageSize.ToString();
            GetDishes();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*TabPage? selectedTabPage = tabControl?.SelectedTab;
            if (selectedTabPage != null)
            {
                if (selectedTabPage.Name == "tabPage2")
                {
                    GetDishes(true);
                }
                if (selectedTabPage.Name == "tabPage1")
                {
                    GetDishes();
                }
            }*/
            if (tabControl.SelectedTab.Name == "tabPage2")
            {
                GetDishes(true);
            }
            else
            {
                GetDishes();
            }
        }

        private void comboBoxPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*int page = comboBoxPage.SelectedItem == null ? 1 : int.Parse(comboBoxPage.SelectedItem.ToString());
            int pageSize = comboBoxPageSize.SelectedItem != null ? int.Parse(comboBoxPageSize.SelectedItem.ToString()) : 5;
            pagination.pageSize = pageSize;
            pagination.current = page;
            tabControl_SelectedIndexChanged(sender, e);*/
            int page = int.Parse(comboBoxPage.SelectedItem.ToString());
            pagination.current = page;
            tabControl_SelectedIndexChanged(sender, e);
        }

        private void btnThemMA_Click(object sender, EventArgs e)
        {
            /*ThemMonAn themMonAn = new ThemMonAn();
			themMonAn.FormClosed += tabControl1_SelectedIndexChanged;
			themMonAn.ShowDialog();*/
        }

        private void toolStripStatusLabelLogout_Click(object sender, EventArgs e)
        {
            /*var confirm = MessageBox.Show("Are you sure to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (File.Exists("access_token"))
                {
                    File.Delete("access_token");
                    access_token = "Bearer ";
                    panelAllDishes.Controls.Clear();
                    panelMyDished.Controls.Clear();
                    //CheckAuthorization();
                }
            }*/
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                File.Delete("access_token");
                this.Close();
            }
        }

        private async void LoginBt_Click(object sender, EventArgs e)
        {
            string username = userTb.Text.Trim();
            string password = passTb.Text.Trim();
            await LoginAsync(username, password);
            //StartEmailCheckLoop();
            CheckEmails();
        }

        private async Task LoginAsync(string email, string password)
        {
            try
            {
                imapClient = new ImapClient();
                await imapClient.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                await imapClient.AuthenticateAsync(email, password);

                smtpClient = new SmtpClient();
                await smtpClient.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                await smtpClient.AuthenticateAsync(email, password);

                MessageBox.Show("Logged in successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed: " + ex.Message);
            }
        }

        private void lblNotification_Click(object sender, EventArgs e)
        {
            EmailForm emailForm = new EmailForm(emails,smtpClient);
            emailForm.Show();
        }

        private void CheckEmails()
        {
            try
            {
                var inbox = imapClient.Inbox;
                inbox.Open(MailKit.FolderAccess.ReadOnly);

                var query = SearchQuery.SubjectContains("Người bạn mời ăn");
                var uids = inbox.Search(query);

                emails.Clear();
                foreach (var uid in uids)
                {
                    var message = inbox.GetMessage(uid);
                    emails.Add(message);
                }

                this.Invoke((MethodInvoker)delegate
                {
                    lblNotification.Text = $"Bạn có {emails.Count} lời mời";
                });

                imapClient.Disconnect(true);
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Error: {ex.Message}");
                });
            }    
        }
    }
}
