using Microsoft.AspNetCore.Mvc;

namespace Apiauth.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("health")]
        
        public object Health() =>  new  {messagem  = "API esta ok", status = "OK"};

        [HttpGet]
        [Route("ready")]

        public object Ready() =>  new  {messagem  = "API foi iniciada", status = "OK"};
    }
}