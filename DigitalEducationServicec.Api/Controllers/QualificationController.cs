using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.Qualification.Commands.Models;
using DigitalEducationServicec.Application.Features.Qualification.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QualificationController : AppControllerBase
    {
        [HttpGet(Router.QualificationRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetQualificationListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.QualificationRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddQualificationCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.QualificationRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditQualificationCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.QualificationRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteQualificationCommand() { QualificationId = id }));
        }
    }
}
