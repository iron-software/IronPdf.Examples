using IronPdf;
namespace IronPdf.Examples.HowTo.CreateAccessiblePdfs508CSharp
{
    public static class Section1
    {
        public static void Run()
        {
            IronPdf.PdfDocument.FromFile("input.pdf").SaveAsPdfUA("output‑accessible.pdf");
        }
    }
}