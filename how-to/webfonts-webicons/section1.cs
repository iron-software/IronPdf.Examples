using IronPdf.Engines.Chrome;
using IronPdf;
namespace IronPdf.Examples.HowTo.WebfontsWebicons
{
    public static class Section1
    {
        public static void Run()
        {
            var renderer = new IronPdf.ChromePdfRenderer();
            renderer.RenderingOptions.WaitFor.AllFontsLoaded(2000);

            renderer.RenderHtmlAsPdf("<link href=\"https://fonts.googleapis.com/css?family=Lobster\" rel=\"stylesheet\">" +
                                 "<link href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.0/css/all.min.css\" rel=\"stylesheet\">" +
                                 "<p style=\"font-family:'Lobster', serif; font-size:30px;\">Hello Google Font</p>" +
                                 "<i class=\"fa fa-coffee\" style=\"font-size:40px; color:#b00;\"></i>")
                .SaveAs("webfonts-icons.pdf");
        }
    }
}