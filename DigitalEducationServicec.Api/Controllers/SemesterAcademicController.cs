using DigitalEducationServicec.Api.Base;
using DigitalEducationServicec.Application.Features.SemesterAcademic.Commands.Models;
using DigitalEducationServicec.Application.Features.SemesterAcademic.Queries.Models;
using DigitalEducationServicec.Domain.AppMetaData;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SemesterAcademicController : AppControllerBase
    {
        [HttpGet(Router.SemesterAcademicRouting.List)]
        public async Task<IActionResult> GetStageDataList()
        {
            var response = await Mediator.Send(new GetSemesterAcademicListQuery());
            return Ok(response);
        }
        //}
        //[HttpGet(Router.StudentRouting.GetByID)]
        //public async Task<IActionResult> GetStudentByID([FromRoute] int id)
        //{
        //    return NewResult(await Mediator.Send(new GetStudentByIDQuery(id)));
        //}

        [HttpPost(Router.SemesterAcademicRouting.Create)]
        public async Task<IActionResult> Create([FromBody] AddSemesterAcademicCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpPut(Router.SemesterAcademicRouting.Edit)]
        public async Task<IActionResult> Edit([FromBody] EditSemesterAcademicCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
        [HttpDelete(Router.SemesterAcademicRouting.Delete)]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            return NewResult(await Mediator.Send(new DeleteSemesterAcademicCommand() { SemesterAcademicId = id }));
        }
    }
}
