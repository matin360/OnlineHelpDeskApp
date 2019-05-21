using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Core;
using OnlineHelpdeskAppUI.Models;

namespace OnlineHelpdeskAppUI.Components
{
    public partial class TicketControl : UserControl
    {
        public TicketControl()
        {
            InitializeComponent();
        }

        private void btn_process_Click(object sender, EventArgs e)
        {
            Ticket ticket = DbContext.Tickets.GetTicketById(Convert.ToInt32(lbl_id.Text));
            ticket.TicketStatus = TicketStatus.InProcess;
            ticket.OperatorId = Session.User.Id;
            MessageBox.Show("Ticket is in the process");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Ticket ticket = DbContext.Tickets.GetTicketById(Convert.ToInt32(lbl_id.Text));
            ticket.TicketStatus = TicketStatus.Closed;
            ticket.OperatorId = Session.User.Id;
            ticket.ClosedDate = DateTime.Now;
            ticket.TicketIssue = txbx_issue.Text;
            MessageBox.Show("Ticket is closed");
        }
    }
}
