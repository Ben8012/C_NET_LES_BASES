using System.Reflection.PortableExecutable;

List<int> PrimeNumbers = new List<int>();
int testNumber = 3;
int divCount;
double square;
if (int.TryParse(Console.ReadLine(), out int limit))
{
    PrimeNumbers.Add(2);

    while (PrimeNumbers.Count < limit)
    {
        square = Math.Pow(testNumber, 0.5);
        divCount = 0;
        while (PrimeNumbers[divCount] <= square && testNumber % PrimeNumbers[divCount] != 0)
        {
            divCount++;
        }
        if (testNumber % PrimeNumbers[divCount] != 0)
        {
            PrimeNumbers.Add(testNumber);
        }
        testNumber += 2;
    }
    foreach (int prime in PrimeNumbers)
    {
        Console.WriteLine(prime);
    }
}