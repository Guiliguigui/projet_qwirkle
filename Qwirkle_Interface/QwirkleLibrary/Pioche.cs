using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    class Pioche
    {
        private int[,] tab_TuilesRestantes = new int[6, 6];
        /*
         * Un tableau permettant de compter combien il reste de chacune des tuiles dans la pioche (il en existe 3 de chaque de base),
         * Il est disposé Dans cet ordre:
         * En Lignes : Violet, Bleu, Vert, Jaune, Orange et Rouge
         * En Colones : Trefle, Etoile, Carré, Losange, Croix, Rond
        */

        public Pioche(int[,] tab_TuilesRestantes)
        {
            this.tab_TuilesRestantes = tab_TuilesRestantes;
        }

            public bool Suppr_tuile(int couleur, int forme) //Si il est possible de retirer une tuile de la pioche, la fonction renvoie true, si il n'en reste plus elle renvoie false
        {
            if (this.tab_TuilesRestantes[couleur, forme] > 0)
            {
                this.tab_TuilesRestantes[couleur, forme] = this.tab_TuilesRestantes[couleur, forme] - 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Ajout_tuile(int couleur, int forme) //Si il est possible d'ajouter une tuile dans la pioche, la fonction renvoie true, en cas d'échec elle renvoie false
        {
            if (this.tab_TuilesRestantes[couleur, forme] < 3)
            {
                this.tab_TuilesRestantes[couleur, forme] = this.tab_TuilesRestantes[couleur, forme] + 1;
                return true;
            }
            else
            {
                
                return false;
            }
        }
    }
}
