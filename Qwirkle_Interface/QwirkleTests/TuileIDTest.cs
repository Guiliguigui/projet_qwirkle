using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleLibrary;

namespace QwirkleTests
{
    [TestClass]
    public class TuileIDTest
    {
        [TestMethod]
        public void TestTuileNom()
        {
            Assert.AreEqual("TrefleViolet", TuileID.TuileNom(1, 1));
        }

        [TestMethod]
        public void TestForme()
        {
            Assert.AreEqual(2, TuileID.TuileForme("EtoileBleu"));
        }

        [TestMethod]
        public void TestCouleur()
        {
            Assert.AreEqual(6, TuileID.TuileCouleur("CarréRouge"));
        }

        [TestMethod]
        public void TestMemeForme()
        {
            Assert.AreEqual(true, TuileID.MemeForme("CarréRouge", "CarréBleu"));
            Assert.AreEqual(false, TuileID.MemeForme("RondRouge", "CarréBleu"));
        }

        [TestMethod]
        public void TestMemeCouleur()
        {
            Assert.AreEqual(true, TuileID.MemeCouleur("CarréRouge", "EtoileRouge"));
            Assert.AreEqual(false, TuileID.MemeCouleur("CarréBleu", "RondRouge"));
        }
    }
}
