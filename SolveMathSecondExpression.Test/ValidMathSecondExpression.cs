using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public sealed class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestMethod1()
        {
            var z2 = new MathSecondExpression();
            int x2 = 3;
            int y2 = 2;
            int a2 = 1;
            double f2 = z2.func2(x2, y2, a2);
            Assert.AreEqual(8.79, f2, 0.01);
        }
    }
}
