using Entities.DataTransferObjects.PersonelPrim;
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
    [Route("api/PersonelPrims")]
    public class PersonelPrimsController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public PersonelPrimsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize(Roles = "Editor, Admin")]
        [HttpHead]
        [HttpGet(Name = "GetAllPersonelPrimsAsync")]
        public async Task<IActionResult> GetAllPersonelPrimsAsync()
        {
            var result = await _manager
                .PersonelPrimService
                .GetAllPersonelPrimsAsync(false);

            return Ok(result);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOnePersonelPrimAsync([FromRoute(Name = "id")] int id)
        {
            var personelPrimParameters = await _manager
            .PersonelPrimService
            .GetOnePersonelPrimByIdAsync(id, false);
            
            return Ok(personelPrimParameters);
        }

        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOnePersonelPrimAsync")]
        public async Task<IActionResult> CreateOnePersonelPrimAsync([FromBody] PersonelPrimDtoForInsertion personelPrimDto)
        {
            var personelPrim = await _manager.PersonelPrimService.CreateOnePersonelPrimAsync(personelPrimDto);
            return StatusCode(201, personelPrim); // CreatedAtRoute()
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOnePersonelPrimeAsync([FromRoute(Name = "id")] int id,[FromBody] PersonelPrimDtoForUpdate personelPrimDto)
        {
            await _manager.PersonelPrimService.UpdateOnePersonelPrimAsync(id, personelPrimDto, false);
            return NoContent(); // 204
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOnePersonelPrimeAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.PersonelPrimService.DeleteOnePersonelPrimAsync(id, false);
            return NoContent();
        }
        

        [Authorize]
        [HttpGet("GetAllAdminsAsync")]
        public async Task<IActionResult> GetAllAdminsAsync([FromQuery] AdminParameters adminParameters)
        {
            var result = await _manager
                .PersonelPrimService.GetAllAdminsAsync(false);

            return Ok(result);
        }

        [Authorize]
        [HttpGet("GetOneAdminByIdAsync/{id:int}")]
        public async Task<IActionResult> GetOneAdminByIdAsync([FromRoute(Name = "id")] int id)
        {
            var result = await _manager
            .PersonelPrimService
            .GetOneAdminByIdAsync(id, false);

            return Ok(result);
        }

    }
}
