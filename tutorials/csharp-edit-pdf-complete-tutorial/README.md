# How to Edit a PDF in C#

## Introduction

Iron Software has greatly streamlined multiple PDF editing capabilities through the IronPDF library. This includes everything from adding signatures to inserting HTML content, applying watermarks, and annotating documents. IronPDF ensures that your code remains clean and readable, simplifies PDF creation programmatically, and guarantees straightforward debugging and deployment across various platforms and environments.

With IronPDF, you have access to an extensive array of features for PDF modification. In this instructional tutorial, we'll explore some of these essential features, provide code samples, and explain their uses.

This guide will equip you with the knowledge necessary to manipulate PDF files using IronPDF in C#.

## Table of Contents

- **Edit Document Structure**
  - [Add, Copy, and Delete Pages](#anchor-manipulate-pages)
  - [Merge and Split PDF Documents](#anchor-merge-and-split-pdfs)
- **Edit Document Properties**
  - [Add and Manage PDF Metadata](#anchor-add-and-use-pdf-metadata)
  - [Digital Signatures](#anchor-digital-signatures)
  - [Handling PDF Attachments](#anchor-pdf-attachments)
  - [PDF Compression Techniques](#anchor-compress-pdfs)
- **Edit PDF Content**
  - [Incorporating Headers and Footers](#anchor-add-headers-and-footers)
  - [Search and Replace Text in PDF](#anchor-find-and-replace-text-in-a-pdf)
  - [Using Outlines and Bookmarks](#anchor-outlines-and-bookmarks)
  - [Creating and Modifying Annotations](#anchor-add-and-edit-annotations)
  - [Setting Backgrounds and Foregrounds](#anchor-add-backgrounds-and-foregrounds)
- **Stamping and Watermarking Features**
  - [Overview of Stampers](#anchor-stamper-abstract-class)
    - [Properties of Stamper Classes](#anchor-stamper-class-properties)
  - [Examples of Stamping](#anchor-stamping-examples)
    - [Text Stamping](#anchor-stamp-text-onto-a-pdf)
    - [Image Stamping](#anchor-stamp-an-image-onto-a-pdf)
    - [HTML Stamping](#anchor-stamp-html-onto-a-pdf)
    - [Barcode and QR Code Stamping](#anchor-stamp-a-barcode-onto-a-pdf)
    - [Adding Watermarks](#anchor-add-a-watermark-to-a-pdf)
  - [Applying Stamps to PDFs](#anchor-apply-stamp-onto-a-pdf)
  - [Understanding the Length Class](#anchor-length-class)
    - [Properties of the Length Class](#anchor-length-class-properties)
    - [Using Length in Coding](#anchor-length-examples)
- **Utilization of Forms in PDFs**
  - [Creating and Altering Forms](#anchor-create-and-edit-forms)
  - [Populating Existing Forms](#anchor-fill-existing-forms)

By reading this article, you'll learn the critical capabilities that IronPDF offers for enhancing your PDF editing tasks. Join us as we outline how to maximize the potential of these features in your development projects.

## Introduction

Iron Software has streamlined a variety of PDF editing operations into intuitive and easy-to-follow methods with its IronPDF library. Whether it's inserting signatures, embedding HTML footers, applying watermarks, or adding annotations, IronPDF equips you with the tools for clear coding, on-the-fly PDF creation, straightforward debugging, and effortless deployment across any supported platform or environment.

IronPDF is rich with features for manipulating PDF documents. Throughout this guide, we will explore key functionalities, accompanied by code snippets and brief discussions to enhance your comprehension.

By the end of this article, you'll possess a solid grasp of how to leverage IronPDF for editing PDFs using C#.

## Table of Contents

- **Document Structure Modifications**
  - [Page Additions, Copies, and Deletions](#anchor-manipulate-pages)
  - [Combining and Dividing PDF Documents](#anchor-merge-and-split-pdfs)

- **Property Management in Documents**
  - [Incorporating and Managing PDF Metadata](#anchor-add-and-use-pdf-metadata)
  - [Implementing Digital Signatures](#anchor-digital-signatures)
  - [Managing PDF File Attachments](#anchor-pdf-attachments)
  - [PDF Compression Techniques](#anchor-compress-pdfs)

- **Adjusting PDF Content**
  - [Adding and Customizing Headers and Footers](#anchor-add-headers-and-footers)
  - [Text Search and Replacement in PDFs](#anchor-find-and-replace-text-in-a-pdf)
  - [Managing Outlines and Adding Bookmarks](#anchor-outlines-and-bookmarks)
  - [Inserting and Modifying Annotations](#anchor-add-and-edit-annotations)
  - [Inserting Background and Foreground Graphics](#anchor-add-backgrounds-and-foregrounds)

- **PDF Stamping and Watermark Applications**
  - [Introduction to Stamping](#anchor-stamper-abstract-class)
    - [Properties of Stamper Classes](#anchor-stamper-class-properties)
  - [Examples of Stamping](#anchor-stamping-examples)
    - [Text Stamping Techniques](#anchor-stamp-text-onto-a-pdf)
    - [Image Stamping Methods](#anchor-stamp-an-image-onto-a-pdf)
    - [Using HTML for Stamp Creation](#anchor-stamp-html-onto-a-pdf)
    - [Barcode Implementation in Stamping](#anchor-stamp-a-barcode-onto-a-pdf)
    - [Stamping with QR Codes](#anchor-stamp-a-qr-code-onto-a-pdf)
    - [Watermark Placement Strategy](#anchor-add-a-watermark-to-a-pdf)
  - [Applying Stamps on PDF Documents](#anchor-apply-stamp-onto-a-pdf)
  - [Understanding the Length Class](#anchor-length-class)
    - [Properties Explained in the Length Class](#anchor-length-class-properties)
    - [Utilizing the Length Class in Examples](#anchor-length-examples)

- **Form Handling in PDFs**
  - [Developing and Modifying Form Fields](#anchor-create-and-edit-forms)
  - [Populating Existing PDF Forms](#anchor-fill-existing-forms)

## Editing the Structure of a Document

### Page Manipulation

IronPDF provides straightforward methods to seamlessly manage pages within your PDF documents. Whether you're inserting new pages, copying existing ones, or removing them, the process is intuitive and managed effortlessly in the background by IronPDF.

#### Insert Pages

```csharp
// Create a PDF document from an existing file
var pdf = new PdfDocument("report.pdf");

// Render a cover page from HTML and add it to the beginning of the PDF
var renderer = new ChromePdfRenderer();
var titlePage = renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>");
pdf.PrependPdf(titlePage);

// Save the new PDF with the cover page
pdf.SaveAs("report_with_cover.pdf");
```

#### Duplicate Pages

```csharp
var pdf = new PdfDocument("report.pdf");
// Duplicate pages 5 to 7 into a new document.
pdf.CopyPages(4, 6).SaveAs("report_highlight.pdf");
```

#### Remove Pages

```csharp
var pdf = new PdfDocument("report.pdf");

// Delete the final page from the document and save it
pdf.RemovePage(pdf.PageCount - 1);
pdf.SaveAs("report_minus_one_page.pdf");
```

### Combine and Divide PDFs

Combining multiple PDFs into a single document or dividing a long PDF into smaller sections is straightforward with the intuitive API provided by IronPDF.

#### Merge Several PDFs into a Single File

```csharp
var pdfs = new List<PdfDocument>
{
    PdfDocument.FromFile("A.pdf"),
    PdfDocument.FromFile("B.pdf"),
    PdfDocument.FromFile("C.pdf")
};

// Merge all PDFs into a single document
PdfDocument mergedPdf = PdfDocument.Merge(pdfs);
mergedPdf.SaveAs("merged.pdf");

// Clean up resources
foreach (var pdf in pdfs)
{
    pdf.Dispose();
}
```

For additional coding examples on merging PDFs, visit [IronPDF Merging Example](https://ironsoftware.com/examples/merge-pdfs/).

#### Section PDF and Extract Pages

```csharp
var pdf = new PdfDocument("sample.pdf");

// Extract the first page
var firstPage = pdf.CopyPage(0);
firstPage.SaveAs("Split1.pdf");

// Extract pages 2 and 3
var pagesTwoThree = pdf.CopyPages(1, 2);
pagesTwoThree.SaveAs("Split2.pdf");
```

For further details on splitting and extracting pages, please explore our [Splitting PDFs Example](https://ironsoftware.com/examples/split-pdf-pages-csharp/).

### Page Manipulation

Performing tasks such as inserting PDFs at specific indices, extracting pages individually or by range, and removing pages is straightforward with IronPDF. This tool handles all the complexities in the background, simplifying the entire process.

#### Adding Pages

Using IronPDF's robust capabilities, you can effortlessly prepend pages to your PDF documents at specific positions. This could be essential for inserting a title page or adding any supplementary content before the main material.

```csharp
var pdfDocument = new PdfDocument("report.pdf");
var pdfRenderer = new ChromePdfRenderer();
var titlePagePdf = pdfRenderer.RenderHtmlAsPdf("<h1>Title Page</h1><hr>");

// Insert the new page at the beginning of the PDF document
pdfDocument.PrependPdf(titlePagePdf);
pdfDocument.SaveAs("report_with_title.pdf");
```

```csharp
// Initialize a new PDF document
var document = new PdfDocument("report.pdf");

// Create a renderer for converting HTML to PDF
var pdfRenderer = new ChromePdfRenderer();

// Render a simple HTML string to a PDF
var titlePage = pdfRenderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>");

// Attach the newly created PDF as the first page of the original document
document.InsertPdf(0, titlePage);

// Save the updated PDF to a new file
document.SaveAs("report_including_cover_page.pdf");
```

#### Copying Pages

Manipulating specific pages within a PDF is straightforward with IronPDF. You can easily extract a range of pages or individual pages and save them as a new document. Here’s how you can accomplish this task:

```csharp
var pdf = new PdfDocument("report.pdf");
// Extract and copy pages 5 to 7 into a new PDF document.
pdf.CopyPages(4, 6).SaveAs("report_highlight.pdf");
```

```csharp
var pdfDocument = new PdfDocument("report.pdf");
// Duplicate pages from 5 to 7 and store them in a new PDF file.
pdfDocument.CopyPages(startPageIndex: 4, endPageIndex: 6).SaveAs("highlighted_report.pdf");
```

#### Removing Pages

Easily remove pages from any PDF document using IronPDF's straightforward API. This functionality makes managing your document's length and content quite effortless.

```csharp
var pdf = new PdfDocument("report.pdf");

// Delete the last page of the PDF and save the file
pdf.RemovePage(pdf.PageCount - 1);
pdf.SaveAs("report_minus_one_page.pdf");
```

```csharp
var document = new PdfDocument("report.pdf");

// Delete the final page from the document and save a new version
document.RemovePage(document.PageCount - 1);
document.SaveAs("report_with_final_page_removed.pdf");
```

### Combining and Dividing PDF Documents

Combining multiple PDF documents into a single file or dividing a single PDF into several separate documents is straightforward and efficient, thanks to the user-friendly API provided by IronPDF.

#### Combine Several PDFs into One Document

Merging multiple PDF files into a single document is straightforward using the effective IronPDF API.

```csharp
var pdfList = new List<PdfDocument>
{
    PdfDocument.FromFile("A.pdf"),
    PdfDocument.FromFile("B.pdf"),
    PdfDocument.FromFile("C.pdf")
};

PdfDocument combinedPdf = PdfDocument.Merge(pdfList);
combinedPdf.SaveAs("combined.pdf");

foreach (var pdf in pdfList)
{
    pdf.Dispose();
}
```

For detailed examples on merging PDFs, please see our Code Examples page [here](https://ironpdf.com/examples/merge-pdfs/).

Here's the paraphrased section resolved against ironpdf.com for relative URL paths:

```csharp
var documents = new List<PdfDocument>
{
    PdfDocument.FromFile("A.pdf"),
    PdfDocument.FromFile("B.pdf"),
    PdfDocument.FromFile("C.pdf")
};

// Merge the PDF documents into a single PDF file
PdfDocument combinedPdf = PdfDocument.Merge(documents);
combinedPdf.SaveAs("combined_output.pdf");

// Clean up resources by disposing of the PDF document objects
foreach (var doc in documents)
{
    doc.Dispose();
}
```

For more details on how to merge multiple PDFs using our examples, please refer to our [Code Examples page](https://ironpdf.com/examples/merge-pdfs/).

#### Dividing a PDF and Isolating Specific Pages

Splitting a PDF document into individual pages or extracting specific sections can be effortlessly accomplished using IronPDF's user-friendly APIs.

```csharp
var pdf = new PdfDocument("sample.pdf");

// Extract the first page
var pdf_first_page = pdf.CopyPage(0);
pdf_first_page.SaveAs("Split_First_Page.pdf");

// Isolate pages 2 and 3
var pdf_pages_2_and_3 = pdf.CopyPages(1, 2);
pdf_pages_2_and_3.SaveAs("Split_Pages_2_and_3.pdf");
```

For detailed examples on how to split and extract specific pages from your PDFs using IronPDF, kindly visit [IronPDF's Split PDF pages tutorial](https://ironpdf.com/examples/split-pdf-pages-csharp/).

```csharp
var document = new PdfDocument("sample.pdf");

// Isolate the first page
var firstPage = document.CopyPage(0);
firstPage.SaveAs("FirstPage.pdf");

// Extract pages 2 and 3
var secondAndThirdPages = document.CopyPages(1, 2);
secondAndThirdPages.SaveAs("Pages2And3.pdf");
```

For more detailed information on how to split and extract pages from a PDF, you can explore our comprehensive examples on our [Code Examples page](https://ironpdf.com/examples/split-pdf-pages-csharp/).

## Modifying PDF Document Attributes

IronPDF provides straightforward methods for navigating and manipulating PDF properties. This section of the tutorial demonstrates these capabilities with practical code snippets.

### Adding and Managing PDF Metadata

With IronPDF, adjusting the metadata of your PDF files is effortless:

```csharp
// Loading a protected file or generating a new PDF from HTML content
var pdf = PdfDocument.FromFile("encrypted.pdf", "password");

// Modifying metadata properties
pdf.MetaData.Author = "Satoshi Nakamoto";
pdf.MetaData.Keywords = "SEO, Digital Marketing";
pdf.MetaData.ModifiedDate = DateTime.Now;

// Configuring document security settings
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Updating document encryption passwords
pdf.SecuritySettings.OwnerPassword = "top-secret"; // Edit permission password
pdf.SecuritySettings.UserPassword = "shareable";  // Open permission password
pdf.SaveAs("secured.pdf");
```

### Implementing Digital Signatures

Leverage IronPDF to apply digital signatures to your PDFs using .pfx or .p12 X509Certificate2 certificates, ensuring unaltered document authenticity.

Secure a PDF with a signature in a single line of code:

```csharp
using IronPdf;
using IronPdf.Signing;

new IronPdf.Signing.PdfSignature("Iron.p12", "123456").SignPdfFile("any.pdf");
```

Here’s a more elaborate example for enhanced control:

```csharp
using IronPdf;

// Creating a new PDF
var renderer = new ChromePdfRenderer();
var document = renderer.RenderHtmlAsPdf("<h1>Exploring digital security</h1>");

// Setting up a digital signature
var signature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
{
    SigningContact = "support@ironsoftware.com",
    SigningLocation = "Chicago, USA",
    SigningReason = "Demonstrating PDF signing"
};

// Signing the PDF
document.Sign(signature);

// Finalizing by saving the signed PDF to a file
document.SaveAs("digitally_signed.pdf");
```

Generate a digital signing certificate with Adobe Reader as detailed [here](https://helpx.adobe.com/acrobat/using/digital-ids.html).

### Managing PDF Attachments

IronPDF supports the addition and removal of attachments within your PDF documents seamlessly:

```csharp
var Renderer = new ChromePdfRenderer();
var myPdf = Renderer.RenderHtmlFileAsPdf("my-content.html");

// Adding an attachment
var attachment1 = myPdf.Attachments.AddAttachment("attachment_1", example_attachment);

// Removing an attachment
myPdf.Attachments.RemoveAttachment(attachment1);

myPdf.SaveAs("updated_content.pdf");
```

### Compressing PDFs

To minimize the file size of PDFs, IronPDF offers image compression tools. This feature is especially useful for documents with numerous high-resolution images:

```csharp
var pdf = new PdfDocument("large-file.pdf");

// Set the image quality level (1-100)
pdf.CompressImages(75); // Reduces image quality to optimize size
pdf.SaveAs("optimized_file_size.pdf");
```

Consider varying the quality levels to balance clarity and file size based on your specific needs:

```csharp
var pdf = new PdfDocument("high-res-file.pdf");

pdf.CompressImages(85, true); // Optionally adjusts image scaling
pdf.SaveAs("scaled_optimized_file.pdf");
```

### Adding and Utilizing PDF Metadata

Effortlessly explore and modify PDF metadata with IronPDF:

```csharp
// Load an encrypted PDF file or create a new one from HTML
var pdfDocument = PdfDocument.FromFile("encrypted.pdf", "password");

// Modify the PDF metadata
pdfDocument.MetaData.Author = "Satoshi Nakamoto";
pdfDocument.MetaData.Keywords = "SEO, Friendly";
pdfDocument.MetaData.ModifiedDate = System.DateTime.Now;

// Configure security settings for the PDF
// This code will set the PDF to read-only, preventing copy & paste and printing activities
pdfDocument.SecuritySettings.RemovePasswordsAndEncryption();
pdfDocument.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdfDocument.SecuritySettings.AllowUserAnnotations = false;
pdfDocument.SecuritySettings.AllowUserCopyPasteContent = false;
pdfDocument.SecuritySettings.AllowUserFormData = false;
pdfDocument.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Update or establish the PDF's encryption passwords
pdfDocument.SecuritySettings.OwnerPassword = "top-secret"; // Set password required to edit the PDF
pdfDocument.SecuritySettings.UserPassword = "shareable";  // Set password required to open the PDF
pdfDocument.SaveAs("secured.pdf");
```

### Digital Signatures

IronPDF provides robust solutions for digitally signing PDF documents, whether they are newly created or already existing, through the use of .pfx and .p12 X509Certificate2 digital certificates.

Once a document is digitally signed, any alterations to it require verification via the signing certificate, which secures the document's integrity.

For instructions on creating a signing certificate at no cost with Adobe Reader, visit [Adobe's Digital IDs guide](https://helpx.adobe.com/acrobat/using/digital-ids.html).

IronPDF also supports the use of visually representational signatures, such as handwritten signatures or company seals, for document signing purposes.

Easily sign a PDF document cryptographically with a single line of code using IronPDF.

```csharp
using IronPdf;
using IronPdf.Signing;

// Sign an existing PDF with a digital certificate
var pdfSignature = new PdfSignature("Iron.p12", "123456");
pdfSignature.SignPdfFile("any.pdf");
```

```csharp
using IronPdf;

// Begin by generating a PDF from HTML content
var renderer = new ChromePdfRenderer();
var document = renderer.RenderHtmlAsPdf("<h1>Demonstrating Robust Digital Security with IronPDF</h1>");

// Initialize the PDF signature
// Ensure you have a .pfx or .p12 signing certificate, which can be created using tools like Adobe Acrobat Reader.
// Reference: https://helpx.adobe.com/acrobat/using/digital-ids.html
var signature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
{
    // Optional: Configure additional signing details
    SigningContact = "support@ironsoftware.com",
    SigningLocation = "Chicago, USA",
    SigningReason = "Illustration of PDF signing capabilities"
};

// Apply the digital signature to the PDF
document.Sign(signature);

// Remember to save the document to finalize the signature.
document.SaveAs("digitally-signed.pdf");
```

```csharp
using IronPdf;

// Step 1: Generate a new PDF
var renderer = new ChromePdfRenderer();
var document = renderer.RenderHtmlAsPdf("<h1>Assessing 2048-bit Digital Security</h1>");

// Step 2: Initialize the digital signature
// For creating a .pfx or .p12 certification, refer to Adobe Acrobat Reader instructions:
// Read more at: https://helpx.adobe.com/acrobat/using/digital-ids.html
var signature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
{
    // Step 3: Configure optional parameters for the digital signature, including a graphical handwritten signature
    SigningContact = "support@ironsoftware.com",
    SigningLocation = "Chicago, USA",
    SigningReason = "Demonstrating PDF signing capabilities"
};

// Step 4: Apply the digital signature to the PDF. You can use multiple certificates here.
document.Sign(signature);

// Step 5: Persist changes to the PDF. It remains unsigned until it is saved.
document.SaveAs("signed.pdf");
```

### PDF Attachments

IronPDF offers comprehensive functionality for managing attachments within your PDF documents. You can effortlessly add or delete attachments as needed.

```csharp
// Initialize the PDF Renderer
var pdfRenderer = new ChromePdfRenderer();
// Render an HTML file into a PDF document
var documentPdf = pdfRenderer.RenderHtmlFileAsPdf("my-content.html");

// Adding an attachment by specifying its name and using the byte array 'example_attachment'
var attachedFile = documentPdf.Attachments.AddAttachment("attachment_1", example_attachment);

// Removing the previously added attachment
documentPdf.Attachments.RemoveAttachment(attachedFile);

// Save the modified PDF to a new file
documentPdf.SaveAs("my-content.pdf");
```

### Compressing PDF Documents

IronPDF provides functionality for compressing PDF files. A common method to decrease PDF file size is by compressing the embedded images within the document using IronPDF's `CompressImages` method.

Compression of JPEG images varies significantly with quality settings. A setting of 100% quality maintains the original quality with negligible loss, whereas 1% quality produces significantly degraded images. As a rule of thumb, quality settings between 90% and 100% yield high-quality outputs; 80%-90% offers medium quality; and 70%-80% results in lower quality images. Reducing the quality below 70% can lead to dramatic reductions in file size, albeit at the cost of noticeable quality loss.

It is advisable to experiment with various quality settings to find an ideal balance between image quality and file size that suits your specific requirements. The degree of quality loss is dependent on the type of images used, and some images may experience more noticeable reductions in clarity than others.

Here is a paraphrased version of the given section, with the URL paths resolved accordingly from `ironpdf.com`:

```csharp
// Load the PDF file to be compressed
var pdfDocument = new PdfDocument("document.pdf");

// Compress images within the document using the provided quality parameter (range 1-100)
pdfDocument.CompressImages(60); // 60% quality retains a balance between quality and file size
pdfDocument.SaveAs("document_compressed.pdf"); // Save the new compressed PDF
```

The `CompressImages` method also accepts an optional parameter allowing you to adjust the image resolution to match its displayed size in the PDF. However, be aware that this could lead to image distortion depending on the specific layout configurations:

Here's the paraphrased section with the updated link:

```csharp
var document = new PdfDocument("document.pdf");

// Compress images in the PDF with 90% quality and scale down resolution
document.CompressImages(90, true);
document.SaveAs("document_scaled_compressed.pdf");
```

## Modifying Content in PDFs

### Adding Headers and Footers

Utilizing IronPDF, you can seamlessly integrate headers and footers into your PDFs. IronPDF offers two varieties for headers and footers, `TextHeaderFooter` and `HtmlHeaderFooter`. For simple text-based headers and footers, `TextHeaderFooter` is optimal, allowing the incorporation of merge fields like `"{page} of {total-pages}"`. On the other hand, `HtmlHeaderFooter` is designed for more complex requirements, supporting full HTML content for visually exact layouts.

#### HTML Headers and Footers

The HTML version will render your HTML content as headers or footers on your PDFs, ensuring precise alignment and appearance.

```csharp
var renderer = new ChromePdfRenderer();

// Stylish HTML footer
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
    MaxHeight = 15, // in millimeters
    DrawDividerLine = true
};

// Header with an image
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    HtmlFragment = "<img src='logo.png'>",
    MaxHeight = 20,  // in millimeters
    BaseUrl = new System.Uri(@"C:\assets\images").AbsoluteUri
};
```

For a comprehensive guide with varied scenarios, visit [here](https://ironpdf.com/examples/adding-headers-and-footers-advanced/).

#### Text Headers and Footers

For straightforward text-based headers and footers, see the example below:

```csharp
var renderer = new ChromePdfRenderer()
{
    RenderingOptions = { FirstPageNumber = 1 },  // use 2 if appending a cover page

    // Simple text header
    TextHeader = {
        DrawDividerLine = true,
        CenterText = "{url}",
        Font = IronSoftware.Drawing.FontTypes.Helvetica,
        FontSize = 12
    },

    // Matching footer
    TextFooter = {
        DrawDividerLine = true,
        Font = IronSoftware.Drawing.FontTypes.Arial,
        FontSize = 10,
        LeftText = "{date} {time}",
        RightText = "{page} of {total-pages}"
    }
};
```

The system replaces merge fields such as `{page}`, `{total-pages}`, `{url}`, `{date}`, `{time}`, `{html-title}`, `{pdf-title}` with actual values during rendering.

### Text Replacement in PDFs

IronPDF enables you to replace placeholders or text in your PDFs effectively through programmatic means using the `ReplaceTextOnPage` method.

```csharp
// Load the existing PDF
var pdf = PdfDocument.FromFile("sample.pdf");

// Configuration
int pageIndex = 1;
string oldText = ".NET 6";  // Text to be replaced
string newText = ".NET 7";  // New text

// Replace Text on a specific page
pdf.ReplaceTextOnPage(pageIndex, oldText, newText);

// Example of replacing a placeholder
pdf.ReplaceTextOnPage(pageIndex, "[DATE]", "01/01/2000");

// Persist the modified PDF
pdf.SaveAs("new_sample.pdf");
```

For detailed examples and usage, check [here](https://ironpdf.com/examples/csharp-replace-text-in-pdf/).

### Managing Bookmarks and Outlines

IronPDF also facilitates the management of PDF bookmarks which provide a way to jump to specific sections of a PDF and are displayed in the sidebar of applications like Adobe Acrobat Reader.

```csharp
// Editing an existing PDF
PdfDocument pdf = PdfDocument.FromFile("existing.pdf");

// Add bookmark
pdf.Bookmarks.AddBookMarkAtEnd("Author's Note", 2);
pdf.Bookmarks.AddBookMarkAtEnd("Table of Contents", 3);

// Create a bookmark for 'Summary'
var summaryBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Summary", 17);

// Nested bookmark under 'Summary'
var conclusionBookmark = summaryBookmark.Children.AddBookMarkAtStart("Conclusion", 18);

// Add another bookmark
pdf.Bookmarks.AddBookMarkAtEnd("References", 20);

pdf.SaveAs("existing.pdf");
```

Explore more about Outlines and Bookmarks at [here](https://ironpdf.com/examples/bookmarks/).

### Annotations within PDFs

IronPDF supports a wide array of annotation options, providing high customization for annotations within your PDFs.

```csharp
// Create or edit a PDF
var pdf = PdfDocument.FromFile("existing.pdf");

// Setting up a text annotation
var textAnnotation = new IronPdf.Annotations.TextAnnotation(PageIndex: 0)
{
    Title = "Major Title",
    Contents = "Detailed comment content...",
    Subject = "Subtitle",
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Note,
    Opacity = 0.8,
    Printable = true,
    OpenByDefault = true
};

// Add the text annotation
pdf.Annotations.Add(textAnnotation);

pdf.SaveAs("annotated.pdf");
```

Annotations allow for detailed comments or notes to be incorporated easily into your PDF documents. For more on configuring annotations, visit [https://ironpdf.com/examples/csharp-pdf-annotations/](https://ironpdf.com/examples/csharp-pdf-annotations/).

### Adding Backgrounds and Foregrounds

IronPDF allows for seamless integration of backgrounds and foregrounds by merging PDFs, using one as the background or foreground of another:

```csharp
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
pdf.AddBackgroundPdf(@"MyBackground.pdf");
pdf.AddForegroundOverlayPdfToPage(0, @"MyForeground.pdf", 0);
pdf.SaveAs(@"C:\Path\To\Complete.pdf");
```

Incorporating headers and footers into your PDF documents is straightforward with IronPDF, which offers two specific types of "HeaderFooters": `TextHeaderFooter` and `HtmlHeaderFooter`. For simpler applications including only textual content, `TextHeaderFooter` is ideal and supports dynamic content such as page numbers through merge fields like `"{page} of {total-pages}"`. For more complex requirements, `HtmlHeaderFooter` allows the inclusion of any HTML content, ensuring rich formatting and design flexibility in your document's headers and footers.

#### HTML Headers and Footers

Utilizing the rendered HTML directly, IronPDF enables you to perfectly format and integrate HTML headers and footers into your PDF documents. This feature ensures precise and exact visual layouts as headers or footers on each page.

The C# code snippet below demonstrates how to customize headers and footers within a PDF document using the IronPDF library's `ChromePdfRenderer`.

```csharp
var renderer = new ChromePdfRenderer();

// Configuring the footer with HTML. Merge fields include:
// {page}, {total-pages}, {url}, {date}, {time}, {html-title}, and {pdf-title}
renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
{
    MaxHeight = 15, // Set in millimeters
    HtmlFragment = "<center><i>{page} of {total-pages}</i></center>",
    DrawDividerLine = true // Adds a line above the footer for separation
};

// Setting up the header by utilizing an image
// Using BaseUrl to specify the relative path for image assets
renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
{
    MaxHeight = 20, // Millimeters
    HtmlFragment = "<img src='logo.png'>", // Path to the logo image
    BaseUrl = new System.Uri(@"https://ironpdf.com/assets/images").AbsoluteUri // Set absolute URL for base path
};
```

This example highlights the use of dynamic text and image content in headers and footers, enhanced by HTML formatting capabilities. It also showcases the use of `HtmlHeaderFooter` for adding structured design elements to your PDFs, facilitating content personalization while maintaining proper relative path referencing through `BaseUrl`.

For comprehensive examples demonstrating a variety of scenarios, please refer to our detailed tutorial available [here](https://ironpdf.com/examples/adding-headers-and-footers-advanced/).

#### Text Header and Footer

TextHeaderFooter provides a simple way to include basic headers and footers in your PDF documents. Below is an example showcasing how to implement this feature.

```csharp
var renderer = new ChromePdfRenderer();

// Configuration options for rendering
renderer.RenderingOptions.FirstPageNumber = 1; // Adjust to 2 if starting with a cover page

// Setting up the header template:
renderer.RenderingOptions.TextHeader.CenterText = "{url}"; // Central text
renderer.RenderingOptions.TextHeader.DrawDividerLine = true; // A line beneath the header
renderer.RenderingOptions.TextHeader.Font = IronSoftware.Drawing.FontTypes.Helvetica;
renderer.RenderingOptions.TextHeader.FontSize = 12;

// Setting up the footer template:
renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}"; // Left-aligned text
renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}"; // Right-aligned text
renderer.RenderingOptions.TextFooter.DrawDividerLine = true; // A line above the footer
renderer.RenderingOptions.TextFooter.Font = IronSoftware.Drawing.FontTypes.Arial;
renderer.RenderingOptions.TextFooter.FontSize = 10;
```
This section facilitates the integration of headers and footers with dynamic fields such as `{page}`, `{total-pages}`, `{url}`, `{date}`, `{time}`, `{html-title}`, and `{pdf-title}` which get automatically replaced with actual content during PDF generation, providing a professional-looking navigation system for your documents.

```csharp
var renderer = new ChromePdfRenderer
{
    RenderingOptions =
    {
        FirstPageNumber = 1, // Adjust this to 2 if including a cover page
        
        // Configuring a header on each page is straightforward:
        TextHeader =
        {
            DrawDividerLine = true, // Enables a dividing line
            CenterText = "{url}",  // Inserts the URL at the center
            Font = IronSoftware.Drawing.FontTypes.Helvetica,  // Sets the font type
            FontSize = 12  // Specifies the font size
        },
        
        // Similarly, adding a footer is just as easy:
        TextFooter =
        {
            DrawDividerLine = true, // Places a line for separation
            Font = IronSoftware.Drawing.FontTypes.Arial, // Chooses the font
            FontSize = 10, // Defines the font size
            LeftText = "{date} {time}", // Displays date and time on the left
            RightText = "{page} of {total-pages}" // Shows page count on the right
        }
    }
};
```

IronPDF supports a variety of merge fields that dynamically update with specific values during the rendering process. These include `{page}` for the current page number, `{total-pages}` displaying the total number of pages, `{url}` stating the source URL (if any), `{date}` and `{time}` for the current date and time, `{html-title}` for the title of the source HTML, and `{pdf-title}` which is used for the title of the PDF document.

### Finding and Replacing Text in a PDF Document

Effortlessly modify your PDFs by either inserting placeholders or replacing specific text segments programmatically. Utilize the `ReplaceTextOnPage` method to efficiently handle these text modifications in your PDFs.

The following C# code illustrates how to modify text within an existing PDF document using IronPDF:

```csharp
// Load a PDF document
var pdf = PdfDocument.FromFile("sample.pdf");

// Define the parameters for text replacement
int pageIndex = 1;  // Page index for operations
string oldText = ".NET 6"; // Text to be replaced
string newText = ".NET 7"; // New text to insert

// Execute the text replacement on the specified page
pdf.ReplaceTextOnPage(pageIndex, oldText, newText);

// Example of replacing a placeholder within the PDF
pdf.ReplaceTextOnPage(pageIndex, "[DATE]", "01/01/2000");

// Save the modified PDF to a new file
pdf.SaveAs("new_sample.pdf");
```
This refactored code snippet effectively demonstrates altering text within a PDF, providing clear, organized parameters and actions for each operation step.

For a detailed example of finding and replacing text in a PDF using our Code Examples, please click [here](https://ironpdf.com/examples/csharp-replace-text-in-pdf/).

### Outlines and Bookmarks

Outlines, often referred to as "bookmarks," provide a convenient means to quickly access important sections within a PDF document. These bookmarks are prominently displayed in the left sidebar of Adobe Acrobat Reader and can include nested levels. IronPDF seamlessly imports any existing bookmarks from PDF files and offers the flexibility to enhance these with new additions, modifications, or further organization.

Here's the paraphrased section of your article with resolved relative URL paths:

```csharp
// Initialize a PDF Document by loading an existing file or creating a new one.
PdfDocument pdf = PdfDocument.FromFile("existing.pdf");

// Inserting bookmarks at the end of the PDF document for quick access.
pdf.Bookmarks.AddBookMarkAtEnd("Author's Note", 2);
pdf.Bookmarks.AddBookMarkAtEnd("Table of Contents", 3);

// Create a new bookmark for the Summary section and store it for further use.
var summaryBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Summary", 17);

// Append a child bookmark for the Conclusion under the Summary section.
var conclusionBookmark = summaryBookmark.Children.AddBookMarkAtStart("Conclusion", 18);

// Add a final bookmark for References at the document's end.
pdf.Bookmarks.AddBookMarkAtEnd("References", 20);

// Save all changes to the same PDF file.
pdf.SaveAs("existing.pdf");
```

For an in-depth example of Outlines and Bookmarks, refer to our detailed tutorial on the Code Examples page [here](https://ironpdf.com/examples/bookmarks/).

### Add and Edit Annotations

IronPDF offers extensive customization options for PDF annotations. Below is an example that illustrates the comprehensive features available for annotating PDF documents:

```csharp
// Load an existing PDF or create a new one.
var pdf = PdfDocument.FromFile("existing.pdf");

// Define a PDF annotation object
var textAnnotation = new IronPdf.Annotations.TextAnnotation(PageIndex: 0)
{
    Title = "Main Title",
    Contents = "This is a detailed note added to the page...",
    Subject = "Sub Title",
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Comment,
    Opacity = 0.8,
    Printable = true,
    Hidden = false,
    OpenByDefault = false,
    ReadOnly = true,
    Rotatable = false,
};

// Add the defined annotation to a specific page in the PDF.
pdf.Annotations.Add(textAnnotation);

// Save changes to the PDF
pdf.SaveAs("annotated.pdf");
```

This sample code demonstrates how to implement annotations in PDFs using IronPDF, facilitating the addition of interactive and informative elements within your document.

```csharp
// Load an existing PDF or start with a new one.
var pdf = PdfDocument.FromFile("existing.pdf");

// Instantiate a new text annotation for PDFs
var textAnnotation = new IronPdf.Annotations.TextAnnotation(PageIndex: 0)
{
    Title = "Major Section Title",
    Contents = "Detailed content for a lengthy 'sticky note'...",
    Subject = "Subsection Title",
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
    Opacity = 0.9,  // Set the opacity for see-through effect
    Printable = false, 
    Hidden = false,
    OpenByDefault = true, // Open by default when the PDF is opened
    ReadOnly = false,
    Rotatable = true, // Allow rotation of the annotation
};

// Place the created text annotation on a determined page and location within the PDF.
pdf.Annotations.Add(textAnnotation);

// Save the changes to the same PDF file.
pdf.SaveAs("existing.pdf");
```

PDF annotations enable the addition of "sticky note"-style comments on PDF pages. The `TextAnnotation` class facilitates the programmatically insertion of these annotations. It supports a range of sophisticated features, such as size adjustments, opacity settings, icon selection, and content editing.

### Adding Backgrounds and Foregrounds

IronPDF facilitates the seamless integration of two PDF files by using one as a background or foreground layer. This feature simplifies enhancing PDFs with additional graphical elements.

Here's the paraphrased section of the article, with the URL paths resolved.

```csharp
var pdfRenderer = new ChromePdfRenderer();
var pdfDocument = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
pdfDocument.AddBackgroundPdf(@"https://ironpdf.com/MyBackground.pdf");
pdfDocument.AddForegroundOverlayPdfToPage(0, @"https://ironpdf.com/MyForeground.pdf", 0);
pdfDocument.SaveAs(@"C:\Path\To\Complete.pdf");
```

### Stamping and Watermarking

IronPDF provides essential functionalities for both stamping and watermarking, which are critical aspects of any PDF editing software. With IronPDF, you can utilize a versatile API to craft various types of stamps, like those for images and HTML. This framework offers extensive customization options, including adjustable alignments and offsets, to suit diverse stamping needs. These features are detailed illustrated [here](https://ironpdf.com/static-assets/pdf/tutorials/csharp-edit-pdf-complete-tutorial/csharp-edit-pdf-complete-tutorial-1.webp).

<div class="content-img-align-center">
  <img src="/static-assets/pdf/tutorials/csharp-edit-pdf-complete-tutorial/csharp-edit-pdf-complete-tutorial-1.webp" alt="Stamping and Watermarking" class="img-responsive add-shadow">
</div>

#### Abstract Stamper Class

The `Stamper` abstract class serves as a parameter for all stamping functions provided by IronPDF.

Various specialized classes cater to different stamping requirements:

- Use `TextStamper` for text stamps - [Text Example](#anchor-stamp-text-onto-a-pdf)
- Use `ImageStamper` for image stamps - [Image Example](#anchor-stamp-an-image-onto-a-pdf)
- Use `HtmlStamper` for HTML content stamps - [HTML Example](#anchor-stamp-html-onto-a-pdf)
- Use `BarcodeStamper` for barcode stamps - [Barcode Example](#anchor-stamp-a-barcode-onto-a-pdf)
- Use `BarcodeStamper` again for QR code stamps - [QR Code Example](#anchor-stamp-a-qr-code-onto-a-pdf)
- For adding watermarks, refer to [this section](#anchor-add-a-watermark-to-a-pdf).

To utilize these stamping tools, employ one of the `ApplyStamp()` methods outlined in [the Apply Stamp part of this tutorial](#anchor-apply-stamp-onto-a-pdf).

# Stamper Class Properties

The `Stamper` abstract class serves as the foundational parameter for all stamping operations within IronPDF. Each subclass is specialized for different stamping tasks:

- `TextStamper` for stamping text.
- `ImageStamper` for stamping images.
- `HtmlStamper` for stamping HTML content.
- `BarcodeStamper` for stamping barcodes.
- `BarcodeStamper` (another instance) for QR code operations.
- Details for watermark applications are available [here](https://ironpdf.com/examples/pdf-watermarking/).

For executing the stamping functionalities, IronPDF provides a series of methods under `ApplyStamp()`. For detailed guidance, refer to [this tutorial](#anchor-apply-stamp-onto-a-pdf).

Below are the properties of the Stamper class:

```txt
abstract class Stamper
|
└─── int : Opacity
└─── int : Rotation
|
└─── double : Scale
|
└─── Length : HorizontalOffset
└─── Length : VerticalOffset
|
└─── Length : MinWidth
└─── Length : MaxWidth
|
└─── Length : MinHeight
└─── Length : MaxHeight
|
└─── string : Hyperlink
|
└─── bool : IsStampBehindContent (defaults to false)
|
└─── HorizontalAlignment : HorizontalAlignment
│   │   Left
│   │   Center (default)
│   │   Right
│
└─── VerticalAlignment : VerticalAlignment
    │   Top
    │   Middle (default)
    │   Bottom
``` 

This structured set of properties ensures maximum flexibility and customization in how stamps appear on your documents, catering to a wide range of applications and design requirements.

Below is the paraphrased section of article utilizing the properties and structure of the `Stamper` abstract class.

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
│   │   Left
│   │   Center (default)
│   │   Right

└─── VerticalAlignment : VerticalAlignment
    │   Top
    │   Middle (default)
    │   Bottom
```

## Examples of Stamping Capabilities

In this section, we display the diverse functionality of each subclass of the `Stamper` class through detailed code examples.

Each type of stamper serves a different purpose and can be customized extensively to suit specific needs when applying stamps to a PDF. Here's how you can utilize each one effectively:

### Stamping Text on PDF Documents

Initiating and applying two distinct `TextStamper` instances with varied configurations:

```csharp
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<h1>Sample HTML for PDF!</h1>");

// Configure the first text stamper
TextStamper textStamper1 = new TextStamper
{
    Text = "First Stamp: Hello World!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 100,
    IsBold = true,
    IsItalic = true,
    VerticalAlignment = VerticalAlignment.Top
};

// Configure the second text stamper
TextStamper textStamper2 = new TextStamper()
{
    Text = "Second Stamp: Hello Again!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 30,
    VerticalAlignment = VerticalAlignment.Bottom
};

// Creating an array of stampers to be applied
Stamper[] stampers = { textStamper1, textStamper2 };

// Apply both stampers to the PDF
pdf.ApplyMultipleStamps(stampers);
pdf.ApplyStamp(textStamper2);
```

In this example, the flexibility of IronPDF's `TextStamper` is showcased by creating two stamps with different properties and applying them to a PDF document, demonstrating the ease of text stamping customization.

```csharp
// Set up the PDF rendering tool
var pdfRenderer = new ChromePdfRenderer();
// Render a simple HTML page into a PDF
var examplePdf = pdfRenderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");

// Initialize the first text stamper
TextStamper firstStamper = new TextStamper
{
    Text = "Hello World! First Stamp Here!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 100,
    IsBold = true,
    IsItalic = true,
    VerticalAlignment = VerticalAlignment.Top
};

// Initialize the second text stamper
TextStamper secondStamper = new TextStamper
{
    Text = "Hello World! Second Stamp Here!",
    FontFamily = "Bungee Spice",
    UseGoogleFont = true,
    FontSize = 30,
    VerticalAlignment = VerticalAlignment.Bottom
};

// Create an array of stampers
Stamper[] stampArray = { firstStamper, secondStamper };
// Apply multiple stamps to the PDF
examplePdf.ApplyMultipleStamps(stampArray);
// Apply a single stamp again
examplePdf.ApplyStamp(secondStamper);
```

### Stamping an Image onto a PDF

Incorporating an image stamp into an existing PDF document can be accomplished for different page arrangements:

```csharp
var pdf = new PdfDocument("/attachments/2022_Q1_sales.pdf");

ImageStamper logoImageStamper = new ImageStamper("/assets/logo.png");

// Option to apply the stamp across all pages, a single page, or selected pages
pdf.ApplyStamp(logoImageStamper);
pdf.ApplyStamp(logoImageStamper, 0);
pdf.ApplyStamp(logoImageStamper, new[] { 0, 3, 11 });
```

```csharp
var pdfDocument = new PdfDocument("https://ironpdf.com/attachments/2022_Q1_sales.pdf");

ImageStamper imageStamp = new ImageStamper("https://ironpdf.com/assets/logo.png");

// You can stamp on all pages, a single specific page, or selected pages of the PDF.
pdfDocument.ApplyStamp(imageStamp); // Apply stamp to all pages.
pdfDocument.ApplyStamp(imageStamp, 0); // Apply stamp only to the first page.
pdfDocument.ApplyStamp(imageStamp, new[] { 0, 3, 11 }); // Apply stamp to pages 1, 4, and 12.
```

### HTML Stamping on PDFs

Easily incorporate your custom HTML into a PDF as a stamp:

```csharp
var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<p>Welcome to our example!</p>");

HtmlStamper stamper = new HtmlStamper($"<p>Stamps made simple</p><div style='width:250pt;height:250pt;background-color:blue;'></div>")
{
    HorizontalOffset = new Length(-3, MeasurementUnit.Inch),
    VerticalAlignment = VerticalAlignment.Bottom
};

pdf.ApplyStamp(stamper);
```

Here is a paraphrased version of the given section:

```csharp
var pdfRenderer = new ChromePdfRenderer();
var document = pdfRenderer.RenderHtmlAsPdf("<p>Hello World, example HTML body.</p>");

HtmlStamper htmlStamper = new HtmlStamper($"<p>Example HTML Stamped</p><div style='width:250pt;height:250pt;background-color:red;'></div>")
{
    HorizontalOffset = new Length(-3, MeasurementUnit.Inch),  // Horizontal offset of -3 inches
    VerticalAlignment = VerticalAlignment.Bottom  // The vertical alignment at the bottom
};

// Apply the created HTML stamper to the PDF
document.ApplyStamp(htmlStamper);
```

### Embedding a Barcode into a PDF Document

Here's a practical example to demonstrate how a barcode can be incorporated into a PDF:

```csharp
// Initialize a new Barcode Stamper
BarcodeStamper barcodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);

// Alignment settings for the barcode
barcodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
barcodeStamper.VerticalAlignment = VerticalAlignment.Bottom;

// Load an existing PDF document
var document = new PdfDocument("example.pdf");

// Apply the barcode stamp to the document
document.ApplyStamp(barcodeStamper);
```

```csharp
// Initialize a Barcode Stamper with "IronPDF" label and Code39 encoding
BarcodeStamper barcodeStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);

// Set the position of the barcode on the PDF to the bottom left
barcodeStamp.HorizontalAlignment = HorizontalAlignment.Left;
barcodeStamp.VerticalAlignment = VerticalAlignment.Bottom;

// Load a PDF document to stamp the barcode onto
PdfDocument document = new PdfDocument("example.pdf");

// Apply the barcode stamp to the loaded PDF document
document.ApplyStamp(barcodeStamp);
```

### Stamping a QR Code on a PDF Document

Here’s a tutorial on embedding a QR Code into a PDF:

```csharp
// Create a barcode stamper instance for QR codes
BarcodeStamper qrCodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);

// Set dimensions of the QR code
qrCodeStamper.Height = 50; // in pixels
qrCodeStamper.Width = 50;  // in pixels

// Align the QR code on the page
qrCodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
qrCodeStamper.VerticalAlignment = VerticalAlignment.Bottom;

// Load a PDF document where the QR code will be stamped
var document = new PdfDocument("example.pdf");

// Apply the QR code stamper to the PDF
document.ApplyStamp(qrCodeStamper);
```

Here's the paraphrased section of the article, with resolved relative URL paths:

-----
```csharp
// Initialize a QR Code barcode stamper with specific settings
BarcodeStamper qrCodeStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);

// Set the dimensions of the QR Code stamp
qrCodeStamp.Height = 50; // Height in pixels
qrCodeStamp.Width = 50; // Width in pixels

// Configure the alignment of the QR Code stamp within the PDF
qrCodeStamp.HorizontalAlignment = HorizontalAlignment.Left;
qrCodeStamp.VerticalAlignment = VerticalAlignment.Bottom;

// Load an existing PDF document to stamp
var document = new PdfDocument("example.pdf");

// Apply the QR Code stamp to the loaded PDF document
document.ApplyStamp(qrCodeStamp);
```

### Applying Watermarks to PDFs

Adding watermarks across all pages of a PDF is straightforward with the `ApplyWatermark` method provided by IronPDF. Watermarks are commonly used to overlay custom text or images on each page of a document, helping in branding or securing sensitive information.

Here is the paraphrased section with resolved URLs:

```csharp
// Initialize a new PdfDocument object with a file from a specified path
var pdfDocument = new PdfDocument("https://ironpdf.com/attachments/design.pdf");

// Define the HTML content to be used as a watermark
string watermarkHtml = "<h1>Example Title</h1>";

// Set the rotation of the watermark to zero degrees
int watermarkRotation = 0;

// Set the opacity of the watermark to 30%
int opacityOfWatermark = 30;

// Apply the watermark with specified HTML, rotation, and opacity
pdfDocument.ApplyWatermark(watermarkHtml, watermarkRotation, opacityOfWatermark);
```

For a detailed demonstration of watermarking using IronPDF, check out our [Code Examples page](https://ironpdf.com/examples/pdf-watermarking/).

### Utilizing the ApplyStamp Method in PDFs

The `ApplyStamp` method in IronPDF offers multiple overloads, allowing for versatile applications of your customized `Stamper` to a PDF document.

```csharp
// Load an existing PDF document from specified path
var pdfDocument = new PdfDocument("https://ironpdf.com/assets/example.pdf");

// Stamp the entire document with one stamper
pdfDocument.ApplyStamp(singleStamper);

// Stamp only the first page of the document
pdfDocument.ApplyStamp(singleStamper, 0);

// Stamp multiple specific pages, in this case pages 1, 4, and 6
pdfDocument.ApplyStamp(singleStamper, new[] { 0, 3, 5 });

// Apply multiple stampers to the entire document
pdfDocument.ApplyMultipleStamps(multipleStampers);

// Apply multiple stampers to just the first page
pdfDocument.ApplyMultipleStamps(multipleStampers, 0);

// Apply multiple stampers to specific pages
pdfDocument.ApplyMultipleStamps(multipleStampers, new[] { 0, 3, 5 });

// Asynchronous versions for applying stamps
await pdfDocument.ApplyStampAsync(singleStamper, 4);
await pdfDocument.ApplyMultipleStampsAsync(multipleStampers);

// Method for applying a watermark with specific properties
string watermarkHtml = "<h1> Example Title <h1/>";
int watermarkRotation = 0;
int watermarkOpacityLevel = 30;
pdfDocument.ApplyWatermark(watermarkHtml, watermarkRotation, watermarkOpacityLevel);
```

#### The `Length` Class

The `Length` class is characterized by two main properties: `Unit` and `Value`. First, choose a `Unit` from the `MeasurementUnit` enumeration, where `Percentage` of the page is the standard setting. Next, specify the `Value`, which determines the extent of the length relative to the chosen unit.

## Overview of Length Class Attributes

The `Length` class in IronPDF provides precise control over measurements, especially useful in design contexts such as setting stamps or configuring layouts. Below is a detailed breakdown of the properties within this class:

```txt
class Length
|
└─── double: Value (default : 0)
|
└─── MeasurementUnit: Unit
         |   Inch
         |   Millimeter
         |   Centimeter
         |   Percentage (default)
         |   Pixel
         |   Points
```

This class allows users to specify the measurement in various units such as inches, pixels, or percentages, which enhances flexibility in different types of PDF designs and layouts.
```

```txt
class Length
|
└─── double : Value (initial : 0)
|
└─── MeasurementUnit : Unit
     |   Inch
     |   Millimeter
     |   Centimeter
     |   Percentage (initial)
     |   Pixel
     |   Points
```

### Examples of Using `Length`

#### Defining Specific Lengths

Here are various ways to instantiate the `Length` class in different units:

```csharp
// Specify a length in inches
new Length(value: 5, unit: MeasurementUnit.Inch); // Results in a length of 5 inches

// Define a length in pixels
new Length(value: 25, unit: MeasurementUnit.Pixel); // Creates a length of 25 pixels

// Create a default Length
new Length(); // Defaults to 0% of the page dimension, as value is zero and unit is percentage

// Set a percentage-based length
new Length(value: 20); // Establishes a length of 20% relative to the page dimension
```

#### Incorporating Length in Parameters

You can also utilize the `Length` class as a parameter in various other classes:

```csharp
HtmlStamper companyLogoStamper = new HtmlStamper
{
    VerticalOffset = new Length(15, MeasurementUnit.Percentage), // Sets vertical offset as a percentage
    HorizontalOffset = new Length(1, MeasurementUnit.Inch) // Sets horizontal offset in inches
    // Additional properties can be set here...
};
```

#### Defining a Length

```csharp
// Create a new Length instance representing 5 inches
new Length(value: 5, unit: MeasurementUnit.Inch);

// Define a Length of 25 pixels
new Length(value: 25, unit: MeasurementUnit.Pixel);

// Establish a default Length as 0% of the page dimension by leaving the value and unit at their defaults
new Length();

// Specify a Length as 20% of the page dimension
new Length(value: 20);
```

#### Utilizing Length in Parameters

```csharp
// Configuring an HtmlStamper with vertical and horizontal offsets using Length
HtmlStamper logoStamper = new HtmlStamper
{
    VerticalOffset = new Length(15, MeasurementUnit.Percentage),
    HorizontalOffset = new Length(1, MeasurementUnit.Inch)
    // Configure additional properties as needed...
};
```

In the above examples, we initiate `Length` classes for various measurement units like inches and pixels, demonstrating their adaptability across different dimensional specifications within PDF documents. These `Length` instances facilitate precise positioning and dimensioning when used as properties in other PDF manipulation tools such as stampers.

```csharp
new Length(value: 5, unit: MeasurementUnit.Inch); // Specifies a length of 5 inches.

new Length(value: 25, unit: MeasurementUnit.Pixel); // Defines a length of 25 pixels.

new Length(); // Sets the length to 0% of the page size as the default value is zero and the default unit is percentage.

new Length(value: 20); // Indicates a length equivalent to 20% of the page dimension.
```

#### Utilizing Length as a Parameter

The `Length` class in IronPDF allows you to define specific measurements that are crucial when setting the dimensions and positions of elements like stamps in a PDF. Each length instance can be defined with a value and a measurement unit, which can range from inches to percentages.

Here's how you can apply the `Length` class effectively:

```csharp
HtmlStamper logoStamper = new HtmlStamper
{
    VerticalOffset = new Length(15, MeasurementUnit.Percentage),
    HorizontalOffset = new Length(1, MeasurementUnit.Inch)
    // Additional properties can be set here...
};
```

In this example, the vertical offset is set to 15% of the total page height, while the horizontal offset is set at 1 inch from the side. This gives precise control over where elements like logos are placed on the PDF page.

```csharp
// Initialize an HtmlStamper for positioning logos in a PDF
HtmlStamper logoStamper = new HtmlStamper
{
    VerticalOffset = new Length(15, MeasurementUnit.Percentage), // Set vertical offset to 15% of the page height
    HorizontalOffset = new Length(1, MeasurementUnit.Inch) // Set the horizontal offset to 1 inch
    // Additional properties can be configured here as needed...
};
```

## PDF Form Management

IronPDF provides comprehensive tools for interacting with forms within PDF documents. This section will guide you through the processes of creating, editing, and filling out forms using IronPDF's robust capabilities.

## Table of Contents

- [Create and Configure Forms](#anchor-create-and-edit-forms)
- [Populate Existing Forms with Data](#anchor-fill-existing-forms)

## Create and Configure Forms

IronPDF enables you to embed form fields into a PDF from HTML code:

```csharp
// Step 1: Generate a PDF with editable forms from HTML.
string formHtml = @"
    <html>
        <body>
            <h2>Edit Form</h2>
            <form>
              First name: <br> <input type='text' name='firstname' value=''> <br>
              Last name: <br> <input type='text' name='lastname' value=''>
            </form>
        </body>
    </html>";

// Create a renderer instance
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
renderer.RenderHtmlAsPdf(formHtml).SaveAs("CustomForm.pdf");

// Step 2: Access and modify PDF form fields.
var editForm = PdfDocument.FromFile("CustomForm.pdf");

// Access the field for the first name
var fieldFirstName = editForm.Form.FindFormField("firstname");

// Access the field for the last name
var fieldLastName = editForm.Form.FindFormField("lastname");
```

For an extended example on creating and configuring PDF forms, check out [this detailed guide](https://ironpdf.com/examples/form-data/).

## Populate Existing Forms with Data

With IronPDF, you can also manipulate existing forms within a PDF to update or fill them:

```csharp
var exampleForm = PdfDocument.FromFile("CustomForm.pdf");

// Set and retrieve the value of the "firstname" field
var fieldFirstName = exampleForm.Form.FindFormField("firstname");
fieldFirstName.Value = "Mickey";
Console.WriteLine("FirstNameField value: {0}", fieldFirstName.Value);

// Set and retrieve the value of the "lastname" field
var fieldLastName = exampleForm.Form.FindFormField("lastname");
fieldLastName.Value = "Mouse";
Console.WriteLine("LastNameField value: {0}", fieldLastName.Value);

exampleForm.SaveAs("UpdatedForm.pdf");
```

To see more about filling existing PDF forms, visit [this tutorial](https://ironpdf.com/examples/form-data/).

## Summary

IronPDF streamlines the process of creating and managing forms within PDF documents, making it simple to generate, edit, and fill forms directly within your software applications. Whether starting from scratch or modifying an existing document, IronPDF provides the tools needed for effective PDF form management.

For further information or to make a feature request, reach out to our [support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are eager to assist you with your PDF editing needs.

### Create and Edit Forms

IronPDF enables you to design PDFs that integrate customizable form fields directly:

```csharp
// Step 1. Construct a PDF that includes editable form elements using HTML form and input tags
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

// Initialize a Renderer
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
renderer.RenderHtmlAsPdf(formHtml).SaveAs("InteractiveForm.pdf");

// Step 2. Manipulate PDF form data.
var formDocument = PdfDocument.FromFile("InteractiveForm.pdf");

// Access the "firstname" field
var firstNameField = formDocument.Form.FindFormField("firstname");

// Access the "lastname" field
var lastNameField = formDocument.Form.FindFormField("lastname");
```

Explore more about creating and managing PDF forms on our [Code Examples page](https://ironpdf.com/examples/form-data/).

Below is the paraphrased section of the article:

```csharp
// Step 1: Generate a PDF with interactive forms using HTML form and input elements
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

// Initialize the PDF renderer
var renderer = new ChromePdfRenderer();
renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
renderer.RenderHtmlAsPdf(formHtml).SaveAs("BasicForm.pdf");

// Step 2: Access and manipulate values within PDF forms
var formDocument = PdfDocument.FromFile("BasicForm.pdf");

// Retrieve the value from the "firstname" input field
var firstNameField = formDocument.Form.FindFormField("firstname");

// Access the value from the "lastname" input field
var lastNameField = formDocument.Form.FindFormField("lastname");
```

For a detailed illustration of PDF Form handling with IronPDF, be sure to explore our code examples on [this page](https://ironpdf.com/examples/form-data/).

### Filling Out Pre-existing Forms

IronPDF enables seamless access and modification of all present form fields within a PDF document, allowing for straightforward updates and resaving:

Here's the paraphrased section:

```csharp
var loadedPdfForm = PdfDocument.FromFile("BasicForm.pdf");

// Assign and retrieve the 'firstname' field value
var fieldFirstName = loadedPdfForm.Form.FindFormField("firstname");
fieldFirstName.Value = "Minnie";
Console.WriteLine("Value of First Name Field: {0}", fieldFirstName.Value);

// Assign and retrieve the 'lastname' field value
var fieldLastName = loadedPdfForm.Form.FindFormField("lastname");
fieldLastName.Value = "Mouse";
Console.WriteLine("Value of Last Name Field: {0}", fieldLastName.Value);

// Save the changes to a new PDF file
loadedPdfForm.SaveAs("FilledForm.pdf");
``` 

In this revision, variable names and comments are altered for clarity and variety while ensuring the functional steps remain accurate and effective.

For a detailed demonstration of the PDF Form example, please explore our [Code Examples page](https://ironpdf.com/examples/form-data/).

## Conclusion

The above examples clearly illustrate that IronPDF is equipped with essential functionalities that are ready to use for PDF editing tasks.

Should you wish to suggest a new feature or have any inquiries regarding IronPDF or its licensing terms, feel free to [reach out to our support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are always here to help.

