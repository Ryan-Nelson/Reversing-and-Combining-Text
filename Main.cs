namespace smile67Kata
{
    using System.Linq;

    public class Kata 
    {
        public string reverseAndCombineText(string text) 
        {
            var words = text.Split(' ').AsEnumerable();

            while (words.Count() > 1)
            {
                words = words
                    .Select((w, i) => new { Word = string.Concat(w.Reverse()), Index = i })
                    .GroupBy(e => e.Index / 2)
                    .Select(g => string.Concat(g.Select(e => e.Word)));
            }

            return string.Concat(words);
        }
    }
}
