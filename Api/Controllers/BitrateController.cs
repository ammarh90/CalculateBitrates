using CalculateBitrates.Api.ServiceInterfaces;
using CalculateBitrates.DataLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalculateBitrates.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BitrateController : ControllerBase
    {
        private readonly INICService _nicService;
        public BitrateController(INICService nicService)
        {
            _nicService = nicService;
        }

        [HttpPost("calculate")]
        public Task<List<Response>> Post([FromBody] DeviceInfo data)
        {
            return _nicService.PrintCalculateBitrates(data);
        }
    }
}
