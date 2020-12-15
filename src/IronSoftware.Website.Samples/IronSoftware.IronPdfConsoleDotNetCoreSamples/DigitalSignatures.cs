using IronPdf;
using IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    public class DigitalSignatures : IExecuteApp
    {
        public string OutputPath { get ; set; }

        public void Run()
        {
            // Install IronPdf with Nuget:  PM> Install-Package IronPdf
      
            //The quickest way to cryptographically sign an existing PDF a digital certificate
            //new IronPdf.PdfSignature("Iron.p12", "123456").SignPdfFile("any.pdf");

            // All done in 1 line of code!
            //Advanced example for more control
            // Step 1. Create a PDF
            IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();
            PdfDocument doc = Renderer.RenderHtmlAsPdf("<h1>Testing 2048 bit digital security</h1>");
            // Step 2. Create a Signature.
            // You may create a .pfx or .p12 PDF signing certificate using Adobe Acrobat Reader. 
            // Read: https://helpx.adobe.com/acrobat/using/digital-ids.html
            var signature = new IronPdf.PdfSignature(@"Inputs\cert123.pfx", "123");
            // Step 3. Optional signing options and a handwritten signature graphic
            signature.SigningContact = "support@ironsoftware.com";
            signature.SigningLocation = "Chicago, USA";
            signature.SigningReason = "To show how to sign a PDF";
            signature.LoadSignatureImageFromFile(@"Inputs\logo.png");
            //Step 4. Sign the PDF with the PdfSignature. Multiple signing certificates may be used
            doc.SignPdfWithDigitalSignature(signature);
            //Step 4. The PDF is not signed until saved to file, steam or byte array.
            doc.SaveAs($@"{OutputPath}\DigitalSignatures.pdf");
        }
    }
}
