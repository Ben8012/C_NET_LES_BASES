/*
 * Calculer les 25 premiers nombres de la suite de Fibonacci
 */

int nb1 = 0, nb2 = 1, temp;

Console.Write(nb1);

for ( int i = 0; i < 25; i++ )
{
    Console.Write($", {nb2}");

    temp = nb1 + nb2;
    nb1 = nb2;
    nb2 = temp;
}