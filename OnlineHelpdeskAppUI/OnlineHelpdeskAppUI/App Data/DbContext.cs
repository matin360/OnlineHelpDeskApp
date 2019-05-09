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

        public static void AddDefaultUsers()
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
        }

        static DbContext()
        {
            Cards = new DbSet<Card>();
            Users = new DbSet<User>();
            Tickets = new DbSet<Ticket>();
            AddDefaultUsers();
       }
    }

}

