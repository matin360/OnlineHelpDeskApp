using OnlineHelpdeskAppUI.App_Data;
using OnlineHelpdeskAppUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.Core
{
    public static class EnumHelper
    {

        public static T StringToEnum<T>(string data)
        {
            return (T)Enum.Parse(typeof(T), data);
        }

       
    }
}
