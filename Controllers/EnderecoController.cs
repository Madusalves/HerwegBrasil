using HerwegBrasil.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HerwegBrasil.Controllers
{
    [ApiController]
    [Route("/api/v1[controller]")] 
    public class EnderecoController : ControllerBase
    {
        public readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("/api/cep/v1/{cep}")]
        public async Task<ActionResult> SearchCep([FromRoute] string cep)
        {
            var DataReturn  = await _enderecoService.SearchCep(cep);

            if(DataReturn.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(DataReturn);
            }
            else
            {
                return StatusCode((int)DataReturn.CodigoHttp, DataReturn.ErrorReturn);
            }
        }
    }
}
