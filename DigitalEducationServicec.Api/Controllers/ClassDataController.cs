using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.ClassData.Commands.Models;
using DigitalEducationServicec.Application.Features.ClassData.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassDataController : AppControllerBase
    {
        [HttpGet(Router.ClassDataRouting.List)]
        public async Task<IActionResult> GetClassDataList()
        {
            var response = await Mediator.Send(new GetClassDataListQuery());
            return Ok(response);
        }

        [HttpPost(Router.ClassDataRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddClassDataCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.ClassDataRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditClassDataCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.ClassDataRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteClassDataCommand() { ClassId = id }));
        }
    }
}
