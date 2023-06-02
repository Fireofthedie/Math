using MathLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMath
{
    [TestClass]
    public class TrigonometryTest
    {
        [TestMethod]
        public void Sinac8ab4S2()
        {
            //Arrange
            string ac = "8";
            string ab = "4";
            double S = 2;
            //Add
            double res = Trigonometry.Sin(ac, ab);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void Sinac4ab8S0_5()
        {
            //Arrange
            string ac = "4";
            string ab = "8";
            double S = 0.5;
            //Add
            double res = Trigonometry.Sin(ac, ab);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void Sinac3ab2S1_5()
        {
            //Arrange
            string ac = "3";
            string ab = "2";
            double S = 1.5;
            //Add
            double res = Trigonometry.Sin(ac, ab);
            //Assert
            Assert.AreEqual(S, res);
        }
    }
}
