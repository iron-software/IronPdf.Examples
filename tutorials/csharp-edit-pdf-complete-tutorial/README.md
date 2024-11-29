# Editing PDFs using C&num;

***Based on <https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/>***


## Overview

Iron Software equips developers with the IronPDF library, which streamlines numerous PDF modifications through user-friendly methods. Whether it’s adding signatures, incorporating HTML footers, embedding watermarks, or inserting annotations, IronPDF ensures your code remains clean, the PDF creation process is straightforward, deployment is hassle-free, and debugging is a breeze across all supported platforms and environments.

IronPDF offers an extensive array of functionalities for PDF editing. This guide delves into some significant features, providing code snippets and discussions to enhance your understanding of PDF editing in C&num; using IronPDF.

By the end of this guide, you'll be well-equipped to use IronPDF for editing PDFs in C&num;.

## Table of Contents

- **Document Structure Modifications**
  - [Add, Copy, and Remove Pages](#anchor-manipulate-pages)
  - [Combine and Divide PDFs](#anchor-merge-and-split-pdfs)
- **Property Modifications of Documents**
  - [Modify and Utilize PDF Metadata](#anchor-add-and-use-pdf-metadata)
  - [Digital Signatures](#anchor-digital-signatures)
  - [PDF File Attachments](#anchor-pdf-attachments)
  - [PDF Compression](#anchor-compress-pdfs)
- **Content Editing in PDFs**
  - [Insert Headers and Footers](#anchor-add-headers-and-footers)
  - [Search and Modify Text within a PDF](#anchor-find-and-replace-text-in-a-pdf)
  - [Add Bookmarks and Outlines](#anchor-outlines-and-bookmarks)
  - [Insert and Modify Annotations](#anchor-add-and-edit-annotations)
  - [Include Backgrounds and Foregrounds](#anchor-add-backgrounds-and-foregrounds)
- **Applying Stamps and Watermarks**
  - [Overview of Stampers](#anchor-stamper-abstract-class)
    - [Stamper Class Attributes](#anchor-stamper-class-properties)
  - [Stamper Demonstrations](#anchor-stamping-examples)
    - [Text Stamping on a PDF](#anchor-stamp-text-onto-a-pdf)
    - [Image Stamping on a PDF](#anchor-stamp-an-image-onto-a-pdf)
    - [HTML Stamping on a PDF](#anchor-stamp-html-onto-a-pdf)
    - [Barcode Stamping on a PDF](#anchor-stamp-a-barcode-onto-a-pdf)
    - [QR Code Stamping on a PDF](#anchor-stamp-a-qr-code-onto-a-pdf)
    - [Watermark Addition on a PDF](#anchor-add-a-watermark-to-a-pdf)
  - [Stamp Application on PDFs](#anchor-apply-stamp-onto-a-pdf)
  - [Overview of Length Class](#anchor-length-class)
    - [Properties of the Length Class](#anchor-length-class-properties)
    - [Examples of Using Length](#anchor-length-examples)
- **Form Usage in PDFs**
  - [Creating and Editing Forms](#anchor-create-and-edit-forms)
  - [Populating Existing Forms](#anchor-fill-existing-forms)

For additional details on how to merge multiple PDFs into one, please visit [here](https://ironpdf.com/examples/merge-pdfs/).

For insights on how to split and extract pages from a PDF, check [here](https://ironpdf.com/examples/split-pdf-pages-csharp/).

## Introduction

Iron Software has streamlined a variety of PDF editing capabilities into user-friendly methods available in the IronPDF library. Whether you're integrating signatures, appending HTML footers, embedding watermarks, or inserting annotations, IronPDF equips you with the tools to ensure your code is understandable, the PDF generation is programmatically controlled, and the library can be effortlessly debugged and deployed across any supported platform or environment.

IronPDF boasts an extensive array of functionalities for PDF modification. This instructional guide will delve into several primary features, supplemented by code samples and detailed discussions.

By the end of this tutorial, you will possess a comprehensive understanding of how to leverage IronPDF for editing PDFs using C#.

## Table of Contents

- **Modification of Document Structure**
  - [Insert, Duplicate, and Remove Pages](#anchor-manipulate-pages)
  - [Combine and Divide PDF Documents](#anchor-merge-and-split-pdfs)

- **Adjusting Document Settings**
  - [Incorporate and Manipulate PDF Metadata](#anchor-add-and-use-pdf-metadata)
  - [Secure with Digital Signatures](#anchor-digital-signatures)
  - [Manage PDF Attachments](#anchor-pdf-attachments)
  - [Reduce PDF File Size](#anchor-compress-pdfs)

- **Enhancing PDF Content**
  - [Insert Headers and Footers](#anchor-add-headers-and-footers)
  - [Search and Replace Text within a PDF](#anchor-find-and-replace-text-in-a-pdf)
  - [Insert and Manage Bookmarks](#anchor-outlines-and-bookmarks)
  - [Insert and Modify Annotations](#anchor-add-and-edit-annotations)
  - [Incorporate Backgrounds and Overlays](#anchor-add-backgrounds-and-foregrounds)

- **Application of Stamps and Watermarks**
  - [Overview of Stamper Tool](#anchor-stamper-abstract-class)
    - [Attributes of Stamper Tool](#anchor-stamper-class-properties)
  - [Implementing Stamps: Examples](#anchor-stamping-examples)
    - [Text Stamping](#anchor-stamp-text-onto-a-pdf)
    - [Image Stamping](#anchor-stamp-an-image-onto-a-pdf)
    - [HTML Stamping](#anchor-stamp-html-onto-a-pdf)
    - [Barcode Stamping](#anchor-stamp-a-barcode-onto-a-pdf)
    - [QR Code Stamping](#anchor-stamp-a-qr-code-onto-a-pdf)
    - [Watermark Application](#anchor-add-a-watermark-to-a-pdf)
  - [Executing Stamps on a PDF](#anchor-apply-stamp-onto-a-pdf)
  - [Introduction to the Length Class](#anchor-length-class)
    - [Details on Length Class](#anchor-length-class-properties)
    - [Example of Length Utilization](#anchor-length-examples)

- **Working with Forms in PDFs**
  - [Develop and Modify Forms](#anchor-create-and-edit-forms)
  - [Populate Existing Forms](#anchor-fill-existing-forms)
```

## Document Structure Management

Iron Software streamlines various functions for managing the structure of PDF documents using the IronPDF library. Whether it involves inserting new pages, duplicating existing ones, or removing them from the document, IronPDF manages these processes behind the scenes efficiently.

### Page Manipulation

#### Adding Pages

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section1
    {
        public void Run()
        {
            var pdf = new PdfDocument("report.pdf");
            var renderer = new ChromePdfRenderer();
            var coverPagePdf = renderer.RenderHtmlAsPdf("<h1>Welcome Page</h1><hr>");
            pdf.PrependPdf(coverPagePdf);
            pdf.SaveAs("updated_report.pdf");
        }
    }
}
```

#### Duplicating Pages

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section2
    {
        public void Run()
        {
            var pdf = new PdfDocument("report.pdf");
            // Duplicate pages 5 to 7 to a new document.
            pdf.CopyPages(4, 6).SaveAs("extracted_pages.pdf");
        }
    }
}
```

#### Removing Pages

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section3
    {
        public void Run()
        {
            var pdf = new PdfDocument("report.pdf");
            
            // Delete the last page of the PDF and save the modified document
            pdf.RemovePage(pdf.PageCount - 1);
            pdf.SaveAs("trimmed_report.pdf");
        }
    }
}
```

### Combining and Dividing PDFs

Combining multiple PDF documents into a single PDF or separating pages from a PDF into new documents is effortlessly done using IronPDF's intuitive API.

#### Combine Multiple PDFs into One

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section4
    {
        public void Run()
        {
            var pdfs = new List<PdfDocument>
            {
                PdfDocument.FromFile("A.pdf"),
                PdfDocument.FromFile("B.pdf"),
                PdfDocument.FromFile("C.pdf")
            };
            
            PdfDocument combinedPdf = PdfDocument.Merge(pdfs);
            combinedPdf.SaveAs("combined_document.pdf");
            
            foreach (var pdf in pdfs)
            {
                pdf.Dispose();
            }
        }
    }
}
```

For further information on how to combine PDFs using our API, please visit [this link](https://ironpdf.com/examples/merge-pdfs/).

#### Extract Pages from a PDF

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section5
    {
        public void Run()
        {
            var pdf = new PdfDocument("sample.pdf");
            
            // Extract the first page
            var first_page = pdf.CopyPage(0);
            first_page.SaveAs("Page1.pdf");
            
            // Extract pages 2 & 3
            var pages_2_and_3 = pdf.CopyPages(1, 2);
            pages_2_and_3.SaveAs("Pages2-3.pdf");
        }
    }
}
```

For more detailed examples of how to split and extract pages, please refer to [this page](https://ironpdf.com/examples/split-pdf-pages-csharp/).

### Manipulate Pages

Working with IronPDF makes inserting, copying, and removing pages from PDFs remarkably straightforward. Whether you're adding pages at particular indexes, extracting specific ranges, or deleting individual pages, IronPDF efficiently handles all these tasks for you seamlessly.

### Adding Pages to a PDF

IronPDF simplifies the process of inserting pages into your PDF documents. This robust tool handles the underlying complexity, providing a straightforward method for page manipulation.

#### Adding New Pages

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class AddPages
    {
        public void Execute()
        {
            // Create a new PDF document instance from an existing file
            var pdfDoc = new PdfDocument("report.pdf");
            // Create a renderer for HTML content
            var pdfRenderer = new ChromePdfRenderer();
            // Render a PDF from HTML content for the cover page
            var coverPage = pdfRenderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>");
            // Insert the cover page at the beginning of the PDF document
            pdfDoc.PrependPdf(coverPage);
            // Save the new PDF with the inserted page
            pdfDoc.SaveAs("updated_report_with_cover.pdf");
        }
    }
}
```

This snippet demonstrates how to prepend a cover page to an existing PDF. It begins by rendering HTML content for the new page and then seamlessly integrates this into the existing PDF document structure.

Here's the paraphrased section of the article, with code comments added for clarity and improved understanding:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section1
    {
        public void Run()
        {
            // Create a new PDF document from an existing file
            var pdf = new PdfDocument("report.pdf");

            // Initialize the PDF renderer
            var renderer = new ChromePdfRenderer();

            // Generate a PDF from HTML content which serves as the cover page
            var coverPagePdf = renderer.RenderHtmlAsPdf("<h1>Cover Page</h1><hr>");

            // Insert the cover page at the beginning of the PDF document
            pdf.PrependPdf(coverPagePdf);

            // Save the modified PDF to a new file
            pdf.SaveAs("report_with_cover.pdf");
        }
    }
}
```

#### Duplicating Pages

Utilizing IronPDF, you can seamlessly copy selected pages from a PDF and generate a new document from those pages. Below you'll find a straightforward example demonstrating this capability:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section2
    {
        public void Run()
        {
            var pdf = new PdfDocument("report.pdf");

            // Duplicating specific pages (5 to 7) into a new PDF file.
            pdf.CopyPages(4, 6).SaveAs("report_highlight.pdf");
        }
    }
}
```

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section2
    {
        public void Run()
        {
            // Initialize a new PdfDocument object from a file
            var pdfDocument = new PdfDocument("report.pdf");
            // Extract pages 5 to 7 and create a new highlighted report PDF document
            pdfDocument.CopyPages(4, 6).SaveAs("report_highlight.pdf");
        }
    }
}
```

#### Removing Pages from a PDF

Easily delete pages from any PDF document using IronPDF's straightforward approach that manages everything in the background.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section3
    {
        public void Run()
        {
            var pdf = new PdfDocument("report.pdf");
            
            // Delete the last page of the PDF and then save the changes.
            pdf.RemovePage(pdf.PageCount - 1);
            pdf.SaveAs("report_with_last_page_removed.pdf");
        }
    }
}
```

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section3
    {
        public void Run()
        {
            var pdfDocument = new PdfDocument("report.pdf");

            // Delete the final page from the document then save it
            pdfDocument.RemovePage(pdfDocument.PageCount - 1);
            pdfDocument.SaveAs("report_with_last_page_removed.pdf");
        }
    }
}
```

### Combining and Separating PDFs

Using IronPDF’s straightforward API, you can effortlessly combine multiple PDF files into a single document or divide a single PDF into several distinct files.

#### Combining Multiple PDFs into One

Merging several PDF files into a single document is straightforward using the IronPDF library, thanks to its user-friendly API.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section4
    {
        public void Run()
        {
            var pdfCollection = new List<PdfDocument>
            {
                PdfDocument.FromFile("A.pdf"),
                PdfDocument.FromFile("B.pdf"),
                PdfDocument.FromFile("C.pdf")
            };
            
            PdfDocument combinedPdf = PdfDocument.Merge(pdfCollection);
            combinedPdf.SaveAs("combined_document.pdf");
            
            foreach (var pdf in pdfCollection)
            {
                pdf.Dispose();
            }
        }
    }
}
```

For more examples on merging documents, please visit [IronPDF Merging PDFs Example](https://ironpdf.com/examples/merge-pdfs/).

Here's a paraphrased version of the specified section of your article:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section4
    {
        public void Run()
        {
            // Initialize a list of PdfDocument objects from files
            var pdfDocuments = new List<PdfDocument>
            {
                PdfDocument.FromFile("A.pdf"),
                PdfDocument.FromFile("B.pdf"),
                PdfDocument.FromFile("C.pdf")
            };

            // Merge all PDF documents into a single PdfDocument
            PdfDocument combinedPdf = PdfDocument.Merge(pdfDocuments);
            combinedPdf.SaveAs("merged.pdf");

            // Dispose all individual PdfDocuments to free resources
            foreach (var pdf in pdfDocuments)
            {
                pdf.Dispose();
            }
        }
    }
}
``` 

This version rephrases your code comments to enhance clarity and changes variable names to make the code slightly distinct but logically equivalent to your original sample.

For a comprehensive guide on merging multiple PDFs using our code examples, please visit [this link](https://ironpdf.com/examples/merge-pdfs/).

#### Dividing a PDF into Separate Pages

IronPDF makes it simple to split a PDF into individual pages using its intuitive methods. Here's how you can accomplish that:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section5
    {
        public void Run()
        {
            var pdf = new PdfDocument("sample.pdf");
            
            // Extract the first page
            var firstPage = pdf.CopyPage(0);
            firstPage.SaveAs("Split1.pdf");
            
            // Extract pages 2 and 3
            var pagesTwoThree = pdf.CopyPages(1, 2);
            pagesTwoThree.SaveAs("Split2.pdf");
        }
    }
}
```

To explore more about how to split and extract pages from a PDF document using C#, you can check out detailed examples and tutorials [here](https://ironpdf.com/examples/split-pdf-pages-csharp/).

```csharp
using IronPdf;

namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section5
    {
        public void Run()
        {
            // Load a sample PDF document
            var pdf = new PdfDocument("sample.pdf");

            // Extract and save the first page as a new PDF file
            var firstPage = pdf.CopyPage(0);
            firstPage.SaveAs("Split1.pdf");

            // Extract and save the second and third pages as another new PDF file
            var pagesTwoThree = pdf.CopyPages(1, 2);
            pagesTwoThree.SaveAs("Spli2t.pdf");
        }
    }
}
```

For further information on how to split and extract pages from a PDF using our code examples, please check out our detailed tutorial [here](https://ironpdf.com/examples/split-pdf-pages-csharp/).

## Modifying Document Properties

IronPDF provides an intuitive set of tools for adjusting the properties of your PDF documents. This section outlines various operations you can perform, from editing metadata to compressing files, along with some practical code snippets.

### Adjusting PDF Metadata

Utilizing IronPDF, modifying the metadata of a PDF is straightforward and efficient:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class MetadataSection
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("encrypted.pdf", "password");
            
            // Update metadata attributes
            pdf.MetaData.Author = "Jane Doe";
            pdf.MetaData.Keywords = "Blockchain, Cryptocurrency";
            pdf.MetaData.ModifiedDate = System.DateTime.Now;
            
            // Configure security settings of the PDF
            pdf.SecuritySettings.RemovePasswordsAndEncryption();
            pdf.SecuritySettings.MakePdfDocumentReadOnly("new-secret");
            pdf.SecuritySettings.AllowUserAnnotations = false;
            pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            pdf.SecuritySettings.AllowUserFormData = false;
            pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;
            
            // Set new encryption passwords
            pdf.SecuritySettings.OwnerPassword = "masterkey";
            pdf.SecuritySettings.UserPassword = "userkey";
            pdf.SaveAs("updated_encrypted.pdf");
        }
    }
}
```

### Implementing Digital Signatures

Enhance the security of your PDF files by applying digital signatures. IronPDF supports both .pfx and .p12 digital certificates for authenticating the integrity of your documents.

```csharp
using IronPdf;
using IronPdf.Signing;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class SignatureSection
    {
        public void Run()
        {
            var pdf = new PdfDocument("document.pdf");
            var digitalSignature = new PdfSignature("Iron.p12", "password")
            {
                SigningContact = "contact@example.com",
                SigningLocation = "San Francisco, USA",
                SigningReason = "Contract Agreement"
            };
            pdf.Sign(digitalSignature);
            pdf.SaveAs("signed_contract.pdf");
        }
    }
}
```

### Handling PDF Attachments

IronPDF facilitates the addition and removal of attachments from your PDFs with ease:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class AttachmentSection
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var document = renderer.RenderHtmlAsPdf("<html>Attachment Example</html>");
            var attachment = document.Attachments.AddAttachment("extra_info.txt", new byte[]{});
            
            // Removing an existing attachment
            document.Attachments.RemoveAttachment(attachment);
            document.SaveAs("document_with_attachment.pdf");
        }
    }
}
```

### Compressing PDF Documents

Reduce the file size of your PDF documents using IronPDF's `CompressImages` method, which allows you to adjust the quality of embedded images for optimal size reduction:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class CompressionSection
    {
        public void Run()
        {
            var document = new PdfDocument("large_file.pdf");
            
            // Compress images at 80% quality
            document.CompressImages(80);
            document.SaveAs("compressed_file.pdf");
        }
    }
}
```

For further in-depth examples and additional features, visit our Code Examples page [here](https://ironpdf.com/examples/merge-pdfs/).

### Managing PDF Metadata with IronPDF

Utilizing IronPDF simplifies the process of accessing and modifying PDF metadata effectively:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section6
    {
        public void Run()
        {
            // Load a protected PDF file or create a new PDF from an HTML source
            var pdf = PdfDocument.FromFile("encrypted.pdf", "password");
            
            // Modify the document's metadata properties
            pdf.MetaData.Author = "Satoshi Nakamoto";
            pdf.MetaData.Keywords = "SEO, Friendly";
            pdf.MetaData.ModifiedDate = System.DateTime.Now;
            
            // Adjust PDF security settings, disabling certain features
            pdf.SecuritySettings.RemovePasswordsAndEncryption();
            pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
            pdf.SecuritySettings.AllowUserAnnotations = false;
            pdf.SecuritySettings.AllowUserCopyPasteContent = false;
            pdf.SecuritySettings.AllowUserFormData = false;
            pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;
            
            // Update the document password settings
            pdf.SecuritySettings.OwnerPassword = "top-secret"; // Editing password
            pdf.SecuritySettings.UserPassword = "shareable";  // Opening password
            pdf.SaveAs("secured.pdf");
        }
    }
}
```

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class MetadataSecurityExample
    {
        public void Execute()
        {
            // Load an encrypted file or alternatively, create a new PDF from HTML content
            var pdfDocument = PdfDocument.FromFile("encrypted.pdf", "password");

            // Update PDF metadata
            pdfDocument.MetaData.Author = "Satoshi Nakamoto";
            pdfDocument.MetaData.Keywords = "SEO, Friendly";
            pdfDocument.MetaData.ModifiedDate = System.DateTime.Now;

            // Update PDF security settings to restrict certain actions
            pdfDocument.SecuritySettings.RemovePasswordsAndEncryption();
            pdfDocument.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
            pdfDocument.SecuritySettings.AllowUserAnnotations = false;
            pdfDocument.SecuritySettings.AllowUserCopyPasteContent = false;
            pdfDocument.SecuritySettings.AllowUserFormData = false;
            pdfDocument.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

            // Set new passwords for editing and opening the PDF document
            pdfDocument.SecuritySettings.OwnerPassword = "top-secret"; // Password required to edit the PDF
            pdfDocument.SecuritySettings.UserPassword = "shareable"; // Password required to view the PDF

            // Save the changes to a new secured PDF file
            pdfDocument.SaveAs("secured.pdf");
        }
    }
}
```

### Digital Signatures

IronPDF provides tools to digitally sign both new and existing PDF documents using .pfx and .p12 X509Certificate2 certificates. This digital signature ensures that once a PDF is signed, any modifications would require validation through the certificate, preserving the document's integrity.

For instructions on generating a signing certificate at no cost using Adobe Reader, please refer to [Adobe Reader's guide](https://helpx.adobe.com/acrobat/using/digital-ids.html).

Besides cryptographic signing, IronPDF also supports the inclusion of handwritten signatures or company stamp images for signing documents.

Achieve cryptographic signing of PDF documents with a single line of code using IronPDF.

```csharp
using IronPdf;
using IronPdf.Signing;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section7
    {
        public void Run()
        {
            // Sign an arbitrary PDF file using a specified .p12 file and password.
            var signature = new PdfSignature("Iron.p12", "123456");
            signature.SignPdfFile("any.pdf");
        }
    }
}
```

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section8
    {
        public void Run()
        {
            // Create a new PDF from HTML content
            var renderer = new ChromePdfRenderer();
            var doc = renderer.RenderHtmlAsPdf("<h1>Exploring Advanced Digital Security Features</h1>");
            
            // Initialize the digital signature with a .pfx or .p12 certificate
            var signature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
            {
                // Add details relevant to the digital signing process
                SigningContact = "help@ironsoftware.com",
                SigningLocation = "NYC, USA",
                SigningReason = "Demonstrating Advanced PDF Signature Features"
            };
            
            // Digitally sign the PDF document using the specified certificate
            doc.Sign(signature);
            
            // The document remains unsaved until explicitly saved to a storage medium
            doc.SaveAs("advanced_signed.pdf");
        }
    }
}
```
This refined example offers increased control over the digital signing process using a certificate, allowing you to specify the contact, location, and reason for the signature. Also, remember to store or share the `advanced_signed.pdf` as it's not committed until `SaveAs()` is invoked.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class EnhancedSignatureProcess
    {
        public void Execute()
        {
            // Step 1. Generate a PDF document
            var pdfRenderer = new ChromePdfRenderer();
            var createdPdf = pdfRenderer.RenderHtmlAsPdf("<h1>Testing 2048 bit digital security</h1>");

            // Step 2. Crafting a Digital Signature
            // For certificate creation, utilize Adobe Acrobat Reader.
            // Detailed Instructions: https://helpx.adobe.com/acrobat/using/digital-ids.html
            var digitalSignature = new IronPdf.Signing.PdfSignature("Iron.pfx", "123456")
            {
                // Step 3. Define additional signature properties
                SigningContact = "support@ironsoftware.com",
                SigningLocation = "Chicago, USA",
                SigningReason = "Demonstrating PDF signing"
            };

            // Step 4. Apply the signature to the PDF
            createdPdf.Sign(digitalSignature);

            // Step 5. Persist the signed PDF to storage
            createdPdf.SaveAs("signed.pdf");
        }
    }
}
```

### Managing PDF Attachments

IronPDF offers comprehensive capabilities for both attaching and detaching files within your PDF documents.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section9
    {
        public void Run()
        {
            var pdfRenderer = new ChromePdfRenderer();
            var documentPdf = pdfRenderer.RenderHtmlFileAsPdf("my-content.html");

            // Adding an attachment to the PDF with a specific name and data
            var addedAttachment = documentPdf.Attachments.AddAttachment("attachment_1", example_attachment);

            // Example of how to remove the previously added attachment
            documentPdf.Attachments.RemoveAttachment(addedAttachment);

            documentPdf.SaveAs("my-content.pdf");
        }
    }
}
```

### PDF Compression

IronPDF enables efficient PDF compression, primarily through the reduction of embedded image sizes within a PDF. By using the `CompressImages` method, users can significantly decrease the file size of their documents.

JPEG image resizing in IronPDF allows for a spectrum of quality settings, where 100% maintains the original quality and 1% yields very poor image quality. Typically, settings above 90% maintain high-quality images, while settings between 80-90% and 70-80% offer medium and low-quality outputs, respectively. Compressing images below 70% quality can noticeably degrade the image clarity but can also dramatically reduce the PDF's file size.

It's advisable to experiment with various compression settings to find a suitable balance between image quality and file size reduction. The degree of quality loss can vary depending on the original image type, and some images may experience more pronounced quality reductions than others.

```csharp
using IronPdf;

namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class DocumentCompressionExample
    {
        public void Execute()
        {
            var document = new PdfDocument("document.pdf");
            
            // Set the quality level for image compression (scale: 1 to 100)
            document.CompressImages(60);  // Setting quality to 60%
            document.SaveAs("compressed_document.pdf");
        }
    }
}
```

An additional parameter is available to adjust the resolution of images relative to their visibility in the PDF. Be advised, altering this setting might distort certain image types depending on their layout:

Here's the paraphrased section where `IronPdf` library functionalities are utilized to compress PDF images at a specific quality and scale:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section11
    {
        public void Run()
        {
            var pdfDocument = new PdfDocument("document.pdf");

            // Compress and scale images within the PDF to reduce file size
            pdfDocument.CompressImages(90, scale: true);
            pdfDocument.SaveAs("document_scaled_compressed.pdf");
        }
    }
}
```

## Modifying PDF Content

### Add Headers and Footers

Effortlessly insert headers and footers into your PDF documents using IronPDF’s versatile header and footer capabilities, which include `TextHeaderFooter` for text-based headers and `HtmlHeaderFooter` for more complex HTML.

#### HTML Header and Footer

Employ HTML for creating exact headers or footers that reflect the HTML layout perfectly on your PDF document.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section12
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            
            // HTML footer with styling and central alignment
            renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter()
            {
                MaxHeight = 15, // max height in millimeters
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
                DrawDividerLine = true
            };
            
            // HTML header using an image
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter()
            {
                MaxHeight = 20, // max height in millimeters
                HtmlFragment = "<img src='logo.png'>",
                BaseUrl = new System.Uri(@"C:\assets\images").AbsoluteUri
            };
        }
    }
}
```

For a comprehensive guide with multiple examples, visit our tutorial [here](https://ironpdf.com/examples/adding-headers-and-footers-advanced/).

#### Text Header and Footer

The simpler `TextHeaderFooter` can efficiently add text-based headers or footers, with options such as merge fields available.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section13
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer
            {
                RenderingOptions =
                {
                    FirstPageNumber = 1, // starting page number
                    
                    // Easy text header setup:
                    TextHeader =
                    {
                        DrawDividerLine = true,
                        CenterText = "{url}",
                        Font = IronSoftware.Drawing.FontTypes.Helvetica,
                        FontSize = 12
                    },
            
                    // Simple text footer setup:
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
        }
    }
}
```

### Find and Replace Text in a PDF

IronPDF provides straightforward methods to replace text across your documents, or to swap placeholders with specific data programmatically using the `ReplaceTextOnPage` method.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section14
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("sample.pdf");
            
            int pageIndex = 1; // specify the page index
            string oldText = ".NET 6"; // text to be replaced
            string newText = ".NET 7"; // new text to include
            
            // Replace specific text on specified page
            pdf.ReplaceTextOnPage(pageIndex, oldText, newText);
            
            // Example of replacing a placeholder with a date
            pdf.ReplaceTextOnPage(pageIndex, "[DATE]", "01/01/2000");
            
            // Save the modified PDF
            pdf.SaveAs("new_sample.pdf");
        }
    }
}
```

For detailed instructions on text replacement, please visit our page [here](https://ironpdf.com/examples/csharp-replace-text-in-pdf/).

### Outlines and Bookmarks

Easily navigate through PDFs by adding, editing, or organizing outlines and bookmarks with IronPDF. These bookmarks, accessible through Adobe Acrobat Reader's sidebar, enhance the document's navigability.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section15
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("existing.pdf");
            
            pdf.Bookmarks.AddBookMarkAtEnd("Author's Note", 2);
            pdf.Bookmarks.AddBookMarkAtEnd("Table of Contents", 3);
            
            var summaryBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Summary", 17);
            summaryBookmark.Children.AddBookMarkAtStart("Conclusion", 18);
            
            pdf.Bookmarks.AddBookMarkAtEnd("References", 20);
            
            pdf.SaveAs("existing.pdf");
        }
    }
}
```

For more information regarding bookmarks and outlines, click [here](https://ironpdf.com/examples/bookmarks/).

### Add and Edit Annotations

IronPDF offers comprehensive tools to customize annotations in PDF documents. Annotate with text, customize appearance and specify behaviors as shown below:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section16
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("existing.pdf");
            
            var textAnnotation = new IronPdf.Annotations.TextAnnotation(0)
            {
                Title = "This is the major title",
                Contents = "This is the long 'sticky note' comment content...",
                Subject = "This is a subtitle",
                Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
                Opacity = 0.9,
                Printable = false,
                Hidden = false,
                OpenByDefault = true,
                ReadOnly = false,
                Rotatable = true,
            };
            
            pdf.Annotations.Add(textAnnotation);
            
            pdf.SaveAs("existing.pdf");
        }
    }
}
```

Text annotations are just one of many customizable options available for adding "sticky note" style comments to PDF pages.

### Add Backgrounds and Foregrounds

Use IronPDF to effortlessly layer PDF documents by merging them as backgrounds or foregrounds to create visually enriched PDF files.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section17
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            pdf.AddBackgroundPdf(@"MyBackground.pdf");
            pdf.AddForegroundOverlayPdfToPage(0, @"MyForeground.pdf", 0);
            pdf.SaveAs(@"C:\Path\To\Complete.pdf");
        }
    }
}
```

### Incorporating Headers and Footers

Adding headers and footers to your PDF documents is straightforward with IronPDF. The library offers two types of header/footer implementations: `TextHeaderFooter` and `HtmlHeaderFooter`. For simple text-based headers and footers, `TextHeaderFooter` is ideal and supports dynamic content such as `"{page} of {total-pages}"`. For more complex requirements, `HtmlHeaderFooter` allows the inclusion of full HTML content in headers and footers, accommodating more elaborate designs and formatting.

#### HTML Headers and Footers

Employ HTML for your PDF's headers and footers for an impeccable layout that precisely mirrors your HTML rendering. This approach ensures that your PDF documents achieve a pixel-perfect presentation in their headings and footings.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section12
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();

            // Set the HTML footer with dynamic fields for pagination and dates
            // Available template fields include {page}, {total-pages}, {url}, {date}, {time}, {html-title}, and {pdf-title}
            renderer.RenderingOptions.HtmlFooter = new HtmlHeaderFooter
            {
                MaxHeight = 15, // Set the height in millimeters
                HtmlFragment = "<center><i>{page} of {total-pages}<i></center>",
                DrawDividerLine = true // Draws a line above the footer for separation
            };

            // Configure the HTML header using an image, changing the BaseUrl to local machine absolute path
            renderer.RenderingOptions.HtmlHeader = new HtmlHeaderFooter
            {
                MaxHeight = 20, // Height in millimeters
                HtmlFragment = "<img src='logo.png'>", // Source image for the header
                // Set the base URL to resolve relative paths
                BaseUrl = new System.Uri("C:\\assets\\images").AbsoluteUri
            };
        }
    }
}
```

To explore an extensive example that covers various scenarios, please visit our detailed tutorial [here](https://ironpdf.com/examples/adding-headers-and-footers-advanced/).

#### Text Header and Footer

For straightforward header and footer implementations, IronPDF provides the `TextHeaderFooter` class. Explore the example provided for a clearer understanding.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section13
    {
        public void Run()
        {
            // Initialize a PDF renderer to facilitate adding headers and footers
            var renderer = new ChromePdfRenderer
            {
                RenderingOptions =
                {
                    FirstPageNumber = 1, // Option to start numbering from 2 if including a cover page

                    // Configuring the header for each page
                    TextHeader = new TextHeaderFooter
                    {
                        DrawDividerLine = true,
                        CenterText = "{url}", // Placeholder for the current URL
                        Font = IronSoftware.Drawing.FontTypes.Helvetica,
                        FontSize = 12 // Size of the font used in the header
                    },

                    // Similarly, setting up the footer
                    TextFooter = new TextHeaderFooter
                    {
                        DrawDividerLine = true,
                        Font = IronSoftware.Drawing.FontTypes.Arial,
                        FontSize = 10, // Font size for the footer
                        LeftText = "{date} {time}", // Display date and time on the left
                        RightText = "{page} of {total-pages}" // Page count on the right
                    }
                }
            };
        }
    }
}
```

In addition, IronPDF supports the use of merge fields that are dynamically replaced with specific values during rendering. These fields include `{page}`, `{total-pages}`, `{url}`, `{date}`, `{time}`, `{html-title}`, and `{pdf-title}`.

### Text Replacement in PDFs

Effortlessly replace text or establish placeholders in your PDF documents using the versatile `ReplaceTextOnPage` method from IronPDF. This feature allows seamless updates to text content programmatically, perfect for dynamic data integration in your documents.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class TextReplacementSection
    {
        public void Execute()
        {
            // Load an existing PDF document
            var pdfDocument = PdfDocument.FromFile("sample.pdf");
            
            // Define parameters for the text replacement
            int pageToEdit = 1; // Page index for operation
            string textToReplace = ".NET 6"; // Existing text
            string replacementText = ".NET 7"; // New text to insert

            // Perform text replacement on specified page
            pdfDocument.ReplaceTextOnPage(pageToEdit, textToReplace, replacementText);

            // Example: Replace placeholders with concrete texts
            pdfDocument.ReplaceTextOnPage(pageToEdit, "[DATE]", "01/01/2000");

            // Save the updated PDF document
            pdfDocument.SaveAs("new_sample.pdf");
        }
    }
}
```

For an in-depth example of finding and replacing text in a PDF, please explore our Code Examples page [here](https://ironpdf.com/examples/csharp-replace-text-in-pdf/).

### Outlines and Bookmarks

Outlines, often referred to as "bookmarks," provide a handy navigation tool for accessing important pages within a PDF document. Displayed on the left sidebar of Adobe Acrobat Reader, these bookmarks can be nested for organized access. IronPDF efficiently imports any existing bookmarks from PDF files and allows for the creation, modification, and organization of new bookmarks.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section15
    {
        public void Execute()
        {
            // Initialize a new or existing PDF document.
            PdfDocument pdf = PdfDocument.FromFile("existing.pdf");

            // Append bookmarks to the PDF.
            pdf.Bookmarks.AddBookMarkAtEnd("Author's Note", 2);
            pdf.Bookmarks.AddBookMarkAtEnd("Table of Contents", 3);

            // Create a new bookmark for the summary section.
            var summaryBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Summary", 17);

            // Insert a nested bookmark for the conclusion within the summary.
            var conclusionBookmark = summaryBookmark.Children.AddBookMarkAtStart("Conclusion", 18);

            // Place an additional bookmark for references at the end of the document.
            pdf.Bookmarks.AddBookMarkAtEnd("References", 20);

            // Save the changes to the same PDF file.
            pdf.SaveAs("existing.pdf");
        }
    }
}
```

To explore the Outlines and Bookmarks example on our Code Examples page, you can find it [here](https://ironpdf.com/examples/bookmarks/).

### Adding and Modifying Annotations in PDFs

IronPDF provides extensive options for customizing annotations within PDF documents. Here is a detailed example to illustrate these capabilities:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section16
    {
        public void Run()
        {
            // Load an existing PDF document or create a new one.
            var pdf = PdfDocument.FromFile("existing.pdf");
            
            // Define a new text annotation with specific properties
            var textAnnotation = new IronPdf.Annotations.TextAnnotation(PageIndex: 0)
            {
                Title = "This is the major title",
                Contents = "Here is a detailed sticky note comment...",
                Subject = "Subtitle Information",
                Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Note,
                Opacity = 0.8,
                Printable = true,
                Hidden = false,
                OpenByDefault = false,
                ReadOnly = true,
                Rotatable = false,
            };
            
            // Add the newly created annotation to a specific page
            pdf.Annotations.Add(textAnnotation);
            
            // Save the changes to a new file
            pdf.SaveAs("updated.pdf");
        }
    }
}
```

In this section, annotations can be completely tailored to suit specific requirements including options like the annotation's icon, visibility, whether it's printable, and more. Each property can be individually set to achieve the desired functionality and appearance within the PDF.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section16
    {
        public void Run()
        {
            // Load an existing PDF or initialize a new one.
            var pdf = PdfDocument.FromFile("existing.pdf");

            // Define a text annotation for insertion into the PDF.
            var textAnnotation = new IronPdf.Annotations.TextAnnotation(PageIndex: 0)
            {
                Title = "This is the major title",
                Contents = "This is the long 'sticky note' comment content...",
                Subject = "This is a subtitle",
                Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
                Opacity = 0.9,
                Printable = false,
                Hidden = false,
                OpenByDefault = true,
                ReadOnly = false,
                Rotatable = true,
            };

            // Insert the defined text annotation into a specific page in the PDF.
            pdf.Annotations.Add(textAnnotation);

            // Save the changes to the same existing PDF file.
            pdf.SaveAs("existing.pdf");
        }
    }
}
```

PDF annotations make it possible to insert comments resembling "sticky notes" into PDF documents. Utilizing the `TextAnnotation` class, these annotations can be programmatically positioned within the pages. Its robust feature set includes options for resizing, setting opacity, choosing icons, and performing edits.

### Incorporating Backgrounds and Foregrounds into PDFs

IronPDF enables effortless integration of two PDF files, allowing you to designate one as either a background or a foreground to the other:

Here is the paraphrased version of the provided C# code section, with absolute URLs resolved to `ironpdf.com`:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class BackgroundForegroundSection
    {
        public void Execute()
        {
            var pdfRenderer = new ChromePdfRenderer();
            var generatedPdf = pdfRenderer.RenderUrlAsPdf("https://www.nuget.org/packages/IronPdf");
            generatedPdf.AddBackgroundPdf(@"MyBackground.pdf");
            generatedPdf.AddForegroundOverlayPdfToPage(0, @"MyForeground.pdf", 0);
            generatedPdf.SaveAs(@"C:\Path\To\Complete.pdf");
        }
    }
}
```

This version maintains the same functionality with different variable naming and slight structural changes for clarity and distinction.

### Stamping and Watermarking

Stamping and watermarking capabilities are essential tools in any PDF editing software. IronPDF offers a robust API that allows for the creation of various types of stamps, including image and HTML stamps. This flexibility is enhanced by customizable options for alignment and offsets, ensuring precise placement of stamps within your documents. Detailed examples of these features can be explored here:

<div class="content-img-align-center">
  <img src="/static-assets/pdf/tutorials/csharp-edit-pdf-complete-tutorial/csharp-edit-pdf-complete-tutorial-1.webp" alt="Stamping and Watermarking" class="img-responsive add-shadow">
</div>

#### Abstract Stamper Class

The abstract `Stamper` class serves as a foundation for all stamping operations in IronPDF. It plays a crucial role in customizing how content is stamped onto PDFs.

IronPDF provides several specialized stamper classes tailored to different needs:

- `TextStamper` for adding text [Text Example](#anchor-stamp-text-onto-a-pdf)
- `ImageStamper` for embedding images [Image Example](#anchor-stamp-an-image-onto-a-pdf)
- `HtmlStamper` for incorporating HTML content [HTML Example](#anchor-stamp-html-onto-a-pdf)
- `BarcodeStamper` for barcode integration [Barcode Example](#anchor-stamp-a-barcode-onto-a-pdf)
- Another `BarcodeStamper` for QR code implementations [QR Code Example](#anchor-stamp-a-qr-code-onto-a-pdf)
- For adding watermarks, refer to [this section](#anchor-add-a-watermark-to-a-pdf).

To utilize these stampers, employ the methods found in the `ApplyStamp()` section of this tutorial. See the relevant instructions [here](#anchor-apply-stamp-onto-a-pdf).

## Stamper Class Properties Overview

The `Stamper` class in IronPDF serves as the foundation for all stamping operations within PDF documents, offering a suite of properties to customize the appearance and behavior of stamps. Below is a detailed description of these properties:


abstract class Stamper
|
└─── int : Opacity (Defines the transparency level of the stamp)
└─── int : Rotation (Sets the rotation angle of the stamp in degrees)
|
└─── double : Scale (Adjusts the scale of the stamp, where 1 represents original size)
|
└─── Length : HorizontalOffset (Determines the horizontal position of the stamp relative to the page)
└─── Length : VerticalOffset (Determines the vertical position of the stamp relative to the page)
|
└─── Length : MinWidth (Specifies the minimum width of the stamp)
└─── Length : MaxWidth (Specifies the maximum width of the stamp)
|
└─── Length : MinHeight (Specifies the minimum height of the stamp)
└─── Length : MaxHeight (Specifies the maximum height of the stamp)
|
└─── string : Hyperlink (Embeds a clickable hyperlink within the stamp)
|
└─── bool : IsStampBehindContent (Determines whether the stamp appears behind page content, default is false)
|
└─── HorizontalAlignment : HorizontalAlignment
│   │   Left (Aligns stamp to the left)
│   │   Center (Aligns stamp to the center, default setting)
│   │   Right (Aligns stamp to the right)
│
└─── VerticalAlignment : VerticalAlignment
    │   Top (Aligns stamp at the top)
    │   Middle (Aligns stamp at the center, default setting)
    │   Bottom (Aligns stamp at the bottom)
```

This configuration schema empowers developers to precisely control how stamps are applied across different PDF pages, ensuring the modifications fit the required context and design specifications.

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
│
└─── VerticalAlignment : VerticalAlignment
    │   Top
    │   Middle (default)
    │   Bottom
```

## Examples of Stamping

In the following section, we present a variety of examples that illustrate the use of the different `Stamper` subclasses within IronPDF, accompanied by relevant code snippets.

### Stamp Text onto a PDF

Creating two distinct Text Stampers and applying them:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section18
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<h1>Example HTML Document!</h1>");
            
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
            
            TextStamper stamper2 = new TextStamper()
            {
                Text = "Hello World! Stamp Two Here!",
                FontFamily = "Bungee Spice",
                UseGoogleFont = true,
                FontSize = 30,
                VerticalAlignment = VerticalAlignment.Bottom
            };
            
            Stamper[] stampersToApply = { stamper1, stamper2 };
            pdf.ApplyMultipleStamps(stampersToApply);
            pdf.ApplyStamp(stamper2);
        }
    }
}
```

### Stamp an Image onto a PDF

Applying an Image Stamp across various pages of an existing PDF document:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section19
    {
        public void Run()
        {
            var pdf = new PdfDocument("/attachments/2022_Q1_sales.pdf");
            
            ImageStamper logoImageStamper = new ImageStamper("/assets/logo.png");
            
            // Apply to every page, one page, or some pages
            pdf.ApplyStamp(logoImageStamper);
            pdf.ApplyStamp(logoImageStamper, 0);
            pdf.ApplyStamp(logoImageStamper, new[] { 0, 3, 11 });
        }
    }
}
```

### Stamp HTML onto a PDF

Incorporating your custom HTML content as a stamp:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section20
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<p>Hello World, example HTML body.</p>");
            
            HtmlStamper stamper = new HtmlStamper($"<p>Example HTML Stamped</p><div style='width:250pt;height:250pt;background-color:red;'></div>")
            {
                HorizontalOffset = new Length(-3, MeasurementUnit.Inch),
                VerticalAlignment = VerticalAlignment.Bottom
            };
            
            pdf.ApplyStamp(stamper);
        }
    }
}
```

### Stamp a Barcode onto a PDF

Creating and applying a Barcode stamp:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section21
    {
        public void Run()
        {
            BarcodeStamper bcStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);
            
            bcStamp.HorizontalAlignment = HorizontalAlignment.Left;
            bcStamp.VerticalAlignment = VerticalAlignment.Bottom;
            
            var pdf = new PdfDocument("example.pdf");
            pdf.ApplyStamp(bcStamp);
        }
    }
}
```

### Stamp a QR Code onto a PDF

Example of generating and stamping a QR Code:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section22
    {
        public void Run()
        {
            BarcodeStamper qrStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);
            
            qrStamp.Height = 50; // pixels
            qrStamp.Width = 50; // pixels
            
            qrStamp.HorizontalAlignment = HorizontalAlignment.Left;
            qrStamp.VerticalAlignment = VerticalAlignment.Bottom;
            
            var pdf = new PdfDocument("example.pdf");
            pdf.ApplyStamp(qrStamp);
        }
    }
}
```

This section has displayed various practical examples on how to utilize the different subclasses of `Stamper` to add stamps to PDF documents using IronPDF. Each example is aimed at showcasing the flexibility and range of customization possible with IronPDF's stamping features.

### Text Stamping on PDFs

Explore how to create and apply two distinct `TextStamper` instances on a PDF:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section18
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<h1>Sample HTML Content</h1>");
            
            // Configure the first text stamper
            TextStamper textStamper1 = new TextStamper
            {
                Text = "First Text Stamp Here!",
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
                Text = "Second Text Stamp Here!",
                FontFamily = "Bungee Spice",
                UseGoogleFont = true,
                FontSize = 30,
                VerticalAlignment = VerticalAlignment.Bottom
            };
            
            // Prepare an array of stampers to apply
            Stamper[] stampersArray = { textStamper1, textStamper2 };
            
            // Apply both stampers to the PDF
            pdf.ApplyMultipleStamps(stampersArray);
            pdf.ApplyStamp(textStamper2);
        }
    }
}
```

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section18
    {
        public void Run()
        {
            // Instantiate the ChromePdfRenderer
            var renderer = new ChromePdfRenderer();

            // Render an HTML snippet as a PDF
            var pdf = renderer.RenderHtmlAsPdf("<h1>Sample HTML Document</h1>");

            // Create the first text stamper configuration
            TextStamper textStamperOne = new TextStamper
            {
                Text = "Greeting! First Stamp Right Here!",
                FontFamily = "Bungee Spice",
                UseGoogleFont = true,
                FontSize = 100,
                IsBold = true,
                IsItalic = true,
                VerticalAlignment = VerticalAlignment.Top
            };

            // Create the second text stamper configuration
            TextStamper textStamperTwo = new TextStamper
            {
                Text = "Hello Again! Second Stamp Over Here!",
                FontFamily = "Bungee Spice",
                UseGoogleFont = true,
                FontSize = 30,
                VerticalAlignment = VerticalAlignment.Bottom
            };

            // Array of stampers to apply
            Stamper[] stampers = { textStamperOne, textStamperTwo };

            // Apply multiple stampers to the PDF
            pdf.ApplyMultipleStamps(stampers);

            // Apply the second stamper individually
            pdf.ApplyStamp(textStamperTwo);
        }
    }
}
```

### Stamping Images onto a PDF Document

Embedding image stamps into an existing PDF can be performed on selected pages or across the entire document. Here's how to execute various scenarios:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section19
    {
        public void Run()
        {
            var pdf = new PdfDocument("/attachments/2022_Q1_sales.pdf");
            
            // Initialize the ImageStamper with the desired logo
            ImageStamper logoImageStamper = new ImageStamper("/assets/logo.png");
            
            // Apply the stamp across all pages
            pdf.ApplyStamp(logoImageStamper);
            
            // Apply the stamp to the first page
            pdf.ApplyStamp(logoImageStamper, 0);
            
            // Apply the stamp to specific pages: first, fourth, and twelfth
            pdf.ApplyStamp(logoImageStamper, new[] { 0, 3, 11 });
        }
    }
}
```

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section19
    {
        public void Run()
        {
            // Load the PDF document from the specified path
            var pdf = new PdfDocument("https://ironpdf.com/attachments/2022_Q1_sales.pdf");

            // Create an ImageStamper object and define the stamp image source
            ImageStamper logoImageStamper = new ImageStamper("https://ironpdf.com/assets/logo.png");

            // Apply the image stamper to several configurations: across all pages, on the first page, and on specific pages
            pdf.ApplyStamp(logoImageStamper); // Apply to all pages
            pdf.ApplyStamp(logoImageStamper, 0); // Apply to the first page
            pdf.ApplyStamp(logoImageStamper, new[] { 0, 3, 11 }); // Apply to the first, fourth, and twelfth pages
        }
    }
}
```

### HTML Stamping on a PDF

Craft custom HTML to act as your personalized PDF stamp:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section20
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<p>Welcome to custom HTML stamping.</p>");
            
            HtmlStamper htmlStamper = new HtmlStamper("<div style='color: green;'><p>Custom HTML Stamp</p></div>")
            {
                HorizontalOffset = new Length(-2, MeasurementUnit.Inch),
                VerticalAlignment = VerticalAlignment.Bottom
            };
            
            pdf.ApplyStamp(htmlStamper);
        }
    }
}
```

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section20
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer();
            var pdf = renderer.RenderHtmlAsPdf("<p>Hello World! This is an example HTML body.</p>");

            HtmlStamper htmlStamper = new HtmlStamper("<p>Demonstration of HTML Stamping</p><div style='width:250pt;height:250pt;background-color:red;'></div>")
            {
                HorizontalOffset = new Length(-3, MeasurementUnit.Inch),
                VerticalAlignment = VerticalAlignment.Bottom
            };

            pdf.ApplyStamp(htmlStamper);
        }
    }
}
```

### Placing a Barcode on a PDF Document

Below is an example on how to create and insert a barcode into a PDF file:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section21
    {
        public void Run()
        {
            // Create a barcode stamper with specified barcode content and type
            BarcodeStamper barcodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);

            // Set the alignment of the barcode in the PDF
            barcodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
            barcodeStamper.VerticalAlignment = VerticalAlignment.Bottom;

            // Load an existing PDF document
            var pdf = new PdfDocument("example.pdf");

            // Apply the barcode stamp to the PDF
            pdf.ApplyStamp(barcodeStamper);
        }
    }
}
```

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section21
    {
        public void Run()
        {
            // Initialize a new Barcode Stamper with the "IronPDF" text and Code39 encoding.
            BarcodeStamper barcodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.Code39);

            // Set the alignments for the barcode stamper to the left and bottom of the page.
            barcodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
            barcodeStamper.VerticalAlignment = VerticalAlignment.Bottom;

            // Load an example PDF document to apply the barcode stamper.
            PdfDocument document = new PdfDocument("example.pdf");

            // Apply the barcode stamper to the loaded document.
            document.ApplyStamp(barcodeStamper);
        }
    }
}
```

### Incorporating a QR Code into a PDF

This segment demonstrates how to insert a QR Code into a PDF document:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section22
    {
        public void Run()
        {
            // Create a new barcode stamper instance for a QR Code
            BarcodeStamper qrStamp = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);
            
            // Set dimensions and alignment for the QR Code
            qrStamp.Height = 50; // pixels
            qrStamp.Width = 50; // pixels
            
            qrStamp.HorizontalAlignment = HorizontalAlignment.Left;
            qrStamp.VerticalAlignment = VerticalAlignment.Bottom;
            
            // Load a PDF document to stamp the QR Code onto
            var pdf = new PdfDocument("example.pdf");
            // Apply the QR Code stamp to the loaded document
            pdf.ApplyStamp(qrStamp);
        }
    }
}
```

Here's your paraphrased section with markdown format and resolved links:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class ExampleSectionQRCode
    {
        public void Run()
        {
            // Initialize a new QR Code BarcodeStamper with specific attributes
            BarcodeStamper qrCodeStamper = new BarcodeStamper("IronPDF", BarcodeEncoding.QRCode);
            
            // Set the size of the QR code to 50x50 pixels
            qrCodeStamper.Height = 50; // in pixels
            qrCodeStamper.Width = 50; // in pixels
            
            // Align the QR code to the left bottom corner of the page
            qrCodeStamper.HorizontalAlignment = HorizontalAlignment.Left;
            qrCodeStamper.VerticalAlignment = VerticalAlignment.Bottom;
            
            // Load an existing PDF document
            var document = new PdfDocument("example.pdf");
            
            // Apply the QR code stamp to the PDF
            document.ApplyStamp(qrCodeStamper);
        }
    }
}
```

### Adding a Watermark to a PDF Document

A watermark acts as a consistent stamp across all pages of a PDF, which you can effortlessly apply with the `ApplyWatermark` method from the IronPDF library. This feature is helpful for branding or securing document content with minimal effort.

Here is the paraphrased section of your article, with the relative URL paths resolved:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section23
    {
        public void Run()
        {
            // Create a PdfDocument instance by loading the design PDF
            var pdf = new PdfDocument("https://ironpdf.com/attachments/design.pdf");
            // Define the HTML content for the watermark
            string htmlContent = "<h1>Sample Watermark Title<h1/>";
            // Set watermark rotation angle and opacity level
            int rotatingAngle = 0;
            int transparency = 30;

            // Apply the watermark with specified HTML content, rotation, and opacity
            pdf.ApplyWatermark(htmlContent, rotatingAngle, transparency);
        }
    }
}
```

For an in-depth look at implementing watermarking using IronPDF, check out our full example on the [Code Examples page](https://ironpdf.com/examples/pdf-watermarking/).

### Applying a Stamp to a PDF Document

Numerous variations of the `ApplyStamp` method are available, enabling you to affix your custom `Stamper` to any part of your PDF document.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section24
    {
        public void Run()
        {
            var pdf = new PdfDocument("https://ironpdf.com/assets/example.pdf");

            // Apply a single stamper across all pages
            pdf.ApplyStamp(myStamper);

            // Apply the stamper to just the first page
            pdf.ApplyStamp(myStamper, 0);

            // Apply the stamper to selected pages
            pdf.ApplyStamp(myStamper, new[] { 0, 3, 5 });

            // Apply a collection of stamps to every page
            pdf.ApplyMultipleStamps(stampArray);

            // Apply a collection of stamps to the first page
            pdf.ApplyMultipleStamps(stampArray, 0);

            // Apply the collection of stamps to a range of specific pages
            pdf.ApplyMultipleStamps(stampArray, new[] { 0, 3, 5 });

            // Asynchronously applying a stamper to page four
            await pdf.ApplyStampAsync(myStamper, 4);
            await pdf.ApplyMultipleStampsAsync(stampArray);

            // Add a watermark applying a rotation and specifying opacity
            string htmlWatermark = "<h1> Example Title <h1/>";
            int rotateDegrees = 0;
            int opacityLevel = 30;
            pdf.ApplyWatermark(htmlWatermark, rotateDegrees, opacityLevel);
        }
    }
}
```

#### Length Class Overview

The `Length` class comprises two primary attributes: `Unit` and `Value`. To utilize this class, first select a measurement unit from the `MeasurementUnit` enumeration, where the default setting is `Percentage`, relating to the page dimensions. Subsequently, define the `Value`, which specifies the length as a proportion of the selected unit. This setup allows precise control over sizing and positioning in document modifications.

## Length Class Attributes

The `Length` class in IronPDF defines measurements used to position elements such as stamps in a PDF document. Below, find a detailed outline of its properties:

```txt
class Length
|
└─── double : Value (default : 0)  // Indicates the numerical magnitude of the length
|
└─── MeasurementUnit : Unit        // Specifies the unit of measurement, defaulting to Percentage of the page
     |   Inch                      // Represents inches
     |   Millimeter                // Denotes millimeters
     |   Centimeter                // Stands for centimeters
     |   Percentage (default)      // Represents a percentage in relation to the page dimensions
     |   Pixel                     // Indicates pixels
     |   Points                    // Refers to typographic points
```

This class allows developers to precisely control the layout and positioning of various elements in their PDF handling and manipulation tasks by specifying dimensions in multiple units of measurement.

```txt
class Length

└─── double : Value (initially : 0)

└─── MeasurementUnit : Unit
   |  Inch
   |  Millimeter
   |  Centimeter
   |  Percentage (standard)
   |  Pixel
   |  Points
```

### Examples of Using Length

Below, we demonstrate various ways to utilize the `Length` class:

#### Creating Specified Lengths

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section25
    {
        public void Run()
        {
            // Define a length of 5 inches
            new Length(value: 5, unit: MeasurementUnit.Inch);

            // Define a length of 25 pixels
            new Length(value: 25, unit: MeasurementUnit.Pixel);

            // Default Length: zero percentage of the page dimension
            new Length();

            // Define a length as 20% of the page dimension
            new Length(value: 20);
        }
    }
}
```

#### Using Length as a Parameter in Stamping

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section26
    {
        public void Run()
        {
            HtmlStamper logoStamper = new HtmlStamper
            {
                // Set vertical offset as 15% of the page
                VerticalOffset = new Length(15, MeasurementUnit.Percentage),

                // Set horizontal offset as 1 inch
                HorizontalOffset = new Length(1, MeasurementUnit.Inch)
                
                // Additional stamper properties can be set here...
            };
        }
    }
}
```

#### Defining a `Length` Instance

Using the `Length` class in IronPDF allows you to specify dimensions for various elements of your PDF documents. The class uses different units for measurement, providing flexibility depending on your requirements. Here's how you can utilize the `Length` class effectively:

```csharp
using IronPdf;

namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section25
    {
        public void Run()
        {
            // Create a length of 5 inches
            new Length(5, MeasurementUnit.Inch);

            // Create a length of 25 pixels
            new Length(25, MeasurementUnit.Pixel);

            // Default Length creation equals 0% of the page's dimension
            new Length();

            // Define a Percentage-based length, e.g., 20% of the page dimension
            new Length(20);
        }
    }
}
```

This example illustrates various ways to define lengths using the `Length` class, catering to diverse layout needs such as margins, paddings, or even positioning elements like stamps in your PDF documents.

Here's the paraphrased section:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section25
    {
        public void Run()
        {
            // Defining a Length of 5 inches
            new Length(value: 5, unit: MeasurementUnit.Inch); 

            // Setting a Length of 25 pixels
            new Length(value: 25, unit: MeasurementUnit.Pixel);

            // Default Length, implicitly set to 0% due to defaults in measurement unit being percentage
            new Length(); 

            // Specifying a Length as 20% of a page's dimension 
            new Length(value: 20); 
        }
    }
}
```

#### Utilizing `Length` for Parameter Settings

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section26
    {
        public void Run()
        {
            // Configure a visual aspect using Length specifying vertical and horizontal offsets
            HtmlStamper logoStamper = new HtmlStamper
            {
                VerticalOffset = new Length(15, MeasurementUnit.Percentage), // Set vertical offset to 15% of page height
                HorizontalOffset = new Length(1, MeasurementUnit.Inch)      // Set horizontal offset to 1 inch
                // Additional properties can be configured here...
            };
        }
    }
}
```
In this snippet, `Length` is implemented to precisely position elements on the page, using units like percentage and inches for vertical and horizontal alignment respectively.

Here's the paraphrased section of your article:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section26
    {
        public void Initialize()
        {
            // Creating a new instance of HtmlStamper to apply HTML content as a stamp
            HtmlStamper customStamper = new HtmlStamper
            {
                // Adjusting the vertical alignment relative to the total page height
                VerticalOffset = new Length(15, MeasurementUnit.Percentage),
                // Setting the horizontal position using an inch measurement
                HorizontalOffset = new Length(1, MeasurementUnit.Inch)
                // Additional properties can be configured here
            };
        }
    }
}
```

## PDF Form Management

IronPDF provides robust features to create and manipulate forms within PDF documents. This section illustrates how to effectively utilize IronPDF for working with forms in PDFs.

### Create and Manipulate Forms

Use IronPDF to generate PDFs with editable form fields:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section27
    {
        public void Run()
        {
            // Define HTML content for the form
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
            
            // Create a Renderer instance
            var renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            // Render HTML as PDF
            renderer.RenderHtmlAsPdf(formHtml).SaveAs("InteractiveForm.pdf");
            
            // Optionally, manipulate form fields
            var documentWithForm = PdfDocument.FromFile("InteractiveForm.pdf");
            
            // Access form fields by name
            var firstNameField = documentWithForm.Form.FindFormField("firstname");
            var lastNameField = documentWithForm.Form.FindFormField("lastname");
        }
    }
}
```

For more details on creating PDF forms, explore our documentation [here](https://ironpdf.com/examples/form-data/).

### Populate Existing Forms

Quickly fill in the form fields within a PDF document and save the updated document:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section28
    {
        public void Run()
        {
            var loadedForm = PdfDocument.FromFile("InteractiveForm.pdf");
            
            // Access and update the 'firstname' field
            var firstNameField = loadedForm.Form.FindFormField("firstname");
            firstNameField.Value = "Minnie";
            Console.WriteLine($"FirstNameField value: {firstNameField.Value}");
            
            // Access and update the 'lastname' field
            var lastNameField = loadedForm.Form.FindFormField("lastname");
            lastNameField.Value = "Mouse";
            Console.WriteLine($"LastNameField value: {lastNameField.Value}");
            
            // Save the filled form
            loadedForm.SaveAs("CompletedForm.pdf");
        }
    }
}
```

Refer to our complete guide to filling forms [here](https://ironpdf.com/examples/form-data/).

## Final Thoughts

Through the above examples, IronPDF demonstrates its capability to quickly create and manage forms within PDF documents, allowing users to automate this typically manual process effectively.

### Creating and Modifying Forms

Leverage the capabilities of IronPDF to generate PDFs that contain interactive form fields:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section27
    {
        public void Run()
        {
            // Define the HTML for a form with input elements
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
            
            // Configure the PDF renderer to create forms from HTML
            var renderer = new ChromePdfRenderer();
            renderer.RenderingOptions.CreatePdfFormsFromHtml = true;

            // Render the HTML as a PDF and save it
            renderer.RenderHtmlAsPdf(formHtml).SaveAs("InteractiveForm.pdf");

            // Optionally, interact with form values
            var formPdf = PdfDocument.FromFile("InteractiveForm.pdf");
            
            // Access form fields by name
            var firstNameField = formPdf.Form.FindFormField("firstname");
            var lastNameField = formPdf.Form.FindFormField("lastname");
        }
    }
}
```

This workflow not only creates a fillable PDF form but also guides you on how to manipulate the values within the form programmatically.

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class FormCreationSection
    {
        public void Execute()
        {
            // Step 1: Generate a PDF with interactive forms using HTML form elements
            const string htmlFormContent = @"
                <html>
                    <body>
                        <h2>Interactive PDF Form</h2>
                        <form>
                            First name: <br> <input type='text' name='firstname' value=''> <br>
                            Last name: <br> <input type='text' name='lastname' value=''>
                        </form>
                    </body>
                </html>";

            // Initialize the PDF Renderer
            var pdfRenderer = new ChromePdfRenderer();
            pdfRenderer.RenderingOptions.CreatePdfFormsFromHtml = true;
            pdfRenderer.RenderHtmlAsPdf(htmlFormContent).SaveAs("BasicForm.pdf");

            // Step 2: Access and manipulate PDF form fields
            var pdfForm = PdfDocument.FromFile("BasicForm.pdf");

            // Fetch and display the value from the "firstname" field
            var firstNameFormField = pdfForm.Form.FindFormField("firstname");

            // Fetch and display the value from the "lastname" field
            var lastNameFormField = pdfForm.Form.FindFormField("lastname");
        }
    }
}
```

For a detailed demonstration of the PDF form example, please explore our Code Examples page [here](https://ironpdf.com/examples/form-data/).

### Populating Existing PDF Forms

IronPDF enables straightforward access to all existing form fields within a PDF, allowing you to populate and save them effortlessly:

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section28
    {
        public void Run()
        {
            var formDocument = PdfDocument.FromFile("BasicForm.pdf");
            
            // Retrieve and set the value of the "firstname" field
            var firstNameField = formDocument.Form.FindFormField("firstname");
            firstNameField.Value = "Minnie";
            Console.WriteLine("FirstNameField value: {0}", firstNameField.Value);
            
            // Retrieve and set the value of the "lastname" field
            var lastNameField = formDocument.Form.FindFormField("lastname");
            lastNameField.Value = "Mouse";
            Console.WriteLine("LastNameField value: {0}", lastNameField.Value);
            
            // Save the populated form
            formDocument.SaveAs("FilledForm.pdf");
        }
    }
}
```

For further details on working with PDF forms, see this detailed guide: [PDF Form Handling](https://ironpdf.com/examples/form-data/).

```csharp
using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section28
    {
        public void Run()
        {
            // Load a PDF document that contains form fields
            var formDocument = PdfDocument.FromFile("BasicForm.pdf");
            
            // Access and update the 'firstname' form field
            var firstNameField = formDocument.Form.FindFormField("firstname");
            firstNameField.Value = "Minnie";
            Console.WriteLine($"Updated FirstNameField value: {firstNameField.Value}");

            // Access and update the 'lastname' form field
            var lastNameField = formDocument.Form.FindFormField("lastname");
            lastNameField.Value = "Mouse";
            Console.WriteLine($"Updated LastNameField value: {lastNameField.Value}");

            // Save the updated form fields in a new PDF file
            formDocument.SaveAs("FilledForm.pdf");
        }
    }
}
```

Explore the PDF Form example in our Code Examples section by following this [link](https://ironpdf.com/examples/form-data/).

## Conclusion

The numerous examples provided above showcase IronPDF's robust and ready-to-use features for PDF editing.

Should you need to submit a feature request or have any inquiries regarding IronPDF or its licensing, feel free to [reach out to our support team](https://ironpdf.com/troubleshooting/engineering-request-pdf/). We are always here to help.

