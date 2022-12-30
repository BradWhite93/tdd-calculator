namespace tdd_calculator
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            var delimiter  = ",";
            var indexOfDelimiter  = numbers.IndexOf("//", StringComparison.Ordinal);
            if (indexOfDelimiter != -1)
            {
                delimiter = numbers.Substring(indexOfDelimiter + 2, 1);
                numbers = numbers.Remove(indexOfDelimiter, numbers.IndexOf(delimiter, StringComparison.Ordinal));
            }
            
            var listOfNumbers = numbers.Split(new [] {",", "\n", delimiter}, StringSplitOptions.RemoveEmptyEntries);
            return listOfNumbers.Sum(int.Parse);
        }


    }
}
