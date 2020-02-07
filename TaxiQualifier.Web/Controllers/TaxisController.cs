using Microsoft.AspNetCore.Mvc;

namespace TaxiQualifier.Web.Controllers
{
    public class TaxisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}