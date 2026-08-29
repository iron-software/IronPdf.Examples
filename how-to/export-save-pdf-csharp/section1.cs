using IronPdf;
namespace IronPdf.Examples.HowTo.ExportSavePdfCsharp
{
    public static class Section1
    {
        public static void Run()
        {
            new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>HelloPDF</h1>").SaveAs("myExportedFile.pdf");
        }
    }
}