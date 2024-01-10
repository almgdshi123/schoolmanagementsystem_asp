using DigitalEducationServicec.Application.Features.Semesters.Commands.CreateSemester;
using DigitalEducationServicec.Application.Features.Semesters.Queries.GetSemesterList;
using MediatR;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;

namespace DigitalEducationServicec.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;


        
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;

        }
        [HttpGet("all", Name = "GetAllPosts")]
        public async Task<ActionResult<List<GetAllSemeterQuery>>> GetAllPosts()
        {
            var dtos = await _mediator.Send(new GetAllSemeterQuery());
            return Ok(dtos);
        }
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [HttpPost(Name = "AddPost")]
        public async Task<ActionResult<string>> Create([FromBody] CreateSemesterCommand createPostCommand)
        {
            string id = await _mediator.Send(createPostCommand);
            return Ok(id);
        }

    }
}