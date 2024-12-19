using IronPdf;
namespace IronPdf.Examples.Tutorial.VbNetPdf
{
    public static class Section3
    {
        public static void Run()
        {
            Imports IronPdf
            
            Module Module1
                Sub Main()
                    Dim renderer = New ChromePdfRenderer()
                    Dim document = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf/")
                    document.SaveAs("UrlToPdf.pdf")
                    System.Diagnostics.Process.Start("UrlToPdf.pdf")
                End Sub
            End Module
        }
    }
}