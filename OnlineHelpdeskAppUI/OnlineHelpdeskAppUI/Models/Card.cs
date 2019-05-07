using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.Models
{
    public class Card
    {
        public int Id { get; set; }

        public CardAmountType cardAmountType { get; set; }

        public string Number { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ActivatedDate { get; set; }

        public DateTime ExpireDate { get; set; }

        public int? ActivatedBy { get; set; }
    }
}
