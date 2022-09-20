/*
 * Calcule de la division entière, du modulo et de la division de deux entiers.
 * Résultat attendu pour 5 et 2 :
 *  • Division entière : 2, 
 *  • Modulo : 1, 
 *  • Division : 2,5.
 */

// Récupération des entiers
Console.WriteLine("Entrez le premier nombre :");
if ( int.TryParse(Console.ReadLine(), out int nb1) )
{
    Console.WriteLine("Entrez le deuxième nombre :");
    if ( int.TryParse(Console.ReadLine(), out int nb2) )
    {
        Console.WriteLine($"Division entière : { nb1 / nb2 }");
        Console.WriteLine($"Modulo : { nb1 % nb2 }");
        Console.WriteLine($"Division : { (double) nb1 / nb2 }");
    }
}
