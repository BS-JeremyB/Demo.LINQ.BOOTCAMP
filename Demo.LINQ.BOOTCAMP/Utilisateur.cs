using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.LINQ.BOOTCAMP
{


    public class Utilisateur
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }


        Func<int,int> agePlusCinq = x => x + 5; 

        public void presentation()
        {
            Console.WriteLine($"{Prenom} {Nom}, {Age} ans, à contacter sur {Email}, dans cinq ans j'aurai {agePlusCinq(Age)}");
        }
    }
}
