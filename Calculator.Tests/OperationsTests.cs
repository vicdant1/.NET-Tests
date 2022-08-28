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

            int result = GenericClassLib.Calculator.Sum(n1, n2);

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
            decimal result = GenericClassLib.Calculator.Divide(n1, n2);

            // Assert
            Assert.Equal(expectedResult, result);

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