using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QwirkleLibrary;

namespace QwirkleTests
{
    [TestClass]
    public class PiocheTest
    {
        [TestMethod]
        public void TestPiocheConstructor()
        {
            Pioche LaPioche = new Pioche(int[,] tab_TuilesRestantes);

            Assert.AreEqual({ { 3,3,3,3,3,3},{ 3,3,3,3,3,3},{ 3,3,3,3,3,3},{ 3,3,3,3,3,3},{ 3,3,3,3,3,3},{ 3,3,3,3,3,3}}, Lapioche.tab_TuilesRestantes);

        }
    }
}
