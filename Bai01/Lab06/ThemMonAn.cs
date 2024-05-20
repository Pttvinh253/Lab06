using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class ThemMonAn : Form
    {
        private string access_token;

        public ThemMonAn(string token)
        {
            InitializeComponent();
            this.access_token = token;
        }
        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string tenMonAn = tbTenMonAn.Text;
            float gia = float.Parse(tbGia.Text);
            string diaChi = tbDiaChi.Text;
            string hinhAnh = tbHinhAnh.Text;

            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("ten_mon_an", tenMonAn),
                new KeyValuePair<string, string>("gia", gia.ToString()),
                new KeyValuePair<string, string>("dia_chi", diaChi),
                new KeyValuePair<string, string>("hinh_anh", hinhAnh)
            });

            httpClient.DefaultRequestHeaders.Clear();
            httpClient.DefaultRequestHeaders.Add("Authorization", access_token);

            using HttpResponseMessage response = await httpClient.PostAsync("api/v1/monan", formData);

            var res = await response.Content.ReadAsStringAsync();
            JObject keyValuePairs = JObject.Parse(res);

            if (response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(keyValuePairs["detail"].ToString());
            }
            else
            {
                MessageBox.Show("Thêm món ăn thành công!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
