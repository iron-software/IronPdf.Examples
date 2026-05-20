using IronPdf;
namespace IronPdf.Examples.HowTo.CreateAccessiblePdfs508CSharp
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Make your PDF Section508 and PDF/UA compliant in one call!
            IronPdf.PdfDocument.FromFile("input.pdf").SaveAsPdfUA("output‑accessible.pdf");
        }
    }
}