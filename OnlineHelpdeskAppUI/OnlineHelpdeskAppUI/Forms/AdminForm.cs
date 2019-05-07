using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineHelpdeskAppUI.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Mainform.Show();
            Close();
        }

        private void link_addcard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AddCardForm().Show();
        }

        private void link_cards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardsForm().Show();
        }

        private void link_users_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new UsersForm().Show();
        }

        private void lbl_greetings_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            lbl_greetings.Text += Session.User.Email;
        }
    }
}
