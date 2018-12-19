using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class Extensions
    {
        public static int Age(this Coureur c)
        {
            return Convert.ToInt32(DateTime.Now.Subtract(c.DateNaissance).TotalDays) / 365;
        }
    }
}
