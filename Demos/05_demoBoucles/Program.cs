/*
 * Boucles
 */

// For (Pour)
#region Boucle FOR

//Console.WriteLine("Entrez le nombre de côtes : ");

//if ( int.TryParse(Console.ReadLine(), out int nbCotes) )
//{
//	int sum = 0;
//	double average;
//	// for → →
//	// Initialisation ; Condition ; Incrémentation
//	for ( int i = 0; i < nbCotes; i++ )
//	{
//		Console.WriteLine($"Entrez la côte de l'élève n°{i + 1} : ");
//		sum += int.Parse(Console.ReadLine());
//	}

//	average = (double) sum / nbCotes;

//	Console.WriteLine($"La moyenne de la classe est de {average:00.00}");

//}

#endregion

#region WHILE

//Console.WriteLine("ENtrez une valeur numérique :");
//string userInput = Console.ReadLine();

//while (!int.TryParse(userInput, out _) )
//{
//	Console.WriteLine("Mauvaise entrée ! Réessayez :");
//	userInput = Console.ReadLine();
//}

//Console.WriteLine("La valeur est correcte");

// Optimisé

Console.WriteLine("Entrez une valeur numérique :");

while ( !int.TryParse(Console.ReadLine(), out _) )
{
    Console.WriteLine("Mauvaise entrée ! Réessayez :");
}

Console.WriteLine("La valeur est correcte");

#endregion

#region Boucle Do ... While

do
{
    Console.WriteLine("Entrez une valeur numérique :");

} while ( !int.TryParse(Console.ReadLine(), out _) );

#endregion