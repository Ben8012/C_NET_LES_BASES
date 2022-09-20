/*
 * Tableaux orthogonaux
 */

int[][] entiers = new int[4][];

entiers[0] = new int[2];
entiers[1] = new int[5];
entiers[2] = new int[1];
entiers[3] = new int[3];

entiers[0][0] = 1;
entiers[0][1] = 1;

entiers[1][0] = 2;
entiers[1][1] = 2;
entiers[1][2] = 2;
entiers[1][3] = 2;
entiers[1][4] = 2;

entiers[2][0] = 3;

entiers[3][0] = 4;
entiers[3][1] = 4;
entiers[3][2] = 4;

Console.WriteLine(entiers.Length); // Output : 4 => nombre d'éléments dans le tableau
Console.WriteLine(entiers[0].Length); // Output : 2 => nombre d'éléments dans le tableau à l'indice 0
Console.WriteLine(entiers[1].Length); // Output : 5 => nombre d'éléments dans le tableau à l'indice 1
Console.WriteLine(entiers[2].Length); // Output : 1 => nombre d'éléments dans le tableau à l'indice 2
Console.WriteLine(entiers[3].Length); // Output : 3 => nombre d'éléments dans le tableau à l'indice 3


for ( int ligne = 0; ligne < entiers.Length; ligne++ )
{
    Console.WriteLine($"Ligne n°{ligne + 1} :");

    for ( int colonne = 0; colonne < entiers[ligne].Length; colonne++ )
    {
        Console.WriteLine($"Colonne n°{colonne + 1} : {entiers[ligne][colonne]}");
    }

    Console.WriteLine();
}