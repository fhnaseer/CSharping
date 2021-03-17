using System.Web.Mvc;

namespace Framework.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var output = Library.Math.Subtract(32, 0);
            ViewBag.Title = $"Home Page: {output}";
            return View();
        }
    }
}
