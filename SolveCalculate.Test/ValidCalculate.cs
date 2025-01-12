﻿using SolveCalculate.Lib;

namespace SolveCalculate.Test
{
    [TestClass]
    public sealed class ValidCalculate
    {
        [TestMethod]
        public void TestCalculateSumma()
        {
            var calculator = new Calculate();
            double a = 4, b = 3;
            double result = calculator.CalculateSumma(a, b);
            Assert.AreEqual(7, result);

        }

        [TestMethod]
        public void TestCalculateDifference()
        {
            var calculator = new Calculate();
            double a = 4, b = 3;
            double result = calculator.CalculateDifference(a, b);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestCalculateMultiplication()
        {
            var calculator = new Calculate();
            double a = 4, b = 3;
            double result = calculator.CalculateMultiplication(a, b);
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void TestCalculateQuotient()
        {
            var calculator = new Calculate();
            double a = 4, b = 4;
            double result = calculator.CalculateQuotient(a, b);
            Assert.AreEqual(1, result);
        }
    }
}
