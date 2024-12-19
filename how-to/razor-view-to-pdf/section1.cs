using IronPdf;
namespace IronPdf.Examples.HowTo.RazorViewToPdf
{
    public static class Section1
    {
        public static void Run()
        {
            Response.Clear();
            Response.ContentType = "application/pdf";
            Response.AddHeader("Content-Disposition", "attachment;filename=\"FileName.pdf\"");
            Response.BinaryWrite(System.IO.File.ReadAllBytes("PdfName.pdf"));
            Response.Flush();
            Response.End();
        }
    }
}