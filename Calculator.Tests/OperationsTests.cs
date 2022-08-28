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
    }
}