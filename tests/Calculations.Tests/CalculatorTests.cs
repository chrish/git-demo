namespace Calculations.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Add_NegativeNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = -5;
        int b = -3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(-8, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = 3;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        int a = 4;
        int b = 5;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(20, result);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 10;
        int b = 2;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
    }

    [Fact]
    public void Power_SquareOfNumber_ReturnsCorrectValue()
    {
        // Arrange
        double baseNumber = 2;
        double exponent = 3;

        // Act
        double result = _calculator.Power(baseNumber, exponent);

        // Assert
        Assert.Equal(8.0, result);
    }

    [Fact]
    public void SquareRoot_PositiveNumber_ReturnsCorrectValue()
    {
        // Arrange
        double number = 16;

        // Act
        double result = _calculator.SquareRoot(number);

        // Assert
        Assert.Equal(4.0, result);
    }

    [Fact]
    public void SquareRoot_NegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        double number = -16;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(number));
    }

    [Fact]
    public void Percentage_CalculatesCorrectPercentage()
    {
        // Arrange
        double number = 200;
        double percent = 15;

        // Act
        double result = _calculator.Percentage(number, percent);

        // Assert
        Assert.Equal(30.0, result);
    }

    [Fact]
    public void Average_MultipleNumbers_ReturnsCorrectAverage()
    {
        // Arrange
        int[] numbers = { 2, 4, 6, 8, 10 };

        // Act
        double result = _calculator.Average(numbers);

        // Assert
        Assert.Equal(6.0, result);
    }

    [Fact]
    public void Average_EmptyArray_ThrowsArgumentException()
    {
        // Arrange
        int[] numbers = { };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.Average(numbers));
    }

    [Fact]
    public void Max_MultipleNumbers_ReturnsMaximum()
    {
        // Arrange
        int[] numbers = { 3, 7, 2, 9, 1 };

        // Act
        int result = _calculator.Max(numbers);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void Max_EmptyArray_ThrowsArgumentException()
    {
        // Arrange
        int[] numbers = { };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.Max(numbers));
    }

    [Fact]
    public void Min_MultipleNumbers_ReturnsMinimum()
    {
        // Arrange
        int[] numbers = { 3, 7, 2, 9, 1 };

        // Act
        int result = _calculator.Min(numbers);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Min_EmptyArray_ThrowsArgumentException()
    {
        // Arrange
        int[] numbers = { };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.Min(numbers));
    }
}
