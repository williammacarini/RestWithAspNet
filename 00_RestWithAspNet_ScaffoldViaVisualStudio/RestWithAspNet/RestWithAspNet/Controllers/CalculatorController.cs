using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstnumber}/{secondnumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);

                return Ok(sum.ToString());
            }

            return BadRequest("Invalid input");
        }

        [HttpGet("subtracao/{firstnumber}/{secondnumber}")]
        public IActionResult GetSubtracao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);

                return Ok(sub.ToString());
            }

            return BadRequest("Invalid input");
        }

        [HttpGet("divisao/{firstnumber}/{secondnumber}")]
        public IActionResult GetDivisao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var divisao = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);

                return Ok(divisao.ToString());
            }

            return BadRequest("Invalid input");
        }

        [HttpGet("media/{firstnumber}/{secondnumber}")]
        public IActionResult GetMedia(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var media = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;

                return Ok(media.ToString());
            }

            return BadRequest("Invalid input");
        }

        [HttpGet("raiz/{firstnumber}")]
        public IActionResult GetRaiz(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var raiz = Math.Sqrt((double)ConvertToDecimal(firstNumber));

                return Ok(raiz.ToString());
            }

            return BadRequest("Invalid input");
        }

        private bool IsNumeric(string number)
        {
            double value;
            bool isNumber = double.TryParse(
                number,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out value);
            return isNumber;
        }

        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue;

            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }

            return 0;
        }
    }
}
