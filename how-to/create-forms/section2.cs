using IronSoftware.Forms;
using IronPdf;
namespace IronPdf.Examples.HowTo.CreateForms
{
    public static class Section2
    {
        public static void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Editable PDF Form</h2>");
            
            // Configure required parameters
            string name = "firstname";
            string value = "first name";
            uint pageIndex = 0;
            double x = 100;
            double y = 700;
            double width = 50;
            double height = 15;
            
            // Create text form field
            var textForm = new TextFormField(name, value, pageIndex, x, y, width, height);
            
            // Add form
            pdf.Form.Add(textForm);
            
            pdf.SaveAs("addTextForm.pdf");
        }
    }
}