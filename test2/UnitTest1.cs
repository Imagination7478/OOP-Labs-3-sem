using System;
using OOP_test_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        Shape circle = new Shape(3, 5, 7);
        
        [TestMethod]
        public void OutputTest()    
        {
            string expected = "Centre: x = 3, y = 5\nRadius: 7";
            string result = circle.getInfo();
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AreaTest()
        {
            double result = circle.getArea();
            Assert.AreEqual(49 * Math.PI, result);
        }

        [TestMethod]
        public void PerimetreTest()
        {
            double result = circle.getPer();
            Assert.AreEqual(14 * Math.PI, result);
        }

        [TestMethod]
        public void MoveTest()
        {
            Shape localCircle = new Shape(0, 0, 7);
            localCircle.move(new Vector(12, 12));
            string expected = "Centre: x = 12, y = 12\nRadius: 7";
            string result = localCircle.getInfo();
            Assert.AreEqual(expected, result);
        }
        
    }
}
