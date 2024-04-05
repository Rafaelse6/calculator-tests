using Calculator.Services;

namespace CalculatorTests
{
    public class StringValidationTest
    {

        private StringValidation _validations;

        public StringValidationTest()
        {
            _validations = new StringValidation();
        }

        [Fact]
        public void ShouldCount5CaracthersInHelloAndReturn5()
        {
            // Arrange
            string text = "Hello";

            //Act
            int result = _validations.CountCharacters(text);

            //Assert

            Assert.Equal(5, result);
        }

    }
}