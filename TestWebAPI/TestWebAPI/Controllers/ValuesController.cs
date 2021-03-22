using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace TestWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            return Ok(await Task.FromResult($"Pod is running on machine {Environment.MachineName}"));
        }
    }
}
