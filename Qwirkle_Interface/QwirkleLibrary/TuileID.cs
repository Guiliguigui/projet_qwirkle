using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    class TuileID
    {
        public int TuileValue(string tuile)
        {
            int Forme=1, Couleur=1;
            switch(tuile)
            {
                case "Trefle" :
                    Forme = 1;
                    break;

            }
            return Forme+Couleur;
        }
    }
}
