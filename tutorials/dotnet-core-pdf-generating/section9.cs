[HttpPost]
public ActionResult TicketView(TicketModel model)
{
    IronPdf.License.LicenseKey = "YourLicenseKey";
    IronPdf.Installation.TempFolderPath = $@"{Directory.GetParent}/irontemp/";
    IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;
    var html = this.RenderViewAsync("_TicketPdf", model);
    var renderer = new IronPdf.ChromePdfRenderer();
    using var pdf = renderer.RenderHtmlAsPdf(html.Result, @"wwwroot/css");
    return File(pdf.Stream.ToArray(), "application/pdf");
}