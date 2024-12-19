# Converting DOCX Files to PDFs with IronPDF

***Based on <https://ironpdf.com/how-to/docx-to-pdf/>***


A DOCX file is essentially a document format created using Microsoft Word, which employs the Office Open XML (OOXML) standard. The format is known for its efficiency and wide compatibility. Since the release of Microsoft Word 2007, DOCX has been the standard format, superseding the older DOC format.

IronPDF provides functionality to transform DOCX documents into PDFs, including a Mail Merge capability that allows the creation of customized document batches for each recipient. This conversion process not only maintains the layout and formatting intact but also enhances document security and promotes better compatibility across different platforms.

### Getting Started with IronPDF

#### Example: Converting a DOCX File to a PDF

To convert a Microsoft Word document to a PDF, start by initializing an instance of the `DocxToPdfRenderer` class. Next, utilize the `RenderDocxAsPdf` method from a `DocxToPdfRenderer` instance, passing it the file path of the DOCX document. This method produces a `PdfDocument` object which can be further customized according to your needs. Here, we use the "Modern Chronological Resume" as an example. You can access the [Modern Chronological Resume DOCX](https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/Modern-chronological-resume.docx).

#### Microsoft Word Preview

<div align="center">
  <img src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/microsoft-word-preview.webp" alt="Microsoft Word Preview" style="width:50%; box-shadow: 2px 2px 10px rgba(0,0,0,0.1);">
</div>

#### Code Sample

The `RenderDocxAsPdf` method additionally supports DOCX file content in the form of bytes and streams.

```cs
using IronPdf;

// Create a new renderer
DocxToPdfRenderer renderer = new DocxToPdfRenderer();

// Convert a DOCX to PDF
PdfDocument pdf = renderer.RenderDocxAsPdf("Modern-chronological-resume.docx");

// Save the created PDF
pdf.SaveAs("convertedPDF.pdf");
```

#### Output PDF View

<iframe src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/pdfFromDocx.pdf" width="100%" height="500px" loading="lazy">
</iframe>

<hr>

#### Mail Merge Example: Creating Personalized Documents

The Mail Merge feature, which can be found under the "Mailings" tab in Microsoft Word, is typically employed for generating a batch of personalized documents such as invitations, newsletters, or letters, where most of the content remains consistent but specific details vary per recipient.

##### Data Model for Mail Merge

First, we construct a data model to represent the information needed for our mail merge.

```cs
internal class RecipientsDataModel
{
    public string EventDate { get; set; }
    public string Venue { get; set; }
    public string Name { get; set; }
    public string ContactInfo { get; set; }
}
```

A Microsoft Word template has been adapted for our mail merge purposes. Please download the [Party Invitation DOTX file](https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/Party-invitation.dotx). We will configure the operation to combine all generated PDFs into a single document. The merge fields include EventDate, Venue, Name, and Contact Info.

##### Microsoft Word Preview

<div align="center">
  <img src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/microsoft-word-preview-mail-merge.webp" alt="Microsoft Word Preview" style="width:50%; box-shadow: 2px 2px 10px rgba(0,0,0,0.1);">
</div>

##### Code Sample

```cs
using IronPdf;
using System.Collections.Generic;

List<RecipientsDataModel> recipients = new List<RecipientsDataModel>()
{
    new RecipientsDataModel()
    {
        EventDate = "Saturday, October 15th, 2023",
        Venue = "Iron Software Cafe, Chiang Mai",
        Name = "Olivia Smith",
        ContactInfo = "support@ironsoftware.com"
    },
    new RecipientsDataModel()
    {
        EventDate = "Saturday, October 15th, 2023",
        Venue = "Iron Software Cafe, Chiang Mai",
        Name = "Ethan Davis",
        ContactInfo = "support@ironsoftware.com"
    },
};

DocxToPdfRenderer pdfRenderer = new DocxToPdfRenderer();
DocxPdfRenderOptions renderOptions = new DocxPdfRenderOptions { MailMergePrintAllInOnePdfDocument = true };

var combinedPdf = pdfRenderer.RenderDocxMailMergeAsPdf(recipients, "Party-invitation.dotx", renderOptions);
combinedPdf.First().SaveAs("mailMergeOutput.pdf");
```

##### Output PDF

<iframe src="https://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/mailMerge.pdf" width="100%" height="500px" loading="lazy">
</iframe>

Once your PDF is ready, you can perform additional modifications such as converting it to [PDF/A](https://ironpdf.com/how-to/pdfa/) or [PDF/UA](https://ironpdf.com/how-to/pdfua/), signing it digitally at [Digital Certificate](https://ironpdf.com/how-to/signing/), and adjusting pages by [merging, splitting](https://ironpdf.com/how-to/merge-or-split-pdfs/), or rotating them. You also have the option to enhance your documents with [annotations](https://ironpdf.com/how-to/annotations/) and [bookmarks](https://ironpdf.com/how-to/bookmarks/).