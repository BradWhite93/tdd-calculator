namespace tdd_calculator
{
    public class StringCalculator
    {
        public virtual int Add(string numbers)
        {
            var delimiters = new List<char> { ',', '\n' };

            if (numbers.Contains("//"))
            {
                var customDelimiter = numbers.Split("//").Last().ToCharArray()[0];
                delimiters.Add(customDelimiter);
                numbers = numbers.Remove(0, numbers.IndexOf(customDelimiter, StringComparison.Ordinal));
            }

            var listOfNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            return listOfNumbers.Sum(int.Parse);
        }
    }
}