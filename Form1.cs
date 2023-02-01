using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Reflection.Emit;

namespace Email_Sender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int recoveryCode;
        private void recoveryCodeGenerator()
        {
            Random rand = new Random();
            recoveryCode = rand.Next(100000, 999999);
            MessageBox.Show(recoveryCode.ToString());
            //recoveryCodeChecker(recoveryCode.ToString());
        }

        private void recoveryCodeChecker(string recoveryCode)
        {
            if (txtEnteredCode.Text == recoveryCode)
            {
                MessageBox.Show("Success!");
                pnlCreateNewPassword.Visible = true;
                pnlCreateNewPassword.Location = new Point(5, 8);
                this.Size = new Size(292, 148);
                pnlEnterCode.Visible = false;
                pnlEnterEmail.Visible = false;

            }
            else
            {
                MessageBox.Show("Unsuccessfull, please try again");
            } 
        }

        private void recoveryCodeEntryPage()
        {
            this.Size = new Size(215, 139);
            pnlEnterEmail.Visible = false;
            pnlEnterCode.Visible = true;
            pnlEnterCode.Location = new Point(2, 2);
        }

        private void newPasswordEntry()
        {

        }

        private void btnSendVerifyCode_Click(object sender, EventArgs e)
        {
            recoveryCodeGenerator();
            SendEmail();
            recoveryCodeEntryPage();
        }

        private void SendEmail()
        {
            try
            {
                string from = "no.reply.pass.recovery.test@gmail.com";
                string password = "bejf uvos dnjo ffka";
                MailMessage msg = new MailMessage();
                msg.Subject = "Password Reset";
                msg.From = new MailAddress(from);
                msg.Body = "Your verification code is: "+ recoveryCode.ToString();
                msg.To.Add(new MailAddress(txtUserEmail.Text));
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                //Encrypts the email to ensure enhanced security.
                smtp.EnableSsl = true;
                NetworkCredential nc= new NetworkCredential (from, password);
                smtp.Credentials = nc;
                smtp.Send(msg);
                MessageBox.Show("Email Sent!");
          
            }
            catch 
            {
                MessageBox.Show("Email Failed To Send!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(268, 143);
            pnlEnterEmail.Visible = true;
            pnlEnterEmail.Location = new Point(12, 12);
            pnlEnterCode.Visible = false;
            pnlCreateNewPassword.Visible = false;
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            recoveryCodeChecker(recoveryCode.ToString());
        }

        private void btnSendAnotherCode_Click(object sender, EventArgs e)
        {
            recoveryCodeGenerator();
            SendEmail();
            //recoveryCodeEntryPage();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Email_Sender.Properties.Resources.eye_open;
            txtNewPassword.PasswordChar = '\0';
            txtNewPassword.UseSystemPasswordChar = false;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.BackgroundImage = Email_Sender.Properties.Resources.eye_closed;
            txtNewPassword.PasswordChar = '*';
            txtNewPassword.UseSystemPasswordChar = false;
        }

        private void btnAppendPassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.TextLength >= 8)
            {
                MessageBox.Show("Your Password has successully been reset!");
            }
            else if (txtNewPassword.TextLength < 8)
            {
                MessageBox.Show("Password must be longer than 8 characters!");
            }
            
        }
    }
}
