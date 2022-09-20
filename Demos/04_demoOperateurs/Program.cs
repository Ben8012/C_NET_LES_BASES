/*
 * Opérateurs
 */

// Post/Pré-incrémentation (décrémentation)

int i = 0;

while ( i < 20 )
{
    Console.WriteLine($"La valeur de i vaut {i++}.");
}

// Ternary operator

Console.WriteLine(( false ) ? "OK" : "KO");

if ( false ) { Console.WriteLine("OK"); }
else { Console.WriteLine("KO"); }

// Opérateur coalesce
string message = null, message2 = "Ceci est mon message";

//message = message ?? message2 ?? "Valeur par défaut";

Console.WriteLine(message);

string login = null;

login ??= "admin"; // login = login ?? "admin";

string estPossible = null;

estPossible ??= message ?? "Ma valeur par défaut";

Console.WriteLine("estPossible: " + estPossible);

// Typeof()

object o = 5L; // Boxing (type valeur dans type référence)

Type typeVariable = typeof(object);
Type typeValeur = o.GetType();

Console.WriteLine(typeVariable); // Type de la variable (déclarée)
Console.WriteLine(typeValeur); // Type de la valeur de la variable

if ( typeVariable == typeValeur ) Console.WriteLine("Ils sont du même type.");
else Console.WriteLine($"o n'est pas un type {typeVariable} mais est de type {typeValeur}");

// Opérateur "is"

object obj1 = 5;

if ( obj1 is decimal )
{
    Console.WriteLine("obj est de type décimal");
}
else if ( obj1 is float )
{
    Console.WriteLine("obj est de type float");
}
else Console.WriteLine("Type non reconnu");


// Pattern matching

object obj = 5M;

if ( obj is decimal dec )
{
    Console.WriteLine($"{dec} {dec.GetType()} est de type décimal");

}
else if ( obj is float flo )
{
    Console.WriteLine($"{flo} est de type float");
}
else Console.WriteLine("Type non reconnu");


// Opérateur checked

int x = int.MaxValue;
int y = unchecked(x + 1);
//int y = checked(x + 1);
//int y = x + 1;

Console.WriteLine(y);