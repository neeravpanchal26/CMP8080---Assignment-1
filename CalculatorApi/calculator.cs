using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;

        public CalculatorController()
        {
            _calculator = new Calculator();
        }

        [HttpGet]
        public decimal Add(decimal number1 = 0, decimal number2 = 0)
        {
            return _calculator.Add(number1, number2);
        }

        [HttpGet]
        public decimal Subtract(decimal number1 = 0, decimal number2 = 0)
        {
            return _calculator.Subtract(number1, number2);
        }

        [HttpGet]
        public decimal Multiply(decimal number1 = 0, decimal number2 = 0)
        {
            return _calculator.Multiply(number1, number2);
        }

        [HttpGet]
        public decimal Divide(decimal number1 = 0, decimal number2 = 0)
        {
            return _calculator.Divide(number1, number2);
        }

        [HttpGet]
        public decimal Modulo(decimal number1 = 0, decimal number2 = 0)
        {
            return _calculator.Modulo(number1, number2);
        }
    }
}
