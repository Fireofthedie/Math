using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathLibrary1;

namespace TestMath
{
    [TestClass]
    public class GemetryClassTest
    {
        [TestMethod]
        public void SRectanglea4b7S28()
        {
            //Arrange
            string a = "4";
            string b = "7";
            double S = 28;
            //Add
            double res=GeometryClass1.SRectangle(a, b);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void SRectanglea5b3S15()
        {
            //Arrange
            string a = "5";
            string b = "3";
            double S = 15;
            //Add
            double res = GeometryClass1.SRectangle(a, b);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void SRectanglea2b8S16()
        {
            //Arrange
            string a = "2";
            string b = "8";
            double S = 16;
            //Add
            double res = GeometryClass1.SRectangle(a, b);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STrianglea5h3S7_5()
        {
            //Arrange
            string a = "5";
            string h = "3";
            double S = 7.5;
            //Add
            double res = GeometryClass1.STriangle(a, h);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STrianglea7h3S10_5()
        {
            //Arrange
            string a = "7";
            string h = "3";
            double S = 10.5;
            //Add
            double res = GeometryClass1.STriangle(a, h);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STrianglea5h1S2_5()
        {
            //Arrange
            string a = "5";
            string h = "1";
            double S = 2.5;
            //Add
            double res = GeometryClass1.STriangle(a, h);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STriangle2a6h8S24()
        {
            //Arrange
            string a = "6";
            string b = "8";
            double S = 24;
            //Add
            double res = GeometryClass1.STriangle2(a, b);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STriangle2a8h5S20()
        {
            //Arrange
            string a = "8";
            string b = "5";
            double S = 20;
            //Add
            double res = GeometryClass1.STriangle2(a, b);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STriangle2a6h47S141()
        {
            //Arrange
            string a = "6";
            string b = "47";
            double S = 141;
            //Add
            double res = GeometryClass1.STriangle2(a, b);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void SCircler6S113_04()
        {
            //Arrange
            string r = "6";
            double S = 113.04;
            //Add
            double res = GeometryClass1.SCircle(r);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void SCircler2S12_56()
        {
            //Arrange
            string r = "2";
            double S = 12.56;
            //Add
            double res = GeometryClass1.SCircle(r);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void SCircler4S50_24()
        {
            //Arrange
            string r = "4";
            double S = 50.24;
            //Add
            double res = GeometryClass1.SCircle(r);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STrapezoida1b2h3S4_5()
        {
            //Arrange
            string a = "1";
            string b = "2";
            string h = "3";
            double S = 4.5;
            //Add
            double res = GeometryClass1.STrapezoid(a,b,h);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STrapezoida4b5h6S27()
        {
            //Arrange
            string a = "4";
            string b = "5";
            string h = "6";
            double S = 27;
            //Add
            double res = GeometryClass1.STrapezoid(a, b, h);
            //Assert
            Assert.AreEqual(S, res);
        }
        [TestMethod]
        public void STrapezoida7b8h9S67_5()
        {
            //Arrange
            string a = "7";
            string b = "8";
            string h = "9";
            double S = 67.5;
            //Add
            double res = GeometryClass1.STrapezoid(a, b, h);
            //Assert
            Assert.AreEqual(S, res);
        }
    }
}
