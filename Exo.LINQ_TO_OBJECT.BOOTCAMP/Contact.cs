using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo.LINQ_TO_OBJECT.BOOTCAMP
{
    public class Contact
    {

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int AnneeDeNaissance { get; set; }

        public override string ToString()
        {
            return $"{Prenom} {Nom} - {Email} - {AnneeDeNaissance}";
        }


    }
}
