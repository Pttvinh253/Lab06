using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MimeKit;

namespace Lab06
{
    public partial class checkmail : Form
    {
        private MimeMessage receivedMessage;
        private SmtpClient smtpClient;

        public checkmail(MimeMessage message, SmtpClient client)
        {
            this.receivedMessage = message;
            this.smtpClient = client;
            InitializeComponent();
            DisplayEmailContent();
        }

        private async void DisplayEmailContent()
        {
            toLb.Text = "To: " + string.Join(", ", receivedMessage.To.Mailboxes.Select(m => m.Address));
            fromLb.Text = "From: " + string.Join(", ", receivedMessage.From.Mailboxes.Select(m => m.Address));

            await webView21.EnsureCoreWebView2Async(null);

            var htmlContent = new StringBuilder();

            if (!string.IsNullOrEmpty(receivedMessage.HtmlBody))
            {
                htmlContent.Append(receivedMessage.HtmlBody);
            }
            else if (!string.IsNullOrEmpty(receivedMessage.TextBody))
            {
                htmlContent.Append($"<pre>{receivedMessage.TextBody}</pre>");
            }

            foreach (var attachment in receivedMessage.Attachments.OfType<MimePart>())
            {
                if (attachment.ContentDisposition?.Disposition == ContentDisposition.Inline &&
                    !string.IsNullOrEmpty(attachment.ContentId))
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        attachment.Content.DecodeTo(memoryStream);
                        var imageBytes = memoryStream.ToArray();
                        var imageBase64 = Convert.ToBase64String(imageBytes);
                        var imageUrl = $"data:{attachment.ContentType.MimeType};base64,{imageBase64}";

                        htmlContent.Replace($"cid:{attachment.ContentId}", imageUrl);
                    }
                }
            }

            webView21.NavigateToString(htmlContent.ToString());
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string from, to, subject;
            from = receivedMessage.To.ToString();
            to = ((MailboxAddress)receivedMessage.From.First()).Address;
            subject = "Phản hồi lời mời";
            try
            {
                var replyMessage = new MimeMessage();
                replyMessage.From.Add(MailboxAddress.Parse(from));
                replyMessage.To.Add(MailboxAddress.Parse(to));
                replyMessage.Subject = subject;

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.TextBody = messageRtb.Text;

                // Set the body of the message
                replyMessage.Body = bodyBuilder.ToMessageBody();

                await smtpClient.SendAsync(replyMessage);
                messageRtb.Text = "";

                MessageBox.Show("Email sent successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
