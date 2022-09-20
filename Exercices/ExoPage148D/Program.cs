/*
 * A l’aide de boucles « for » afficher les 5 premières tables de multiplication en 
 * allant jusque « x20 ».
 * 1x1 = 1 ; 2x1 = 2 ; ……
 * 2x1 = 2 ; 2x2 = 4 ; ……
 */

for ( int table = 1; table <= 5; table++ )
{
    Console.WriteLine("La table de " + table);

	for ( int number = 1; number <= 20; number++ )
	{
		Console.WriteLine($"{number} x {table} = {number * table}");
	}

	Console.WriteLine();
}