namespace tdd_calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var listOfNumbers = numbers.Split(new [] {",", "\n"}, StringSplitOptions.RemoveEmptyEntries);
            return listOfNumbers.Sum(int.Parse);
        }
    }
}
