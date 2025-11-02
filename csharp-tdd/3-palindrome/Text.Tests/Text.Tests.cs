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
        /// Test simple palindrome in lowercase
        /// </summary>
        [Test]
        public void IsPalindrome_SimpleWord_ReturnsTrue()
        {
            // Arrange
            string s = "level";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test palindrome with mixed case
        /// </summary>
        [Test]
        public void IsPalindrome_MixedCase_ReturnsTrue()
        {
            // Arrange
            string s = "Racecar";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test palindrome with spaces and punctuation
        /// </summary>
        [Test]
        public void IsPalindrome_WithSpacesAndPunctuation_ReturnsTrue()
        {
            // Arrange
            string s = "A man, a plan, a canal: Panama.";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test empty string is palindrome
        /// </summary>
        [Test]
        public void IsPalindrome_EmptyString_ReturnsTrue()
        {
            // Arrange
            string s = "";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test non-palindrome returns false
        /// </summary>
        [Test]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            // Arrange
            string s = "hello";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test single character is palindrome
        /// </summary>
        [Test]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            // Arrange
            string s = "a";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test palindrome with numbers
        /// </summary>
        [Test]
        public void IsPalindrome_WithNumbers_ReturnsTrue()
        {
            // Arrange
            string s = "12321";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test palindrome with only spaces and punctuation
        /// </summary>
        [Test]
        public void IsPalindrome_OnlySpacesAndPunctuation_ReturnsTrue()
        {
            // Arrange
            string s = "   !!!   ";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test two characters palindrome
        /// </summary>
        [Test]
        public void IsPalindrome_TwoSameCharacters_ReturnsTrue()
        {
            // Arrange
            string s = "aa";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test two different characters not palindrome
        /// </summary>
        [Test]
        public void IsPalindrome_TwoDifferentCharacters_ReturnsFalse()
        {
            // Arrange
            string s = "ab";

            // Act
            bool result = Str.IsPalindrome(s);

            // Assert
            Assert.IsFalse(result);
        }
    }
}