using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Specialization.Commands.Models;
using DigitalEducationServicec.Application.Features.Specialization.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializationController : AppControllerBase
    {
        [HttpGet(Router.SpecializationRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetSpecializationListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.SpecializationRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddSpecializationCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.SpecializationRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditSpecializationCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.SpecializationRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteSpecializationCommand() { SpecializationId = id }));
        }
    }
}
