namespace tdd_calculator
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var indexOfDelimmiter = numbers.IndexOf("//", StringComparison.Ordinal);
            var delimmiter = numbers.Substring(indexOfDelimmiter + 2, 1);
            var numbersWithDelimmiterRemoved = numbers.Remove(indexOfDelimmiter, numbers.IndexOf(delimmiter, StringComparison.Ordinal));
            var listOfNumbers = numbersWithDelimmiterRemoved.Split(new [] {",", "\n", delimmiter}, StringSplitOptions.RemoveEmptyEntries);
            return listOfNumbers.Sum(int.Parse);
        }
    }
}
