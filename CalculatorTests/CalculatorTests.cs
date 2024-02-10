using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;

namespace CalculatorLibrary.Tests
{
    [TestClass]
    public class CalculatorAddTests
    {
        private readonly Calculator _calculator;

        public CalculatorAddTests()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            // Arrange
            decimal number1 = 5;
            decimal number2 = 7;

            // Act
            decimal result = _calculator.Add(number1, number2);

            // Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            // Arrange
            decimal number1 = -5;
            decimal number2 = -7;

            // Act
            decimal result = _calculator.Add(number1, number2);

            // Assert
            Assert.AreEqual(-12, result);
        }

        [TestMethod]
        public void Add_PositiveAndNegativeNumbers_ReturnsSum()
        {
            // Arrange
            decimal number1 = 5;
            decimal number2 = -7;

            // Act
            decimal result = _calculator.Add(number1, number2);

            // Assert
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Add_ZeroAndPositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            decimal number1 = 0;
            decimal number2 = 7;

            // Act
            decimal result = _calculator.Add(number1, number2);

            // Assert
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Add_ZeroAndNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            decimal number1 = 0;
            decimal number2 = -7;

            // Act
            decimal result = _calculator.Add(number1, number2);

            // Assert
            Assert.AreEqual(-7, result);
        }
    }
}