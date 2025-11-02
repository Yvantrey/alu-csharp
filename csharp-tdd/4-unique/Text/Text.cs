using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Provides string manipulation operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <returns>The index of the first non-repeating character, or -1 if none exists</returns>
        public static int UniqueChar(string s)
        {
            // Return -1 for null or empty string
            if (string.IsNullOrEmpty(s))
                return -1;

            // Count occurrences of each character
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            // Find the first character with count of 1
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                    return i;
            }

            // No unique character found
            return -1;
        }
    }
}