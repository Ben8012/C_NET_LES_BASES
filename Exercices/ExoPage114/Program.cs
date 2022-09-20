/*
 * Demander à l’utilisateur d’encoder 1 nombre (int), si la somme des deux moitiés 
 * de celui-ci donne le nombre, afficher « le nombre est paire »
 * sinon « le nombre est impaire ».
 */

Console.WriteLine("Entrez un nombre: ");
if ( int.TryParse(Console.ReadLine(), out int number) )
{
    if ( ( number / 2 ) * 2 == number ) Console.WriteLine($"Le nombre {number} est pair.");
    else Console.WriteLine($"Le nombre {number} est impair.");
}
else Console.WriteLine("L'entrée de l'utilisateur n'est pas un nombre entier.");
