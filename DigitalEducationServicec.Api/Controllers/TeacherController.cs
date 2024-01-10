using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Teacher.Commands.Models;
using DigitalEducationServicec.Application.Features.Teacher.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : AppControllerBase
    {
        [HttpGet(Router.TeacherRouting.List)]
        public async Task<IActionResult> GetClassDataList()
        {
            var response = await Mediator.Send(new GetTeacherListQuery());
            return Ok(response);
        }

        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetTeacherByIDQuery(id)));
        //}
        //[AllowAnonymous]
        //[HttpGet(Router.StudentRouting.Paginated)]
        //public async Task<IActionResult> Paginated([FromQuery] GetStudentPaginatedListQuery query)
        //{
        //    var response = await Mediator.Send(query);
        //    return Ok(response);
        //}
        [HttpPost(Router.TeacherRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddTeacherCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.StudentRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditTeacherCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.StudentRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteTeacherCommand() { TeacherId = id }));
        }
    }
}
