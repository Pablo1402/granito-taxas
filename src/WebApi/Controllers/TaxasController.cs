using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Dtos.Response;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxasController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> BuscarTaxa()
        {
            var taxa = new TaxasDto() { Taxa = Convert.ToDecimal(Environment.GetEnvironmentVariable("TAXA")) / 100};
            return Ok(taxa);
        }

    }
}
