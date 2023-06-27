using EtablissementProject.BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EtablissementProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EtablissementController : ControllerBase
    {
        private readonly IEtablissementService _etablissementService;

        public EtablissementController(IEtablissementService etablissementService)
        {
            _etablissementService = etablissementService;
        }

        [HttpGet("getAllEtablissement")]
        public async Task<IActionResult> GetNewAllEtablissementAsync(string code)
        {
            return Ok(await _etablissementService.GetNewAllEtablissementAsync(code));
        }

    }
}
