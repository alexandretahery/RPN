using Microsoft.AspNetCore.Mvc;
using calculatrice_RPN.Services.Abstraction;


namespace calculatrice_RPN.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OperatorsController
    {
        private readonly IOperators operators;

        public OperatorsController(IOperators operators)
        {
            this.operators = operators;
        }

        [HttpPost("/plus")]
        public string PostPlus()
        {
            return operators.OpPlus();
        }


        [HttpPost("/min")]
        public string Postmin()
        {
            return operators.OpMinus();
        }

        [HttpPost("/multi")]
        public string PostMulti()
        {
            return operators.OpMulti();
        }

        [HttpPost("/Div")]
        public string PostDiv()
        {
            return operators.OpDiv();
        }

    }
}
