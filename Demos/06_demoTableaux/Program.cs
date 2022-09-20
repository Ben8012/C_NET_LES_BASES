/*
 * 06 Tableaux
 */

// Déclaration d'un tableau
int[] entiers = new int[5];
Console.WriteLine(entiers[0]);

// Déclaration et initialisation
bool[] bools = { false, true, true, false };

string[] mots = new string[10];
Console.WriteLine($"\"{mots[0]}\"");
Console.WriteLine($"\"{mots[1]}\"");
Console.WriteLine($"\"{mots[2]}\"");

// Affectation d'une valeur dans le tableau
entiers[0] = 5;

Console.WriteLine(entiers.Length);
Console.WriteLine(mots.Length);

// --- 

int i = 0;

while ( i < entiers.Length )
{
    entiers[i] = new Random().Next();
    Console.WriteLine(entiers[i]);
    i++;
}

// ----

Console.WriteLine("Foreach");

foreach ( int nombre in entiers )
{
    Console.WriteLine($"{nombre} est {( nombre % 2 == 0 ? "pair" : "impair" )}");
}