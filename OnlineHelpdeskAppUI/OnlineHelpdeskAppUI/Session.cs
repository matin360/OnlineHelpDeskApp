using OnlineHelpdeskAppUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineHelpdeskAppUI
{
    public static class Session
    {
        public static Form Mainform { get; set; }

        public static User User { get; set; }

        public static string Code { get; set; }
    }
}
