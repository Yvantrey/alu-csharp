using NUnit.Framework;
using Text;

namespace Text.Tests
{
    /// <summary>
    /// Test class for Text.Str class
    /// </summary>
    [TestFixture]
    public class StrTests
    {
        /// <summary>
        /// Test finding first unique character in a string
        /// </summary>
        [Test]
        public void UniqueChar_HasUniqueChar_ReturnsIndex()
        {
            // Arrange
            string s = "leetcode";
            int expected = 0; // 'l' is the first unique character

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test string with no unique characters
        /// </summary>
        [Test]
        public void UniqueChar_NoUniqueChar_ReturnsMinusOne()
        {
            // Arrange
            string s = "aabb";
            int expected = -1;

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test empty string returns -1
        /// </summary>
        [Test]
        public void UniqueChar_EmptyString_ReturnsMinusOne()
        {
            // Arrange
            string s = "";
            int expected = -1;

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test null string returns -1
        /// </summary>
        [Test]
        public void UniqueChar_NullString_ReturnsMinusOne()
        {
            // Arrange
            string s = null;
            int expected = -1;

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test single character string
        /// </summary>
        [Test]
        public void UniqueChar_SingleChar_ReturnsZero()
        {
            // Arrange
            string s = "a";
            int expected = 0;

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test unique character at the end
        /// </summary>
        [Test]
        public void UniqueChar_UniqueAtEnd_ReturnsCorrectIndex()
        {
            // Arrange
            string s = "aabbcd";
            int expected = 4; // 'c' is at index 4

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test unique character in the middle
        /// </summary>
        [Test]
        public void UniqueChar_UniqueInMiddle_ReturnsCorrectIndex()
        {
            // Arrange
            string s = "aabbc";
            int expected = 4; // 'c' is at index 4

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test all characters are unique
        /// </summary>
        [Test]
        public void UniqueChar_AllUnique_ReturnsZero()
        {
            // Arrange
            string s = "abcdef";
            int expected = 0; // 'a' is the first unique character

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test string with repeating pattern
        /// </summary>
        [Test]
        public void UniqueChar_RepeatingPattern_ReturnsCorrectIndex()
        {
            // Arrange
            string s = "loveleetcode";
            int expected = 2; // 'v' is the first unique character

            // Act
            int result = Str.UniqueChar(s);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}