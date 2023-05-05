using Microsoft.AspNetCore.Mvc;
using WebApplicationAPI.CalculatorModule;

namespace WebApplicationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly ICalculator _calculator;

        public CalculatorController(ILogger<CalculatorController> logger, ICalculator calculator)
        {
            _logger = logger;
            _calculator = calculator;
        }

        [HttpGet("Add/{x}/{y}", Name = "SumTwoNumbers")]
        public int Get(int x, int y)
        {
           return _calculator.Calculate(x, y);
        }

    }
}
