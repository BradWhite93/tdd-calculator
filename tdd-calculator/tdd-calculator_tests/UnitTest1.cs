namespace tdd_calculator_tests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenCalculatorWhenEmptyStringReturnZero()
        {
            var calculator = new tdd_calculator.StringCalculator();
            var result = calculator.Add("");
            Assert.True(result == 0);
        }

        [Fact]
        public void GivenCalculatorWhenASingleNumberThenReturnInput()
        {
            var calculator = new tdd_calculator.StringCalculator();
            var result = calculator.Add("1");
            Assert.True(result == 1);
        }

        [Fact]
        public void GivenCalculatorWhenTwoValidNumbersThenReturnTheSumOfThese()
        {
            var calculator = new tdd_calculator.StringCalculator();
            var result = calculator.Add("1,2");
            Assert.True(result == 3);
        }
    }
}