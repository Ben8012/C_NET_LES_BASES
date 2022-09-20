/*
 * Transformer un compte bancaire BBAN Belge (xxx-xxxxxxx-xx) 
 * en IBAN (BExx-xxxx-xxxx-xxxx). 
 * Trouvez la démarche via un moteur de recherche.
 */

// https://thebasementgeek.wordpress.com/2011/03/01/calculate-iban-numbers-from-a-belgian-bank-account-number/

Console.WriteLine("Entrez le BBAN : ");
string bban = Console.ReadLine().Replace("-", "");

string twoLast = bban.Substring(10, 2);

string code = twoLast + twoLast + 111400;

long codeNumber = Convert.ToInt64(code);

short calculatedNumbers = (short) ( 98 - ( codeNumber % 97 ) );

string formatedIBAN = "BE" + ( ( calculatedNumbers < 10 ) ? "0" + calculatedNumbers.ToString() : calculatedNumbers ) + bban.ToString();

// Permet de formater une valeur numérique
string formatedIBAN2 =  $"{1502.66666:00.00}";

Console.WriteLine($"Le code BBAN {bban} vaut en IBAN {formatedIBAN}");
Console.WriteLine($"{formatedIBAN2}");
