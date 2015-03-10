using System.Web.Mvc;

namespace AspNetMvc.Layouts
{
    public class GreetingsController : Controller
    {
        public ActionResult Hello()
        {
            return View();
        }

        public ActionResult Goodbye()
        {
            return View();
        }
    }
}