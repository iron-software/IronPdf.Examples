# Converting Word Documents to PDF Format

A DOCX file is produced using Microsoft Word, a widely used word processing software developed by Microsoft. This format, based on the Office Open XML (OOXML) standard, has been the default for Word documents since Word 2007, succeeding the earlier DOC format. It is known for its efficiency and broad compatibility across different applications.

IronPDF provides functionality to transform DOCX files into PDFs. This conversion is crucial for enhancing document security, maintaining consistent formatting across different platforms, and ensuring better file portability. Additionally, IronPDF features a Mail Merge tool, perfect for creating custom document batches tailored for individual recipients.

## Example of Converting a DOCX File to PDF

To perform the conversion of a Microsoft Word document into a PDF file, begin by creating an instance of the `DocxToPdfRenderer` class. Use the `RenderDocxAsPdf` method from this instance, specifying the DOCX file's path. This function will return a `PdfDocument` object, which can be further modified or used as needed. Below is an example using the "Modern Chronological Resume" template from Microsoft Word. Here is the link to download the example DOCX file: [Modern Chronological Resume](https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/Modern-chronological-resume.docx).

### Preview of the Microsoft Word Document

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/microsoft-word-preview.webp" alt="Microsoft Word Preview" class="img-responsive add-shadow">
    </div>
</div>

### Sample Code

Apart from files, the `RenderDocxAsPdf` method can also process DOCX content delivered as byte arrays or streams.

```cs
using IronPdf;

// Create an instance of the renderer
DocxToPdfRenderer renderer = new DocxToPdfRenderer();

// Convert DOCX to PDF
PdfDocument pdf = renderer.RenderDocxAsPdf("Modern-chronological-resume.docx");

// Saving the resulting PDF file
pdf.SaveAs("pdfFromDocx.pdf");
```

### PDF Display

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/pdfFromDocx.pdf" width="100%" height="500px">
</iframe>

<hr>

## Example of Using Mail Merge

The Mail Merge functionality, found under the "Mailings" tab in Microsoft Word, is designed for creating multiple documents, such as letters or emails, where most of the content remains the same but specific details vary per document. This feature is commonly used for items like invitations or newsletters.

### Data Model Creation

Firstly, we define a model to hold the data that will be incorporated into the document via mail merge placeholders.

```cs
internal class RecipientsDataModel
{
    public string Date { get; set; }
    public string Location { get; set; }
    public string Recipients_Name { get; set; }
    public string Contact_Us { get; set; }
}
```

You can download the adjusted Microsoft Word template used in this example [here](https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/Party-invitation.dotx). For this particular case, we use the `MailMergePrintAllInOnePdfDocument` property set to true to combine all generated PDFs into a single document. The mail merge will employ fields such as Date, Location, Recipient's Name, and Contact Us.

### Word Document Preview for Mail Merge

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/microsoft-word-preview-mail-merge.webp" alt="Microsoft Word Preview" class="img-responsive add-shadow">
    </div>
</div>

### Code for Mail Merge

```cs
using IronPdf;
using System.Collections.Generic;
using System.Linq;

// List of recipients
var recipients = new List<RecipientsDataModel>()
{
    new RecipientsDataModel()
    {
        Date ="Saturday, October 15th, 2023",
        Location="Iron Software Cafe, Chiang Mai",
        Recipients_Name="Olivia Smith",
        Contact_Us = "support@ironsoftware.com"
    },
    new RecipientsDataModel()
    {
        Date ="Saturday, October 15th, 2023",
        Location="Iron Software Cafe, Chiang Mai",
        Recipients_Name="Ethan Davis",
        Contact_Us = "support@ironsoftware.com"
    },
};

DocxToPdfRenderer docxToPdfRenderer = new DocxToPdfRenderer();

// Configure options for rendering
DocxPdfRenderOptions options = new DocxPdfRenderOptions();
options.MailMergePrintAllInOnePdfDocument = true;

// Generate PDF from DOTX file using mail merge
var pdfs = docxToPdfRenderer.RenderDocxMailMergeAsPdf<RecipientsDataModel>(
     recipients,
     "Party-invitation.dotx",
     options);

pdfs.First().SaveAs("mailMerge.pdf");
```

### Display Generated PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/mailMerge.pdf" width="100%" height="500px">
</iframe>

Upon completing the PDF creation, further modifications are possible, such as exporting to [PDF/A](https://ironpdf.com/how-to/pdfa/) or [PDF/UA](https://ironpdf.com/how-to/pdfua/), securing with a [digital certificate](https://ironpdf.com/how-to/signing/), or modifying pages by [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), rotating, applying [annotations](https://ironpdf.com/how-to/annotations/), and adding [bookmarks](https://ironpdf.com/how-to/bookmarks/).