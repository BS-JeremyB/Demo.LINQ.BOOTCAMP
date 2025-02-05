using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.LINQ.BOOTCAMP
{
    public static class ToolBox
    {
        public static string toCapitalize(this string str)
        {
            string[] mots = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < mots.Length; i++)
            {
                string mot = mots[i];
                mots[i] = char.ToUpper(mot[0]) + mot.Substring(1).ToLower();

            }


            return string.Join(" ", mots);
        }
    
    }
}
