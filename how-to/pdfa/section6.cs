using System.IO;
using IronPdf;
namespace IronPdf.Examples.HowTo.Pdfa
{
    public static class Section6
    {
        public static void Run()
        {
            PdfDocument pdf = new PdfDocument("Google.pdf");
            
            // Initialize collection of embed file as Bytes and their file type
            byte[] fileData1 = File.ReadAllBytes("File1.png");
            byte[] fileData2 = File.ReadAllBytes("File2.xml");
            
            var embedFileConfig1 = new EmbedFileConfiguration(EmbedFileType.png);
            embedFileConfig1.EmbedFileName = "logo.png";
            
            var embedFileConfig2 = new EmbedFileConfiguration(EmbedFileType.xml)
            {
                EmbedFileName = "supportSystem.xml",
                AFDesc = "Internal system",
                ConformanceLevel = ConformanceLevel.XRECHNUNG,
                SchemaNamespace = SchemaNamespace.Zugferd1,
                SchemaPrefix = SchemaPrefix.rsm,
                PropertyVersion = PropertyVersion.v1p0,
                AFRelationship = AFRelationship.Supplement,
            };
            
            IEnumerable<EmbedFileByte> embedBytes = new[]
            {
                new EmbedFileByte(fileData1, embedFileConfig1),
                new EmbedFileByte(fileData2, embedFileConfig2)
            };
            
            // Convert to Pdf/A-3B with embeded files
            pdf.ConvertToPdfA(embedBytes).SaveAs("PdfACompliance.pdf");
        }
    }
}