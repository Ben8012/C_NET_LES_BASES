// Conversion


// Type Valeur → String
int a = 5;

Console.WriteLine($"{a} {a.GetType()}");
Console.WriteLine($"{a.ToString()} {a.ToString().GetType()}");

// String → Type Valeur
// 3 façons de faire
// - Classe Convert
// - Méthode Parse()
// - Méthode TryParse()

// ---- CONVERT ----
string b = "5";

int bConverted = Convert.ToInt32(b);

Console.WriteLine($"{b} {b.GetType()}");
Console.WriteLine($"{bConverted} {bConverted.GetType()}");

// ---- PARSE ----

string c = "7";

int cConverted = int.Parse(c);
Console.WriteLine($"{c} {c.GetType()}");
Console.WriteLine($"{cConverted} {cConverted.GetType()}");

// ---- TRYPARSE ----

string d = "42a";
//int dConverted;

bool success = int.TryParse(d, out int dConverted);

Console.WriteLine(success);

Console.WriteLine(dConverted);

if (int.TryParse(d, out int dConverted2))
{
    Console.WriteLine("Conversion réussie, valeur : " + dConverted2);
}
else
{
    Console.WriteLine("Conversion échouée, valeur: " + dConverted2);
}
