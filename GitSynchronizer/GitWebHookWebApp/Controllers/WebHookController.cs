using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GitWebHookWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class WebHookController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] PushedGitEvent pushedGitEvent )
        {
            Console.WriteLine(pushedGitEvent.commits.First().message);
        }
    }
}