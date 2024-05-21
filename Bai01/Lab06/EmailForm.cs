using System.Collections.Generic;
using System.Windows.Forms;
using MimeKit;

namespace Lab06
{
    public partial class EmailForm : Form
    {
        private List<MimeMessage> emails;

        public EmailForm(List<MimeMessage> emails)
        {
            InitializeComponent();
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
                checkmail cm = new checkmail(); 
                cm.Show();
            }
        }
    }
}
