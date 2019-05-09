using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.Core
{
    public static class Extension
    {
        public static bool HasTicket(this DbSet<Ticket> dbSet, string title)
        {
            bool hasTicket = false;
            foreach (Ticket ticket in dbSet.GetAll())
            {
                if (String.Compare(ticket.Title,title, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    hasTicket = true;
                    break;
                }
            } 
            return hasTicket;
        }

        public static Card FindCardByNumber(this DbSet<Card> dbset, string cardNumber)
        {
            Card _card = null;
            foreach (Card card in dbset.GetAll())
            {
                if (card.Number == cardNumber)
                {
                    _card = card;
                    break;
                }
            }
            return _card;
        }

        public static User FindUserByEmail(this DbSet<User> dbset, string email)
        {
            User _user = null;
            foreach (User user in dbset.GetAll())
            {
                if (user.Email == email)
                {
                    _user = user;
                    break;
                }
            }
            return _user;
        }
    }
}
