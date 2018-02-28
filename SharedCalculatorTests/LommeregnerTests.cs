using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharedCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedCalculator.Tests
{
    [TestClass()]
    public class LommeregnerTests
    {
        [TestMethod()]
        public void PlusTest()
        {
            //Arrange
            // Lommeregner lommeregner = new Lommeregner(); Behøves ikke, da metoder er static

            //Act 
            double resultat = Lommeregner.plus(5, 5);
            double expectedValue = 10;

            //Assert
            Assert.AreEqual(resultat, expectedValue);
        }

        [TestMethod()]
        public void minusTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void gangeTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void divisionTest()
        {
            Assert.Fail();
        }
    }
}