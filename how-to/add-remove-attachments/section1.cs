using IronPdf;
namespace IronPdf.Examples.HowTo.AddRemoveAttachments
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Effortlessly Manage PDF Attachments
            var pdf = IronPdf.PdfDocument.FromFile("example.pdf");
            pdf.Attachments.AddAttachment("file.txt", System.IO.File.ReadAllBytes("file.txt"));
            pdf.SaveAs("updated.pdf");
        }
    }
}