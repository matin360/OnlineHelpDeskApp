using OnlineHelpdeskAppUI.Core;
using OnlineHelpdeskAppUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.App_Data
{
    public static class DbContext
    {
        public static DbSet<Card> Cards { get; set; }

        public static DbSet<User> Users { get; set; }

        public static DbSet<Ticket> Tickets { get; set; }

        public static void AddDefaultItems()
        {
            User admin = new User()
            {
                Name = "admin",
                Surname = "admin",
                Email = "admin@gmail.com",
                Id = Identifier<User>.GenereteId(),
                Password = "1234",
                UserType = UserType.Admin
            };
            Users.Add(admin);
            User testUser = new User()
            {
                Name = "Test",
                Surname = "Test",
                Email = "test@gmail.com",
                Id = Identifier<User>.GenereteId(),
                Password = "1234",
                UserType = UserType.User
            };
            Users.Add(testUser);
            User testOperator = new User()
            {
                Name = "Tofiq",
                Surname = "Agaev",
                Email = "tofka@gmail.com",
                Id = Identifier<User>.GenereteId(),
                Password = "1234",
                UserType = UserType.Operator
            };
            Users.Add(testOperator);
            Ticket ticket1 = new Ticket()
            {
                Id = Identifier<Ticket>.GenereteId(),
                Title = "bbbbbbb",
                UserId = testUser.Id,
                TicketStatus = TicketStatus.Open,
                Description = "ggggggg",
            };
            Tickets.Add(ticket1);
            Ticket ticket2 = new Ticket()
            {
                Id = Identifier<Ticket>.GenereteId(),
                Title = "bbbbbbb",
                UserId = testUser.Id,
                TicketStatus = TicketStatus.Open,
                Description = "ggggggg"
            };
            Tickets.Add(ticket2);
        }

        static DbContext()
        {
            Cards = new DbSet<Card>();
            Users = new DbSet<User>();
            Tickets = new DbSet<Ticket>();
            AddDefaultItems();
       }
    }

}

