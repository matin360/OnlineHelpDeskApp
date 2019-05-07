using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Core;
using OnlineHelpdeskAppUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineHelpdeskAppUI.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if(txbx_password.Text != txbx_confirmPassword.Text)
            {
                MessageBox.Show("Passwords are not the same!");
                return;
            }
            User user = new User
            {
                Email = txbx_email.Text,
                Name = txbx_name.Text,
                Surname = txbx_surname.Text,
                Password = txbx_password.Text,
                Id = Identifier<User>.GenereteId(),
                UserType = UserType.User,
                IsEmailConfirmed = false
            };
            DbContext.Users.Add(user);
            Session.User = user;
            SendEmail(txbx_email.Text);
            new CodeCofirmationForm().ShowDialog();
        }

        private void SendEmail(string toEmail)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("matin.manafov@aiesec.net", "XMLSULBW"),
                EnableSsl = true
        };
            
            Random random = new Random();
            int code = random.Next(1000, 9999);
            Session.Code = code.ToString();
            string message = $"Your code is {code}";
            smtpClient.Send("matin.manafov@aiesec.net", toEmail, "Code cofirmation for OnlineHelpDesk", message);

        }

        private void btn_card_register_Click(object sender, EventArgs e)
        {
            if (txbx_password.Text != txbx_confirmPassword.Text)
            {
                MessageBox.Show("Passwords are not the same!");
                return;
            }
            Card card = DbContext.Cards.FindCardByNumber(txbx_cardNumber.Text);
            if (card != null)
            {
                MessageBox.Show("Card is not valid");
                return;
            }
            User user = new User
            {
                Email = txbx_email.Text,
                Password = txbx_password.Text,
                Id = Identifier<User>.GenereteId(),
                UserType = UserType.User
            };
            DbContext.Users.Add(user);
            MessageBox.Show("You are successfully registered!");
        }

        private void Btn_goToLoginPage_Click(object sender, EventArgs e)
        {
            Hide();
            Session.Mainform = this;
            new LoginForm().ShowDialog();
        }
    }
}
