using IronSoftware.Forms;
using IronPdf;
namespace IronPdf.Examples.HowTo.CreateForms
{
    public static class Section10
    {
        public static void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
            
            // Configure required parameters
            string name = "cert";
            uint pageIndex = 0;
            double x = 100;
            double y = 600;
            double width = 300;
            double height = 100;
            
            // Create signature
            SignatureFormField signature = new SignatureFormField(name, pageIndex, x, y, width, height);
            
            // Add signature
            pdf.Form.Add(signature);
            
            pdf.SaveAs("signature.pdf");
        }
    }
}