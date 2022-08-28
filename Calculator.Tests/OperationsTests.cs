using GenericClassLib;
using Xunit.Sdk;
using static GenericClassLib.Calculator;

namespace Calculator.Tests
{
    public class OperationsTests
    {
        [Fact(DisplayName = "Sum_Unit_Test")]
        [Trait("Category", "Unit")]
        public void SumUnderNormalNumbersShouldReturnIntegerSum()
        {
            // AAA -> Arrange, Act, Assert
            // Arrange

            int n1 = 1;
            int n2 = 2;
            int expectedResult = 3;

            // Act

            int result = Sum(n1, n2);

            // Assert

            Assert.Equal(expectedResult, result);

        }

        [Fact]
        [Trait("Category", "Unit")]
        public void DivideUnderNormalNumbersShouldReturnDecimal()
        {
            // Arrange
            int n1 = 1;
            int n2 = 2;

            decimal expectedResult = n1 / n2;

            // Act
            decimal result = Divide(n1, n2);

            // Assert
            Assert.Equal(expectedResult, result);

        }

        [Fact(Skip = "Not implemented")]
        [Trait("Category", "Unit")]
        public void MultiplyMemberZeroShouldReturnZero()
        {
            // Arrange
            int n1 = 0;
            int n2 = 100;

            // Act
            int result = Multiply(n1, n2);
            // Assert
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(1, 1, 0)]
        [InlineData(1, 2, -1)]
        [InlineData(50, 30, 220)]
        [Trait("Category", "Unit - Theory")]
        public void SubtractWithManyValues(int n1, int n2, int expected)
        {
            // Arrange
            int result;

            // Act

            result = Sub(n1, n2);

            // Assert

            try
            {
                Assert.Equal(result, expected);
            }
            catch(EqualException ex)
            {
                throw new XunitException($"Custom message => \n{ex.Message}");
            }
        }


        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        [Trait("Category", "Unit - Theory")]
        public void SubtractMassiveValues(int n1, int n2, int expected)
        {
            // Arrange
            int result;
            // Act

            result = Sub(n1, n2);

            // Assert
            try
            {
                Assert.Equal(result, expected);
            }
            catch(EqualException ex)
            {
                throw new XunitException($"Test failed\nExeption message: {ex.Message}");
            }
        }

        [Theory]
        [MemberData(nameof(Data))]
        [Trait("Category", "Unit - Theory")]
        public void MultiplyWithMassiveValues(int n1, int n2, int expected)
        {
            // Arrange
            int result;
            // Act

            result = Multiply(n1, n2);

            // Assert

            try
            {
                Assert.Equal(result, expected);
            }
            catch(EqualException ex)
            {
                throw new XunitException($"Custom message assertion:\n{ex.Message}");
            }
        }


        public static IEnumerable<object[]> Data => new List<object[]>
        {
            new object[] { 1, 2, 2 },
            new object[] { 4, 5, 12 },
            new object[] { 4, 5, 20 },
            new object[] { 4, 7, 28 },
            new object[] { 4, 5, 6 }
        };
    }
}