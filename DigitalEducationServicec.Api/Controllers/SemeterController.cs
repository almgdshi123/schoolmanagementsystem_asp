using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Parent.Commands.Models;
using DigitalEducationServicec.Application.Features.Parent.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemeterController : AppControllerBase
    {

        [HttpGet(Router.SemeterRouting.List)]
        public async Task<IActionResult> GetStudentList()
        {
            var response = await Mediator.Send(new GetParentListQuery());
            return Ok(response);
        }
        //[AllowAnonymous]
        //[HttpGet(Router.StudentRouting.Paginated)]
        //public async Task<IActionResult> Paginated([FromQuery] GetStudentPaginatedListQuery query)
        //{
        //    var response = await Mediator.Send(query);
        //    return Ok(response);
        //}
        [HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.StudentRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddParentCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        //   [HttpPut(Router.StudentRouting.Edit)]
        //public async Task<IActionResult> Edit([FromBody] EditStudentCommand command)
        //{
        //    var response = await Mediator.Send(command);
        //    return NewResult(response);
        //}
        //[HttpDelete(Router.StudentRouting.Delete)]
        //public async Task<IActionResult> Delete([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new DeleteStudentCommand(id)));
        //}
    }
}