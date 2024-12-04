using IronSoftware.Forms;
using IronPdf;
namespace ironpdf.CreateForms
{
    public class Section8
    {
        public void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Editable PDF Form</h2>");
            
            // Configure required parameters
            string name = "image1";
            uint pageIndex = 0;
            double x = 100;
            double y = 600;
            double width = 200;
            double height = 200;
            
            // Create the image form
            ImageFormField imageForm = new ImageFormField(name, pageIndex, x, y, width, height);
            
            pdf.Form.Add(imageForm);
            
            pdf.SaveAs("addImageForm.pdf");
        }
    }
}