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
            Joueur Joueur_1 = new Joueur("Louis", 0, 1);
            
            Assert.AreEqual("Louis", Joueur_1.Get_name());
            Assert.AreEqual(0, Joueur_1.Get_points());
            Assert.AreEqual(1, Joueur_1.Get_numero());
        }
    }
}
