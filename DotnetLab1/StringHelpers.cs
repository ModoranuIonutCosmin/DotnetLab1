using System.Collections.Generic;
using System.Linq;

namespace DotNetLab1
{
    public static class StringHelpers
    {
        public static List<string> ComputeWordsFromSentence (this string sentence)
        {
            if(sentence is null)
            {
                return new();
            }

            var punctuatie = sentence.Where(c => char.IsPunctuation(c) && c != '\'')
                .Distinct().ToArray();

            return sentence.Split()
                .Select(e => e.Trim(punctuatie))
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();
        }
    }
}
