using Xunit;
using DynamicCalculation;
using System;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    [Fact]
    public void Add_ShouldReturnSum_WhenGivenTwoNumbers()
    {
        // Arrange
        double a = 5;
        double b = 10;

        // Act
        double result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(15, result);
    }

    [Fact]
    public void Subtract_ShouldReturnDifference_WhenGivenTwoNumbers()
    {
        // Arrange
        double a = 15;
        double b = 10;

        // Act
        double result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Multiply_ShouldReturnProduct_WhenGivenTwoNumbers()
    {
        // Arrange
        double a = 5;
        double b = 10;

        // Act
        double result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(50, result);
    }

    [Fact]
    public void Divide_ShouldReturnQuotient_WhenGivenTwoNumbers()
    {
        // Arrange
        double a = 10;
        double b = 2;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ShouldThrowArgumentException_WhenDividingByZero()
    {
        // Arrange
        double a = 10;
        double b = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.Divide(a, b));
    }
}
