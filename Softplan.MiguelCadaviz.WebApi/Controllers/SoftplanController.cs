using Microsoft.AspNetCore.Mvc;
using Softplan.MiguelCadaviz.WebApi.Domain;

namespace Softplan.MiguelCadaviz.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class SoftplanController : Controller
    {

        [HttpGet("calculajuros")]
        public decimal CalculaJuros(decimal valorInicial, int meses)
        {
            return Calculos.Truncar(Calculos.CalcularJurosCompostos(valorInicial, meses), 2);
        }
        

        [HttpGet("showmethecode")]
        public string ShowMeTheCode()
        {
            return @"";
        }
    }
}
