using System.Web.Mvc;

namespace Arma3BattlEye.Web.Core
{
    [LoggingFilter]
    [Authorize]
    public abstract class BaseController : Controller
    {
         
    }
}