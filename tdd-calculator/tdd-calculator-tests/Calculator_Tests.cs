// See https://aka.ms/new-console-template for more information

using Xunit;

Console.WriteLine("Hello, World!");

[Fact]
void GivenCalculatorWhenEmptyStringReturnZero()
{
    var calculator = new tdd_calculator.Calculator();
    var result = calculator.Add("");
    Assert.True(result == 0);
}
