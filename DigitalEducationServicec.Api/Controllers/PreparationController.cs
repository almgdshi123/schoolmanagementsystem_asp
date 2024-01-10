using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Preparation.Commands.Models;
using DigitalEducationServicec.Application.Features.Preparation.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreparationController : AppControllerBase
    {
        [HttpGet(Router.PreparationnRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetPreparationListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.PreparationnRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddPreparationCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.PreparationnRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditPreparationCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.PreparationnRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeletePreparationCommand() { PreparationId = id }));
        }
    }
}
