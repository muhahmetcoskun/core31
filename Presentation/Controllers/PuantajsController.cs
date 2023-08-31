using Entities.DataTransferObjects.Puantaj;
using Entities.Exceptions;
using Entities.Models;
using Entities.RequestFeatures;
using Marvin.Cache.Headers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Presentation.ActionFilters;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    //[ApiVersion("1.0")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ServiceFilter(typeof(LogFilterAttribute))]
    [ApiController]
    [Route("api/puantajs")]
    public class PuantajsController : ControllerBase
    {
        private readonly IServiceManager _manager;
        public PuantajsController(IServiceManager manager)
        {
            _manager = manager;
        }

        [Authorize]
        [HttpHead]
        [HttpGet(Name = "GetAllPuantajsAsync")]
        [ResponseCache(Duration = 60)]
        public async Task<IActionResult> GetAllPuantajsAsync([FromQuery] PuantajParameters puantajParameters)
        {
            var result = await _manager
                .PuantajService
                .GetAllPuantajsAsync(puantajParameters, false);

            Response.Headers.Add("X-Pagination",
                JsonSerializer.Serialize(result.metaData));

            return Ok(result.puantajs);
        }

        [Authorize]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetOnePuantajAsync([FromRoute(Name = "id")] int id)
        {
            var puantaj = await _manager
            .PuantajService
            .GetOnePuantajByIdAsync(id, false);
            
            return Ok(puantaj);
        }

        [Authorize]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPost(Name = "CreateOnePuantajAsync")]
        public async Task<IActionResult> CreateOnePuantajAsync([FromBody] PuantajDtoForInsertion puantajDto)
        {
            var puantaj = await _manager.PuantajService.CreateOnePuantajAsync(puantajDto);
            return StatusCode(201, puantaj); // CreatedAtRoute()
        }

        [Authorize(Roles = "Editor, Admin")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateOnePuantajAsync([FromRoute(Name = "id")] int id,[FromBody] PuantajDtoForUpdate puantajDto)
        {
            await _manager.PuantajService.UpdateOnePuantajAsync(id, puantajDto, false);
            return NoContent(); // 204
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteOnePuantajAsync([FromRoute(Name = "id")] int id)
        {
            await _manager.PuantajService.DeleteOnePuantajAsync(id, false);
            return NoContent();
        }

        [Authorize]
        [HttpPost("PuantajCizelgesiReportAsync")]
        public async Task<FileResult> PuantajCizelgesiReportAsync([FromQuery] PuantajParameters puantajParameters)
        {
            var fileStream = await _manager.PuantajService.PuantajCizelgesiReportAsync(puantajParameters);
            return File(fileStream, "application/pdf", "PuantajCizelgesi.pdf");
        }

    }
}
