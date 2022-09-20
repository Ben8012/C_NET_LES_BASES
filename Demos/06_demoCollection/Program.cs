using System.Collections;

/*
 * Collections
 */

// ArrayList
// = Une liste classique

ArrayList maListe = new ArrayList();

Console.WriteLine(maListe.Count); // Output : 0 => Permet de renvoyer le nombre d'éléments d'une liste

// Array.Add(object? value)
maListe.Add("Quentin");
maListe.Add(12);
maListe.Add(true);
maListe.Add(new Random());
maListe.Add(new int[] { 4, 5, 5 });

Console.WriteLine($"Affichage comme un tableau : {maListe[0]}");

// Array.AddRange(Collection values)
maListe.AddRange(new ArrayList() { "Michel", "Dimitry", "Benjamin" });

// Parcourt de la liste
foreach ( var i in maListe )
{
    if ( i is int[] value )
    {
        Console.Write("[ ");
        foreach ( var item in value )
        {
            Console.Write($" {item} ");

        }
        Console.WriteLine(" ]");
    }

    else
    {
        Console.WriteLine(i);
    }
}

// ----------------------------------------------------------------------------------------------------

Console.Clear();

// HashTable
// = Permet d'enregistrer des clefs associées à des valeurs

Hashtable stagiaires = new Hashtable();

stagiaires.Add("96040327530", "Quentin");
stagiaires.Add("96040327531", "Quentin");
//stagiaires.Add("96040327530", "Quentin2"); // Ne fonctionne par doublon dans la clef
stagiaires.Add("98122645236", "Benjamin");

Console.WriteLine(stagiaires["96040327530"]);

stagiaires.Remove("123"); // Ne fait rien 

Console.Clear();

// Queue
// FIFO = First IN First Out
// File d'attente

Queue fileAttente = new Queue();

fileAttente.Enqueue("Michel");
fileAttente.Enqueue("Seifallah");
fileAttente.Enqueue("Thomas");
fileAttente.Enqueue("Ryan");

Console.WriteLine(fileAttente.Count); // Output : 4

Console.WriteLine(fileAttente.Peek());
Console.WriteLine(fileAttente.Peek());
Console.WriteLine(fileAttente.Peek());
Console.WriteLine(fileAttente.Peek());

int nbClients = fileAttente.Count;

for ( int i = 0; i < nbClients; i++ )
{
    Console.WriteLine("C'est au tour de " + fileAttente.Dequeue());
    Console.WriteLine($"Il reste {fileAttente.Count} client(s) en attente.");
}

Console.WriteLine(fileAttente.Count); // Output : 0

// Stack
// LIFO = Last In First Out
// Pile d'assiettes

Console.Clear();

Stack pileAssiettes = new Stack();

pileAssiettes.Push("Assiette 1");
pileAssiettes.Push("Assiette 2");
pileAssiettes.Push("Assiette 3");
pileAssiettes.Push("Assiette 4");

Console.WriteLine(pileAssiettes.Count); // Output : 4

Console.WriteLine(pileAssiettes.Peek()); // Output : Assiette 4
Console.WriteLine(pileAssiettes.Peek()); // Output : Assiette 4
Console.WriteLine(pileAssiettes.Peek()); // Output : Assiette 4
Console.WriteLine(pileAssiettes.Peek()); // Output : Assiette 4

int nbAssiettes = pileAssiettes.Count;

for ( int i = 0; i < nbAssiettes; i++ )
{
    string assiette = (string) pileAssiettes.Pop();
    Console.WriteLine("Lavage de " + assiette);
}

Console.WriteLine("Lavage terminé.");

Console.WriteLine(pileAssiettes.Count); // Output : 0
