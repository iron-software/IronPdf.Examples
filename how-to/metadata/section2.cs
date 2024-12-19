using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.HowTo.Metadata
{
    public static class Section2
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");
            
            Dictionary<string, string> newMetadata = new Dictionary<string, string>();
            newMetadata.Add("Title", "How to article");
            newMetadata.Add("Author", "IronPDF");
            
            // Set metadata dictionary
            pdf.MetaData.SetMetaDataDictionary(newMetadata);
            
            // Retreive metadata dictionary
            Dictionary<string, string> metadataProperties = pdf.MetaData.GetMetaDataDictionary();
        }
    }
}