using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    class TuileID
    {
        public int TuileForme(string tuile)
        {
            int i=1;
            int FormeID;
            string Forme;
            char sepa;
            
            while (tuile[i] != char.ToUpper(tuile[i]))
            {
                i++;
            }
            sepa = tuile[i];

            Forme = tuile.Split(sepa)[0];

            tuile.Split(sepa);

            switch (Forme)
            {
                case "Trefle":
                    FormeID = 1;
                    break;
                case "Etoile":
                    FormeID = 2;
                    break;
                case "Carré":
                    FormeID = 3;
                    break;
                case "Losange":
                    FormeID = 4;
                    break;
                case "Croix":
                    FormeID = 5;
                    break;
                case "Rond":
                    FormeID = 6;
                    break;
                default:
                    FormeID = 0;
                    break;
            }
            
            return FormeID;
        }

        public int TuileCouleur(string tuile)
        {
            int i = 1;
            int CouleurID;
            string Couleur;
            char sepa;

            while (tuile[i] != char.ToUpper(tuile[i]))
            {
                i++;
            }
            sepa = tuile[i-1];

            Couleur = tuile.Split(sepa)[0];

            tuile.Split(sepa);

            switch (Couleur)
            {
                case "Trefle":
                    CouleurID = 1;
                    break;
                case "Etoile":
                    CouleurID = 2;
                    break;
                case "Carré":
                    CouleurID = 3;
                    break;
                case "Losange":
                    CouleurID = 4;
                    break;
                case "Croix":
                    CouleurID = 5;
                    break;
                case "Rond":
                    CouleurID = 6;
                    break;
                default:
                    CouleurID = 0;
                    break;
            }

            return CouleurID;
        }
    }
}
