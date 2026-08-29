using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfa
{
    public static class Section8
    {
        public static void Run()
        {
            var config = new EmbedFileConfiguration(EmbedFileType.xml)
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
            
            // Files are embedded as part of the PDF/A save, not beforehand.
            document.SaveAsPdfA(
                "output-with-configured-attachment.pdf",
                new[] { new EmbedFilePath("path/to/attachment", config) },
                PdfAVersions.PdfA3b);
        }
    }
}