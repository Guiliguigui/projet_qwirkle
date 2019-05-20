using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleLibrary;

namespace QwirkleTests
{
    [TestClass]
    public class JoueurTest
    {
        [TestMethod]
        public void TestJoueurConstructor()
        {
            Joueur Joueur_1 = new Joueur("Louis", 0, 1, new string[6] { "vide", "vide","vide","vide","vide","vide" });
            string[] tab = new string[6] { "vide", "vide", "vide", "vide", "vide", "vide" };


            Assert.AreEqual("Louis", Joueur_1.Get_name());
            Assert.AreEqual(0, Joueur_1.Get_points());
            Assert.AreEqual(1, Joueur_1.Get_numero());
            for (int index = 0; index < 6; index++)
            {
                Assert.AreEqual(tab[index], Joueur_1.Get_main()[index]);
            }
        }
    }
}
