using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newton;
namespace NewtonTests
{
    [TestClass]
    public class NewtonTests
    {
        [TestMethod]
        public void RootOfNDegreeTest1()
        {
            double act = Newton.NewtonMethod.RootOfNDegree(1, 2, 0.0001);
            double expected = Math.Pow(1, 0.5);
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void RootOfNDegreeTest2()
        {
            double act = Newton.NewtonMethod.RootOfNDegree(1, 0, 0.0001);
            double expected = Math.Pow(1, 0);
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void RootOfNDegreeTest3()
        {
            double act = Newton.NewtonMethod.RootOfNDegree(0, 0, 0.0001);
            double expected = Math.Pow(0, 0);
            Assert.AreEqual(expected, act);
        }

        [TestMethod]
        public void RootOfNDegreeTest4()
        {
            double act = Newton.NewtonMethod.RootOfNDegree(19.02, 5, 0.0000000000000000000001);
            double expected = Math.Pow(19.02, 0.2);
            Assert.AreEqual(expected, act);
        }

    
    }
}
