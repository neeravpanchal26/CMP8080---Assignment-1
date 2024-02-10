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

        [TestMethod]
        public void TestSubtractPositiveNumbers()
        {
            // Arrange
            decimal number1 = 5;
            decimal number2 = 3;

            // Act
            decimal result = _calculator.Subtract(number1, number2);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestSubtractNegativeNumbers()
        {
            // Arrange
            decimal number1 = -5;
            decimal number2 = -3;

            // Act
            decimal result = _calculator.Subtract(number1, number2);

            // Assert
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void TestSubtractPositiveAndNegativeNumbers()
        {
            // Arrange
            decimal number1 = 5;
            decimal number2 = -3;

            // Act
            decimal result = _calculator.Subtract(number1, number2);

            // Assert
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void TestSubtractZero()
        {
            // Arrange
            decimal number1 = 5;
            decimal number2 = 0;

            // Act
            decimal result = _calculator.Subtract(number1, number2);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtractLargeNumbers()
        {
            // Arrange
            decimal number1 = 1000000000000000000;
            decimal number2 = 999999999999999999;

            // Act
            decimal result = _calculator.Subtract(number1, number2);

            // Assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMultiply_TwoPositiveNumbers()
        {
            // Arrange
            decimal number1 = 2;
            decimal number2 = 3;

            // Act
            decimal result = _calculator.Multiply(number1, number2);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMultiply_PositiveAndNegativeNumber()
        {
            // Arrange
            decimal number1 = 5;
            decimal number2 = -4;

            // Act
            decimal result = _calculator.Multiply(number1, number2);

            // Assert
            Assert.AreEqual(-20, result);
        }

        [TestMethod]
        public void TestMultiply_TwoNegativeNumbers()
        {
            // Arrange
            decimal number1 = -2;
            decimal number2 = -3;

            // Act
            decimal result = _calculator.Multiply(number1, number2);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMultiply_OneZero()
        {
            // Arrange
            decimal number1 = 0;
            decimal number2 = 5;

            // Act
            decimal result = _calculator.Multiply(number1, number2);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMultiply_BothZero()
        {
            // Arrange
            decimal number1 = 0;
            decimal number2 = 0;

            // Act
            decimal result = _calculator.Multiply(number1, number2);

            // Assert
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestDivide_NormalCase()
        {
            // Arrange
            decimal number1 = 6;
            decimal number2 = 2;

            // Act
            decimal result = _calculator.Divide(number1, number2);

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestDivide_DivideByZero()
        {
            // Arrange
            decimal number1 = 6;
            decimal number2 = 0;

            // Act & Assert
            Assert.ThrowsException<System.DivideByZeroException>(() =>
            {
                _calculator.Divide(number1, number2);
            });
        }

        [TestMethod]
        public void TestDivide_LargeNumber()
        {
            // Arrange
            decimal number1 = 10000;
            decimal number2 = 10;

            // Act
            decimal result = _calculator.Divide(number1, number2);

            // Assert
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void TestDivide_DecimalNumbers()
        {
            // Arrange
            decimal number1 = 5.5m;
            decimal number2 = 2.5m;

            // Act
            decimal result = _calculator.Divide(number1, number2);

            // Assert
            Assert.AreEqual(2.2m, result);
        }

        [TestMethod]
        public void TestDivide_NegativeNumbers()
        {
            // Arrange
            decimal number1 = -10;
            decimal number2 = 2;

            // Act
            decimal result = _calculator.Divide(number1, number2);

            // Assert
            Assert.AreEqual(-5, result);
        }
    }
}