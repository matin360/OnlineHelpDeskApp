using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Components;
using OnlineHelpdeskAppUI.Core;
using OnlineHelpdeskAppUI.Exceptions;
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
    public partial class New_Operator : Form
    {
        
        public New_Operator()
        {
            InitializeComponent();
            registerControl.btn_register.Click += Btn_register_Click1;
        }

        private void Btn_register_Click1(object sender, EventArgs e)
        {
            try
            {
                Validator.Validation(registerControl.txbx_name.Text, registerControl.txbx_surname.Text, registerControl.txbx_email.Text, registerControl.txbx_email.Text);
                User Operator = new User()
                {
                    Name = registerControl.txbx_name.Text,
                    Surname = registerControl.txbx_surname.Text,
                    Email = registerControl.txbx_email.Text,
                    Password = registerControl.txbx_email.Text,
                    Id = Identifier<User>.GenereteId(),
                    UserType = UserType.Operator
                };
                User user = DbContext.Users.FindUserByEmail(registerControl.txbx_email.Text);
                if (user != null)
                {
                    MessageBox.Show("This Operator already exists");
                }
                else
                {
                    DbContext.Users.Add(Operator);
                    MessageBox.Show("Operator was added");
                }
            }
            catch (DataEmptyException exp)
            {
                MessageBox.Show(exp.Message);
            }
                      
        }

        private void New_Operator_Load(object sender, EventArgs e)
        {

        }

        private void registerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
