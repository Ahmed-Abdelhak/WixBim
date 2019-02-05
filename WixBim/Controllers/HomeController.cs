using System.Configuration;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Xbim.Ifc;
using Xbim.ModelGeometry.Scene;

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

        public ActionResult Uploader()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Uploader(HttpPostedFileBase file)
        {
            if (file == null) return Content("Please Choose .ifc File and upload it");
            if (file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var path = Path.Combine(Server.MapPath("../content/data"), fileName);
                file.SaveAs(path);
                ConvertToWexBIM(path);
                ViewBag.Message = "File Uploaded Successfully";
            }

            return RedirectToAction("Viewer");
            //return View();
        }

        private void ConvertToWexBIM(string filePath)
        {
            //  const string fileName = "../../my.ifc";
            using (var model = IfcStore.Open(filePath))
            {
                var context = new Xbim3DModelContext(model);
                context.CreateContext();


                // physical full path in drive
                var wexBimFullPath = Path.ChangeExtension(filePath, "wexBIM");

                var wexBimFileName = Path.GetFileName(wexBimFullPath);

                ConfigurationManager.AppSettings.Set("wexBIMFileName", wexBimFileName);
                ConfigurationManager.AppSettings.Set("wexBIMFullPath", "../content/data/" + wexBimFileName);

                using (var wexBiMfile = System.IO.File.Create(wexBimFullPath))
                {
                    using (var wexBimBinaryWriter = new BinaryWriter(wexBiMfile))
                    {
                        model.SaveAsWexBim(wexBimBinaryWriter);
                        wexBimBinaryWriter.Close();
                    }
                    wexBiMfile.Close();
                }

            }
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