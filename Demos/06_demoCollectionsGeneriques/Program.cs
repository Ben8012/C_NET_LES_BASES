/*
 * Collections Génériques
 */

// ArrayList => List<Type>
// Hashtable => Dictionary<Type>
// Queue => Queue<Type>
// Stack => Stack<Type>

// List<T>
List<string> students = new List<string>();

students.Add("Jérémie");
students.Add("Ludivic");
students.Add("Dimitry");

Console.WriteLine("Liste des élèves");

foreach ( string student in students )
{
    Console.WriteLine(" - " + student);
}

// Dictionary<T, U>
Console.Clear();

Dictionary<string, string> dictionnaire = new Dictionary<string, string>();

dictionnaire.Add("Csharp", "Magnifique langage");
dictionnaire.Add("HTML", "Squellette web");
dictionnaire.Add("CSS", "Style de la page");
dictionnaire.Add("JavaScript", "Dynamiser la page");
//dictionnaire.Add(42, "Le nombre 42"); // Ne fonctionne par ne respecte pas le type de la clef

foreach ( KeyValuePair<string, string> entree in dictionnaire )
{
    Console.WriteLine($"## {entree.Key} ##");
    Console.WriteLine($"{entree.Value}");
}

