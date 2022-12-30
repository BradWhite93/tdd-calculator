namespace tdd_calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var listOfNumbers = numbers.Split(",", StringSplitOptions.RemoveEmptyEntries);
            return listOfNumbers.Sum(int.Parse);
        }
    }
}
