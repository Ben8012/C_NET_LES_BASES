using EXP203;

namespace EXP203
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            Carte[] cartes = new Carte[52];

            Console.WriteLine("boucle sur enum");
            Console.WriteLine();
            int i = 0;
            foreach (CarteCouleur carteCouleur in (CarteCouleur[]) Enum.GetValues(typeof(CarteCouleur)))
            {
               
                Console.WriteLine($" Les {carteCouleur} : ");
                Console.WriteLine("-------------");
                foreach (CarteValeur carteValeur in (CarteValeur[])Enum.GetValues(typeof(CarteValeur)))
                {
                    Console.WriteLine($"{carteValeur} DE {carteCouleur}");
                    // en utilisant le constructeur
                    cartes[i++] = new Carte(carteValeur, carteCouleur); 

                    // sans le constructeur 
                    //cartes[i].Valeurs = carteValeur;
                    //cartes[i].Couleurs = carteCouleur;
                    //i++;
                }
                Console.WriteLine();
            }
     
            Console.WriteLine("boucle sur tableau");
            Console.WriteLine("-------------------");
            for (int k = 0; k < cartes.Count(); k++)
            {
                if (k % (cartes.Count() / Enum.GetValues(typeof(CarteCouleur)).Length) == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($" Les { cartes[k].Couleurs }");
                    Console.WriteLine("-------------");
                }
                  
                Console.WriteLine($"{cartes[k].Valeurs} DE {cartes[k].Couleurs}");
            }

            ///// autre maniere de boucler
            //foreach (Carte carte in cartes)
            //{
            //    Console.WriteLine($"{carte.Valeurs} DE {carte.Couleurs}");
            //}
        }
    }
}
