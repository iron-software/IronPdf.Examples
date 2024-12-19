# How to Modify PDFs Using C&#35;

***Based on <https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/>***


## Introduction

Iron Software's IronPDF library brings clarity and simplicity to PDF manipulation tasks like signing documents, appending HTML footers, inserting watermarks, and adding notes. IronPDF ensures that your code remains clear and maintainable, supports seamless PDF creation programmatically, facilitates debugging, and can be effortlessly deployed across various platforms and environments.

IronPDF offers a vast array of functionalities for PDF edits. This guide will delineate several key features using code examples and detailed explanations.

By the end of this tutorial, you will be proficient in utilizing IronPDF for your PDF modification needs in C#.

## Contents

- **Document Structure Modifications**
  - [Page Addition, Duplication, and Deletion](#anchor-manipulate-pages)
  - [Combining and Dividing PDFs](#anchor-merge-and-split-pdfs)
- **Property Adjustments in Documents**
  - [Metadata Usage and Addition](#anchor-add-and-use-pdf-metadata)
  - [Implementing Digital Signatures](#anchor-digital-signatures)
  - [Managing PDF Attachments](#anchor-pdf-attachments)
  - [Reducing PDF Size](#anchor-compress-pdfs)
- **Content Editing in PDFs**
  - [Incorporating Headers and Footers](#anchor-add-headers-and-footers)
  - [Text Search and Replacement](#anchor-find-and-replace-text-in-a-pdf)
  - [Creating and Modifying Outlines and Bookmarks](#anchor-outlines-and-bookmarks)
  - [Annotations Enhancement](#anchor-add-and-edit-annotations)
  - [Integrating Backgrounds and Foregrounds](#anchor-add-backgrounds-and-foregrounds)
- **Applying Stamps and Watermarks**
  - [Overview of Stamping](#anchor-stamper-abstract-class)
    - [Properties of Stamper](#anchor-stamper-class-properties)
  - [Stamping Examples](#anchor-stamping-examples)
    - [Text Impression on PDF](#anchor-stamp-text-onto-a-pdf)
    - [Image Imprinting on PDF](#anchor-stamp-an-image-onto-a-pdf)
    - [HTML Marking on PDF](#anchor-stamp-html-onto-a-pdf)
    - [Barcode Stamping on PDF](#anchor-stamp-a-barcode-onto-a-pdf)
    - [QR Code Imprinting on PDF](#anchor-stamp-a-qr-code-onto-a-pdf)
    - [Embedding Watermarks in PDF](#anchor-add-a-watermark-to-a-pdf)
  - [Stamp Application Techniques](#anchor-apply-stamp-onto-a-pdf)
  - [Exploration of Length Class](#anchor-length-class)
    - [Properties of Length Class](#anchor-length-class-properties)
    - [Usage Examples of Length](#anchor-length-examples)
- **Working with Forms in PDFs**
  - [Creating and Adjusting Forms](#anchor-create-and-edit-forms)
  - [Filling Pre-existing Forms](#anchor-fill-existing-forms)

## Conclusion

This comprehensive insight showcases IronPDF's robust capabilities for straightforward PDF editing.

Should you need further assistance or wish to suggest a feature, please don't hesitate to [reach out to our support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are eager to assist with any inquiries regarding IronPDF or its licenses.

## Introduction

Iron Software has streamlined a variety of PDF editing tasks into straightforward and understandable functions through the IronPDF library. Whether it's inserting signatures, appending HTML footers, embedding watermarks, or including annotations, IronPDF is the ideal solution. It offers clean and readable code, facilitates programmatic PDF creation, ensures easy debugging, and supports smooth deployment across different environments and platforms.

IronPDF boasts a wealth of features for PDF modification. In this tutorial, we'll explore several key functionalities, complete with coding examples and detailed descriptions.

By the end of this article, you'll gain a comprehensive insight into leveraging IronPDF for editing PDF documents using C#.

## Table of Contents

- **Document Structure Modifications**
  - [Page Management: Adding, Copying, and Removing Pages](#anchor-manipulate-pages)
  - [Combining and Dividing PDF Documents](#anchor-merge-and-split-pdfs)

- **Document Property Enhancements**
  - [Metadata Management in PDFs](#anchor-add-and-use-pdf-metadata)
  - [Implementing Digital Signatures](#anchor-digital-signatures)
  - [Handling PDF Attachments](#anchor-pdf-attachments)
  - [Reducing PDF File Size](#anchor-compress-pdfs)

- **Content Editing in PDFs**
  - [Incorporating Headers and Footers](#anchor-add-headers-and-footers)
  - [Text Search and Modification](#anchor-find-and-replace-text-in-a-pdf)
  - [Creating and Managing Outlines and Bookmarks](#anchor-outlines-and-bookmarks)
  - [Implementation and Modification of Annotations](#anchor-add-and-edit-annotations)
  - [Applying Background and Foreground Layers](#anchor-add-backgrounds-and-foregrounds)

- **PDF Stamping and Watermarking Features**
  - [Introduction to Stamper Tool](#anchor-stamper-abstract-class)
    - [Properties of Stamper Tool](#anchor-stamper-class-properties)
  - [Examples of Using Stamps](#anchor-stamping-examples)
    - [Text Stamping on PDFs](#anchor-stamp-text-onto-a-pdf)
    - [Image Stamping Techniques](#anchor-stamp-an-image-onto-a-pdf)
    - [Utilizing HTML Stamping](#anchor-stamp-html-onto-a-pdf)
    - [Barcode Application in PDFs](#anchor-stamp-a-barcode-onto-a-pdf)
    - [Incorporating QR Codes](#anchor-stamp-a-qr-code-onto-a-pdf)
    - [Adding Watermarks](#anchor-add-a-watermark-to-a-pdf)
  - [Comprehensive Guide to Applying Stamps](#anchor-apply-stamp-onto-a-pdf)
  - [Exploring Length Class](#anchor-length-class)
    - [Understanding Length Class Properties](#anchor-length-class-properties)
    - [Practical Examples of Length Utilization](#anchor-length-examples)

- **Interactive Forms within PDFs**
  - [Developing and Modifying Forms](#anchor-create-and-edit-forms)
  - [Filling Pre-existing Forms](#anchor-fill-existing-forms)

## Document Structure Modification

IronPDF significantly streamlines the process of modifying the structure of PDF documents, offering effortless methods for adding, copying, deleting, merging, and splitting pages. Below we'll delve into how these tasks can be efficiently handled using IronPDF.

### Page Manipulation

IronPDF provides an intuitive set of functions that make it simple to manage the pages within a PDF.

#### Add Pages

```csharp
var pdf = new PdfDocument("report.pdf");
var renderer = new ChromePdfRenderer();
var titlePagePdf = renderer.RenderHtmlAsPdf("<h1>Title Page</h1><hr>");
pdf.InsertPdf(titlePagePdf);
pdf.SaveAs("report_with_title.pdf");
```

#### Copy Pages

```csharp
var pdf = new PdfDocument("report.pdf");
// Duplicate specific pages (here, pages 5 to 7) and save as a new document.
pdf.CopyPages(4, 6).SaveAs("extracted_pages.pdf");
```

#### Delete Pages

```csharp
var pdf = new PdfDocument("report.pdf");

// Eliminate the final page of the document and save the modified PDF.
pdf.DeletePage(pdf.PageCount - 1);
pdf.SaveAs("report_with_final_page_removed.pdf");
```

### Merge and Split PDFs

IronPDF's API allows you to seamlessly merge multiple PDFs into one or segment a single PDF into multiple parts.

#### Combine Several PDFs into One Document

```csharp
var pdfDocuments = new List<PdfDocument>
{
    PdfDocument.FromFile("A.pdf"),
    PdfDocument.FromFile("B.pdf"),
    PdfDocument.FromFile("C.pdf")
};

PdfDocument combinedPdf = PdfDocument.Merge(pdfDocuments);
combinedPdf.SaveAs("combined.pdf");

foreach (var doc in pdfDocuments)
{
    doc.Dispose();
}
```

To explore more about merging PDFs, visit our code examples page [here](https://ironpdf.com/examples/merge-pdfs/).

#### Divide a PDF and Extract Pages

```csharp
var pdf = new PdfDocument("sample.pdf");

// Extract the first page.
var pageOne = pdf.CopyPage(0);
pageOne.SaveAs("First_Page.pdf");

// Extract the next two pages.
var pagesTwoThree = pdf.CopyPages(1, 2);
pagesTwoThree.SaveAs("Pages_Two_and_Three.pdf");
```

See our examples for splitting and extracting PDF pages [here](https://ironpdf.com/examples/split-pdf-pages-csharp/).

### Page Manipulation

With IronPDF, manipulating pages within a PDF document is incredibly straightforward. Whether you're adding PDFs at precise positions, extracting a series of pages, or removing individual pages, IronPDF handles all the complex details seamlessly behind the scenes.

### Page Insertion

Adding pages at specific locations within a PDF file is a streamlined process with IronPDF, facilitating seamless integration and management of pages.

#### Inserting a New Page

```csharp
var pdfDocument = new PdfDocument("report.pdf");
var pdfRenderer = new ChromePdfRenderer();
var titlePage = pdfRenderer.RenderHtmlAsPdf("<h1>Title Page</h1><hr>");
pdfDocument.PrependPdf(titlePage);
pdfDocument.SaveAs("updated_report.pdf");
```

Here's the paraphrased version of the given C# code snippet:

```csharp
// Initialize a new PDF document
var reportPdf = new PdfDocument("report.pdf");

// Create a renderer using Chrome engine
var pdfRenderer = new ChromePdfRenderer();

// Convert HTML to PDF for the cover page
var coverPdf = pdfRenderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>");

// Insert the cover page at the beginning of the document
reportPdf.PrependPdf(coverPdf);

// Save the new PDF document with the cover page included
reportPdf.SaveAs("report_with_cover.pdf");
```

#### Copying Pages

```csharp
var pdfDocument = new PdfDocument("report.pdf");
// This snippet demonstrates copying select pages (from page 5 to 7) and creating a new document.
pdfDocument.CopyPages(4, 6).SaveAs("highlighted_report.pdf");
```

```csharp
var document = new PdfDocument("report.pdf");
// Extracts pages 5 to 7 and stores them in a separate document.
document.CopyPages(4, 6).SaveAs("report_highlight.pdf");
```

#### Removing Pages

Deleting pages from a PDF document is straightforward with IronPDF, which seamlessly handles all the underlying processes.

```csharp
var pdfDocument = new PdfDocument("report.pdf");

// Eliminate the final page and save the document again
pdfDocument.DeletePage(pdfDocument.PageCount - 1);
pdfDocument.SaveAs("report_final.pdf");
```

```csharp
var document = new PdfDocument("report.pdf");

// Eliminate the final page of the PDF and save the updated document
document.RemovePage(document.PageCount - 1);
document.SaveAs("updated_report.pdf");
```

### Combining and Dividing PDFs

With IronPDF's user-friendly API, you can effortlessly combine multiple PDFs into a single document or divide an existing PDF into separate files.

#### Merge Several PDFs into One Document

Combining multiple PDF files into a single document is straightforward using the functionalities provided by IronPDF. Here’s how you can achieve it efficiently:

```csharp
var pdfList = new List<PdfDocument>
{
    PdfDocument.FromFile("A.pdf"),
    PdfDocument.FromFile("B.pdf"),
    PdfDocument.FromFile("C.pdf")
};

PdfDocument combinedPdf = PdfDocument.Merge(pdfList);
combinedPdf.SaveAs("combined.pdf");

// Dispose all the individual PDFs to free resources
foreach (var pdf in pdfList)
{
    pdf.Dispose();
}
```

For comprehensive guidelines on merging various PDFs via our API, continue to our detailed code examples page [here](https://ironpdf.com/examples/merge-pdfs/).

Here's a paraphrased version of the provided C# code snippet:

```csharp
// Initialize a list to hold the PDF documents
var listOfPdfs = new List<PdfDocument>
{
    PdfDocument.FromFile("A.pdf"),
    PdfDocument.FromFile("B.pdf"),
    PdfDocument.FromFile("C.pdf")
};

// Merge all the PDFs from the list into one single document
PdfDocument combinedPdf = PdfDocument.Merge(listOfPdfs);
// Save the merged document
combinedPdf.SaveAs("combined_output.pdf");

// Clean up resources by disposing of the PDF documents
foreach (var singlePdf in listOfPdfs)
{
    singlePdf.Dispose();
}
```

For more detailed demonstrations on combining multiple PDF files, please explore our code examples by visiting [this link](https://ironpdf.com/examples/merge-pdfs/).

#### Dividing and Extracting Individual PDF Pages

IronPDF provides a straightforward API for dividing existing PDFs and extracting specific pages with ease.

#### Divide an Existing PDF and Extract Pages

```csharp
var pdf = new PdfDocument("sample.pdf");

// Extract the first page of the PDF and save it separately.
var firstPage = pdf.CopyPage(0);
firstPage.SaveAs("FirstPage.pdf");

// Extract pages two and three from the PDF and save them as a new document.
var pagesTwoThree = pdf.CopyPages(1, 2);
pagesTwoThree.SaveAs("PagesTwoAndThree.pdf");
```

For more examples on how to split and extract PDF pages using C#, you can refer to our detailed code examples on the IronPDF website: [Split and Extract PDF Pages in C#](https://ironpdf.com/examples/split-pdf-pages-csharp/).
```

```csharp
var pdf = new PdfDocument("sample.pdf");

// Extract the first page and save it as a separate PDF
var firstPage = pdf.CopyPage(0);
firstPage.SaveAs("FirstPage.pdf");

// Extract pages 2 and 3 and save them as another PDF
var secondThirdPages = pdf.CopyPages(1, 2);
secondThirdPages.SaveAs("Page2and3.pdf");
```

For additional examples and tutorials on splitting and extracting pages from PDFs, please explore our [Code Examples page](https://ironpdf.com/examples/split-pdf-pages-csharp/).

## Modifying Document Attributes

Utilizing the IronPDF library, enhancing and manipulating the properties of PDF documents becomes incredibly effortless:

### Including and Managing PDF Metadata

IronPDF facilitates easy management and alteration of PDF metadata:

```csharp
// Load a password-protected PDF or instantiate a new one from HTML
var pdf = PdfDocument.FromFile("encrypted.pdf", "password");

// Modifying document metadata
pdf.MetaData.Author = "Satoshi Nakamoto";
pdf.MetaData.Keywords = "SEO, Optimization";
pdf.MetaData.ModifiedDate = System.DateTime.Now;

// Adjust document security settings 
// The following settings enforce read-only access, prohibiting copying, pasting, and printing
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Update or set the encryption password
pdf.SecuritySettings.OwnerPassword = "top-secret";  // Password for editing the pdf
pdf.SecuritySettings.UserPassword = "shareable";   // Password for opening the pdf
pdf.SaveAs("secured.pdf");
```

### Implementing Digital Signatures

IronPDF supports the digital signing of PDFs using .pfx and .p12 digital certificates to ensure document integrity:

```csharp
using IronPdf;
using IronPdf.Signing;

// Sign an existing PDF file quickly with one line of code
new IronPdf.Signing.PdfSignature("Iron.p12", "123456").SignPdfFile("any.pdf");

// Detailed example for more control over the signing process:
using IronPdf;

// Step 1: Create a PDF
var renderer = new ChromePdfRenderer();
var doc = renderer.RenderHtmlAsPdf("<h1>Testing 2048-bit digital security</h1>");

// Step 2: Prepare a Signature.
var signature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
{
    SigningContact = "support@ironsoftware.com",
    SigningLocation = "Chicago, USA",
    SigningReason = "Demonstrating PDF signing"
};

// Step 4: Apply the signature to the PDF
doc.Sign(signature);

// Step 5: The PDF must be saved to file, steam, or byte array to finalize signing
doc.SaveAs("signed.pdf");
```

Get useful information for generating free digital certificates using Adobe Reader [here](https://ironpdf.com/examples/merge-pdfs/).

### Managing PDF Attachments

With IronPDF, adding or removing attachments to and from PDF files is straightforward:

```csharp
var Renderer = new ChromePdfRenderer();
var myPdf = Renderer.RenderHtmlFileAsPdf("my-content.html");

// Attach a file with its byte data
var attachment1 = myPdf.Attachments.AddAttachment("attachment_1", example_attachment);

// Detaching an attachment is just as easy
myPdf.Attachments.RemoveAttachment(attachment1);

myPdf.SaveAs("my-content.pdf");
```

### Compressing PDF Files

IronPDF enables PDF compression, substantially reducing file size, especially by compressing embedded images:

```csharp
var pdf = new PdfDocument("document.pdf");

// Compress images within the document with adjustable quality levels
pdf.CompressImages(60);
pdf.SaveAs("document_compressed.pdf");

// Optionally adjust image resolution based on its visible size in the document
pdf.CompressImages(90, true);
pdf.SaveAs("document_scaled_compressed.pdf");
```

### Manipulate and Utilize PDF Metadata

With IronPDF, managing and modifying the metadata of PDF documents is a straightforward process:

```csharp
// Load a secured PDF or create a fresh one from an HTML source
var pdf = PdfDocument.FromFile("encrypted.pdf", "password");

// Modify document metadata
pdf.MetaData.Author = "Satoshi Nakamoto";
pdf.MetaData.Keywords = "Blockchain, Bitcoin";
pdf.MetaData.ModifiedDate = System.DateTime.Now;

// Adjust document security settings
// The following lines set the PDF to read-only, prohibiting copy-pasting and printing
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Set new encryption passwords
pdf.SecuritySettings.OwnerPassword = "high-security";  // password needed to edit the pdf
pdf.SecuritySettings.UserPassword = "view-only";  // password required to open the pdf
pdf.SaveAs("secured.pdf");
```

```csharp
// Load an encrypted PDF, or alternatively, generate a new PDF from HTML
var pdf = PdfDocument.FromFile("encrypted.pdf", "password");

// Modify document metadata
pdf.MetaData.Author = "Satoshi Nakamoto";
pdf.MetaData.Keywords = "SEO, Friendly";
pdf.MetaData.ModifiedDate = System.DateTime.Now;

// Update security settings of the document
// The following snippets of code set the PDF to read-only, and disable copy, paste, and printing functionalities
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Update or establish the document encryption passwords
pdf.SecuritySettings.OwnerPassword = "top-secret"; // Password for editing the PDF
pdf.SecuritySettings.UserPassword = "shareable";  // Password for opening the PDF
pdf.SaveAs("secured.pdf");
```

### Digital Signatures

IronPDF enables the digital signing of both new and existing PDF documents utilizing .pfx and .p12 X509Certificate2 digital certificates for robust security.

Once digitally signed, a PDF document becomes immutable without the corresponding certificate's verification, thereby ensuring the document's integrity.

For guidance on creating a signing certificate at no cost using Adobe Reader, consult Adobe's support page here: <https://helpx.adobe.com/acrobat/using/digital-ids.html>.

Beyond cryptographic signatures, IronPDF also supports the addition of hand-written signature images or company seal images for signing documents.

Effortlessly sign any PDF file with just a single line of code using IronPDF's powerful cryptographic features.

```csharp
using IronPdf;
using IronPdf.Signing;

// Sign an existing PDF file with a digital certificate
new PdfSignature("Iron.p12", "123456").SignPdfFile("any.pdf");
```

```csharp
using IronPdf;

// First, create a new PDF using HTML content
var pdfRenderer = new ChromePdfRenderer();
var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Advanced Digital Security Test</h1>");

// Next, prepare a digital signature
// You can get a .pfx or .p12 certificate from Adobe Acrobat Reader
// For a guide on creating certificates, visit: https://helpx.adobe.com/acrobat/using/digital-ids.html
var digitalSignature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
{
    SigningContact = "support@ironsoftware.com",
    SigningLocation = "Chicago, USA",
    SigningReason = "Demonstrate PDF signing capabilities"
};

// Apply the signature to the created PDF document
pdfDocument.Sign(digitalSignature);

// Remember, the PDF only becomes officially signed when it is saved
pdfDocument.SaveAs("advanced_signed.pdf");
```

```csharp
using IronPdf;

// Initialize the renderer for creating a PDF
var pdfRenderer = new ChromePdfRenderer();
var document = pdfRenderer.RenderHtmlAsPdf("<h1>Testing 2048 bit digital security</h1>");

// Create a digital signature using a .pfx or .p12 file. For instructions on creating a signing certificate, visit:
// Read: https://helpx.adobe.com/acrobat/using/digital-ids.html
var digitalSignature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
{
    // Configure optional signature properties, including a graphic for handwritten signatures
    SigningContact = "support@ironsoftware.com",
    SigningLocation = "Chicago, USA",
    SigningReason = "Demonstrating PDF signing"
};

// Apply the signature to the PDF. This method can support multiple signatures if required.
document.Sign(digitalSignature);

// The document needs to be saved to ensure the signature is applied.
document.SaveAs("signed.pdf");
```

### PDF Attachments

IronPDF offers comprehensive capabilities for attaching and detaching files within your PDF documents.

```csharp
var pdfRenderer = new ChromePdfRenderer();
var pdfDocument = pdfRenderer.RenderHtmlFileAsPdf("my-content.html");

// Adding an attachment to the PDF with a unique identifier and binary data
var addedAttachment = pdfDocument.Attachments.AddAttachment("attachment_1", example_attachment);

// Example of how to remove an attachment from the PDF
pdfDocument.Attachments.RemoveAttachment(addedAttachment);

// Save the final PDF with changes
pdfDocument.SaveAs("my-content.pdf");
```

### Compress PDFs

IronPDF offers functionalities to compress PDF files effectively, primarily by reducing the size of the pictures embedded within the document. This is achieved using the `CompressImages` method available in the library.

When adjusting JPEG images, maintaining 100% quality almost completely preserves the original, whereas setting quality to 1% results in a significantly degraded image output. Typically, quality levels above 90% are regarded as high, between 80% and 90% as medium, and between 70% and 80% as low. It's important to note that decreasing the quality below 70% can considerably diminish the image quality, however, it may significantly lower the overall file size of your PDF.

It’s encouraged to test various compression settings to discover the ideal compromise between image quality and file size suited to your needs. The extent to which the quality degrades will depend largely on the original image used, with some images potentially experiencing more noticeable reductions in clarity.

```csharp
var document = new PdfDocument("document.pdf");

// Set the compression quality between 1 (lowest) and 100 (highest)
document.CompressImages(60); // Using 60% of the original quality for compression
document.SaveAs("compressed_document.pdf");
```

A secondary optional parameter allows for the resizing of the image based on its apparent size within the PDF document. Be advised that certain image arrangements may experience distortion when this is used:

Here's the paraphrased section of the article, with updated relative URL paths resolved to the specified domain:

```csharp
var pdfDocument = new PdfDocument("document.pdf");

// Compress images in the document with quality settings, resize based on visibility
pdfDocument.CompressImages(90, resizeBasedOnVisibility: true);
pdfDocument.SaveAs("document_scaled_compressed.pdf");
```

## Modifying PDF Content

### Incorporating Headers and Footers

IronPDF facilitates the addition of both headers and footers to your PDF documents. There are two styles available, `TextHeaderFooter` for simple text-based content and `HtmlHeaderFooter` for more complex HTML content, ensuring a perfect visual match with the rest of your document.

#### HTML Headers and Footers

This feature allows the application of HTML-rendered headers and footers across your document, preserving exact formatting for consistency across pages.

```csharp
var renderer = new ChromePdfRenderer();

// Establish a footer with HTML content, including dynamic fields
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    MaxHeight = 15, // Set in millimeters
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
    DrawDividerLine = true
};

// Define a header using an image, referencing assets relatively
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 20, // Set in millimeters
    HtmlFragment = "<img src='logo.png'>",
    BaseUrl = new System.Uri(@"C:\assets\images").AbsoluteUri
};
```

For detailed examples on implementing these features, explore our tutorial: [Advanced Headers and Footers](https://ironsoftware.com/examples/adding-headers-and-footers-advanced/).

#### Text-based Headers and Footers

For simpler applications, use `TextHeaderFooter`, which allows for straightforward text additions with flexible placement and formatting options.

```csharp
var renderer = new ChromePdfRenderer
{
    RenderingOptions =
    {
        FirstPageNumber = 1,
        
        // Easy text header configuration:
        TextHeader =
        {
            DrawDividerLine = true,
            CenterText = "{url}",
            Font = IronSoftware.Drawing.FontTypes.Helvetica,
            FontSize = 12
        },

        // Configuration for the footer:
        TextFooter =
        {
            DrawDividerLine = true,
            Font = IronSoftware.Drawing.FontTypes.Arial,
            FontSize = 10,
            LeftText = "{date} {time}",
            RightText = "{page} of {total-pages}"
        }
    }
};
```

### Text Replacement in PDFs

IronPDF enables dynamic text replacements within PDFs, perfect for updating content or filling predefined placeholders.

```csharp
// Load an example PDF
var pdf = PdfDocument.FromFile("sample.pdf");

// Define parameters for text replacement
int pageIndex = 1;
string oldText = ".NET 6";
string newText = ".NET 7";

// Execute text replacement on a specified page
pdf.ReplaceTextOnPage(pageIndex, oldText, newText);
pdf.ReplaceTextOnPage(pageIndex, "[DATE]", "01/01/2000");

// Save the updated PDF
pdf.SaveAs("new_sample.pdf");
```

To explore more about text replacement functionality, visit our example page: [Replace Text in PDF using C#](https://ironsoftware.com/examples/csharp-replace-text-in-pdf/).

### Managing Outlines and Bookmarks

Enhance PDF navigation with IronPDF by adding and managing bookmarks which facilitate quick access to important sections.

```csharp
// Open or create a PDF
PdfDocument pdf = PdfDocument.FromFile("existing.pdf");

// Insert bookmarks at relevant sections
var authorNoteBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Author's Note", 2);
var tocBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Table of Contents", 3);

// Organize nested bookmarks for structured navigation
var summaryBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Summary", 17);
var conclusionBookmark = summaryBookmark.Children.AddBookMarkAtStart("Conclusion", 18);

// Add a bookmark for the references section
pdf.Bookmarks.AddBookMarkAtEnd("References", 20);

// Save changes to the PDF
pdf.SaveAs("existing.pdf");
```

For a more detailed guide on adding bookmarks and outlines, visit: [Outlines and Bookmarks](https://ironsoftware.com/examples/bookmarks/).

### Annotation Implementation

IronPDF supports a diverse range of annotations, enabling users to add interactive comments and notes to their PDFs.

```csharp
// Load or initialize a PDF document
var pdf = PdfDocument.FromFile("existing.pdf");

// Configure a text annotation
var textAnnotation = new IronPdf.Annotations.TextAnnotation(0)
{
    Title = "Major Title",
    Contents = "Extended sticky note content...",
    Subject = "Subtitle",
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
    Opacity = 0.9,
    OpenByDefault = true
};

// Apply the annotation to a specified page
pdf.Annotations.Add(textAnnotation);

// Save the annotated PDF
pdf.SaveAs("existing.pdf");
```

Annotations in PDF facilitate the inclusion of non-intrusive comments which are customizable in terms of appearance and behavior, providing a flexible tool for PDF interactivity.

### Incorporating Backgrounds and Forefronts

IronPDF allows merging of PDF files to add layered content; utilize a foreground or background PDF to enrich your primary document visually.

```csharp
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");

// Set a background PDF
pdf.AddBackgroundPdf(@"MyBackground.pdf");
// Overlay a foreground PDF on a specific page
pdf.AddForegroundOverlayPdfToPage(0, @"MyForeground.pdf", 0);

// Save the composite PDF
pdf.SaveAs(@"C:\Path\To\Complete.pdf");
```

IronPDF equips you with comprehensive tools to modify and enrich your PDF documents, making it simple and efficient to apply complex PDF edits programmatically.

### Incorporating Headers and Footers into PDFs

IronPDF facilitates the addition of bespoke headers and footers to your documents with ease. Offering two types of "HeaderFooters" to choose from—`TextHeaderFooter` and `HtmlHeaderFooter`—you can cater to simple or complex styling needs. `TextHeaderFooter` is optimal for straightforward text-based headers and footers, and it supports dynamic content through merge fields like `"{page} of {total-pages}"`. For a more sophisticated approach, `HtmlHeaderFooter` accommodates any HTML content, allowing for a polished and precise formatting of headers and footers.

#### HTML Headers and Footers

IronPDF allows for the incorporation of HTML content as headers and footers within your PDF documents, ensuring a precise and visually accurate layout. This feature is perfect for adding sophisticated design elements to the top or bottom of your pages.

```csharp
var pdfRenderer = new ChromePdfRenderer();

// Configure the footer with HTML by utilizing mergeable fields such as:
// {page}, {total-pages}, {url}, {date}, {time}, {html-title}, and {pdf-title}
pdfRenderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    MaxHeight = 15, // Specified in millimeters
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
    DrawDividerLine = true // This will add a line above the footer for separation
};

// Construct a header by including an image
// BaseUrl helps in resolving the path where the assets are stored
pdfRenderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 20, // Specified in millimeters
    HtmlFragment = "<img src='logo.png'>", // Incorporate image as part of the header
    BaseUrl = new System.Uri(@"C:\assets\images").AbsoluteUri // Absolute path to the image directory
};
```

For an extensive walkthrough covering various scenarios, consult our detailed tutorial [here](https://ironpdf.com/examples/adding-headers-and-footers-advanced/).

#### Text Headers and Footers

For straightforward header and footer requirements, the `TextHeaderFooter` class provides a straightforward solution. Below is an example demonstrating its usage.

```csharp
var renderer = new ChromePdfRenderer
{
    RenderingOptions =
    {
        FirstPageNumber = 1, // use index 2 if preceded by a cover page

        // Effortlessly introduce a header to every page:
        TextHeader =
        {
            DrawDividerLine = true, // adds a visual divider
            CenterText = "{url}",   // dynamic URL at the header center
            Font = IronSoftware.Drawing.FontTypes.Helvetica, // elegant Helvetica font
            FontSize = 12           // balanced font size
        },

        // Incorporate a footer similarly:
        TextFooter =
        {
            DrawDividerLine = true, // ensures a separator line at the footer
            Font = IronSoftware.Drawing.FontTypes.Arial, // using Arial font for clarity
            FontSize = 10,          // slightly smaller font size for the footer
            LeftText = "{date} {time}",              // dynamically insert date and time to the left
            RightText = "{page} of {total-pages}"   // page navigation information on the right
        }
    }
};
```

Merge fields act as placeholders in your document which will be automatically filled with the actual values when the PDF is rendered. Here are the available merge fields in IronPDF:

- `{page}`: Current page number.
- `{total-pages}`: Total number of pages in the document.
- `{url}`: The URL of the page when HTML is sourced from a web page.
- `{date}`: Current date.
- `{time}`: Current time.
- `{html-title}`: Title of the HTML document, if available.
- `{pdf-title}`: The title of the PDF document.

### Searching and Updating Text in a PDF

You can design your PDF documents to contain placeholders that can be programmatically updated, or you can effortlessly update any instance of a specific text phrase through the use of the `ReplaceTextOnPage` method provided by IronPDF.

Here's the paraphrased section with updated URLs and code comments:

```csharp
// Load an existing PDF file
var pdfDocument = PdfDocument.FromFile("sample.pdf");

// Define parameters for text replacement
int targetPageIndex = 1; // The page index where the text replacement will occur
string textToReplace = ".NET 6"; // The text you want to replace
string replacementText = ".NET 7"; // The new text that will replace the old text

// Execute text replacement on the specified page
pdfDocument.ReplaceTextOnPage(targetPageIndex, textToReplace, replacementText);

// Example using placeholders in your PDF
// Replace the placeholder "[DATE]" with an actual date
pdfDocument.ReplaceTextOnPage(targetPageIndex, "[DATE]", "01/01/2000");

// Store the modified PDF as a new file
pdfDocument.SaveAs("new_sample.pdf");
```

For a detailed example of the Find and Replace Text feature, visit our Code Examples page [here](https://ironpdf.com/examples/csharp-replace-text-in-pdf/).

### Navigating PDFs with Outlines and Bookmarks

Outlines, commonly referred to as "bookmarks," enhance PDF navigation by allowing users quick access to significant sections. Displayed on the left sidebar in Adobe Acrobat Reader, these bookmarks can also be nested for structured navigation. IronPDF seamlessly imports any existing bookmarks from PDF documents while enabling the addition, modification, and organization of new ones.

```csharp
// Load an existing PDF or initiate a new one.
PdfDocument pdf = PdfDocument.FromFile("existing.pdf");

// Append bookmarks at the end of the PDF for easy navigation.
pdf.Bookmarks.AddBookMarkAtEnd("Author's Note", 2);
pdf.Bookmarks.AddBookMarkAtEnd("Table of Contents", 3);

// Create a new bookmark variable that can be manipulated further.
var summaryBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Summary", 17);

// Nested bookmarking inside the "Summary" section.
var conclusionBookmark = summaryBookmark.Children.AddBookMarkAtStart("Conclusion", 18);

// Append a concluding bookmark at the document's end.
pdf.Bookmarks.AddBookMarkAtEnd("References", 20);

// Save the PDF with all the newly added bookmarks.
pdf.SaveAs("existing.pdf");
```

For a detailed demonstration of the Outlines and Bookmarks functionality, please refer to our Code Examples page by clicking [here](https://ironpdf.com/examples/bookmarks/).

### Adding and Modifying Annotations

IronPDF offers extensive options for customizing annotations within PDF documents. For a practical illustration of these features, please review the example below:

```csharp
// Initialize a new PDF or modify an existing document.
var pdf = PdfDocument.FromFile("existing.pdf");

// Define a PDF annotation
var textAnnotation = new IronPdf.Annotations.TextAnnotation(pageIndex: 0)
{
    Title = "Main Heading",
    Contents = "Here's detailed content for the annotation, acting as a lengthy comment.",
    Subject = "Subheading",
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Note,
    Opacity = 0.8,
    Printable = true,
    Hidden = false,
    OpenByDefault = false,
    ReadOnly = true,
    Rotatable = false,
};

// Add this annotation to a specific page at a designated location within any PDF, new or existing.
pdf.Annotations.Add(textAnnotation);

// Save the modifications to the PDF
pdf.SaveAs("updated.pdf");
```

This example showcases the ability to add "sticky note" like comments to any page of a PDF document. The `TextAnnotation` class is used here to programmatically insert annotations with options for customizing their appearance, behavior, and more.

```csharp
// Begin by either creating a new PDF or modifying an existing document.
var pdf = PdfDocument.FromFile("existing.pdf");

// Construct a text annotation object for PDF modifications
var textAnnotation = new IronPdf.Annotations.TextAnnotation(PageIndex: 0)
{
    Title = "Main Title for the Annotation",
    Contents = "Detailed comment in a 'sticky note' style...",
    Subject = "Secondary Title",
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
    Opacity = 0.9,
    Printable = false,
    Hidden = false,
    OpenByDefault = true,
    ReadOnly = false,
    Rotatable = true,
};

// Place the newly created text annotation onto a designated page in the PDF
pdf.Annotations.Add(textAnnotation);

// Finalize the annotations and save the modified document
pdf.SaveAs("existing.pdf");
```

With IronPDF, you can programmatically insert annotations reminiscent of "sticky notes" onto PDF pages using the `TextAnnotation` class. This functionality supports a variety of sophisticated features such as customizable sizes, transparency settings, choice of icons, and the ability to modify annotations after they've been added.

### Incorporating Backgrounds and Foregrounds

IronPDF effortlessly allows the merging of two PDF files, designating one as either a background or a foreground layer:

```csharp
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
pdf.AddBackgroundPdf("MyBackground.pdf");
pdf.AddForegroundOverlayPdfToPage(0, "MyForeground.pdf", 0);
pdf.SaveAs("C:\\Path\\To\\Complete.pdf");
```

```csharp
var pdfRenderer = new ChromePdfRenderer();
var document = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
document.MergeBackgroundPdf(@"MyBackground.pdf");
document.MergeForegroundPdf(0, @"MyForeground.pdf", 0);
document.SaveAs(@"C:\Path\To\Complete.pdf");
```

### Stamping and Watermarking

Stamping and watermarking are essential tools for any PDF editor. IronPDF offers a robust API that supports a diverse array of stamp types, including image and HTML stamps. These features provide highly adjustable positioning options through customizable alignments and offsets, as illustrated here:

<div class="content-img-align-center">
  <img src="https://ironpdf.com/static-assets/pdf/tutorials/csharp-edit-pdf-complete-tutorial/csharp-edit-pdf-complete-tutorial-1.webp" alt="Stamping and Watermarking" class="img-responsive add-shadow">
</div>

<div class="content-img-align-center">
  <img src="/static-assets/pdf/tutorials/csharp-edit-pdf-complete-tutorial/csharp-edit-pdf-complete-tutorial-1.webp" alt="Stamping and Watermarking" class="img-responsive add-shadow">
</div>

#### Stamper Abstract Class Overview

The `Stamper` abstract class forms the backbone for all stamping functionalities within the IronPDF library. It serves as a foundational parameter across various stamping procedures.

IronPDF offers a diverse array of specialized `Stamper` classes tailored for different stamping needs:

- `TextStamper` for text applications - see [Text Example](https://ironpdf.com#anchor-stamp-text-onto-a-pdf)
- `ImageStamper` for image applications - see [Image Example](https://ironpdf.com#anchor-stamp-an-image-onto-a-pdf)
- `HtmlStamper` for HTML content - see [HTML Example](https://ironpdf.com#anchor-stamp-html-onto-a-pdf)
- `BarcodeStamper` for barcode generation - see [Barcode Example](https://ironpdf.com#anchor-stamp-a-barcode-onto-a-pdf)
- `BarcodeStamper` for QR Code creation - see [QR Code Example](https://ironpdf.com#anchor-stamp-a-qr-code-onto-a-pdf)
- For adding watermarks, consult [this section](https://ironpdf.com#anchor-add-a-watermark-to-a-pdf).

To deploy these stamping options, utilize one of the `ApplyStamp()` methods detailed in [the Apply Stamp section of this tutorial](https://ironpdf.com#anchor-apply-stamp-onto-a-pdf).

-----
 ## Properties of the Stamper Class

```txt
abstract class Stamper
|
└─── int : Opacity                  # Transparency level of the stamp
└─── int : Rotation                 # Degree of rotation for the stamp (0-360)
|
└─── double : Scale                 # Scaling factor for the stamp size
|
└─── Length : HorizontalOffset      # Horizontal displacement of the stamp from its original position
└─── Length : VerticalOffset        # Vertical displacement of the stamp from its original position
|
└─── Length : MinWidth              # Minimum width that the stamp can be resized to
└─── Length : MaxWidth              # Maximum width that the stamp can extend to
|
└─── Length : MinHeight             # Minimum height that the stamp can be resized to
└─── Length : MaxHeight             # Maximum height that the stamp can extend to
|
└─── string : Hyperlink             # URL linked to the stamp
|
└─── bool : IsStampBehindContent    # Determines whether the stamp should appear behind the main content (default: false)
|
└─── HorizontalAlignment : HorizontalAlignment  # Alignment of the stamp along the horizontal axis 
│   │   Left               # Aligns the stamp to the left
│   │   Center (default)   # Centers the stamp
│   │   Right              # Aligns the stamp to the right
│
└─── VerticalAlignment : VerticalAlignment        # Alignment of the stamp along the vertical axis
    │   Top               # Positions the stamp at the top
    │   Middle (default)  # Centers the stamp vertically
    │   Bottom            # Positions the stamp at the bottom
```

Each of these properties is designed to provide precise control over how a stamp appears on your PDF documents using IronPDF. Whether adjusting for transparency, positioning, dimensions, or adding interactive elements like hyperlinks, these properties ensure that each stamp is tailored to your specific needs.

```txt
abstract class Stamper

└─── int : Opacity
└─── int : Rotation

└─── double : Scale

└─── Length : HorizontalOffset
└─── Length : VerticalOffset

└─── Length : MinWidth
└─── Length : MaxWidth

└─── Length : MinHeight
└─── Length : MaxHeight

└─── string : Hyperlink

└─── bool : IsStampBehindContent (default : false)

└─── HorizontalAlignment : HorizontalAlignment
    │   Left
    │   Center (default)
    │   Right

└─── VerticalAlignment : VerticalAlignment
    │   Top
    │   Middle (default)
    │   Bottom
```

## Stamping Examples

In this portion of the tutorial, we detail various instances of applying each subclass of `Stamper` with respective code snippets.

### Stamp Text onto a PDF

Demonstration of setting up two distinct text stamps and applying them simultaneously:

```csharp
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<h1>Sample HTML Document</h1>");

TextStamper stamper1 = new TextStamper
{
    Text = "First Stamp: Hello World!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 100,
    IsBold = true,
    IsItalic = true,
    VerticalAlignment = VerticalAlignment.Top
};

TextStamper stamper2 = new TextStamper()
{
    Text = "Second Stamp: Hello Again!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 30,
    VerticalAlignment = VerticalAlignment.Bottom
};

Stamper[] stampersToApply = { stamper1, stamper2 };
pdf.ApplyMultipleStamps(stampersToApply);
pdf.ApplyStamp(stamper2);
```

### Stamp an Image onto a PDF

Application of an image stamp on selected pages of an existing PDF:

```csharp
var pdf = new PdfDocument("/attachments/2022_Q1_sales.pdf");

ImageStamper brandingStamper = new ImageStamper("/assets/logo.png");

// Applying to various page scenarios
pdf.ApplyStamp(brandingStamper);
pdf.ApplyStamp(brandingStamper, 0);
pdf.ApplyStamp(brandingStamper, new[] { 0, 3, 11 });
```

### Stamp HTML onto a PDF

Utilizing custom HTML for unique stamping:

```csharp
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<p>Example HTML Body</p>");

HtmlStamper htmlStamper = new HtmlStamper($"<p>Custom HTML Stamp</p><div style='width:250pt;height:250pt;background-color:red;'></div>")
{
    HorizontalOffset = new Length(-3, MeasurementUnit.Inch),
    VerticalAlignment = VerticalAlignment.Bottom
};

pdf.ApplyStamp(htmlStamper);
```

### Stamp a Barcode onto a PDF

Illustration of barcode generation and application:

```csharp
BarcodeStamper barcodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);

barcodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
barcodeStamper.VerticalAlignment = VerticalAlignment.Bottom;

var pdf = new PdfDocument("example.pdf");
pdf.ApplyStamp(barcodeStamper);
```

### Stamp a QR Code onto a PDF

Creating and applying a QR Code:

```csharp
BarcodeStamper qrCodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);

qrCodeStamper.Height = 50; // in pixels
qrCodeStamper.Width = 50; // in pixels

qrCodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
qrCodeStamper.VerticalAlignment = VerticalAlignment.Bottom;

var pdf = new PdfDocument("example.pdf");
pdf.ApplyStamp(qrCodeStamper);
```

### Add a Watermark to a PDF

Easy application of a HTML-based watermark across all pages:

```csharp
var pdf = new PdfDocument("/attachments/design.pdf");
string htmlContent = "<h1>Watermark Example Title</h1>";
int rotationAngle = 0;
int watermarkOpacity = 30;

pdf.ApplyWatermark(htmlContent, rotationAngle, watermarkOpacity);
```

This detailed look at stamping demonstrates the versatility and control provided by IronPDF's `Stamper` classes, each tailored for specific types of stamps.

### Adding Text Stamps to a PDF

Here's how to utilize two distinct `TextStamper` instances in C# for adding text stamps to a PDF document, each configured uniquely:

```csharp
// Initialize the PDF renderer
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Configure the first text stamper
TextStamper stamper1 = new TextStamper
{
    Text = "Hello World! Stamp One Here!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 100,
    IsBold = true,
    IsItalic = true,
    VerticalAlignment = VerticalAlignment.Top
};

// Configure the second text stamper
TextStamper stamper2 = new TextStamper()
{
    Text = "Hello World! Stamp Two Here!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 30,
    VerticalAlignment = VerticalAlignment.Bottom
};

// Array of stampers to be applied
Stamper[] stampersToApply = { stamper1, stamper2 };
pdf.ApplyMultipleStamps(stampersToApply);
pdf.ApplyStamp(stamper2);
```

This script showcases how to create and apply text stamps using different styles and alignments within a single PDF document, enhancing the visual appeal and informational value of the PDF.

```csharp
// Create an instance of the ChromePdfRenderer for rendering HTML to PDF
var pdfRenderer = new ChromePdfRenderer();
// Render an example HTML string into a PDF document
var examplePdf = pdfRenderer.RenderHtmlAsPdf("<h1>Example of an HTML Document</h1>");

// Initialize a new TextStamper to apply a text stamp on the PDF
TextStamper firstTextStamper = new TextStamper
{
    Text = "Hello World! This is the first stamp!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 100,
    IsBold = true,
    IsItalic = true,
    VerticalAlignment = VerticalAlignment.Top
};

// Configure a second TextStamper for adding another stamp
TextStamper secondTextStamper = new TextStamper()
{
    Text = "Hello World! This is the second stamp!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 30,
    VerticalAlignment = VerticalAlignment.Bottom
};

// Prepare both stampers for application
Stamper[] stamperArray = { firstTextStamper, secondTextStamper };
// Execute the method to apply multiple stamps at once
examplePdf.ApplyMultipleStamps(stamperArray);
// Apply the second text stamper separately
examplePdf.ApplyStamp(secondTextStamper);
```

### Stamping an Image Onto a PDF

Inserting image stamps into your PDF can be done on single or multiple pages effortlessly:

```csharp
var pdfDocument = new PdfDocument("/attachments/2022_Q1_sales.pdf");
ImageStamper imageStamp = new ImageStamper("/assets/logo.png");

// Apply the stamp across multiple pages, a single page, or select pages
pdfDocument.ApplyStamp(imageStamp); // Applies to all pages
pdfDocument.ApplyStamp(imageStamp, 0); // Applies to the first page only
pdfDocument.ApplyStamp(imageStamp, new[] { 0, 3, 11 }); // Applies to specific pages: 1st, 4th, and 12th
```

```csharp
var pdfDocument = new PdfDocument("https://ironpdf.com/attachments/2022_Q1_sales.pdf");

ImageStamper imageStamper = new ImageStamper("https://ironpdf.com/assets/logo.png");

// You can stamp the image on all pages, a single page, or selected pages
pdfDocument.ApplyStamp(imageStamper);  // Apply stamp to all pages
pdfDocument.ApplyStamp(imageStamper, 0);  // Apply stamp to the first page
pdfDocument.ApplyStamp(imageStamper, new[] { 0, 3, 11 });  // Apply stamp to pages 1, 4, and 12
```

### Applying HTML Stamps to PDF Documents

Elevate your PDF customizations by utilizing HTML to create unique stamps:

```csharp
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<p>Welcome to IronPDF Stamping!</p>");

HtmlStamper htmlStamp = new HtmlStamper("<div style='background-color:blue;width:300pt;height:300pt;'><p>Custom HTML Stamp</p></div>")
{
    HorizontalOffset = new Length(-2, MeasurementUnit.Inch),
    VerticalAlignment = VerticalAlignment.Bottom
};

pdf.ApplyStamp(htmlStamp);
```

Using IronPDF, custom HTML content can easily be formatted and stamped onto any page of your PDF document, providing a highly flexible way to add dynamic content or branding elements.

Here's a paraphrased version of the provided C# code snippet:

```csharp
// Initialize the PDF renderer
var pdfRenderer = new ChromePdfRenderer();

// Render a simple HTML paragraph into a PDF
var document = pdfRenderer.RenderHtmlAsPdf("<p>Hello World, example HTML body.</p>");

// Define an HTML stamper with custom HTML content
HtmlStamper htmlStamper = new HtmlStamper($"<p>Example HTML Stamped</p><div style='width:250pt;height:250pt;background-color:red;'></div>")
{
    // Set the horizontal offset for the stamp
    HorizontalOffset = new Length(-3, MeasurementUnit.Inch),

    // Position the stamp at the bottom of the page
    VerticalAlignment = VerticalAlignment.Bottom
};

// Apply the HTML stamper to the PDF
document.ApplyStamp(htmlStamper);
```

### Stamping a Barcode on a PDF

Below is an illustrated method to add a barcode stamp to a PDF using IronPDF:

```csharp
// Instantiate a BarcodeStamper with the data "IronPDF" and BarcodeEncoding as Code39
BarcodeStamper barcodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);

// Set alignment preferences for the barcode
barcodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
barcodeStamper.VerticalAlignment = VerticalAlignment.Bottom;

// Load an existing PDF document to stamp
var targetPdf = new PdfDocument("example.pdf");

// Apply the barcode stamp to the PDF
targetPdf.ApplyStamp(barcodeStamper);
```

This code snippet creates a `BarcodeStamper` configured for a "Code39" type barcode containing the text "IronPDF". It applies this stamper to a designated PDF, aligning the barcode to the bottom-left of each page.

Here's the paraphrased section with updated links:

```csharp
// Initialize a new instance of BarcodeStamper with "IronPDF" as the text and Code39 as the encoding
BarcodeStamper barcodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);

// Set the alignment of the barcode within the PDF
barcodeStamper.HorizontalAlignment = HorizontalAlignment.Left; // Positions the barcode to the left
barcodeStamper.VerticalAlignment = VerticalAlignment.Bottom;  // Positions the barcode at the bottom

// Load a PDF document to stamp the barcode on
var document = new PdfDocument("example.pdf");

// Apply the barcode stamp to the PDF
document.ApplyStamp(barcodeStamper);
```

### Placing a QR Code Stamp on a PDF

The following example demonstrates how to create a QR Code and apply it as a stamp on a PDF document:

```csharp
// Create a BarcodeStamper instance for QR Code
BarcodeStamper qrCodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);

// Set properties for the QR Code
qrCodeStamper.Height = 50; // height of the QR code in pixels
qrCodeStamper.Width = 50;  // width of the QR code in pixels

// Positioning the QR Code
qrCodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
qrCodeStamper.VerticalAlignment = VerticalAlignment.Bottom;

// Load a PDF document to stamp
var pdfDocument = new PdfDocument("example.pdf");

// Apply the QR Code stamp to the PDF
pdfDocument.ApplyStamp(qrCodeStamper);
```

```csharp
// Initialize a new QR Code Barcode Stamper with the label "IronPDF"
BarcodeStamper qrCodeStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);

// Set the dimensions of the QR Code
qrCodeStamp.Height = 50;  // Height in pixels
qrCodeStamp.Width = 50;   // Width in pixels

// Position the QR Code on the PDF
qrCodeStamp.HorizontalAlignment = HorizontalAlignment.Left;  // Align to the left
qrCodeStamp.VerticalAlignment = VerticalAlignment.Bottom;    // Align to the bottom

// Load an existing PDF document
var pdfDocument = new PdfDocument("example.pdf");

// Stamp the QR Code onto the PDF
pdfDocument.ApplyStamp(qrCodeStamp);
```

### Adding a Watermark to Your PDF Document

Incorporating a watermark into your PDF is straightforward with the `ApplyWatermark` method, which seamlessly adds a watermark across all pages of the document.

```csharp
var pdfDocument = new PdfDocument("https://ironpdf.com/attachments/design.pdf");
string watermarkHtml = "<h1>Example Title</h1>";
int watermarkRotation = 0;
int opacityOfWatermark = 30;

pdfDocument.ApplyWatermark(watermarkHtml, watermarkRotation, opacityOfWatermark);
```

For a practical demonstration of watermarking with code samples, please check out our tutorial on the [Code Examples page](https://ironsoftware.com/examples/pdf-watermarking/).

### Applying Stamps to a PDF Document

Utilizing IronPDF's `ApplyStamp` method, you can effectively place your customized `Stamper` anywhere within your PDF document. This method is versatile, accommodating a variety of applications for different stamping needs.

```csharp
var pdf = new PdfDocument("https://ironpdf.com/assets/example.pdf");

// Apply a single stamp to every page of the document
pdf.ApplyStamp(myStamper);

// Apply a single stamp to the first page only
pdf.ApplyStamp(myStamper, 0);

// Apply the same stamp to multiple selected pages
pdf.ApplyStamp(myStamper, new int[] { 0, 3, 5 });

// Implement a collection of stamps across all pages
pdf.ApplyMultipleStamps(stampArray);

// Implement a collection of stamps on the first page
pdf.ApplyMultipleStamps(stampArray, 0);

// Implement a collection of stamps to specified pages
pdf.ApplyMultipleStamps(stampArray, new int[] { 0, 3, 5 });

// Asynchronous stamp application to the fifth page
await pdf.ApplyStampAsync(myStamper, 4);

// Asynchronously apply multiple stamps to multiple pages
await pdf.ApplyMultipleStampsAsync(stampArray);

// Utilize a watermark with specified attributes
string htmlContent = "<h1> Example Title </h1>";
int angle = 0;
int opacity = 30;
pdf.ApplyWatermark(htmlContent, angle, opacity);
```

#### Length Class Overview

The `Length` class is designed with two primary attributes: `Unit` and `Value`. You first choose a `Unit` from the available options in the `MeasurementUnit` enumeration, where the default setting is `Percentage` relative to the page size. After setting the unit, you specify the `Value`, which determines the extent of the length relative to the chosen unit.

## Properties of the Length Class

```txt
class Length
|
└─── double : Value (default : 0)
|
└─── MeasurementUnit : Unit
     |   Inch
     |   Millimeter
     |   Centimeter
     |   Percentage (default)
     |   Pixel
     |   Points
```

This outline defines the attributes of the `Length` class used within the IronPDF library. It encapsulates a `double` type `Value`, where the default is 0, and a `MeasurementUnit` for the unit. The supported units are Inch, Millimeter, Centimeter, Percentage (which is the default unit), Pixel, and Points. These properties facilitate precise layout adjustments in PDF documents generated or manipulated by IronPDF.

```txt
class Length

└─── double : Value (initial value : 0)

└─── MeasurementUnit : Unit
   |   Inch
   |   Millimeter
   |   Centimeter
   |   Percentage (initial value)
   |   Pixel
   |   Points
```

### Examples of Using Length

#### Creating a Length Instance

```csharp
// Instantiates a Length object representing 5 inches
new Length(value: 5, unit: MeasurementUnit.Inch);

// Instantiates a Length object representing 25 pixels
new Length(value: 25, unit: MeasurementUnit.Pixel);

// Creates a Length with a default value, which is 0% of the page dimension
new Length();

// Creates a Length representing 20% of the page dimension
new Length(value: 20);
```

#### Using Length in a Parameter Context

```csharp
HtmlStamper sampleStamper = new HtmlStamper
{
    // Setting vertical offset to 15% of the page dimension
    VerticalOffset = new Length(15, MeasurementUnit.Percentage),
    // Setting horizontal offset to 1 inch
    HorizontalOffset = new Length(1, MeasurementUnit.Inch)
    // Define other properties as needed...
};
```

### Defining a Length

The creation and application of a `Length` object in IronPDF offers a versatile way to manage dimensions within your PDF documents. Below, we explore the properties of the `Length` class and demonstrate its usage through various examples:

```csharp
// Initialize a Length instance specifying 5 inches
Length fiveInches = new Length(5, MeasurementUnit.Inch);

// Define a Length in pixels
Length twentyFivePixels = new Length(25, MeasurementUnit.Pixel);

// Create a Length with a default unit of percentage (0% of the page dimension)
Length defaultLength = new Length();

// Specify a Length as a percentage of the page dimension
Length twentyPercent = new Length(20);  // This implies 20% of the page dimension
```

#### Utilizing Length in Parameters

```csharp
HtmlStamper logoStamper = new HtmlStamper
{
    VerticalOffset = new Length(15, MeasurementUnit.Percentage),  // Set 15% vertical offset
    HorizontalOffset = new Length(1, MeasurementUnit.Inch)        // Set 1 inch horizontal offset
    // You can specify other properties as needed...
};
```

This section demonstrates how to set up dimensions for various PDF elements effectively, offering flexibility in document design by specifying measurements in inches, pixels, or percent — catering to diverse layout needs.

Here is the paraphrased section, focusing on maintaining the technical accuracy and clarity while altering the structure and presentation of the original content:

```csharp
// Define a length of 5 inches
new Length(value: 5, unit: MeasurementUnit.Inch);

// Define a length of 25 pixels
new Length(value: 25, unit: MeasurementUnit.Pixel);

// Default Length - equals to 0% of the page's dimensions
new Length();

// Set the Length to 20% of the page's dimensions
new Length(value: 20); // Percentage is implicitly the default unit
```

#### Utilizing `Length` as a Parameter

The `Length` class provides the flexibility to define dimensions in various units:

```csharp
// Define a length of 5 inches
new Length(value: 5, unit: MeasurementUnit.Inch);

// Define a length of 25 pixels
new Length(value: 25, unit: MeasurementUnit.Pixel);

// Default length, equivalent to zero percent of the page dimensions
new Length();

// Length as twenty percent of the page dimensions
new Length(value: 20);
```

Example of applying `Length` in a practical scenario: 

```csharp
HtmlStamper logoStamper = new HtmlStamper
{
    VerticalOffset = new Length(15, MeasurementUnit.Percentage),
    HorizontalOffset = new Length(1, MeasurementUnit.Inch)
    // Additional properties can be set here...
};
```

```csharp
HtmlStamper logoStamper = new HtmlStamper
{
    VerticalOffset = new Length(15, MeasurementUnit.Percentage),
    HorizontalOffset = new Length(1, MeasurementUnit.Inch)
    // Additional properties can be configured here...
};
```

## Working with PDF Forms

IronPDF offers robust tools for both creating new PDFs with forms, and editing or filling out existing forms. This section will guide you through creating, editing, and handling PDF forms using IronPDF's powerful features.

### Creating and Modifying PDF Forms

IronPDF simplifies the process of creating PDFs with integrated forms direct from HTML. This capability means you can generate a PDF with interactive form fields embedded directly within the document.

```csharp
// Creating a PDF from HTML with editable form fields
var htmlForm = @"
    <html>
        <body>
            <h2>User Information Form</h2>
            <form>
                First name: <br> <input type='text' name='firstname'> <br>
                Last name: <br> <input type='text' name='lastname'>
            </form>
        </body>
    </html>";

// Initialize the PDF renderer with option to create form fields from HTML
var pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.CreatePdfFormsFromHtml = true;

// Convert the HTML to a functional PDF form
pdfRenderer.RenderHtmlAsPdf(htmlForm).SaveAs("EditablePDFForm.pdf");

// Load the created PDF to manipulate form fields
var editableForm = PdfDocument.FromFile("EditablePDFForm.pdf");

// Example of reading a field value
var firstnameField = editableForm.Form.FindFormField("firstname");
var lastnameField = editableForm.Form.FindFormField("lastname");
```

For more detailed examples and use cases, please visit [Creating and Editing PDF Forms](https://ironpdf.com/examples/form-data/).

### Filling Out Existing PDF Forms

IronPDF not only facilitates the creation of PDF forms, but it also makes it simple to fill out existing forms programmatically. This feature is particularly useful for automating form completions based on user input or data processing needs.

```csharp
// Load an existing PDF with forms
var loadedForm = PdfDocument.FromFile("EditablePDFForm.pdf");

// Setting field values
var firstNameFormField = loadedForm.Form.FindFormField("firstname");
firstNameFormField.Value = "Mickey";

var lastNameFormField = loadedForm.Form.FindFormField("lastname");
lastNameFormField.Value = "Mouse";

// Console output to verify the field values
Console.WriteLine("First Name: {0}", firstNameFormField.Value);
Console.WriteLine("Last Name: {0}", lastNameFormField.Value);

// Save the filled-out form as a new PDF
loadedForm.SaveAs("CompletedPDFForm.pdf");
```

For more hands-on examples, explore our [Filling Out Forms Tutorial](https://ironpdf.com/examples/form-data/).

## Summary

Whether you're creating a new PDF form from scratch or filling out an existing one, IronPDF provides the necessary tools to handle forms with ease. To learn more about specific functionalities or if you have any inquiries regarding IronPDF capabilities or licensing options, don't hesitate to [reach out to our support](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are here to assist and enhance your PDF processing tasks.

### Form Creation and Editing

Leverage IronPDF to construct PDFs that contain embedded form fields:

```csharp
// Begin by creating a PDF featuring editable forms crafted from HTML
const string formHtml = @"
    <html>
        <body>
            <h2>Interactive PDF Form</h2>
            <form>
                First name: <br> <input type='text' name='firstname' value=''> <br>
                Last name: <br> <input type='text' name='lastname' value=''>
            </form>
        </body>
    </html>";

// Initialize the Renderer
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;  // Set to convert HTML form elements into PDF forms
renderer.RenderHtmlAsPdf(formHtml).SaveAs("InteractiveForm.pdf");

// Now, interact with the PDF form fields.
var interactiveForm = PdfDocument.FromFile("InteractiveForm.pdf");

// Retrieve the 'firstname' field's data
var firstNameField = interactiveForm.Form.FindFormField("firstname");

// Access the 'lastname' field's data
var lastNameField = interactiveForm.Form.FindFormField("lastname");
```

For additional details on manipulating PDF forms with IronPDF, check out the [PDF Form management tutorial](https://ironpdf.com/examples/form-data/).

```csharp
// Step 1: Generating a PDF that includes editable form elements created with HTML
const string htmlForm = @"
    <html>
        <body>
            <h2>PDF Form Creation</h2>
            <form>
              First Name: <br> <input type='text' name='firstname' value=''> <br>
              Last Name: <br> <input type='text' name='lastname' value=''>
            </form>
        </body>
    </html>";

// Initialize the rendering engine
var pdfRenderer = new ChromePdfRenderer();
pdfRenderer.RenderingOptions.CreatePdfFormsFromHtml = true;
pdfRenderer.RenderHtmlAsPdf(htmlForm).SaveAs("BasicForm.pdf");

// Step 2: Access and manipulate the values within the PDF form
var editablePdf = PdfDocument.FromFile("BasicForm.pdf");

// Retrieve the value of the 'firstname' input field
var fieldFirstName = editablePdf.Form.FindFormField("firstname");

// Fetch the value from the 'lastname' input field 
var fieldLastName = editablePdf.Form.FindFormField("lastname");
```

To explore an example of PDF forms on our Code Examples page, please click [here](https://ironpdf.com/examples/form-data/).

### Populating Existing PDF Forms

With IronPDF, accessing and filling out existing form fields within a PDF document is straightforward, allowing you to update the content and save it again seamlessly:

```csharp
var formDocument = PdfDocument.FromFile("BasicForm.pdf");

// Modify the value of the "firstname" field
var firstNameField = formDocument.Form.FindFormField("firstname");
firstNameField.Value = "Minnie";
Console.WriteLine("FirstNameField value: {0}", firstNameField.Value);

// Adjust the value of the "lastname" field
var lastNameField = formDocument.Form.FindFormField("lastname");
lastNameField.Value = "Mouse";
Console.WriteLine("LastNameField value: {0}", lastNameField.Value);

formDocument.SaveAs("FilledForm.pdf");
```

To explore more about handling PDF forms with IronPDF, visit the detailed example [here](https://ironpdf.com/examples/form-data/).

Here's the paraphrased section of the article:

```csharp
var document = PdfDocument.FromFile("BasicForm.pdf");

// Set and Retrieve the "firstname" field's value
var firstField = document.Form.FindFormField("firstname");
firstField.Value = "Minnie";
Console.WriteLine("First Name: {0}", firstField.Value);

// Set and Retrieve the "lastname" field's value
var lastField = document.Form.FindFormField("lastname");
lastField.Value = "Mouse";
Console.WriteLine("Last Name: {0}", lastField.Value);

document.SaveAs("FilledForm.pdf");
```

For a detailed demonstration of the PDF Form example, please check out our Code Examples page by clicking [here](https://ironpdf.com/examples/form-data/).

## Conclusion

The above examples showcase how IronPDF provides essential capabilities for PDF editing that are ready to use immediately.

Should you need to submit a feature request or have inquiries regarding IronPDF or its licensing options, feel free to [reach out to our support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are eager to help you.

