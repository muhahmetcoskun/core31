using Entities.DataTransferObjects.UygulamaYetki;
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
    [Route("api/UygulamaYetkies")]
    public class UygulamaYetkiesController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public UygulamaYetkiesController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Editor, Admin")]
        [HttpHead]
        [HttpGet(Name = "GetAllUygulamaYetkiesAsync")]
        public async Task<IActionResult> GetAllUygulamaYetkiesAsync()
        {
            var result = await _manager
                .UygulamaYetkiService
                .GetAllUygulamaYetkiesAsync(false);

            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneUygulamaYetkiAsync([FromRoute(Name = "id")] int id)
        {
            var puantajVeriGirisi = await _manager
            .UygulamaYetkiService
            .GetOneUygulamaYetkiByIdAsync(id, false);
            
            return Ok(puantajVeriGirisi);
        }

        [Authorize]
        [HttpGet("details")]
        public async Task<IActionResult> GetAllUygulamaYetkiesWithDetailsAsync()
        {
            return Ok(await _manager
                .UygulamaYetkiService
                .GetAllUygulamaYetkiesWithDetailsAsync(false));
        }

        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOneUygulamaYetkiAsync")]
        public async Task<IActionResult> CreateOneUygulamaYetkiAsync([FromBody] UygulamaYetkiDtoForInsertion uygulamaYetkiDto)
        {
            var puantajVeriGirisi = await _manager.UygulamaYetkiService.CreateOneUygulamaYetkiAsync(uygulamaYetkiDto);
            return StatusCode(201, puantajVeriGirisi); // CreatedAtRoute()
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneUygulamaYetkieAsync([FromRoute(Name = "id")] int id,
            [FromBody] UygulamaYetkiDtoForUpdate uygulamaYetkiDto)
        {
            await _manager.UygulamaYetkiService.UpdateOneUygulamaYetkiAsync(id, uygulamaYetkiDto, false);
            return NoContent(); // 204
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneUygulamaYetkieAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.UygulamaYetkiService.DeleteOneUygulamaYetkiAsync(id, false);
            return NoContent();
        }

    }
}
