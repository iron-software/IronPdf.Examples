# How to Convert Microsoft Word to PDF in C#

***Based on <https://ironpdf.com/how-to/docx-to-pdf/>***


A DOCX file originates from Microsoft Word, part of the comprehensive Microsoft Office suite. Utilizing the Office Open XML (OOXML) format, it ensures efficiency and compatibility across various platforms. Introduced in Microsoft Word 2007, the DOCX format has since become the standard, replacing the older DOC format.

IronPDF enables seamless conversion from word documents to PDFs, offering features like Mail Merge to create personalized batches of documents tailored for individual recipients. This transformation from DOCX to PDF not only ensures broad compatibility but also maintains original formatting and increases document security.

## Quickstart: Convert DOCX to PDF Using IronPDF

IronPDF simplifies converting DOCX to PDF in C# utilizing the `DocxToPdfRenderer` class and its `RenderDocxAsPdf` method. This guide provides a straightforward approach to converting documents, ensuring the final PDF maintains all original characteristics and format compatibility.

```cs
:title=Convert DOCX to PDF in One line of Code!
var pdfRenderer = new IronPdf.DocxToPdfRenderer();
var pdfDocument = pdfRenderer.RenderDocxAsPdf("document.docx");
pdfDocument.SaveAs("output.pdf");
```

## Example: Convert DOCX File to PDF

IronPDF facilitates the programmatic conversion of Word documents to PDF, boosting efficiency and integration capabilities across .NET applications. Starting with an instance of the `DocxToPdfRenderer` class, you can convert a DOCX file to a PDF by using the `RenderDocxAsPdf` method with the file path. This method returns a `PdfDocument` object for further customization. You can download the [Modern Chronological Resume DOCX example file](https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/Modern-chronological-resume.docx).

### Microsoft Word Preview

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/microsoft-word-preview.webp" alt="Microsoft Word Preview" class="img-responsive add-shadow">
    </div>
</div>

### Code Sample

The `RenderDocxAsPdf` method can also convert DOCX content from bytes and streams.

```csharp
using IronPdf;

// Create a new renderer instance
var renderer = new DocxToPdfRenderer();

// Convert a DOCX file into a PDF document
var pdfDocument = renderer.RenderDocxAsPdf("Modern-chronological-resume.docx");

// Save the newly created PDF
pdfDocument.SaveAs("pdfFromDocx.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/pdfFromDocx.pdf" width="100%" height="500px">
</iframe>

<hr>

## Mail Merge Example

The Mail Merge feature in Microsoft Word, found under the "Mailings" tab, facilitates the creation of multiple personalized documents, such as letters, labels, or emails. Each document contains unique details specific to each recipient while sharing common content.

### Model

Below is a model capturing data required for the mail merging process.

```csharp
internal class RecipientsDataModel
{
    public string Date { get; set; }
    public string Location { get; set; }
    public string Recipients_Name { get; set; }
    public string Contact_Us { get; set; }
}
```

Modify a Microsoft Word template as needed for your application. Download the [Party Invitation DOTX example file](https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/Party-invitation.dotx). Use the `MailMergePrintAllInOnePdfDocument` property to consolidate the produced PDFs into a single file using specified merge fields.

### Microsoft Word Preview

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/microsoft-word-preview-mail-merge.webp" alt="Microsoft Word Preview" class="img-responsive add-shadow">
    </div>
</div>

### Code Sample

```csharp
using IronPdf;
using System.Collections.Generic;
using System.Linq;

var recipients = new List<RecipientsDataModel>
{
    new RecipientsDataModel
    {
        Date = "Saturday, October 15th, 2023",
        Location = "Iron Software Cafe, Chiang Mai",
        Recipients_Name = "Olivia Smith",
        Contact_Us = "support@ironsoftware.com"
    },
    new RecipientsDataModel
    {
        Date = "Saturday, October 15th, 2023",
        Location = "Iron Software Cafe, Chiang Mai",
        Recipients_Name = "Ethan Davis",
        Contact_Us = "support@ironsoftware.com"
    }
};

DocxToPdfRenderer docxRenderer = new DocxToPdfRenderer();
DocxPdfRenderOptions renderOptions = new DocxPdfRenderOptions
{
    MailMergePrintAllInOnePdfDocument = true
};

var pdfDocument = docxRenderer.RenderDocxMailMergeAsPdf(recipients, "Party-invitation.dotx", renderOptions);
pdfDocument.First().SaveAs("mailMerge.pdf");
```

### Output PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/mailMerge.pdf" width="100%" height="500px">
</iframe

Aside from its core capabilities, IronPDF supports various other document conversions, manipulations, and certifications. Explore these features and more in the [extensive tutorial on HTML to PDF conversion](https://ironpdf.com/tutorials/html-to-pdf/).