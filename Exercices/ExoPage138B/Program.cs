/*
 * Vérification d’un compte bancaire BBAN, 
 * si le compte est bon affichez OK sur la console sinon KO.
 * Le modulo des 10 premiers chiffres par 97 donne les 2 derniers. 
 * Sauf si le modulo = 0 dans ce cas les 2 derniers chiffres sont 97.
 * (utilisez la méthode « Substring » de la classe « string »).
 */

// 3224418142 14
// -2^31 à 2^31 - 1

Console.WriteLine("Entrez un code BBAN sans tiret :");
string bban = Console.ReadLine();

// Découpe du numéro
string tenFirst = bban.Substring(0, 10);
string twoLast = bban.Substring(10, 2);

// Conversion des numéros en valeur numérique
long tenNumber = long.Parse(tenFirst);
short twoNumber = short.Parse(twoLast);

// Vérification
if ( tenNumber % 97 == twoNumber || tenNumber % 97 == 0 && twoNumber == 97 )
    Console.WriteLine("OK");
else
    Console.WriteLine("KO");



// OU

Console.WriteLine(
    tenNumber % 97 == twoNumber || 
    tenNumber % 97 == 0 && twoNumber == 97
    ? "OK" : "KO");