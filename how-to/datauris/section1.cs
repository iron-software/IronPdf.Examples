using IronPdf;
namespace IronPdf.Examples.HowTo.Datauris
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Embed Images Effortlessly with IronPDF
            new IronPdf.ChromePdfRenderer.StaticRenderHtmlAsPdf("<img src='data:image/png;base64,...' />").SaveAs("output.pdf");
        }
    }
}