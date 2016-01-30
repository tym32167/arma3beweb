using System.Web.Mvc;
using Arma3BattlEye.Web.Core;

namespace Arma3BattlEye.Web.Controllers
{
    public class ErrorController : BaseController 
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
    }
}