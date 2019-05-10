using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Core;
using OnlineHelpdeskAppUI.Models;

namespace OnlineHelpdeskAppUI.Forms
{
    public partial class AddTicketForm : Form
    {
        private UserForm _userForm;

        public AddTicketForm(UserForm userForm)
        {
            InitializeComponent();
            _userForm = userForm;
        }

        private void btn_addticket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket()
            {
                Id = Identifier<Ticket>.GenereteId(),
                Title = txbx_title.Text,
                UserId = Session.User.Id,
                TicketStatus = TicketStatus.Open,
                Description = txbx_decription.Text
            };
            if (!DbContext.Tickets.HasTicket(ticket.Title))
            {
                DbContext.Tickets.Add(ticket);
                MessageBox.Show("Your ticket added");
            }
            else
                MessageBox.Show("Duplicating tickets is not allowed!");
            link_number.Text = DbContext.Tickets.CountTickets(Session.User.Id).ToString();
        }

        private void AddTicketForm_Load(object sender, EventArgs e)
        {
            link_number.Text = DbContext.Tickets.CountTickets(Session.User.Id).ToString();
        }
    }
}
