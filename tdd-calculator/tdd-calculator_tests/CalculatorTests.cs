using tdd_calculator;

namespace tdd_calculator_tests;

public class CalculatorTests
{
    [Theory]
    [InlineData("", 0)]
    [InlineData("1",1)]
    [InlineData("1,2",3)]
    [InlineData("1,2,3,4,5", 15)]
    [InlineData("1\n2,3", 6)]
    public void GivenCalculator_WhenInputsProvidedWithoutCustomDelimmiter_InputsAreAddedTogether(string input, int expectedResult)
    {
        var calculator = new StringCalculator();
        var result = calculator.Add(input);
        Assert.True(result == expectedResult);
    }

    [Fact]
    public void GivenCalculator_WhenInputsProvidedWithCustomDelimmiter_InputsAreAddedTogether()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("//;\n1;2");
        Assert.True(result == 3);
    }

    [Theory]
    [InlineData("-1")]
    [InlineData("-1,-2,-3")]
    public void GivenCalculator_WhenNegativeInputIsProvided_ExceptionIsThrown(string input)
    {
        var calculator = new StringCalculator();
        var ex = Assert.Throws<Exception>(() => calculator.Add(input));
        Assert.Equal($"Negatives not allowed {input}", ex.Message);
    }

    [Fact]
    public void GivenCalculator_WhenNegativeInputIsProvidedWithPositiveNumbers_ExceptionIsThrownOnlyWithNegativeNumbers()
    {
        var calculator = new StringCalculator();
        const string input = "-1,2,-4";
        const string expectedOutput = "-1,-4";
        var ex = Assert.Throws<Exception>(() => calculator.Add(input));
        Assert.Equal($"Negatives not allowed {expectedOutput}", ex.Message);
    }
}