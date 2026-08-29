using IronPdf;
namespace IronPdf.Examples.HowTo.Metadata
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = IronPdf.PdfDocument.FromFile("example.pdf");

            // MetaData is read-only; set its properties rather than replacing it.
            pdf.MetaData.Title = "MyDoc";
            pdf.MetaData.Author = "Me";
            pdf.MetaData.Subject = "Demo";
            pdf.MetaData.Keywords = "ironpdf,metadata";
            pdf.MetaData.Creator = "MyApp";
            pdf.MetaData.Producer = "IronPDF";
            pdf.MetaData.CreationDate = DateTime.Today;
            pdf.MetaData.ModifiedDate = DateTime.Now;

            pdf.SaveAs("updated_example.pdf");
        }
    }
}