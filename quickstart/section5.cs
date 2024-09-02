using IronPdf;
using System;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using var PDF = IronPdf.ChromePdfRenderer.StaticRenderUrlAsPdf(new Uri("https://en.wikipedia.org"));
            return File(PDF.BinaryData, "application/pdf", "Wiki.Pdf");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}