using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo.LINQ.BOOTCAMP
{
    public static class Utilitaire
    {
        public static string ToUpdateMail(this Contact contact)
        {
            if (contact.Email.EndsWith("@gmail.com"))
            {
                contact.Email = contact.Email.Replace("@gmail.com", "@metamail.com");
            }

            return contact.Email;
        } 
    }
}
