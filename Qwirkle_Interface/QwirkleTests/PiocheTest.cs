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
            Pioche LaPioche = new Pioche(new int[6,6] {{ 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 } });
            
            int[,] tab = new int[6, 6] { { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 } };

            for (int index1 = 0; index1 < 6; index1++)
            {
                for (int index2 = 0; index2 < 6; index2++)
                {
                    Assert.AreEqual(tab[index1,index2], LaPioche.Get_TuilesRestantes()[index1,index2]);
                }
            }

        }

        [TestMethod]
        public void TestComptage()
        {
            Pioche LaPioche = new Pioche(new int[6, 6] { { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 } });

            for (int index1 = 0; index1 < 6; index1++)
            {
                for (int index2 = 0; index2 < 6; index2++)
                {
                    Assert.AreEqual(108, LaPioche.Comptage(LaPioche.Get_TuilesRestantes()));
                }
            }
        }


        [TestMethod]
        public void TestAjout()
        {
            Pioche LaPioche = new Pioche(new int[6, 6] { { 3, 0, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 } });
            Assert.AreEqual(false, LaPioche.Ajout_tuile(0,0));
            Assert.AreEqual(3, LaPioche.Get_TuilesRestantes()[0,0]);
            Assert.AreEqual(true, LaPioche.Ajout_tuile(0,1));
            Assert.AreEqual(1, LaPioche.Get_TuilesRestantes()[0, 1]);
        }

        [TestMethod]
        public void TestSuppr()
        {
            Pioche LaPioche = new Pioche(new int[6, 6] { { 3, 0, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 }, { 3, 3, 3, 3, 3, 3 } });
            Assert.AreEqual(true, LaPioche.Suppr_tuile(0, 0));
            Assert.AreEqual(2, LaPioche.Get_TuilesRestantes()[0, 0]);
            Assert.AreEqual(false, LaPioche.Suppr_tuile(0, 1));
            Assert.AreEqual(0, LaPioche.Get_TuilesRestantes()[0, 1]);
        }
    }
}

