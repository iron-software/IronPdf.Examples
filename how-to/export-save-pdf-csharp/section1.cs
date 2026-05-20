using IronPdf;
namespace IronPdf.Examples.HowTo.ExportSavePdfCsharp
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Export or save your PDF in one line!
            new IronPdf.ChromePdfRenderer().RenderHtmlAsPdf("<h1>HelloPDF</h1>").SaveAs("myExportedFile.pdf");
        }
    }
}