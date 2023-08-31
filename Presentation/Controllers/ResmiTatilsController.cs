using Entities.DataTransferObjects.ResmiTatil;
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
    [Route("api/ResmiTatils")]
    public class ResmiTatilsController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public ResmiTatilsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Editor, Admin")]
        [HttpHead]
        [HttpGet(Name = "GetAllResmiTatilsAsync")]
        public async Task<IActionResult> GetAllResmiTatilsAsync()
        {
            var resmiTatils = await _manager
                .ResmiTatilService
                .GetAllResmiTatilsAsync(false);

            return Ok(resmiTatils);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneResmiTatilAsync([FromRoute(Name = "id")] int id)
        {
            var resmiTatil = await _manager
            .ResmiTatilService
            .GetOneResmiTatilByIdAsync(id, false);
            
            return Ok(resmiTatil);
        }

        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOneResmiTatilAsync")]
        public async Task<IActionResult> CreateOneResmiTatilAsync([FromBody] ResmiTatilDtoForInsertion resmiTatilDto)
        {
            var resmiTatil = await _manager.ResmiTatilService.CreateOneResmiTatilAsync(resmiTatilDto);
            return StatusCode(201, resmiTatil); // CreatedAtRoute()
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneResmiTatileAsync([FromRoute(Name = "id")] int id,[FromBody] ResmiTatilDtoForUpdate resmiTatilDto)
        {
            await _manager.ResmiTatilService.UpdateOneResmiTatilAsync(id, resmiTatilDto, false);
            return NoContent(); // 204
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneResmiTatileAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.ResmiTatilService.DeleteOneResmiTatilAsync(id, false);
            return NoContent();
        }

    }
}
