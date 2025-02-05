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

List<RDV> rendezVous = new List<RDV> {
    new RDV(){ Email = "stephane. faulkner@cognitic.be", Date = new DateTime(2012,5,12)},
    new RDV(){ Email = "peppard.george@ateam.com", Date = new DateTime(2011,8,14)},
    new RDV(){ Email = "bruce.willis@diehard.com", Date = new DateTime(2012,6,19)},
    new RDV(){ Email = "bruce.willis@diehard.com", Date = new DateTime(2012,6,20)},
    new RDV(){ Email = "michael.person@cognitic.be", Date = new DateTime(2012,04,19)},
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

#region Count

//int nombreContactFiltre = contacts.Count(c => c.AnneeDeNaissance == 1962);

//Console.WriteLine(nombreContactFiltre);
#endregion

#region Min Max

//int ageMax = contacts.Max(c => DateTime.Now.Year - c.AnneeDeNaissance);

//Console.WriteLine(ageMax);

//int ageMin = contacts.Min(c => DateTime.Now.Year - c.AnneeDeNaissance);

//Console.WriteLine(ageMin);

#endregion

#region Group By
//IEnumerable<IGrouping<string, Contact>> contactsGrouped = contacts.GroupBy(c => c.Email.Substring(c.Email.LastIndexOf(".") + 1));

////IEnumerable<IGrouping<string, Contact>> contactsGrouped = contacts.GroupBy(c => c.Nom);

//foreach (IGrouping<string,Contact> item in contactsGrouped)
//{
//    Console.WriteLine($"{item.Key} : {item.Count()}");
//    foreach(Contact contact in item)
//    {
//        Console.WriteLine(contact.ToString());
//    }

//    Console.WriteLine("------------------------");
//}


//var ensembleContactsGroupe = contacts
//                      .Select(c => new { NomComplet = c.Prenom + " " + c.Nom, c.Email })
//                      .GroupBy(c => c.Email.Substring(c.Email.IndexOf("@") + 1));

//foreach (var groupe in ensembleContactsGroupe)
//{
//    Console.WriteLine($"{groupe.Key} : {groupe.Count()}");
//    foreach (var contact in groupe)
//    {
//        Console.WriteLine($"{contact.NomComplet} - {contact.Email}");
//    }
//}
#endregion

#region Join Group Join
//var resultJoin = contacts.Join(rendezVous,
//                               c => new {c.Email, c.Nom}
//                               rdv => new {rdv.Email, rdv.Nom},
//                               (c, rdv) => new
//                               {
//                                   c.Email,
//                                   c.Nom,
//                                   c.Prenom,
//                                   DateRDV = rdv.Date

//                               }).GroupBy(c => c.Email);



//foreach (var groupe in resultJoin)
//{
//    Console.WriteLine($"{groupe.Key} : {groupe.Count()}");
//    foreach(var contact  in groupe)
//    {
//        Console.WriteLine($"Nom Complet : { contact.Nom} {contact.Prenom} - Email : {contact.Email} - Date RDV : {contact.DateRDV}");
//    }
//}

//var resultJoin = from c in contacts
//                 join rdv in rendezVous on c.Email equals rdv.Email
//                 select new
//                 {
//                     c.Email,
//                     c.Nom,
//                     c.Prenom,
//                     DateRDV = rdv.Date
//                 };


//foreach(var contact in resultJoin)
//{
//    Console.WriteLine($"Nom Complet : {contact.Nom} {contact.Prenom} - Email : {contact.Email} - Date RDV : {contact.DateRDV}");
//}


//Console.WriteLine("----------Group Join----------");

//var resultGroupJoin = contacts.GroupJoin(rendezVous,
//                                         c => c.Email,
//                                         rdv => rdv.Email,
//                                         (c, rdvs) => new
//                                         {
//                                             c.Nom,
//                                             c.Prenom,
//                                             c.Email,
//                                             RendezVous = rdvs

//                                         });

//foreach(var contact in resultGroupJoin)
//{
//    Console.WriteLine($"{contact.Nom} {contact.Prenom} - { contact.Email} :");
//    if (contact.RendezVous.Count() > 0)
//    {
//        foreach (RDV rdv in contact.RendezVous)
//        {
//            Console.WriteLine(rdv.Date);
//        }
//    }
//    else
//    {
//        Console.WriteLine("Aucun RDV");

//    }

//    Console.WriteLine();
//}
#endregion
