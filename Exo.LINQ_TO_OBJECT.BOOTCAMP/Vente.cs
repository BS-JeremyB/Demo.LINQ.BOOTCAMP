using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo.LINQ_TO_OBJECT.BOOTCAMP
{
    public class Vente
    {
        public int VenteId { get; set; }
        public int EmployeId { get; set; }  // Liaison avec l'employé
        public decimal Montant { get; set; }
        public DateTime DateVente { get; set; }
    }
}
