using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.Command.UserCommands;
using CQRS.Common.Dispatchers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CQRS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IDispatchers dispatchers;

        public WeatherForecastController(IDispatchers dispatchers)
        {
            this.dispatchers = dispatchers;
        }

        [HttpGet]
        public async void Get()
        {
           await dispatchers.SendAsync(new UserCommand(1, "kianoush", "dortaj", "kiadr9372@gmail.com"));
            
        }
    }
}
