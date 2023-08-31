using Entities.DataTransferObjects.GunlukCalismaSuresi;
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
    [Route("api/GunlukCalismaSuresies")]
    public class GunlukCalismaSuresiesController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public GunlukCalismaSuresiesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Editor, Admin")]
        [HttpHead]
        [HttpGet(Name = "GetAllGunlukCalismaSuresiesAsync")]
        public async Task<IActionResult> GetAllGunlukCalismaSuresiesAsync()
        {
            var result = await _manager
                .GunlukCalismaSuresiService
                .GetAllGunlukCalismaSuresiesAsync(false);

            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneGunlukCalismaSuresiAsync([FromRoute(Name = "id")] int id)
        {
            var gunlukCalismaSuresi = await _manager
            .GunlukCalismaSuresiService
            .GetOneGunlukCalismaSuresiByIdAsync(id, false);
            
            return Ok(gunlukCalismaSuresi);
        }

        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOneGunlukCalismaSuresiAsync")]
        public async Task<IActionResult> CreateOneGunlukCalismaSuresiAsync([FromBody] GunlukCalismaSuresiDtoForInsertion gunlukCalismaSuresiDto)
        {
            var gunlukCalismaSuresi = await _manager.GunlukCalismaSuresiService.CreateOneGunlukCalismaSuresiAsync(gunlukCalismaSuresiDto);
            return StatusCode(201, gunlukCalismaSuresi); // CreatedAtRoute()
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneGunlukCalismaSuresieAsync([FromRoute(Name = "id")] int id,[FromBody] GunlukCalismaSuresiDtoForUpdate gunlukCalismaSuresiDto)
        {
            await _manager.GunlukCalismaSuresiService.UpdateOneGunlukCalismaSuresiAsync(id, gunlukCalismaSuresiDto, false);
            return NoContent(); // 204
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneGunlukCalismaSuresieAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.GunlukCalismaSuresiService.DeleteOneGunlukCalismaSuresiAsync(id, false);
            return NoContent();
        }

    }
}
