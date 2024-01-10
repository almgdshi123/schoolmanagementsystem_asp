using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Models;
using DigitalEducationServicec.Application.Features.AcademicSystems.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicSystemsController : AppControllerBase
    {
        [HttpGet(Router.AcademicSystemsRouting.List)]
        public async Task<IActionResult> GetAcademicStatusesList()
        {
            var response = await Mediator.Send(new GetAcademicSystemsListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.AcademicSystemsRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddAcademicSystemCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.AcademicSystemsRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditAcademicSystemCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.AcademicSystemsRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteAcademicSystemCommand() { SystemId = id }));
        }
    }
}
