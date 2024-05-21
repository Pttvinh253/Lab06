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

namespace Lab06
{
    public partial class EmailForm : Form
    {
        private List<MimeMessage> emails;
        private SmtpClient client;
        public EmailForm(List<MimeMessage> emails, SmtpClient client)
        {
            InitializeComponent();
            this.client = client;
            this.emails = emails;
            LoadEmails(emails);
            listViewEmails.ItemActivate += ListViewEmails_ItemActivate;
        }

        private void LoadEmails(List<MimeMessage> emails)
        {
            listViewEmails.Items.Clear();
            int number = 1;
            foreach (var email in emails)
            {
                var item = new ListViewItem(new[]
                {
                    number.ToString(),
                    email.From.ToString(),
                    email.Subject,
                    email.Date.ToString()
                });
                item.Tag = email; // Gắn email vào Tag để dễ dàng truy cập sau này
                listViewEmails.Items.Add(item);
                number++;
            }
        }

        private void ListViewEmails_ItemActivate(object sender, EventArgs e)
        {
            if (listViewEmails.SelectedItems.Count > 0)
            {
                var selectedItem = listViewEmails.SelectedItems[0];
                var email = (MimeMessage)selectedItem.Tag; // Lấy email từ Tag
                checkmail cm = new checkmail(email,client); 
                cm.Show();
            }
        }
    }
}
