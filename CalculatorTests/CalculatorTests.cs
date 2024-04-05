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

    [Fact]
    public void ShouldSum10And10AndReturn20()
    {

        //Arrange
        int num1 = 10;
        int num2 = 10;

        //Act
        int result = _calc.Sum(num1, num2);

        //Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void ShouldSubtract10And5AndReturn5()
    {
        //Arrange
        int num1 = 10;
        int num2 = 5;

        //Act
        int result = _calc.Sub(num1, num2);

        //Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void ShouldCheckIf4IsEvenAndReturnTrue()
    {
        //Arrange
        int num = 4;

        // Act
        bool result = _calc.ItsEven(num);

        // Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void ShouldCheckIfNumbersAreEvenAndReturnTrue(int[] nums)
    {

        //Act  /Assert
        Assert.All(nums, num => Assert.True(_calc.ItsEven(num)));
    }

}