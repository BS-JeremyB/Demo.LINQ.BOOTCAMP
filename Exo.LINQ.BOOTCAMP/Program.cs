using Exo.LINQ.BOOTCAMP;

List<Contact> contacts = new List<Contact>
{
    new Contact {Nom = "Doe", Prenom = "John", Email = "johndoe@gmail.com", AnneeInscription = 2025},
    new Contact {Nom = "Doe", Prenom = "Jane", Email = "johndoe@yahoo.com", AnneeInscription = 2020},
    new Contact {Nom = "Smith", Prenom = "John", Email = "johnsmith@yahoo.com", AnneeInscription = 2010},
    new Contact {Nom = "McFly", Prenom = "Marty", Email = "martymcfly@gmail.com", AnneeInscription = 1985},
};


foreach (Contact contact in contacts)
{
    Console.WriteLine($"{contact.Prenom} | {contact.Nom} | {contact.Email} | {contact.AnneeInscription}");
}


var contactsAnon = from contact in contacts
                   select new { NomComplet = contact.NomComplet() , EmailUpdate = contact.ToUpdateMail()};

foreach (var contactAnon in contactsAnon)
{
    Console.WriteLine($"{contactAnon.NomComplet} | {contactAnon.EmailUpdate}" );
}


