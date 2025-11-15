namespace Calculations;

public class Calculator
{
    /// <summary>
    /// Adds two numbers together.
    /// </summary>
    public int Add(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Subtracts the second number from the first.
    /// </summary>
    public int Subtract(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Multiplies two numbers.
    /// </summary>
    public int Multiply(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Divides the first number by the second.
    /// </summary>
    /// <exception cref="DivideByZeroException">Thrown when dividing by zero.</exception>
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
        return (double)a / b;
    }

    /// <summary>
    /// Calculates the power of a number.
    /// </summary>
    public double Power(double baseNumber, double exponent)
    {
        return Math.Pow(baseNumber, exponent);
    }

    /// <summary>
    /// Calculates the square root of a number.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the input is negative.</exception>
    public double SquareRoot(double number)
    {
        if (number < 0)
        {
            throw new ArgumentException("Cannot calculate square root of a negative number.");
        }
        return Math.Sqrt(number);
    }

    /// <summary>
    /// Calculates the percentage of a number.
    /// </summary>
    public double Percentage(double number, double percent)
    {
        return (number * percent) / 100;
    }

    /// <summary>
    /// Calculates the average of an array of numbers.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the array is empty.</exception>
    public double Average(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Cannot calculate average of an empty array.");
        }
        return numbers.Average();
    }

    /// <summary>
    /// Finds the maximum value in an array of numbers.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the array is empty.</exception>
    public int Max(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Cannot find maximum of an empty array.");
        }
        return numbers.Max();
    }

    /// <summary>
    /// Finds the minimum value in an array of numbers.
    /// </summary>
    /// <exception cref="ArgumentException">Thrown when the array is empty.</exception>
    public int Min(params int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Cannot find minimum of an empty array.");
        }
        return numbers.Min();
    }
}
