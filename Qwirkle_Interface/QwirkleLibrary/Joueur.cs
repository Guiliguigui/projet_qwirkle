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
        private int[] main;

        public Joueur(string name, int points, int numero, int[] main)
        {
            this.name = name;
            this.points = points;
            this.numero = numero;
            this.main = main;
        }

        public string Get_name()
        {
            return name;
        }

        public int [] Get_main()
        {
            return main;
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

        public void Set_main(int[] main)
        {
            this.main = main;
        }

    }
}
