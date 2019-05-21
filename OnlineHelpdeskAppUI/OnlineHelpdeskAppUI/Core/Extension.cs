using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineHelpdeskAppUI.Core
{
    public static class Extension
    {
        public static int CountTickets(this DbSet<Ticket> dbSet, int Id)
        {
            return GetTicketsByUserId(dbSet, Id).Count();
        }

        public static Ticket GetTicketById(this DbSet<Ticket> tickets, int Id)
        {
            Ticket _ticket = new Ticket();
            foreach (Ticket ticket in DbContext.Tickets.GetAll())
            {
                if (ticket != null)
                {
                    if (ticket.Id == Id)
                    {
                        _ticket = ticket;
                    }
                }
            }
            return _ticket;
        }

        public static List<Ticket> GetTicketsByUserId(this DbSet<Ticket> tickets, int userId)
        {
            User user = GetUserById(userId);
            List<Ticket> _tickets = new List<Ticket>();
                foreach(Ticket ticket in DbContext.Tickets.GetAll())
            {
                if (ticket != null)
                {
                    if (user.UserType == UserType.User && ticket.UserId == user.Id)
                    { 
                        _tickets.Add(ticket);
                    }
                }
                else
                    MessageBox.Show("You do not have any tickets!");             
            }
            return _tickets;
        }

        private static User GetUserById(int id)
        {
            User _user = null;
            
            foreach (User user in DbContext.Users.GetAll())
            {
                int userId = user.Id;
                if (userId == id )
                {
                    _user = user;
                }
            }
            return _user;
        }

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
