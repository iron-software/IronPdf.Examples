using IronPdf;
namespace IronPdf.Examples.Tutorial.VbNetPdf
{
    public static class Section2
    {
        public static void Run()
        {
            Imports IronPdf
            
            Module Module1
                Sub Main()
                    Dim renderer = New ChromePdfRenderer()
                    Dim document = renderer.RenderHtmlAsPdf("<h1> My First PDF in VB.NET</h1>")
                    document.SaveAs("MyFirst.pdf")
                    System.Diagnostics.Process.Start("MyFirst.pdf")
                End Sub
            End Module
        }
    }
}