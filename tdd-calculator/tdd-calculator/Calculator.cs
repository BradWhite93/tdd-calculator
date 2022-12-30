using System.Text.RegularExpressions;

namespace tdd_calculator
{
    public class StringCalculator
    {
        private int InvokationCount { get; set; }

        public virtual int Add(string numbers)
        {
            var delimiters = new List<char> { ',', '\n' };
            if (numbers.Contains("-"))
            {
                var negativeValue = string.Join(",", Regex.Matches(numbers, @"-\d+"));
                throw new Exception($"Negatives not allowed {negativeValue}");
            }
            if (numbers.Contains("//"))
            {
                var customDelimiter = numbers.Split("//").Last().ToCharArray()[0];
                delimiters.Add(customDelimiter);
                numbers = numbers.Remove(0, numbers.IndexOf(customDelimiter, StringComparison.Ordinal));
            }

            var listOfNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            InvokationCount++;
            return listOfNumbers.Sum(int.Parse);
        }

        public int GetCalledCount()
        {
            return InvokationCount;
        }

    }
}