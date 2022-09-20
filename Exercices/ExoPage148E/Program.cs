/*
 * À l’aide d’une boucle « for » comptez de 0, à 20,0 en augmentant de 0,1, 
 * en utilisant des doubles, et afficher la valeur à chaque itération.
 * Remarquez-vous quelque chose de particulier ?
 */

for ( double i = 0; i <= 20.1; i += 0.1 )
{
    Console.WriteLine($"{i:0.0}");
}

for ( decimal i = 0; i <= 20; i += 0.1M )
{
    Console.WriteLine($"{i}");
}