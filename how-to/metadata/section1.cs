using IronPdf;
namespace IronPdf.Examples.HowTo.Metadata
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Edit PDF Metadata Effortlessly!
            IronPdf.PdfDocument.FromFile("example.pdf")
                .MetaData = new IronPdf.PdfMetaData { 
                    Title="MyDoc", Author="Me", Subject="Demo", Keywords="ironpdf,metadata", Creator="MyApp", Producer="IronPDF", CreationDate=DateTime.Today, ModifiedDate=DateTime.Now 
                }
                .SaveAs("updated_example.pdf");
        }
    }
}