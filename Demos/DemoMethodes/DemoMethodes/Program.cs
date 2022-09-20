using DemoMethodes;

//Instanciation de la class methode
Methodes met = new Methodes();

int[,] tab = new int[5, 5];

// Appel de methode static
Methodes.showAndFillTab(tab);

// Appel de methode non static
int result = met.Addition(5,3,5,9,6,3,5,2,5,8,6);
Console.WriteLine(result);

