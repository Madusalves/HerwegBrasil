using HerwegBrasil.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HerwegBrasil.Controllers
{
    [ApiController]
    [Route("/api/v1[controller]")]
    public class BancoController : ControllerBase
    {
        public readonly IBancoService _bancoService;

        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("busca/todos")]
        public async Task<ActionResult> SearchAllBank()
        {
            var response = await _bancoService.SearchAllBank();

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DataReturn);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErrorReturn);
            }
        }


        [HttpGet("busca/{code}")]
        public async Task<ActionResult> SearchBank(string code)
        {
            var response = await _bancoService.SearchBank(code);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DataReturn);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErrorReturn);
            }
        }
    }
}
