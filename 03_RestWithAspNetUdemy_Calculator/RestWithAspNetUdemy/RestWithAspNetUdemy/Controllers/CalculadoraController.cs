using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaculatorController : ControllerBase
    {

        private readonly ILogger<CaculatorController> _logger;


        public CaculatorController(ILogger<CaculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {

            if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            } 
    
            return BadRequest("Invalid Input");
        }


        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult GetSubtraction(string firstNumber, string secondNumber)
        {
            if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }


        [HttpGet("disivision/{firstNumber}/{secondNumber}")]
        public IActionResult GetDivision(string firstNumber, string secondNumber)
        {
            if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }
            return BadRequest("Invalid Input");
        }


        [HttpGet("multiplication/{firstNumber}/{secondNumber}")]
        public IActionResult GetMultiplication(string firstNumber, string secondNumber)
        {

            if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
            {
                var result = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNumber);
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }


        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult GetMean(string firstNumber, string secondNumber)
        {

            if (IsNumeric(secondNumber) && IsNumeric(secondNumber))
            {
                
                var result = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("square-root/{firstNumber}/{secondNumber}")]
        public IActionResult GetSquareRoot(string firstNumber)
        {

            if (IsNumeric(firstNumber))
            {

                var result = Math.Sqrt((double)ConvertToDecimal(firstNumber));
                return Ok(result.ToString());
            }

            return BadRequest("Invalid Input");
        }
        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber,  System.Globalization.NumberStyles.Any,  System.Globalization.NumberFormatInfo.InvariantInfo,  out number);
            return isNumber;

        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if(decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }


      
    }
}
