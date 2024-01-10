using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Homework.Commands.Models;
using DigitalEducationServicec.Application.Features.Homework.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeworkController : AppControllerBase
    {
        [HttpGet(Router.HomeworkRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetHomeworkListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.HomeworkRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddHomeworkCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.HomeworkRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditHomeworkCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.HomeworkRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteHomeworkCommand() { HomeworkId = id }));
        }
    }
}
