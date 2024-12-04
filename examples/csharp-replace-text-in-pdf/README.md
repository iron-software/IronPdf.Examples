***Based on <https://ironpdf.com/examples/csharp-replace-text-in-pdf/>***

Using IronPDF, you can seamlessly locate and modify text within your PDF documents. This feature is particularly useful for streamlining document workflows without needing external applications.

Here’s how you can implement text replacement in a PDF document using IronPDF:

```csharp
// First, ensure IronPDF is installed in your project
// PM> Install-Package IronPdf

using IronPdf;

// Create a new instance of the PdfDocument class from an existing file
var pdfDocument = new PdfDocument("input.pdf");

// Replace text within the PDF
// Parameters: oldText, newText, caseSensitive (optional), matchWholeWord (optional)
pdfDocument.ReplaceText("oldText", "newText");

// Save the updated PDF to a new file
pdfDocument.SaveAs("updated.pdf");
```

This code sample initializes `IronPdf.PdfDocument` by loading a PDF file, replaces specified text, and saves the modified version of the document. Make sure to replace `"input.pdf"`, `"oldText"`, and `"newText"` with your actual file path and content.

For more information and additional functionalities, you can visit the official IronPDF documentation at [IronPDF Documentation](https://ironpdf.com/documentation/).