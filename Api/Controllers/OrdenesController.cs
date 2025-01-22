using Domian.Entities;
using Infrastructure.Gateway;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdenesController : ControllerBase
    {
        private readonly OrdenesService _ordenesService;

        public OrdenesController(OrdenesService identityService)
        {
            _ordenesService = identityService;
        }

        [HttpPost("Ordenes")]
        public async Task<ActionResult> Ordenes(Request request)
        {
            var result = await _ordenesService.PostRequestAsync(request);
            return Ok(result);
        }

       
    }
}
