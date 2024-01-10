using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.MonthAcademic.Commands.Models;
using DigitalEducationServicec.Application.Features.MonthAcademic.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthAcademicController : AppControllerBase
    {
        [HttpGet(Router.MonthAcademicRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetMonthAcademicListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.MonthAcademicRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddMonthAcademicCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.MonthAcademicRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditMonthAcademicCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.MonthAcademicRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteMonthAcademicCommand() { MonthAcademicId = id }));
        }
    }
}
