using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Components;
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
    public partial class OperatorForm : Form
    {
        public OperatorForm()
        {
            InitializeComponent();
        }

        private void OperatorForm_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text += Session.User.Name + Session.User.Surname;     
            int x = 12;
            
            foreach (Ticket ticket in DbContext.Tickets.GetAll())
            {
                if (ticket.TicketStatus == TicketStatus.Open || ticket.TicketStatus == TicketStatus.InProcess)
                {
                    TicketControl ticketControl = new TicketControl();
                    ticketControl.lbl_title.Text = ticket.Title;
                    ticketControl.lbl_description.Text = ticket.Description;
                    ticketControl.lbl_status.Text += ticket.TicketStatus;
                    ticketControl.lbl_createdate.Text += ticket.CreateDate;
                    ticketControl.lbl_id.Text = ticket.Id.ToString();

                    ticketControl.Location = new Point(x, 60);
                    x += 185;
                    Controls.Add(ticketControl);
                }
                else
                {

                }
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Close();
        }
    }
}
