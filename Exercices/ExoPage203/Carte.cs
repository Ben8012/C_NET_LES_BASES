using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXP203
{
    internal struct Carte
    {

        public CarteValeur Valeurs;
        public CarteCouleur Couleurs;

        public Carte(CarteValeur valeurs, CarteCouleur couleurs)
        {
            Valeurs = valeurs;
            Couleurs = couleurs;
        }
    }
}
