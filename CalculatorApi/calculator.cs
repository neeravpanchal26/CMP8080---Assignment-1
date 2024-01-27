using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class calculator : ControllerBase
    {
        public decimal Add(decimal number1 = 0, decimal number2 = 0)
        {
            return number1 + number2;
        }
        public decimal Subtract(decimal number1 = 0, decimal number2 = 0)
        {
            decimal bigNumber = number1 > number2 ? number1 : number2;
            decimal smallNumber = number1 < number2 ? number1 : number2;
            return bigNumber - smallNumber;
        }
    }
}
