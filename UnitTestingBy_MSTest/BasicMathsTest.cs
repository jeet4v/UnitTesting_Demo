using MyCalculator;

namespace UnitTestingBy_MSTest
{
    // Test class & method requirements:
    // 1. The class must be defined with the [TestClass] attribute just above class name.
    // 1. The method must be defined with the [TestMethod] attribute just above method name.
    // 2. The method must having return type void.
    // 3. The method cannot have any parameters.

    [TestClass]
    public sealed class BasicMathsTest
    {
        [TestMethod]
        public void Test_Add()
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Add(10, 10);
            Assert.AreEqual(20, actual);
        }

        [TestMethod]
        public void Test_Substract()
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Substract(10, 10);
            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test_Divide()
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Divide(10, 5);
            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void Test_Multiply()
        {
            BasicMaths bm = new BasicMaths();
            double actual = bm.Multiply(10, 10);
            Assert.AreEqual(100, actual);
        }
    }
}
