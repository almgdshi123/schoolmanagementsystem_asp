using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Month.Commands.Models;
using DigitalEducationServicec.Application.Features.Month.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonthController : AppControllerBase
    {
        [HttpGet(Router.MonthRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetMonthListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.MonthRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddMonthCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.MonthRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditMonthCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.MonthRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteMonthCommand() { MonthId = id }));
        }
    }
}
