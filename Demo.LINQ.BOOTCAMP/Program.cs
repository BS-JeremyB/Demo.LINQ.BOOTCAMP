using Demo.LINQ.BOOTCAMP;
Func<Utilisateur, string> Pres = x => {
    x.Prenom = x.Prenom.ToUpper();
    x.Nom = x.Nom.ToUpper();
    return ($"{x.Prenom} {x.Nom}");
};

List<Utilisateur> utilisateurs = new List<Utilisateur>
{
    new Utilisateur{ Nom = "Doe", Prenom = "John", Email = "johndoe@mail.com", Age=36 },
    new Utilisateur{ Nom = "Doe", Prenom = "Jane", Email = "janedoe@mail.com", Age=30 },
    new Utilisateur{ Nom = "Smith", Prenom = "John", Email = "johnsmith@mail.com", Age=30 },
};

//foreach (Utilisateur utilisateur in utilisateurs)
//{
//    Console.WriteLine(Pres(utilisateur));
//}


//var utilisateursAnon = from Utilisateur utilisateur in utilisateurs
//                       select new { NomComplet = utilisateur.Prenom + " " + utilisateur.Nom, Mail = utilisateur.Email };


//foreach (var utilisateur in utilisateursAnon)
//{
//    Console.WriteLine($"{utilisateur.NomComplet}, à contacter sur {utilisateur.Mail}");


//}

//string phrase = "Hello à tous !";

//Console.WriteLine(phrase.toCapitalize());


IEnumerable<Utilisateur> utilisateurFiltre = utilisateurs.Where(u => u.Prenom.Contains("John"));

foreach(Utilisateur utilisateur in utilisateurFiltre)
{
    Console.WriteLine(utilisateur.Prenom + " " + utilisateur.Nom);
}

