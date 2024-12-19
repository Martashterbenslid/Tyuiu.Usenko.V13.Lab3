using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public sealed class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestMethod1()
        {
            var z1 = new MathFirstExpression();
            int x = 1;
            int y = 2;
            int a = 3;
            double f1 = z1.func1(x, y, a);
            Assert.AreEqual(28, f1);
        }
    }
}
