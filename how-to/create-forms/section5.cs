using System.Collections.Generic;
using IronPdf;
namespace IronPdf.Examples.HowTo.CreateForms
{
    public static class Section5
    {
        public static void Run()
        {
            // Instantiate ChromePdfRenderer
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h2>Combobox Form Field</h2>");
            
            // Configure required parameters
            string name = "combobox";
            string value = "Car";
            uint pageIndex = 0;
            double x = 100;
            double y = 700;
            double width = 60;
            double height = 15;
            var choices = new List<string>() { "Car", "Bike", "Airplane" };
            
            // Create combobox form field
            var comboboxForm = new ComboboxFormField(name, value, pageIndex, x, y, width, height, choices);
            
            // Add form
            pdf.Form.Add(comboboxForm);
            
            pdf.SaveAs("addComboboxForm.pdf");
        }
    }
}