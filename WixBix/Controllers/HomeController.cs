using System.Web.Mvc;

namespace WixBim.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Viewer()
        {
            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "About WixBix";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Me";

            return View();
        }
    }
}