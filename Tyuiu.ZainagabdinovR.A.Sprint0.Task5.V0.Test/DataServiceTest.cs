using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

//Подключение библиотеки
using Tyuiu.ZainagabdinovR.A.Sprint0.Task5.V0.Lib;

namespace Tyuiu.ZainagabdinovR.A.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckkedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        [TestMethod]
        public void CheckkedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckkedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
