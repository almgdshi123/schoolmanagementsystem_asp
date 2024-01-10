using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Parent.Commands.Models;
using DigitalEducationServicec.Application.Features.Parent.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParentController : AppControllerBase
    {
        [HttpGet(Router.ParentRouting.List)]
        public async Task<IActionResult> GetClassDataList()
        {
            var response = await Mediator.Send(new GetParentListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.ClassDataRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddParentCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.ClassDataRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditParentCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.ClassDataRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteParentCommand() { ParentId = id }));
        }
    }
}
