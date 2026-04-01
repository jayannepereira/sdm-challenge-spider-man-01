using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpiderNetAPI.Models;

namespace SpiderNetAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MissoesController : ControllerBase
    {
        static List<MissaoAranha> missoes = new();
        [HttpGet]
        public ActionResult<IEnumerable<MissaoAranha>> Get()
        {
            return Ok(missoes);
        }
        [HttpPost]
        public ActionResult<MissaoAranha> Post(MissaoAranha missao)
        {
            if (missao.NivelPerigo < 1 || missao.NivelPerigo > 10)
            {
            return BadRequest("NivelPerigo deve estar entre 1 e 10.");
            }
            missoes.Add(missao);
            return CreatedAtAction(nameof(Get), new { id = missao.Id }, missao);
        }
    }
}