using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QwirkleLibrary
{
    public class Joueur
    {
        private string name;
        private int points;
        private int numero; //Ceci à été ajouté pour pouvois gérer les tours de joueurs qui jouent et n'apparait pas dans le diagramme de classe.

        public Joueur(string name, int points, int numero)
        {
            this.name = name;
            this.points = points;
            this.numero = numero;
        }

        public string Get_name()
        {
            return name;
        }

        public void Set_name(string name)
        {
            this.name = name;
        }

        public int Get_points()
        {
            return points;
        }

        public void Set_points(int points)
        {
            this.points = points;
        }

        public int Get_numero()
        {
            return numero;
        }

        public void Set_numero(int numero)
        {
            this.numero = numero;
        }

    }
}
