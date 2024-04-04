using Calculator.Services;

namespace CalculatorTests;

public class CalculatorTests
{
    private CalculatorImp _calc;

    public CalculatorTests()
    {
        _calc = new CalculatorImp();
    }

    [Fact]
    public void ShouldSum5And10AndReturn15()
    {

        //Arrange
        int num1 = 5;
        int num2 = 10;

        //Act
        int result = _calc.Sum(num1, num2);

        //Assert
        Assert.Equal(15, result);
    }
}