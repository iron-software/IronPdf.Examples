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
            var pdf = renderer.RenderHtmlAsPdf("<h1>Please Sign Below</h1>");
            
            // Define the properties for the signature form field.
            string fieldName = "ClientSignature";
            int pageIndex = 0; // Add to the first page.
            // Create the SignatureFormField object. Its position and size are
            // four numbers, not a Rectangle.
            var signatureField = new IronSoftware.Forms.SignatureFormField(
                fieldName, (uint)pageIndex, 50, 200, 300, 100);
            
            // Add the signature field to the PDF's form.
            pdf.Form.Add(signatureField);
            
            // Save the PDF with the new interactive signature field.
            pdf.SaveAs("interactive_signature.pdf");
        }
    }
}