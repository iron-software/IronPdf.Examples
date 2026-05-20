using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfa
{
    public static class Section8
    {
        public static void Run()
        {
            var config = new EmbedFileConfiguration
            {
                EmbedFileName = "Attachment.xml",
                AFDesc = "Associated File Description",
                ConformanceLevel = ConformanceLevel.EN16931,
                SchemaNamespace = SchemaNamespace.facturX,
                SchemaPrefix = SchemaPrefix.fx,
                PropertyVersion = PropertyVersion.v1,
                AFRelationship = AFRelationship.Alternative
            };
            
            // Load a PDF document
            var document = PdfDocument.FromFile("wikipedia.pdf");
            
            // Configure embedded file parameters
            document.EmbedFileFromFilePath("path/to/attachment", config);
            
            // Save the document as PDF/A-3b
            document.SaveAsPdfA3B("output-with-configured-attachment.pdf");
        }
    }
}