using Entities.DataTransferObjects.CalismaGrubu;
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
    [Route("api/CalismaGrubus")]
    public class CalismaGrubusController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public CalismaGrubusController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Editor, Admin")]
        [HttpHead]
        [HttpGet(Name = "GetAllCalismaGrubusAsync")]
        public async Task<IActionResult> GetAllCalismaGrubusAsync()
        {
            var result = await _manager
                .CalismaGrubuService
                .GetAllCalismaGrubusAsync(false);

            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOneCalismaGrubuAsync([FromRoute(Name = "id")] int id)
        {
            var calismaGrubu = await _manager
            .CalismaGrubuService
            .GetOneCalismaGrubuByIdAsync(id, false);
            
            return Ok(calismaGrubu);
        }

        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOneCalismaGrubuAsync")]
        public async Task<IActionResult> CreateOneCalismaGrubuAsync([FromBody] CalismaGrubuDtoForInsertion personelPrimDto)
        {
            var personelPrim = await _manager.CalismaGrubuService.CreateOneCalismaGrubuAsync(personelPrimDto);
            return StatusCode(201, personelPrim); // CreatedAtRoute()
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOneCalismaGrubueAsync([FromRoute(Name = "id")] int id,[FromBody] CalismaGrubuDtoForUpdate personelPrimDto)
        {
            await _manager.CalismaGrubuService.UpdateOneCalismaGrubuAsync(id, personelPrimDto, false);
            return NoContent(); // 204
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOneCalismaGrubueAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.CalismaGrubuService.DeleteOneCalismaGrubuAsync(id, false);
            return NoContent();
        }
        

        [Authorize]
        [HttpGet("GetAllAdminsAsync")]
        public async Task<IActionResult> GetAllAdminsAsync([FromQuery] AdminParameters adminParameters)
        {
            var results = await _manager
                .CalismaGrubuService.GetAllAdminsAsync(false);

            return Ok(results);
        }

        [Authorize]
        [HttpGet("GetOneAdminByIdAsync/{id:int}")]
        public async Task<IActionResult> GetOneAdminByIdAsync([FromRoute(Name = "id")] int id)
        {
            var result = await _manager
            .CalismaGrubuService
            .GetOneAdminByIdAsync(id, false);

            return Ok(result);
        }

    }
}
