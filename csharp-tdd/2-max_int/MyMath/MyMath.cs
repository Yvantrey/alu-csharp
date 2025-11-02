using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// Provides basic mathematical operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Returns the maximum integer in a list of integers
        /// </summary>
        /// <param name="nums">The list of integers to search</param>
        /// <returns>The maximum integer in the list, or 0 if the list is empty</returns>
        public static int Max(List<int> nums)
        {
            // Check if list is null or empty
            if (nums == null || nums.Count == 0)
                return 0;

            // Return the maximum value
            return nums.Max();
        }
    }
}