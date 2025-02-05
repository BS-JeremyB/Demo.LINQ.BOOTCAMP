using Exo.LINQ_TO_OBJECT.BOOTCAMP;
using System.Text.RegularExpressions;

#region PART I

List<Contact> contacts = new List<Contact> {
    new Contact(){ Nom = "Person", Prenom="Michael", Email="michael.person@cognitic.be", AnneeDeNaissance = 1982 },
    new Contact(){ Nom = "Morre", Prenom="Thierry", Email="thierry.morre@cognitic.be", AnneeDeNaissance = 1974 },
    new Contact(){ Nom = "Dupuis", Prenom="Thierry", Email="thierry.dupuis@cognitic.be", AnneeDeNaissance = 1988 },
    new Contact(){ Nom = "Faulkner", Prenom="Stephane", Email="stephane. faulkner@cognitic.be", AnneeDeNaissance = 1969 },
    new Contact(){ Nom = "Selleck", Prenom = "Tom", Email = "tom. selleck@imdb.com", AnneeDeNaissance = 1945 },
    new Contact(){ Nom = "Anderson", Prenom = "Richard Dean", Email = "richard.dean. anderson@imdb.com", AnneeDeNaissance = 1950 },
    new Contact(){ Nom = "Bullock", Prenom = "Sandra", Email = "sandra.bullock@imdb.com", AnneeDeNaissance = 1964 },
    new Contact(){ Nom = "Peppard", Prenom = "George", Email = "peppard.george@ateam.com", AnneeDeNaissance = 1928 },
    new Contact(){ Nom = "Estevez", Prenom = "Emilio", Email = "emilio. estevez@breakfirstclub.com", AnneeDeNaissance = 1962 },
    new Contact(){ Nom = "Moore", Prenom = "Roger", Email = "roger. moore@imdb.com", AnneeDeNaissance = 1963 },
    new Contact(){ Nom = "Moore", Prenom = "Demi", Email = "demi. moore@imdb.com", AnneeDeNaissance = 1962 },
    new Contact(){ Nom = "Willis", Prenom = "Bruce", Email = "bruce.willis@diehard.com", AnneeDeNaissance = 1955 },
};

List<RDV> rendezVous = new List<RDV> {
    new RDV(){ Email = "stephane. faulkner@cognitic.be", Date = new DateTime(2012,5,12)},
    new RDV(){ Email = "peppard.george@ateam.com", Date = new DateTime(2011,8,14)},
    new RDV(){ Email = "bruce.willis@diehard.com", Date = new DateTime(2012,6,19)},
    new RDV(){ Email = "bruce.willis@diehard.com", Date = new DateTime(2012,6,20)},
    new RDV(){ Email = "michael.person@cognitic.be", Date = new DateTime(2012,04,19)},
};


//var mixedData = new List<object>
//{
//    "Texte aléatoire",
//    new Contact() { Nom = "Wayne", Prenom = "Bruce", Email = "bruce.wayne@batcave.com", AnneeDeNaissance = 1939 },
//    12345,
//    new Contact() { Nom = "Kent", Prenom = "Clark", Email = "clark.kent@dailyplanet.com", AnneeDeNaissance = 1938 }
//};

#region 1. Utilisation de Cast<T> et OfType<T>
////Consigne :
////Imaginez que vous ayez mélangé des types différents dans une collection générique. Vous devez extraire uniquement les objets de type Contact.

//IEnumerable<Contact> contactOfType = mixedData.OfType<Contact>();

//foreach (Contact contact in contactOfType)
//{
//    Console.WriteLine(contact.ToString());
//}

#endregion

#region 2. Filtrage avec Where
////Consigne :
////Récupérez tous les contacts dont l'adresse email appartient au domaine imdb.com. Affichez le nom complet (nom + prénom).

//var contactAnon = contacts.Where(c => c.Email.EndsWith("imdb.com")).Select(c => new { NomComplet = c.Nom + " " + c.Prenom });

//foreach (var contact in contactAnon)
//{
//    Console.WriteLine(contact.NomComplet);
//}

#endregion

#region 3. Transformation avec Select
////Consigne :
////Créez une liste contenant uniquement les prénoms des contacts, en utilisant l’opérateur Select. Affichez ces prénoms.

//var contactAnon = contacts.Select(c => new { c.Prenom });

//foreach (var contact in contactAnon) 
//{
//    Console.WriteLine(contact.Prenom);
//}

#endregion

#region 4. Suppression des doublons avec Distinct
////Consigne :
////Certains contacts peuvent avoir le même prénom. Récupérez la liste des prénoms distincts et affichez-les.

//var contactAnon = contacts.Select(c => new { c.Prenom}).Distinct();

//foreach (var contact in contactAnon)
//{
//    Console.WriteLine(contact.Prenom);
//}

#endregion

#region 5. Recherche avec SingleOrDefault
////Consigne :
////Trouvez le contact dont le nom est "Moore" et le prénom "Demi". Utilisez SingleOrDefault.
////Si aucun contact ou plusieurs contacts correspondent, affichez un message d’erreur.
//try
//{
//    Contact contact = contacts.SingleOrDefault(c => c.Nom == "Moore" && c.Prenom == "Demi");
//    if(contact == null)
//    {
//        Console.WriteLine("Le contact n'existe pas !");
//    }
//    else
//    {
//        Console.WriteLine(contact.ToString());
//    }

//} catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
#endregion

#region 6. Recherche avec FirstOrDefault
////Consigne :
////Trouvez le premier contact dont l'année de naissance est antérieure à 1960. Utilisez FirstOrDefault et affichez le nom complet.

////Contact contact = contacts.Where(c => c.AnneeDeNaissance < 1960).FirstOrDefault();

//Contact contact = contacts.FirstOrDefault(c => c.AnneeDeNaissance < 1960);

//Console.WriteLine(contact.ToString());

#endregion

#region 7. Tri avec OrderBy et OrderByDescending
////Consigne :
////Triez les contacts par année de naissance dans l’ordre croissant en utilisant OrderBy, puis affichez les résultats.
////Recommencez avec un tri décroissant en utilisant OrderByDescending.

//IEnumerable<Contact> contactsToOrder = contacts.OrderBy(c => c.AnneeDeNaissance);

//foreach (Contact contact in contactsToOrder)
//{
//    Console.WriteLine(contact.ToString());
//}

//Console.WriteLine("-----------------");
//IEnumerable<Contact> contactsToOrderDesc = contacts.OrderByDescending(c => c.AnneeDeNaissance);

//foreach (Contact contact in contactsToOrderDesc)
//{
//    Console.WriteLine(contact.ToString());
//}
#endregion

#region 8. Tri combiné avec ThenBy et ThenByDescending
////Consigne :
////Triez les contacts par nom, puis par prénom dans l’ordre alphabétique. Affichez les résultats.

//IEnumerable<Contact> contactsToOrder = contacts.OrderBy(c => c.Nom).ThenBy(c => c.Prenom);

//foreach( Contact contact in contactsToOrder)
//{
//    Console.WriteLine(contact.ToString());
//}
#endregion


#endregion

#region PART II
List<Employe> employes = new List<Employe>
{
    new Employe { EmployeId = 1, Nom = "Dupont", Prenom = "Jean", Site = "Paris" },
    new Employe { EmployeId = 2, Nom = "Martin", Prenom = "Alice", Site = "Lyon" },
    new Employe { EmployeId = 3, Nom = "Durand", Prenom = "Paul", Site = "Marseille" },
    new Employe { EmployeId = 4, Nom = "Morel", Prenom = "Sophie", Site = "Paris" },
    new Employe { EmployeId = 5, Nom = "Bernard", Prenom = "Thierry", Site = "Lyon" }
};
Ventes:
List<Vente> ventes = new List<Vente>
{
    new Vente { VenteId = 1, EmployeId = 1, Montant = 500m, DateVente = new DateTime(2023, 5, 1) },
    new Vente { VenteId = 2, EmployeId = 2, Montant = 700m, DateVente = new DateTime(2023, 6, 10) },
    new Vente { VenteId = 3, EmployeId = 1, Montant = 200m, DateVente = new DateTime(2023, 7, 15) },
    new Vente { VenteId = 4, EmployeId = 3, Montant = 450m, DateVente = new DateTime(2023, 8, 3) },
    new Vente { VenteId = 5, EmployeId = 4, Montant = 300m, DateVente = new DateTime(2023, 9, 12) },
    new Vente { VenteId = 6, EmployeId = 5, Montant = 600m, DateVente = new DateTime(2023, 10, 5) }
};


#region Exercice 1 : Utilisation de Count
//Combien de ventes ont été réalisées au total ?

//int totalVentes = ventes.Count();
//Console.WriteLine($"Le total des ventes est de : {totalVentes}");

#endregion


#region Exercice 2 : Utilisation de Min et Max
//Quel est le montant minimum et le montant maximum parmi toutes les ventes ?

//decimal venteMin = ventes.Min(v => v.Montant);
//decimal venteMax = ventes.Max(v => v.Montant);

//Console.WriteLine($"Le montant minimum est de {venteMin} € et le montant maximum est de {venteMax} €");

#endregion


#region Exercice 3 : Utilisation de Sum et Average
//Calculez le chiffre d'affaires total (somme de toutes les ventes).
//Calculez le montant moyen des ventes.

//decimal totalChiffreAffaire = ventes.Sum(v => v.Montant);
//decimal moyenneVentes = ventes.Average(v => v.Montant);

//Console.WriteLine($"Le chiffre d'affaire total est de : {totalChiffreAffaire}");
//Console.WriteLine($"La somme moyenne des ventes est de : {moyenneVentes:f2}");

#endregion


#region Exercice 4 : Groupement(GroupBy)
//Regroupez les employés par site. Pour chaque site, affichez le nombre d'employés.

//IEnumerable<IGrouping<string, Employe>> employeParSite = employes.GroupBy(e => e.Site);

//foreach(IGrouping<string, Employe> site in employeParSite)
//{
//    Console.WriteLine($"Site : {site.Key}, nombre d'employes : {site.Count()}");
//}

#endregion


#region Exercice 5 : Jointure(Join)
//Affichez pour chaque vente, le nom complet de l'employé ayant réalisé la vente.

//var venteEmploye = ventes.Join(employes,
//                               v => v.EmployeId,
//                               e => e.EmployeId,
//                               (v, e) => new
//                               {
//                                   NomComplet = e.Nom + " " + e.Prenom,
//                                   v.Montant,
//                                   v.DateVente
//                               });

//foreach(var vente in venteEmploye)
//{
//    Console.WriteLine($"Vente de {vente.NomComplet} d'un montant de {vente.Montant} € effectuée le {vente.DateVente}");
//}

#endregion


#region Exercice 6 : GroupJoin
//Affichez pour chaque employé la liste de ses ventes, même s'il n'a pas effectué de ventes.

//var employesVentes = employes.GroupJoin(ventes,
//                                        e => e.EmployeId,
//                                        v => v.EmployeId,
//                                        (e, vts) => new
//                                        {
//                                            NomComplet = e.Nom + " " + e.Prenom,
//                                            Ventes = vts,
//                                        });

//foreach (var employe in employesVentes)
//{
//    Console.WriteLine($"{employe.NomComplet} : ");
//    if(employe.Ventes.Count() > 0)
//    {
//        foreach(Vente v in employe.Ventes)
//        {
//            Console.WriteLine($" - ID : {v.VenteId}, Montant : {v.Montant}, Date : {v.DateVente}");
//        }
//    }
//    else
//    {
//        Console.WriteLine("N'a pas effectué de ventes");
//    }
//}

#endregion


#region Exercice 7 : Recherche d’employé ayant le plus de ventes
//Quel employé a réalisé le chiffre d'affaires le plus élevé ?

//var employeMaxVentes = ventes.GroupBy(v => v.EmployeId)
//                             .Select(g => new
//                             {
//                                 EmployeId = g.Key,
//                                 ChiffreAffaire = g.Sum(v => v.Montant)
//                             })
//                             .OrderByDescending(v => v.ChiffreAffaire)
//                             .FirstOrDefault();

//var meilleurEmploye = employes.SingleOrDefault(e => e.EmployeId == employeMaxVentes.EmployeId);


//Console.WriteLine($"{meilleurEmploye.Nom} {meilleurEmploye.Prenom} - {employeMaxVentes.ChiffreAffaire} €");


//var employeMaxVentes = employes.GroupJoin(ventes,
//                                          e => e.EmployeId,
//                                          v => v.EmployeId,
//                                          (e, v) => new
//                                          {
//                                              e.Prenom,
//                                              e.Nom,
//                                              ChiffreAffaire = v.Sum(v => v.Montant)
//                                          })
//                                          .OrderByDescending(v => v.ChiffreAffaire)
//                                          .FirstOrDefault();

//Console.WriteLine($"{employeMaxVentes.Prenom} {employeMaxVentes.Nom} - {employeMaxVentes.ChiffreAffaire} €");


#endregion


#region Exercice 8 : Recherche de la succursale ayant le plus gros chiffre d'affaires
//Quelle succursale (site) a généré le chiffre d'affaires le plus important ?

//var chiffreAffaireSite = ventes.Join(employes,
//                                     e => e.EmployeId,
//                                     v => v.EmployeId,
//                                     (v, e) => new
//                                     {
//                                         e.Site,
//                                         v.Montant
//                                     }) // tableau joint
//                                     .GroupBy(e => e.Site)
//                                     .Select(g => new
//                                     {
//                                         Site = g.Key,
//                                         ChiffreAffaire = g.Sum(v => v.Montant)
//                                     })
//                                     .OrderByDescending(g => g.ChiffreAffaire)
//                                     .FirstOrDefault();


//Console.WriteLine($"Le meilleur site est celui de {chiffreAffaireSite.Site} avec un chiffre d'affaire de {chiffreAffaireSite.ChiffreAffaire} €");


#endregion

#endregion