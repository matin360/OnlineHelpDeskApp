﻿using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Core;
using OnlineHelpdeskAppUI.Models;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txbx_login_email.Text;
            string password = txbx_login_password.Text;

            User user = DbContext.Users.FindUserByEmail(email);
            Session.User = user;
            if (user != null && user.Email == email && user.Password == password)
            {
                if (user.UserType == UserType.Admin)
                {
                    new AdminForm().Show();
                    Close();
                }
                else
                {
                    new UserForm().Show();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Wrong password or email");
            }
        }
    }
}
