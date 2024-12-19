using IronPdf;
namespace IronPdf.Examples.HowTo.VbNetPdf
{
    public static class Section1
    {
        public static void Run()
        {
            Module Module1
                Sub Main()
                    Dim renderer = New ChromePdfRenderer()
                    Dim document = renderer.RenderHtmlAsPdf("<h1> My First PDF in VB.NET</h1>")
                    document.SaveAs("MyFirst.pdf")
                End Sub
            End Module
        }
    }
}