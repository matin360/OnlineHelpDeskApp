using OnlineHelpdeskAppUI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineHelpdeskAppUI.Core
{
    public static class Validator
    {
        public static void Validation(params string[] txbxs)
        {
            foreach (string txbx in txbxs)
            {
                if (txbx.Length == 0)
                {
                    throw new DataEmptyException("Parameter is empty!");
                }
            }

        }
    }
}
