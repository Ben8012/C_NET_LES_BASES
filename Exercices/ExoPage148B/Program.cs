/*
 * Calculer la factorielle d’un nombre entré au clavier.
 */


Console.WriteLine("Entrez un à mettre à la factorielle : ");
int number = int.Parse(Console.ReadLine());
long result = 1;

for ( int i = number; i > 1; i-- )
{
    result *= i;
}

Console.WriteLine($"La factorielle de {number} vaut {result}");