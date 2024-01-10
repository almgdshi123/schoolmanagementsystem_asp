using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Stage.Commands.Models;
using DigitalEducationServicec.Application.Features.Stage.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StageController : AppControllerBase
    {
        [HttpGet(Router.StageRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetStageListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.StageRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddStageCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.StageRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditStageCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.StageRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteStageCommand() { StageId = id }));
        }
    }
}
