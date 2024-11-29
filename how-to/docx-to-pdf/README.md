# How to Convert Microsoft Word to PDF

***Based on <https://ironpdf.com/how-to/docx-to-pdf/>***


A DOCX file represents a document created using Microsoft Word, leveraging the Office Open XML (OOXML) standard. This standard ensures efficiency and compatibility across different platforms. DOCX has been the default file format for Word since 2007, superseding the older DOC format.

IronPDF facilitates the transformation of DOCX files into PDFs. It also offers a Mail Merge feature, which allows for the creation of individualized document batches for distinct recipients. The conversion process from DOCX to PDF guarantees universal accessibility, maintains original formatting, and enhances document security.

## Example: Converting a DOCX File to a PDF

To transform a Microsoft Word document into a PDF, you'll need to create an instance of the `DocxToPdfRenderer` class. The `RenderDocxAsPdf` method of this class accepts the file path of the DOCX document, returning a `PdfDocument` object which can be further customized. As an example, the *Modern Chronological Resume* template from Microsoft Word is used here. You can download the [Modern Chronological Resume DOCX example file](http://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/Modern-chronological-resume.docx).

### Preview of the Microsoft Word Document

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="http://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/microsoft-word-preview.webp" alt="Microsoft Word Preview" class="img-responsive add-shadow">
    </div>
</div>

### Code Sample

The `RenderDocxAsPdf` method also supports DOCX data in the form of bytes and streams.

```cs
using IronPdf;
namespace ironpdf.DocxToPdf
{
    public class Section1
    {
        public void Run()
        {
            // Create an instance of the Renderer
            DocxToPdfRenderer renderer = new DocxToPdfRenderer();
            
            // Convert DOCX to PDF
            PdfDocument pdf = renderer.RenderDocxAsPdf("Modern-chronological-resume.docx");
            
            // Save the resulting PDF
            pdf.SaveAs("pdfFromDocx.pdf");
        }
    }
}
```

### Display of the Output PDF

<iframe loading="lazy" src="http://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/pdfFromDocx.pdf" width="100%" height="500px">
</iframe>

<hr>

## Example of Mail Merge

The Mail Merge feature found under the "Mailings" tab in Microsoft Word allows for the creation of multiple documents personalized for each recipient. It's commonly used for items like letters, envelopes, labels, or emails for events like invitations, newsletters, or standard communications where the core content is consistent, but specific details vary per recipient.

### Data Model

Let's start by defining a model to store the data used in our mail merge:
```cs
using IronPdf;
namespace ironpdf.DocxToPdf
{
    public class Section2
    {
        public void Run()
        {
            internal class RecipientsDataModel
            {
                public string Date { get; set; }
                public string Location{ get; set; }
                public string Recipients_Name { get; set; }
                public string Contact_Us { get; set; }
            }
        }
    }
}
```

I've adapted a template from Microsoft Word for this demonstration. Please download the [Party Invitation DOTX example file](http://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/Party-invitation.dotx). For our demonstration, the `MailMergePrintAllInOnePdfDocument` is set to true to merge the outputs into a single PDF.

### Preview of Microsoft Word

<div class="content-img-align-center">
    <div class="center-image-wrapper" style="width=50%">
         <img src="http://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/microsoft-word-preview-mail-merge.webp" alt="Microsoft Word Preview" class="img-responsive add-shadow">
    </div>
</div>

### Example Code

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.DocxToPdf
{
    public class Section3
    {
        public void Run()
        {
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
            
            // Set options for rendering
            DocxPdfRenderOptions options = new DocxPdfRenderOptions();
            options.MailMergePrintAllInOnePdfDocument = true;
            
            // Perform the mail merge and convert to PDF
            var pdfs = docxToPdfRenderer.RenderDocxMailMergeAsPdf<RecipientsDataModel>(
                 recipients,
                 "Party-invitation.dotx",
                 options);
            
            pdfs.First().SaveAs("mailMerge.pdf");
        }
    }
}
```

### Output PDF Display

<iframe loading="lazy" src="http://ironpdf.com/static-assets/pdf/how-to/docx-to-pdf/mailMerge.pdf" width="100%" height="500px">
</iframe>

Upon creation of the PDF document, additional modifications are possible, such as exporting it as [PDF/A](http://ironpdf.com/how-to/pdfa/) or [PDF/UA](http://ironpdf.com/how-to/pdfua/). Options to [digitally sign the document](http://ironpdf.com/how-to/signing/), merge, split, rotate pages, and add [annotations](http://ironpdf.com/how-to/annotations/) or [bookmarks](http://ironpdf.com/how-to/bookmarks/) are also available.