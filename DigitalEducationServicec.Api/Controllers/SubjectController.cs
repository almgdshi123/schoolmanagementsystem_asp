using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Subject.Commands.Models;
using DigitalEducationServicec.Application.Features.Subject.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : AppControllerBase
    {
        [HttpGet(Router.SubjectRouting.List)]
        public async Task<IActionResult> GetClassDataList()
        {
            var response = await Mediator.Send(new GetSubjectListQuery());
            return Ok(response);
        }

        [HttpGet(Router.SubjectRouting.GetByID)]
        public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new GetSubjectByIDQuery(id)));
        }

        [HttpPost(Router.SubjectRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddSubjectCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.SubjectRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditSubjectCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.SubjectRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteSubjectCommand() { SubjectId = id }));
        }
    }
}
