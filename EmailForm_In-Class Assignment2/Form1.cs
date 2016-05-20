using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace EmailForm_In_Class_Assignment2
{
    public partial class sendEmailForm : System.Windows.Forms.Form
    {
        public sendEmailForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            //if (hidePasswordCheckBox.Checked == true) { passwordTextBox.UseSystemPasswordChar = true; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            serverTextBox.Text = "smtp.live.com";
            portTextBox.Text = "587";
            logoPictureBox.Image = Properties.Resources.Hotmail;
            SSLCheckBox.Checked = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            serverTextBox.Text = "";
            portTextBox.Text = String.Empty;
            logoPictureBox.Image = null;
            SSLCheckBox.Checked = false;
        }

        private void emailSettingsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void sendEmailForm_Load(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = hidePasswordCheckBox.Checked = true;
        }

        private void SentButton_Click(object sender, EventArgs e)
        {
            // Create mail message and SMTP instances
            MailMessage msgMailMessage = new MailMessage();
            SmtpClient clientSmtpClient = new SmtpClient();
            // Constants for email successful message, timeout and domains
            String successString = "Email Sent!";
            const int timeoutInt = 10000;
            try
            {
                // Set SMTP Client parameters
                clientSmtpClient.Port = Convert.ToInt16(portTextBox.Text);
                clientSmtpClient.Host = serverTextBox.Text;
                clientSmtpClient.Timeout = timeoutInt;
                clientSmtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientSmtpClient.EnableSsl = SSLCheckBox.Checked;
                clientSmtpClient.Credentials = new System.Net.NetworkCredential(usernameTextBox.Text,
                passwordTextBox.Text);
                // Set Message content
                msgMailMessage.From = new MailAddress(fromTextBox.Text);
                msgMailMessage.To.Add(new MailAddress(toTextBox.Text));
                msgMailMessage.Subject = subjectTextBox.Text;
                msgMailMessage.Body = messageRichTextBox.Text;
                // Send message and show success
                clientSmtpClient.Send(msgMailMessage);
                MessageBox.Show(successString);
            }
            catch (Exception ex)
            {
                // Show message upon exception
                MessageBox.Show(ex.ToString());
            }

        }

        private void hidePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = hidePasswordCheckBox.Checked;
        }

        private void SSLCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void googleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            serverTextBox.Text = "smtp.gmail.com";
            portTextBox.Text = "587";
            logoPictureBox.Image= Properties.Resources.Google;
            SSLCheckBox.Checked = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            fromTextBox.Text=toTextBox.Text=subjectTextBox.Text=messageRichTextBox.Text= 
            serverTextBox.Text=portTextBox.Text=usernameTextBox.Text=passwordTextBox.Text= String.Empty;
            SSLCheckBox.Checked = hidePasswordCheckBox.Checked= false;
            logoPictureBox.Image = null;
            customRadioButton.Checked = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
