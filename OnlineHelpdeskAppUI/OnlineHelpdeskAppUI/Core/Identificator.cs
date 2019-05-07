using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.Core
{
    public class Identifier<T>
    {
        private static int _id;

        public Identifier()
        {
            _id = 0;
        }

        public static int GenereteId()
        {
            _id++;
            return _id;
        }
    }
}
