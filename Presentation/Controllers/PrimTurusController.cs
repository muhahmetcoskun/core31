using Entities.DataTransferObjects.PrimTuru;
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
    [Route("api/PrimTurus")]
    public class PrimTurusController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public PrimTurusController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Editor, Admin")]
        [HttpHead]
        [HttpGet(Name = "GetAllPrimTurusAsync")]
        public async Task<IActionResult> GetAllPrimTurusAsync()
        {
            var result = await _manager
                .PrimTuruService
                .GetAllPrimTurusAsync(false);

            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOnePrimTuruAsync([FromRoute(Name = "id")] int id)
        {
            var primTuruParameters = await _manager
            .PrimTuruService
            .GetOnePrimTuruByIdAsync(id, false);
            
            return Ok(primTuruParameters);
        }

        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOnePrimTuruAsync")]
        public async Task<IActionResult> CreateOnePrimTuruAsync([FromBody] PrimTuruDtoForInsertion primTuruDto)
        {
            var primTuru = await _manager.PrimTuruService.CreateOnePrimTuruAsync(primTuruDto);
            return StatusCode(201, primTuru); // CreatedAtRoute()
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOnePrimTurueAsync([FromRoute(Name = "id")] int id,[FromBody] PrimTuruDtoForUpdate primTuruDto)
        {
            await _manager.PrimTuruService.UpdateOnePrimTuruAsync(id, primTuruDto, false);
            return NoContent(); // 204
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOnePrimTurueAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.PrimTuruService.DeleteOnePrimTuruAsync(id, false);
            return NoContent();
        }

    }
}
