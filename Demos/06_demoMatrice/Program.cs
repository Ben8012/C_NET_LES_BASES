string[,] groupes =
{
    //  col 0,   col 1         col 2
    { "Michel", "Seifallah", "Thomas" }, // Ligne 0
    { "Ryan", "Jérémie", "Ludivic" }, // Ligne 1
    { "Jean", "Dimitry", "Delphine" }, // Ligne 2
    { "Benjamin", "Paul", "Yves" }, // Ligne 3
    { "Nouveau 1", "Nouveau 2", "Nouveau 3" }
};

// Ligne, colonne
Console.WriteLine(groupes[0, 1]);

//string prenom = "Quentin";
//Console.WriteLine(prenom[0]); // Output : "Q"

Console.WriteLine(groupes[1, 1][0]); // Output : "J" => "Jérémie"
Console.WriteLine(groupes[1, 1].Substring(0, 1)); // Output : "J" => "Jérémie"

Console.WriteLine(groupes.Length); // Output : 12 => Permet de récupérer le nombre d'éléments TOTAL
Console.WriteLine(groupes.Rank); // Output : 2 => Nombre de dimension d'un tableau
Console.WriteLine(groupes.GetLength(0)); // Output : 4 => Nombre d'élément dans la dimension 0
Console.WriteLine(groupes.GetLength(1)); // Output : 3 => Nombre d'élément dans la dimension 1



for ( int ligne = 0; ligne < groupes.GetLength(0) ; ligne++ )
{
    Console.WriteLine($"Groupe n°{ligne + 1}");

    for ( int colonne = 0; colonne < groupes.GetLength(1); colonne++ )
    {
        Console.WriteLine(groupes[ligne, colonne]);
    }

    Console.WriteLine();
}
