using calculatrice_RPN.Services.Abstraction;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace calculatrice_RPN.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PileController : ControllerBase
    {
        private readonly ICalculatriceService calculatriceService;

        public PileController(ICalculatriceService calculatriceService)
        {
            this.calculatriceService = calculatriceService;
        }

        /// <summary>
        /// Récupération de la pile
        /// </summary>        
        [HttpGet("/get_pile")]
        public IEnumerable<string> Get()
        {
            return calculatriceService.DisplayPile();
        }

        /// <summary>
        /// ajoute dans la pile
        /// </summary>
        [HttpPost("/add_pile")]
        public void Post([FromBody] string value)
        {
            calculatriceService.AddPile(value);
        }


        /// <summary>
        /// clean la pile
        /// </summary>
        [HttpDelete("/clean_pile")]
        public void Delete()
        {
            calculatriceService.CleanPile();
        }
    }
}
