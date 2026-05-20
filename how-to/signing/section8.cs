using IronSoftware.Drawing;
using IronPdf;
namespace IronPdf.Examples.HowTo.Signing
{
    public static class Section8
    {
        public static void Run()
        {
            // Create a new PDF to add the signature field to.
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("&lt;h1&gt;Please Sign Below&lt;/h1&gt;");
            
            // Define the properties for the signature form field.
            string fieldName = "ClientSignature";
            int pageIndex = 0; // Add to the first page.
            var fieldRect = new Rectangle(50, 200, 300, 100); // Position: (x, y), Size: (width, height)
            
            // Create the SignatureFormField object.
            var signatureField = new SignatureFormField(fieldName, pageIndex, fieldRect);
            
            // Add the signature field to the PDF's form.
            pdf.Form.Add(signatureField);
            
            // Save the PDF with the new interactive signature field.
            pdf.SaveAs("interactive_signature.pdf");
        }
    }
}