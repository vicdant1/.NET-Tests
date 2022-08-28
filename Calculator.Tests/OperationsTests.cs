using static GenericClassLib.Calculator;

namespace Calculator.Tests
{
    public class OperationsTests
    {
        [Fact(DisplayName = "Sum_Unit_Test")]
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

        /*
        resume study section
        {
            Skip
            theory[theory]
            _sut(using instances)
            member data
            IEnumerabl<object[]>
            classdata
            parallelization
            traist
        }
        */
    }
}