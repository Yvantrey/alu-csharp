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
        /// Test counting words in a simple camelCase string
        /// </summary>
        [Test]
        public void CamelCase_SimpleCamelCase_ReturnsCorrectCount()
        {
            // Arrange
            string s = "helloWorld";
            int expected = 2;

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test single word (no capitals)
        /// </summary>
        [Test]
        public void CamelCase_SingleWord_ReturnsOne()
        {
            // Arrange
            string s = "hello";
            int expected = 1;

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test empty string returns 0
        /// </summary>
        [Test]
        public void CamelCase_EmptyString_ReturnsZero()
        {
            // Arrange
            string s = "";
            int expected = 0;

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test null string returns 0
        /// </summary>
        [Test]
        public void CamelCase_NullString_ReturnsZero()
        {
            // Arrange
            string s = null;
            int expected = 0;

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test multiple words in camelCase
        /// </summary>
        [Test]
        public void CamelCase_MultipleWords_ReturnsCorrectCount()
        {
            // Arrange
            string s = "thisIsACamelCaseString";
            int expected = 6;

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test single character lowercase
        /// </summary>
        [Test]
        public void CamelCase_SingleCharLower_ReturnsOne()
        {
            // Arrange
            string s = "a";
            int expected = 1;

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test two words camelCase
        /// </summary>
        [Test]
        public void CamelCase_TwoWords_ReturnsTwo()
        {
            // Arrange
            string s = "iPhone";
            int expected = 2;

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test consecutive capitals
        /// </summary>
        [Test]
        public void CamelCase_ConsecutiveCapitals_ReturnsCorrectCount()
        {
            // Arrange
            string s = "iOSApp";
            int expected = 4; // i + O + S + A = 4 words

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test long camelCase string
        /// </summary>
        [Test]
        public void CamelCase_LongString_ReturnsCorrectCount()
        {
            // Arrange
            string s = "saveChangesInTheEditor";
            int expected = 5;

            // Act
            int result = Str.CamelCase(s);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}