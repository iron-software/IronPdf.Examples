using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section6
    {
        public void Run()
        {
            [HttpPost]
            public ActionResult Index(ClientModel model)
            {
                if (ModelState.IsValid)
                {
                    ClientServices.AddClient(model);
                    return RedirectToAction("TicketView");
                }
              return View(model);
            }
        }
    }
}