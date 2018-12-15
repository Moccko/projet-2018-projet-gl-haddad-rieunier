using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class Extensions
    {
        public static bool ContientAuMoins(this string s, string texte)
        {
            s = s.ToLower();
            string[] mots = texte.ToLower().Split(' ');
            foreach (string mot in mots)
            {
                if (s.Contains(mot))
                    return true;
            }
            return false;
        }
    }
}
