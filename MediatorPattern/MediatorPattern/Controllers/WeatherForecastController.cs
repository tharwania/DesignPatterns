using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mediator;
using MediatorPattern.CQRS.WeatherQuerries;

namespace MediatorPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator<GetWeatherRequest, IEnumerable<WeatherForecast>>  _mediator;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator<GetWeatherRequest, IEnumerable<WeatherForecast>> mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return _mediator.Send(new GetWeatherRequest());

        }
    }
}
