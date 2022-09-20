/*
 * En utilisant la méthode « Console.ReadLine() »
 *  ◼ Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, 
 *    la conversion devra utiliser la méthode « int.Parse() »
 *  ◼ Demander à l’utilisateur d’encoder 2 nombres (int) et d’en faire l’addition, 
 *    la conversion devra utiliser la méthode « int.TryParse() »
*/

// Valeur par défaut d'un entier : 0

// 1. Parse()

Console.WriteLine("\nParse() :\n");
Console.WriteLine("Entrez un premier nombre : ");
string nb1String = Console.ReadLine();

Console.WriteLine("Entrez un deuxième nombre : ");
string nb2String = Console.ReadLine();

int nb1 = int.Parse(nb1String);
int nb2 = int.Parse(nb2String);

int total = nb1 + nb2;

Console.WriteLine($"{nb1} + {nb2} = {total}");

// 2. TryParse()

Console.WriteLine("\nTryParse() :\n");
Console.WriteLine("Entrez un premier nombre : ");
string nb1S = Console.ReadLine();

Console.WriteLine("Entrez un deuxième nombre : ");
string nb2S = Console.ReadLine();

bool success1 = int.TryParse(nb1S, out int n1);
bool success2 = int.TryParse(nb2S, out int n2);

int total2 = n1 + n2;

Console.WriteLine($"{n1} + {n2} = {total2}");
