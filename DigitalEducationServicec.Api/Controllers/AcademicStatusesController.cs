using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Models;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcademicStatusesController : AppControllerBase
    {
        [HttpGet(Router.AcademicStatusesRouting.List)]
        public async Task<IActionResult> GetAcademicStatusesList()
        {
            var response = await Mediator.Send(new GetAcademicStatusesListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.AcademicStatusesRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddAcademicStatusCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.AcademicStatusesRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditAcademicStatusCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.AcademicStatusesRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteAcademicStatusCommand() { StatusId = id }));
        }
    }
}
