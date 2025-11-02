using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Provides string manipulation operations
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Determines if a string is a palindrome
        /// </summary>
        /// <param name="s">The string to check</param>
        /// <returns>True if the string is a palindrome, False otherwise</returns>
        public static bool IsPalindrome(string s)
        {
            // Empty string is considered a palindrome
            if (string.IsNullOrEmpty(s))
                return true;

            // Remove spaces, punctuation and convert to lowercase
            string cleaned = new string(s.Where(c => char.IsLetterOrDigit(c))
                                         .Select(c => char.ToLower(c))
                                         .ToArray());

            // Empty after cleaning is still a palindrome
            if (cleaned.Length == 0)
                return true;

            // Check if the cleaned string is equal to its reverse
            int left = 0;
            int right = cleaned.Length - 1;

            while (left < right)
            {
                if (cleaned[left] != cleaned[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }
    }
}