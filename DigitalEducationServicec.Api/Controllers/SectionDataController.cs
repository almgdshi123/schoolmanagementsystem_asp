using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.SectionData.Commands.Models;
using DigitalEducationServicec.Application.Features.SectionData.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectionDataController : AppControllerBase
    {
        [HttpGet(Router.SectionDataRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetSectionDataListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.SectionDataRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddSectionDataCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.SectionDataRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditSectionDataCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.SectionDataRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteSectionDataCommand() { SectionId = id }));
        }
    }
}
