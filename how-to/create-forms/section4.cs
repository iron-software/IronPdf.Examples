using IronSoftware.Forms;
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section4
    {
        public void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Checkbox Form Field</h2>");
            
            // Configure required parameters
            string name = "checkbox";
            string value = "no";
            uint pageIndex = 0;
            double x = 100;
            double y = 700;
            double width = 15;
            double height = 15;
            
            // Create checkbox form field
            var checkboxForm = new CheckboxFormField(name, value, pageIndex, x, y, width, height);
            
            // Add form
            pdf.Form.Add(checkboxForm);
            
            pdf.SaveAs("addCheckboxForm.pdf");
        }
    }
}