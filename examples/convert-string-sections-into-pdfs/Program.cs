using IronPdf;
using System;
public class PDFSplitter
{
    public static void SplitStringIntoPDFs()
    {
        // Initialize the ChromePdfRenderer
        var renderer = new ChromePdfRenderer();
        // Define a large string with different sections separated by '---'
        string largeString = @"
            <html><body><h1>Section 1</h1><p>This is the first section of the string.</p></body></html>
            ---
            <html><body><h1>Section 2</h1><p>This is the second section of the string.</p></body></html>
            ---
            <html><body><h1>Section 3</h1><p>This is the third section of the string.</p></body></html>";
        // Split the large string into sections
        string[] sections = largeString.Split(new string[] { "---" }, StringSplitOptions.RemoveEmptyEntries);
        // Loop through each section and create a PDF
        int counter = 1;
        foreach (var section in sections)
        {
            // Use renderer to convert HTML section to PDF
            var pdf = renderer.RenderHtmlAsPdf(section.Trim());
            // Save each PDF as a separate file
            pdf.SaveAs($"Section{counter}.pdf");
            counter++;
        }
    }
}
