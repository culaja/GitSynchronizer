using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GitWebHookWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class WebHookController : ControllerBase
    {
        [HttpPost]
        public async Task Post([FromBody] PushedGitEvent pushedGitEvent )
        {
            Console.WriteLine(pushedGitEvent.commits.First().message);
        }
    }
}