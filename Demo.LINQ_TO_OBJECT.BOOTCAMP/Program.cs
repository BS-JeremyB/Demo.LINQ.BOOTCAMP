using Demo.LINQ_TO_OBJECT.BOOTCAMP;
using System.Collections;
using static System.Collections.Specialized.BitVector32;

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

#region Cast OfType

//ArrayList arrayList = new ArrayList();

//arrayList.Add("bonjour");
//arrayList.Add(22);
//arrayList.Add(contacts[0]);
//arrayList.Add(false);
//arrayList.Add(contacts[1]);

//foreach(var item in arrayList)
//{
//    Console.WriteLine(item);
//}

//// Cast expression de requete
//IEnumerable<Contact> contactCast = from Contact contact in arrayList
//                                     select contact;

//// Cast methode
//IEnumerable<Contact> contactCastMethod = arrayList.Cast<Contact>();


//// OfType expression de requete
//IEnumerable<Contact> contactOfType = from contact in arrayList.OfType<Contact>()
//                                   select contact;

//// OfType methode
//IEnumerable<Contact> contactOfTypeMethode = arrayList.OfType<Contact>();


//foreach (Contact contact in contactCast)
//{
//    Console.WriteLine(contact);
//}
#endregion

#region Where

//Where Expression de requete
//IEnumerable<Contact> contactsCognitic = from contact in contacts
//                                        where contact.Email.EndsWith("cognitic.be")
//                                        select contact;


//Where Methode

//IEnumerable<Contact> contactsCogniticMethode = contacts.Where(c => c.Email.EndsWith("cognitic.be"));

//foreach (Contact contact in contactsCogniticMethode)
//{
//    Console.WriteLine(contact.ToString());
//}

#endregion

#region Select

//// Select Expression de requete

//var NomPrenom = from c in contacts
//                select new { NomComplet = c.Nom + " " + c.Prenom, c.Nom, c.Prenom };


//// Select Methode
//var NomPrenomMethode = contacts.Select(c =>  new {NomComplet = c.Nom + " "+ c.Prenom, c.Nom, c.Prenom});

//foreach (var contact in NomPrenom) 
//{ 
//    Console.WriteLine(contact.NomComplet);
//}

#endregion

#region SingleOrDefault

//// expression de requete
//Contact contact = (from c in contacts
//                  where c.Nom == "Willis"
//                  select c).SingleOrDefault();


//// Methode

//Contact contactMethode = (contacts.Where(c => c.Nom == "Willis")).SingleOrDefault();

//// Methode B

//Contact contactMethodeB = contacts.SingleOrDefault(c => c.Nom == "Willis");

//Console.WriteLine(contactMethodeB);

#endregion

#region FirstOrDefault

//// expression de requete
//Contact contact = (from c in contacts
//                   where c.Prenom== "Thierry"
//                   select c).FirstOrDefault();


//// Methode

//Contact contactMethode = (contacts.Where(c => c.Prenom== "Thierry")).FirstOrDefault();

//// Methode B

//Contact contactMethodeB = contacts.FirstOrDefault(c => c.Prenom== "Thierry");

//Console.WriteLine(contactMethodeB);

#endregion


#region OrderBy

//// expression de requete
//IEnumerable<Contact> contact = from c in contacts
//                               where c.Prenom == "Thierry"
//                               orderby c.Nom descending
//                               select c;

//// methode

//IEnumerable<Contact> contactMethode = contacts.Where(c => c.Prenom == "Thierry").OrderByDescending(c => c.Nom);

//foreach(var item in contactMethode)
//{
//    Console.WriteLine(item);
//}
#endregion

#region ThenOrderBy

//// expression de requete
//IEnumerable<Contact> contact = from c in contacts
//                               where c.Prenom == "Thierry"
//                               orderby c.Nom descending, c.AnneeDeNaissance
//                               select c;

//// methode

//IEnumerable<Contact> contactMethode = contacts.Where(c => c.Prenom == "Thierry")
//                                              .OrderByDescending(c => c.Nom)
//                                              .ThenBy(c => c.AnneeDeNaissance);

//foreach (var item in contactMethode)
//{
//    Console.WriteLine(item);
//}
#endregion

#region EXO

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