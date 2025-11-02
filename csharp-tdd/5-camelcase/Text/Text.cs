using System;

namespace Text
{
    /// <summary>
    /// Provides string manipulation operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines how many words are in a camelCase string
        /// </summary>
        /// <param name="s">The camelCase string to analyze</param>
        /// <returns>The number of words in the string</returns>
        public static int CamelCase(string s)
        {
            // Return 0 for null or empty string
            if (string.IsNullOrEmpty(s))
                return 0;

            // Start with 1 word (the first word doesn't start with capital)
            int wordCount = 1;

            // Count the number of uppercase letters
            foreach (char c in s)
            {
                if (char.IsUpper(c))
                    wordCount++;
            }

            return wordCount;
        }
    }
}