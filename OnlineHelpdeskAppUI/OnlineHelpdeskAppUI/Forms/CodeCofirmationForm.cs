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
    public partial class CodeCofirmationForm : Form
    {
        public CodeCofirmationForm()
        {
            InitializeComponent();
        }

        private void CodeCofirmationForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
           string code = txbx_code.Text;
            if (code == Session.Code)
            {
                Session.User.IsEmailConfirmed = true;
                MessageBox.Show("Email is confirmed");
            }
            else
                MessageBox.Show("Wrong input");
        }
    }
}
