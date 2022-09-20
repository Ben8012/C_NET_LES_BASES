
// Mettre un commentaire single line


/*
 * Commentaire
 * Multi
 * ligne
 * 
 */

// Pour mettre en commentaire avec un raccourci : CTRL + K, CTRL + C
// Pour retirer le commentaire avec un raccourci : CTRL + K, CTRL + U

// Demonstration sur les entrées et sorties

// Pour écrire quelque chose en console: Console.WriteLine(valeur)

// Ecrire sur une ligne sans retourner à la ligne
Console.Write("Hello");
Console.Write("World !");

// Retour à la ligne sans valeur à l'intérieur
Console.WriteLine();

// Écrire sur une ligne avec retour à la ligne
Console.WriteLine("Hello");
Console.WriteLine("World !");

// Raccourci d'écriture : cw → →
Console.WriteLine();

// Afficher le contenu d'une variable
string prenom = "Quentin";
Console.WriteLine(prenom);

// Afficher le contenu d'une variable avec un autre contenu
// + : concaténation : coller deux valeurs ensemble
Console.WriteLine("Bonjour " + prenom);

Console.WriteLine(
    "Bonjour {0}, j'ai {1} ans. Mon n° de tel est {2}. Ah, salut {0}"
    , prenom
    ,
    26
    , 0123456789
);

// String interpolation
Console.WriteLine($"Bonjour {prenom}");

// Lecture du clavier (entrée)

Console.Write("Entrez votre nom : ");
string nom = Console.ReadLine();

Console.WriteLine($"Votre nom est {nom}");

Console.WriteLine("Entre votre année de naissance : ");
//int age = Console.ReadLine();


// Nettoyer la console

Console.Clear();
Console.WriteLine("Nettoyage terminé.");
