using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethodes
{
    public class Methodes
    {
        //fonction qui retourne un int
        //avec b comme paramètre optionnel
        public int Addition(int a, int b = 3)
        {
            return a + b;
        }
        //surcharge de la fonction addition avec params
        //pour rentrer autant de paramètre que l'on veut
        public int Addition(params int[] n)
        {
            int sum = 0;
            foreach (int i in n)
            {
                sum += i;
            }
            return sum;
        }
        //création d'une procédure static
        public static void showAndFillTab(int[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = 2;
                    Console.Write(tab[i, j]);
                }
                Console.WriteLine();
            }
        }


    }
}
