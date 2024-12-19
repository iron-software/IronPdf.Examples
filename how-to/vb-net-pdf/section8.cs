using IronPdf;
namespace IronPdf.Examples.HowTo.VbNetPdf
{
    public static class Section8
    {
        public static void Run()
        {
            Imports IronPdf
            
            Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
                Dim PdfOptions = New IronPdf.ChromePdfRenderOptions()
                IronPdf.AspxToPdf.RenderThisPageAsPDF(AspxToPdf.FileBehavior.Attachment, "MyPdf.pdf", PdfOptions)
            End Sub
        }
    }
}