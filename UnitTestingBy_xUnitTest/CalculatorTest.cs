using MyCalculator;
using Xunit.Abstractions;

namespace UnitTestingBy_xUnitTest
{
    public class CalculatorTest
    {
        // Loggers: Implement the ITestOutputHelper interface to redirect test output to custom locations or append additional information.
        private readonly ITestOutputHelper _output;
        public CalculatorTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Add_PositiveNumbers_ReturnsExpectedResult()
        {
            _output.WriteLine("Cutome Log Message: Add_PositiveNumbers_ReturnsExpectedResult()");

            // Arrange
            var calculator = new Calculator();
            int a = 3;
            int b = 5;
            int expectedResult = 8;

            // Act
            int actualResult = calculator.Add(a, b);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact(Skip = "Message: Skip this test case, with Fact's Skip attribute. Explicit skipping.")]
        public void Add_TwoNumbers_SkipWithFact()
        {
            _output.WriteLine("Cutome Log Message: Add_TwoNumbers_SkipWithFact()");

            // Arrange
            var calculator = new Calculator();
            int a = 3;
            int b = 5;
            int expectedResult = 8;

            // Act
            int actualResult = calculator.Add(a, b);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        // Custom Fact attribute that decides at runtime whether to skip test case.
        [MyConditionalFact]
        public void AddConditional_PositiveNumbers_SkipTestCase()
        {
            _output.WriteLine("Cutome Log Message: AddConditional_PositiveNumbers_SkipTestCase()");

            // Arrange
            var calculator = new Calculator();
            int a = 3;
            int b = 5;
            int c = 8;
            int expectedResult = 16;

            // Act
            int actualResult = calculator.AddConditional(a, b, c);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(-1, -2, -3)]    // InlineData: Supplies inline data values directly in the test method attribute.
        [InlineData(-5, -7, -12)]
        public void Add_NegativeNumbers_ReturnsExpectedResult(int a, int b, int expectedResult)
        {
            _output.WriteLine("Cutome Log Message: Add_NegativeNumbers_ReturnsExpectedResult()");

            // Arrange
            var calculator = new Calculator();

            // Act
            int actualResult = calculator.Add(a, b);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

    }
}
