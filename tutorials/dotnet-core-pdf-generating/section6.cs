using IronPdf;
namespace IronPdf.Examples.Tutorial.DotnetCorePdfGenerating
{
    public static class Section6
    {
        public static void Run()
        {
            // ManipulateExistingPdf.cs — .NET 8 LTS compatible
            using IronPdf;
            using System.Linq;
            
            // Step 1: Open two existing files (password-protected PDFs are supported)
            PdfDocument invoice  = PdfDocument.FromFile("invoice.pdf", "ReadOnly");   // open with user pwd
            PdfDocument tAndCs   = PdfDocument.FromFile("terms.pdf");                 // no pwd required
            
            // Step 2: Merge them (invoice pages first, then T&Cs)
            PdfDocument mergedPdf = PdfDocument.Merge(invoice, tAndCs);               // 1-liner merge
            
            // Step 3: Apply a diagonal CONFIDENTIAL watermark to every page
            mergedPdf.ApplyStamp(
                "<div style='font-size:60px;color:#d9534f;opacity:0.2;transform:rotate(-45deg);"
              + "width:100%;text-align:center;'>CONFIDENTIAL</div>",
                verticalAlignment   : VerticalAlignment.Center,
                horizontalAlignment : HorizontalAlignment.Center);
            
            // Step 4: Extract all text and the first image for audit purposes
            string fullText = mergedPdf.ExtractAllText();
            var    image    = mergedPdf.ExtractAllImages().FirstOrDefault();
            
            // Step 5: Save or stream
            mergedPdf.SaveAs("invoice-with-terms.pdf");
        }
    }
}