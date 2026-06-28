namespace DotnetTutorial.Exercises.Services;

public sealed class FactorialCalculator
{
    public int Calculate(int value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Value must be zero or more.");
        }

        int result = 1;

        for (int i = 2; i <= value; i++)
        {
            result *= i;
        }

        return result;
    }
}