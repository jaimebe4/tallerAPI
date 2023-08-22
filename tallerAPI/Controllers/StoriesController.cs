using tallerAPI.Data.Models;
using tallerAPI.Data.Dto;
using tallerAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace tallerAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StoriesController : ControllerBase
    {
        private readonly IStorieService _storieService;

        public StoriesController(IStorieService storieService)
        {
            _storieService = storieService;
        }

        [HttpPost]
        [Route("PostObtenerHistorias")]
        public async Task<ActionResult<IEnumerable<StoriesDto>>> PostObtenerHistorias()
        {

            var storie = await _storieService.PostObtenerHistoriasAsync();

            if (storie == null)
            {
                return NotFound();
            }

            return Ok(storie);
        }

        [HttpPost]
        [Route("PostCrearHistoria")]
        public async Task<ActionResult> PostCrearHistoria(Storie storie)
        {

            if (storie == null)
            {
                return Problem("Entity set 'TallerApiDBContext.stories'  is null.");
            }

            var _storie = await _storieService.PostCrearHistoriaAsync(storie);

            if (_storie == null)
            {
                return Problem("Error creando la nueva historia");
            }

            return Ok();
        }
    }
}
