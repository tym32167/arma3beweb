using System.Web.Http;

namespace Arma3BEWeb.WebApi.Controllers
{
    public class TestController : ApiController
    {
        [Route("test")]
        public string Get() => "Hello, world!";
    }
}