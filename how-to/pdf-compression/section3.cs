using IronPdf;
namespace IronPdf.Examples.HowTo.PdfCompression
{
    public static class Section3
    {
        public static void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            CompressionOptions compressionOptions = new CompressionOptions();
            
            // Configure image compression
            compressionOptions.CompressImages = true;
            compressionOptions.JpegQuality = 80;
            compressionOptions.HighQualityImageSubsampling = true;
            compressionOptions.ShrinkImages = true;
            
            // Configure tree structure compression
            compressionOptions.RemoveStructureTree = true;
            
            pdf.Compress(compressionOptions);
            
            pdf.SaveAs("compressed.pdf");
        }
    }
}