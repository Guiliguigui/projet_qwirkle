using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    class TuileID
    {
        public string TuileNom(int FormeID, int CouleurID)
        {
            string Forme, Couleur;
            switch(FormeID)
            {
                case 1:
                    Forme = "Trefle";
                    break;
                case 2:
                    Forme = "Etoile";
                    break;
                case 3:
                    Forme = "Carre";
                    break;
                case 4:
                    Forme = "Losange";
                    break;
                case 5:
                    Forme = "Croix";
                    break;
                case 6:
                    Forme = "Rond";
                    break;
                default:
                    Forme = "";
                    break;
            }

            switch(CouleurID)
            {
                case 1:
                    Couleur = "Violet";
                    break;
                case 2:
                    Couleur = "Bleu";
                    break;
                case 3:
                    Couleur = "Vert";
                    break;
                case 4:
                    Couleur = "Jaune";
                    break;
                case 5:
                    Couleur = "Orange";
                    break;
                case 6:
                    Couleur = "Rouge";
                    break;
                default:
                    Couleur = "";
                    break;
            }

            return string.Format("{0}{1}", Forme, Couleur);
        }

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
                case "Violet":
                    CouleurID = 1;
                    break;
                case "Bleu":
                    CouleurID = 2;
                    break;
                case "Vert":
                    CouleurID = 3;
                    break;
                case "Jaune":
                    CouleurID = 4;
                    break;
                case "Orange":
                    CouleurID = 5;
                    break;
                case "Rouge":
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
