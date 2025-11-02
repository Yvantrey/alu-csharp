using NUnit.Framework;
using MyMath;

namespace MyMath.Tests
{
    /// <summary>
    /// Test class for MyMath.Operations class
    /// </summary>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>
        /// Test adding two positive numbers
        /// </summary>
        [Test]
        public void Add_PositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 10;
            int expected = 15;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding two negative numbers
        /// </summary>
        [Test]
        public void Add_NegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -5;
            int b = -10;
            int expected = -15;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding a positive and a negative number
        /// </summary>
        [Test]
        public void Add_PositiveAndNegative_ReturnsCorrectSum()
        {
            // Arrange
            int a = 10;
            int b = -5;
            int expected = 5;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding zero to a number
        /// </summary>
        [Test]
        public void Add_WithZero_ReturnsOtherNumber()
        {
            // Arrange
            int a = 10;
            int b = 0;
            int expected = 10;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding two zeros
        /// </summary>
        [Test]
        public void Add_TwoZeros_ReturnsZero()
        {
            // Arrange
            int a = 0;
            int b = 0;
            int expected = 0;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding large positive numbers
        /// </summary>
        [Test]
        public void Add_LargePositiveNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = 1000000;
            int b = 2000000;
            int expected = 3000000;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test adding large negative numbers
        /// </summary>
        [Test]
        public void Add_LargeNegativeNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int a = -1000000;
            int b = -2000000;
            int expected = -3000000;

            // Act
            int result = Operations.Add(a, b);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}