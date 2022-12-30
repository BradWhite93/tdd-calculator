using tdd_calculator;

namespace tdd_calculator_tests;

public class CalculatorTests
{
    [Fact]
    public void GivenCalculatorWhenEmptyStringReturnZero()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("");
        Assert.True(result == 0);
    }

    [Fact]
    public void GivenCalculatorWhenASingleNumberThenReturnInput()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1");
        Assert.True(result == 1);
    }

    [Fact]
    public void GivenCalculatorWhenTwoValidNumbersThenReturnTheSumOfThese()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2");
        Assert.True(result == 3);
    }

    [Fact]
    public void GivenCalculatorWhenMoreThanTwoValidNumbersThenReturnTheSumOfAllOfThese()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1,2,3,4,5");
        Assert.True(result == 15);
    }


    [Fact]
    public void GivenCalculatorWhenNewLineIsUsedInsteadOfCommaThenAddAllOfThese()
    {
        var calculator = new StringCalculator();
        var result = calculator.Add("1\n2,3");
        Assert.True(result == 6);
    }
}