using Entities.DataTransferObjects.PuantajVeriGirisi;
using Entities.RequestFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Services.Contracts;
using System.Text.Json;

namespace Presentation.Controllers
{
    //[ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ServiceFilter(typeof(LogFilterAttribute))]
    [ApiController]
    [Route("api/puantajVeriGirisis")]
    public class PuantajVeriGirisiesController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public PuantajVeriGirisiesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Editor, Admin")]
        [HttpHead]
        [HttpGet(Name = "GetAllPuantajVeriGirisisAsync")]
        public async Task<IActionResult> GetAllPuantajVeriGirisisAsync([FromQuery] PuantajVeriGirisiParameters puantajVeriGirisiParameters)
        {
            var result = await _manager
                .PuantajVeriGirisiService
                .GetAllPuantajVeriGirisisAsync(puantajVeriGirisiParameters, false);

            Response.Headers.Add("X-Pagination", 
                JsonSerializer.Serialize(result.metaData));

            return Ok(result.puantajVeriGirisis);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOnePuantajVeriGirisiAsync([FromRoute(Name = "id")] int id)
        {
            var puantajVeriGirisi = await _manager
            .PuantajVeriGirisiService
            .GetOnePuantajVeriGirisiByIdAsync(id, false);
            
            return Ok(puantajVeriGirisi);
        }

        [Authorize]
        [HttpGet("details")]
        public async Task<IActionResult> GetAllPuantajVeriGirisiesWithDetailsAsync()
        {
            return Ok(await _manager
                .PuantajVeriGirisiService
                .GetAllPuantajVeriGirisiesWithDetailsAsync(false));
        }

        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOnePuantajVeriGirisiAsync")]
        public async Task<IActionResult> CreateOnePuantajVeriGirisiAsync([FromBody] PuantajVeriGirisiDtoForInsertion puantajVeriGirisiDto)
        {
            var puantajVeriGirisi = await _manager.PuantajVeriGirisiService.CreateOnePuantajVeriGirisiAsync(puantajVeriGirisiDto);
            return StatusCode(201, puantajVeriGirisi); // CreatedAtRoute()
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOnePuantajVeriGirisiAsync([FromRoute(Name = "id")] int id,
            [FromBody] PuantajVeriGirisiDtoForUpdate puantajVeriGirisiDto)
        {
            await _manager.PuantajVeriGirisiService.UpdateOnePuantajVeriGirisiAsync(id, puantajVeriGirisiDto, false);
            return NoContent(); // 204
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOnePuantajVeriGirisiAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.PuantajVeriGirisiService.DeleteOnePuantajVeriGirisiAsync(id, false);
            return NoContent();
        }

    }
}
