# Text Replacement in PDF Documents

***Based on <https://ironpdf.com/how-to/find-replace-text/>***


Text replacement in PDFs is a highly beneficial feature that allows users to edit content swiftly and accurately—ideal for fixing errors, updating details, or customizing documents for various uses. This capability not only enhances efficiency but also significantly reduces the effort needed in managing documents that demand frequent updates or custom tailoring.

IronPDF provides a robust solution for text replacement in PDF documents, making it an essential tool for developers and professionals aiming to automate or modify PDF content effectively.

## Example of Text Replacement

You can replace text in any `PdfDocument` instance, irrespective of whether the PDF was newly created or imported. The `ReplaceTextOnAllPages` function requires the original text and the replacement text. If it fails to find the original text, an exception is thrown, indicating "Error while replacing text: failed to find text '.NET6'."

Below is an example showing how to replace the text in a new PDF document that includes the text '.NET6'.

### Sample Code

```cs
using IronPdf;
namespace ironpdf.FindReplaceText
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>");
            
            string oldText = ".NET6";
            string newText = ".NET7"; // Update text version
            
            // Perform text replacement across all pages
            pdf.ReplaceTextOnAllPages(oldText, newText);
            
            pdf.SaveAs("replaceText.pdf"); // Save the updated document
        }
    }
}
```

## Text Replacement on Specific Pages

IronPDF also allows for text replacement on designated pages, which helps tailor the updates to specific parts of your document. Methods like `ReplaceTextOnPage` and `ReplaceTextOnPages` can be utilized for singular or multiple page updates, respectively. Keep in mind that page indexes are zero-based.

### Single Page Text Replacement

```cs
using IronPdf;
namespace ironpdf.FindReplaceText
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>.NET6</h1>"); // Render HTML to PDF
            
            string oldText = ".NET6";
            string newText = ".NET7";
            
            // Apply text replacement on the first page
            pdf.ReplaceTextOnPage(0, oldText, newText);
            
            pdf.SaveAs("replaceTextOnSinglePage.pdf"); // Save the updated PDF
        }
    }
}
```

### Text Replacement Across Multiple Pages

```cs
using IronPdf;
namespace ironpdf.FindReplaceText
{
    public class Section3
    {
        public void Run()
        {
            string html = @"<p> .NET6 </p>
            <p> This is 1st Page </p>
            <div style = 'page-break-after: always;'></div>
            <p> This is 2nd Page</p>
            <div style = 'page-break-after: always;'></div>
            <p> .NET6 </p>
            <p> This is 3rd Page</p>";
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderHtmlAsPdf(html); // Render complex HTML
            
            string oldText = ".NET6";
            string newText = ".NET7";
            
            int[] pages = { 0, 2 }; // Specifying pages to replace text
            
            // Replace specified text on the first and third pages
            pdf.ReplaceTextOnPages(pages, oldText, newText);
            
            pdf.SaveAs("replaceTextOnMultiplePages.pdf"); // Output results to file
        }
    }
}
```

### PDF Preview

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/find-replace-text/replaceTextOnMultiplePages.pdf" width="100%" height="400px">
</iframe>

This adapted approach facilitates a more targeted and flexible manipulation of PDF content using IronPDF's capabilities, useful in various programming contexts.