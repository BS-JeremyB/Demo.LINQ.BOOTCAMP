using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo.LINQ.BOOTCAMP
{
    public class Contact
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int AnneeInscription { get; set; }

        public Func<string> NomComplet => () => $"{Prenom} {Nom}";

    }


}
