/*
 * Grâce à une boucle « for », calculez les x premiers nombre premier.
 */

Console.WriteLine("Combien de nombres premiers voulez-vous :");
int userNumber = int.Parse(Console.ReadLine());
int primesFound = 0;

// 1 n'est pas un nombre premier => commence à 2

for ( int numberToAnalyze = 2;  primesFound < userNumber; numberToAnalyze++ )
{
	bool isPrimeNumber = true;

	for ( int div = 2; div < numberToAnalyze; div++ )
	{
		if ( numberToAnalyze % div == 0 ) isPrimeNumber = false;
	}

	if ( isPrimeNumber )
	{
		primesFound++;
		Console.WriteLine($"{primesFound} : {numberToAnalyze}");
	}

}
