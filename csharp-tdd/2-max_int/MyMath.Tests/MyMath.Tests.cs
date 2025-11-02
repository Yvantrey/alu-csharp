using NUnit.Framework;
using MyMath;
using System.Collections.Generic;

namespace MyMath.Tests
{
    /// <summary>
    /// Test class for MyMath.Operations class
    /// </summary>
    [TestFixture]
    public class OperationsTests
    {
        /// <summary>
        /// Test finding max in a list of positive numbers
        /// </summary>
        [Test]
        public void Max_PositiveNumbers_ReturnsMaximum()
        {
            // Arrange
            List<int> nums = new List<int> { 1, 5, 3, 9, 2 };
            int expected = 9;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test finding max in empty list returns 0
        /// </summary>
        [Test]
        public void Max_EmptyList_ReturnsZero()
        {
            // Arrange
            List<int> nums = new List<int>();
            int expected = 0;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test finding max in null list returns 0
        /// </summary>
        [Test]
        public void Max_NullList_ReturnsZero()
        {
            // Arrange
            List<int> nums = null;
            int expected = 0;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test finding max with negative numbers
        /// </summary>
        [Test]
        public void Max_NegativeNumbers_ReturnsMaximum()
        {
            // Arrange
            List<int> nums = new List<int> { -10, -5, -20, -1 };
            int expected = -1;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test finding max with mixed positive and negative numbers
        /// </summary>
        [Test]
        public void Max_MixedNumbers_ReturnsMaximum()
        {
            // Arrange
            List<int> nums = new List<int> { -5, 10, -20, 30, 0 };
            int expected = 30;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test finding max with single element
        /// </summary>
        [Test]
        public void Max_SingleElement_ReturnsThatElement()
        {
            // Arrange
            List<int> nums = new List<int> { 42 };
            int expected = 42;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test finding max with all same values
        /// </summary>
        [Test]
        public void Max_AllSameValues_ReturnsValue()
        {
            // Arrange
            List<int> nums = new List<int> { 7, 7, 7, 7 };
            int expected = 7;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test finding max with zero included
        /// </summary>
        [Test]
        public void Max_WithZero_ReturnsMaximum()
        {
            // Arrange
            List<int> nums = new List<int> { 0, -5, 3, -10 };
            int expected = 3;

            // Act
            int result = Operations.Max(nums);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}