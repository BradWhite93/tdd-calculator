namespace tdd_calculator
{
    public class StringCalculator
    {
        public virtual int Add(string numbers)
        {
            var delimiters = new List<char> { ',', '\n' };
            var customDelimiter = '\0';
            if (numbers.Contains("//"))
            {
                customDelimiter = numbers.Split("//").Last().ToCharArray()[0];
                numbers = numbers.Remove(0, numbers.IndexOf(customDelimiter, StringComparison.Ordinal));
            }

            if (customDelimiter != '\0')
            {
                delimiters.Add(customDelimiter);
            }
            
            var listOfNumbers = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            return listOfNumbers.Sum(int.Parse);
        }


    }
}
