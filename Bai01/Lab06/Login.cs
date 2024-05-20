using System.Net.Http;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;


namespace Bai07
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private static readonly HttpClient httpClient = new HttpClient
        {
            BaseAddress = new Uri(@"https://nt106.uitiot.vn")
        };
        private async void DoLogin()
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            var formData = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            using HttpResponseMessage response = await httpClient.PostAsync(
                "auth/token",
                formData
            );

            var res = await response.Content.ReadAsStringAsync();
            JObject keyValuePairs = JObject.Parse(res);


            if (response.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(keyValuePairs["detail"].ToString());
            }
            else
            {
                if (keyValuePairs["access_token"] != null)
                {
                    string tokenType = keyValuePairs["token_type"].ToString();
                    string accessToken = keyValuePairs["access_token"].ToString();
                    string jwt = $"{keyValuePairs["token_type"]} {keyValuePairs["access_token"]}";
                    byte[] byteToWrite = Encoding.ASCII.GetBytes(jwt);

                    using (FileStream file = new FileStream("access_token", FileMode.OpenOrCreate))
                    {
                        file.Write(byteToWrite, 0, byteToWrite.Length);
                    }

                    MainForm mainForm = new MainForm(tokenType, accessToken);
                    mainForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Unexpected error: Token not received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DoLogin();
        }

        private void lbSignup_Click(object sender, EventArgs e)
        {
 /*			Signup signup = new Signup();
			signup.ShowDialog();*/
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DoLogin();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (FileStream fileStream = new FileStream("access_token", FileMode.Open))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        var token = streamReader.ReadToEnd();
                        if (token.Length == 0)
                        {
                            Environment.Exit(0);
                        }
                    }
                }
            }
            catch
            {
                Environment.Exit(0);
            }
        }
    }
}
