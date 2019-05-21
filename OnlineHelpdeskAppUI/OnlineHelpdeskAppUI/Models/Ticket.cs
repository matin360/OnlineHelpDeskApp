using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.Models
{
    public class Ticket
    {
        public Ticket()
        {
            CreateDate = DateTime.Now;
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TicketStatus TicketStatus { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int? OperatorId { get; set; }
        public string TicketIssue { get; set; }
    }
}
