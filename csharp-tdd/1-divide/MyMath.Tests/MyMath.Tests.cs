using NUnit.Framework;
using MyMath;
using System;
using System.IO;

namespace MyMath.Tests
{
    /// <summary>
    /// Test class for MyMath.Matrix class
    /// </summary>
    [TestFixture]
    public class MatrixTests
    {
        /// <summary>
        /// Test dividing a matrix by a positive number
        /// </summary>
        [Test]
        public void Divide_PositiveNumber_ReturnsCorrectMatrix()
        {
            // Arrange
            int[,] matrix = { { 10, 20, 30 }, { 40, 50, 60 } };
            int num = 10;
            int[,] expected = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test dividing by zero should return null and print message
        /// </summary>
        [Test]
        public void Divide_ByZero_ReturnsNullAndPrintsMessage()
        {
            // Arrange
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int num = 0;
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.IsNull(result);
            Assert.That(stringWriter.ToString().Trim(), Is.EqualTo("Num cannot be 0"));
        }

        /// <summary>
        /// Test dividing a null matrix returns null
        /// </summary>
        [Test]
        public void Divide_NullMatrix_ReturnsNull()
        {
            // Arrange
            int[,] matrix = null;
            int num = 5;

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// Test dividing matrix with negative numbers
        /// </summary>
        [Test]
        public void Divide_NegativeNumbers_ReturnsCorrectMatrix()
        {
            // Arrange
            int[,] matrix = { { -10, -20 }, { -30, -40 } };
            int num = -10;
            int[,] expected = { { 1, 2 }, { 3, 4 } };

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test dividing single element matrix
        /// </summary>
        [Test]
        public void Divide_SingleElement_ReturnsCorrectMatrix()
        {
            // Arrange
            int[,] matrix = { { 100 } };
            int num = 10;
            int[,] expected = { { 10 } };

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test dividing matrix by 1 returns same values
        /// </summary>
        [Test]
        public void Divide_ByOne_ReturnsSameValues()
        {
            // Arrange
            int[,] matrix = { { 5, 10, 15 }, { 20, 25, 30 } };
            int num = 1;
            int[,] expected = { { 5, 10, 15 }, { 20, 25, 30 } };

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test dividing matrix by negative number
        /// </summary>
        [Test]
        public void Divide_ByNegativeNumber_ReturnsCorrectMatrix()
        {
            // Arrange
            int[,] matrix = { { 10, 20 }, { 30, 40 } };
            int num = -2;
            int[,] expected = { { -5, -10 }, { -15, -20 } };

            // Act
            int[,] result = Matrix.Divide(matrix, num);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}