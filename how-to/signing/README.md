# Apply Digital Signatures to PDF Documents

***Based on <https://ironpdf.com/how-to/signing/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Is your company overpaying for annual PDF security subscriptions? Look into <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc by Iron Software</a>, your all-in-one solution for digital signatures, redaction, encryption, and document protection with a one-time fee. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Check Out IronSecureDoc Documentation</a>
</div>

### Clarification: Types of PDF Signatures

A frequent query from developers using IronPDF is how to programmatically append a signature to a PDF. The term "signing" could mean different actions:

1. <a href="#anchor-sign-a-pdf-with-a-digital-certificate">Digitally signing a PDF document with a Certificate to ensure document integrity.</a>
2. <a href="#anchor-stamp-a-signature-onto-a-pdf">Adding a signature image to a PDF using a graphic file.</a>
3. <a href="#anchor-stamp-a-signature-onto-a-pdf">Stamping a digital certificate as an image onto a PDF.</a>
4. <a href="#anchor-add-a-signature-form-field-to-a-pdf">Inserting a Signature Form Field into a PDF that prompts viewers to sign.</a>



## Digitally Sign a PDF Using a Certificate

IronPDF enables various methods for applying digital signatures using certificates in `.pfx` and `.p12` formats. This guide will walk you through the **three primary techniques** available to digitally sign PDF files:

<style type="text/css">
.tg  {border-collapse:collapse;border-color:#ccc;border-spacing:0;}
.tg td{background-color:#fff;border-color:#ccc;border-style:solid;border-width:1px;color:#333;
  font-family:Arial, sans-serif;font-size:14px;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{background-color:#f0f0f0;border-color:#ccc;border-style:solid;border-width:1px;color:#333;
  font-family:Arial, sans-serif;font-size:14px;font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-u0o7{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-fymr{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
</style>
<table class="tg">
<thead>
  <tr>
    <th class="tg-fymr">Signing Method</th>
    <th class="tg-u0o7">Description</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td class="tg-0pky">Sign</td>
    <td class="tg-0pky">Apply a digital signature using a <strong>PdfSignature</strong> object.</td>
  </tr>
  <tr>
    <td class="tg-0pky">SignWithFile</td>
    <td class="tg-0pky">Utilize a digital certificate from a file (.pfx or .p12) to sign a PDF.</td>
  </tr>
  <tr>
    <td class="tg-0pky">SignWithStore</td>
    <td class="tg-0pky">Use a digital signature sourced from your system’s certificate store by referencing a thumbprint ID.</td>
  </tr>
</tbody>
</table>

### Compatible Digital Signature Certificate Files

IronPDF adheres to the `X509Certificate2` standard for digital signatures, accepting both `.pfx` and `.p12` formats. Should a direct application of your certificate fail with IronPDF’s methods, you'll need to establish a `X509Certificate2` certificate following the guidelines available on the [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificate2.-ctor).

### Utilizing PdfSignature With X509Certificate2

IronPDF mandates the use of `X509Certificate2` objects configured with **X509KeyStorageFlags** as **Exportable** for its digital signing methods. Note that attempting to use certificates not set as Exportable may trigger an exception indicating that the operation is unsupported.

```cs
using System.Security.Cryptography.X509Certificates;
using IronPdf;
namespace ironpdf.Signing
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>foo</h1>");

            // Instantiate X509Certificate2 with Exportable KeyStorageFlags
            X509Certificate2 cert = new X509Certificate2("IronSoftware.pfx", "123456", X509KeyStorageFlags.Exportable);

            // Generate PdfSignature instance
            var sig = new PdfSignature(cert);

            // Sign the PDF
            pdf.Sign(sig);

            pdf.SaveAs("signed.pdf");
        }
    }
}
```

### Augmenting Detail in PdfSignature

Details such as dates, contact information, signing reasons, and graphical representations can be added to the `PdfSignature` both during and after its creation.

Supports timestamping servers that are compliant with SHA256 and SHA512 standards. 

```cs
using System;
using IronPdf;
namespace ironpdf.Signing
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>foo</h1>");

            pdf.SaveAs("signed.pdf");

            // Initialize PdfSignature
            var sig = new PdfSignature("IronSoftware.pfx", "123456");

            // Embed additional details into PdfSignature
            sig.SignatureDate = new DateTime(2000, 12, 02);
            sig.SigningContact = "IronSoftware";
            sig.SigningLocation = "Chicago";
            sig.SigningReason = "How to guide";
            sig.TimestampHashAlgorithm = TimestampHashAlgorithms.SHA256;
            sig.TimeStampUrl = "http://timestamp.digicert.com";
            sig.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

            // Finalize signing and save
            sig.SignPdfFile("signed.pdf");
        }
    }
}
```

<div class="alert alert-info iron-variant-1" role="alert">

Your organization may be investing excessively in annual subscriptions for PDF security and compliance. Check out [IronSecureDoc from Iron Software](https://ironsoftware.com/enterprise/securedoc/), offering one-time payment solutions for SaaS services including digital signing, redaction, encryption, and protection. Delve into the capabilities further by exploring the [IronSecureDoc Documentation](https://ironsoftware.com/enterprise/securedoc/docs/).

</div>

### Clarifying PDF Signing Options with IronPDF

There is often confusion among developers about the various ways to incorporate signatures into PDF documents using IronPDF. The term "signing" can encompass several different methods, each serving unique needs:

1. <a href="#anchor-sign-a-pdf-with-a-digital-certificate">Digitally signing a PDF with a certificate to ensure its integrity remains intact.</a>
2. <a href="#anchor-stamp-a-signature-onto-a-pdf">Integrating a graphical handwritten signature from an image file into a PDF.</a>
3. <a href="#anchor-stamp-a-signature-onto-a-pdf">Embedding a digital certificate's image into a PDF.</a>
4. <a href="#anchor-add-a-signature-form-field-to-a-pdf">Adding a signature form field that can be activated by certain PDF viewers for signing.</a>

## Digitally Signing PDF Documents with IronPDF

IronPDF offers robust capabilities for applying digital signatures to PDF documents, accommodating both `.pfx` and `.p12` certificate formats. This tutorial delves into the **three primary techniques** for digitally signing PDF files using IronPDF:

<style type="text/css">
.tg  {border-collapse:collapse;border-color:#ccc;border-spacing:0;}
.tg td{background-color:#fff;border-color:#ccc;border-style:solid;border-width:1px;color:#333;
  font-family:Arial, sans-serif;font-size:14px;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{background-color:#f0f0f0;border-color:#ccc;border-style:solid;border-width:1px;color:#333;
  font-family:Arial, sans-serif;font-size:14px;font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-u0o7{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-fymr{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
</style>
<table class="tg">
<thead>
  <tr>
    <th class="tg-fymr">Method of Signing</th>
    <th class="tg-u0o7">Method Description</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td class="tg-0pky">Sign</td>
    <td class="tg-0pky">Utilizes the <strong>PdfSignature object</strong> to sign the PDF document securely.</td>
  </tr>
  <tr>
    <td class="tg-0pky">SignWithFile</td>
    <td class="tg-0pky">Employs a digital signature certificate (.pfx or .p12) stored on the disk to sign the PDF document.</td>
  </tr>
  <tr>
    <td class="tg-0pky">SignWithStore</td>
    <td class="tg-0pky">Implements signature from the digital certificate retrieved from the system's signature repository, using a specific <strong>thumbprint ID</strong>.</td>
  </tr>
</tbody>
</table>

<style type="text/css">

```css
/* Table styles for clear visualization of data */
.tg {
  border-collapse: collapse; /* Remove spaces between borders */
  border-color: #ccc; /* Set border color */
  border-spacing: 0; /* Remove spacing between cells */
}

/* Styles for table data cells */
.tg td {
  background-color: #fff; /* Set background color */
  border-color: #ccc; /* Border color */
  border-style: solid; /* Solid line border */
  border-width: 1px; /* Border width */
  color: #333; /* Text color */
  font-family: Arial, sans-serif; /* Font family */
  font-size: 14px; /* Font size */
  overflow: hidden; /* Hide overflowing content */
  padding: 10px 5px; /* Padding inside cell */
  word-break: normal; /* Normal word breaking */
}

/* Styles for table header cells */
.tg th {
  background-color: #f0f0f0; /* Light grey background */
  border-color: #ccc; /* Border color */
  border-style: solid; /* Solid line border */
  border-width: 1px; /* Border width */
  color: #333; /* Text color */
  font-family: Arial, sans-serif; /* Font family */
  font-size: 14px; /* Font size */
  font-weight: normal; /* Normal font weight */
  overflow: hidden; /* Hide overflowing content */
  padding: 10px 5px; /* Padding inside cell */
  word-break: normal; /* Normal word breaking */
}

/* Custom class for main heading cells */
.tg .tg-u0o7 {
  border-color: inherit; /* Inherit border color */
  font-weight: bold; /* Bold text */
  text-align: left; /* Left text alignment */
  vertical-align: top; /* Top vertical alignment */
}

/* Custom class for subheading cells */
.tg .tg-fymr {
  border-color: inherit; /* Inherit border color */
  font-weight: bold; /* Bold text */
  text-align: left; /* Left text alignment */
  vertical-align: top; /* Top vertical alignment */
}

/* Custom class for standard data cells */
.tg .tg-0pky {
  border-color: inherit; /* Inherit border color */
  text-align: left; /* Left text alignment */
  vertical-align: top; /* Top vertical alignment */
}
```

</style>
<table class="tg">
<thead>
  <tr>
    <th class="tg-fymr">Signing Method</th>
    <th class="tg-u0o7">Description</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td class="tg-0pky">Sign</td>
    <td class="tg-0pky">Sign a PDF with a <strong>PdfSignature object</strong></td>
  </tr>
  <tr>
    <td class="tg-0pky">SignWithFile</td>
    <td class="tg-0pky">Sign PDF with a digital signature certificate(.pfx or .p12) on disk</td>
  </tr>
  <tr>
    <td class="tg-0pky">SignWithStore</td>
    <td class="tg-0pky">Signs the PDF with digital signature extracted from your computer's signature storage. <strong>Based on a thumbprint ID</strong></td>
  </tr>
</tbody>
</table>

### Compatible Digital Signature Formats

IronPDF adheres to the `X509Certificate2` standard and supports digital signatures in `.pfx` and `.p12` file formats. If you encounter issues with applying your signature using the available methods in IronPDF, it may be necessary to generate a `X509Certificate2` certificate. Detailed guidelines for this process can be accessed through the [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificate2.-ctor).

### Create a PdfSignature from an X509Certificate2

IronPDF supports digital signing using `X509Certificate2` objects, provided the **X509KeyStorageFlags** are set to **Exportable**.

- The library specifically requires the use of **X509KeyStorageFlags.Exportable** when handling certificates. While some certificates might be preset with these flags, attempting to utilize any non-exportable flags will lead to an exception: Internal.Cryptography.CryptoThrowHelper.WindowsCryptographicException: 'The requested operation is not supported.'

Here's the paraphrased version of the provided C# code section, maintaining its original logic and structure but using varied naming and comments for clarity:

```cs
using System.Security.Cryptography.X509Certificates;
using IronPdf;
namespace ironpdf.SignatureProcessing
{
    public class SignatureDemo
    {
        public void Execute()
        {
            // Initialize the PDF renderer
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
            // Generate a PDF from HTML content
            PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>foo</h1>");

            // Set up the digital certificate with exportable key storage flags
            X509Certificate2 certificate = new X509Certificate2("IronSoftware.pfx", "123456", X509KeyStorageFlags.Exportable);

            // Configure PDF signature using the specified certificate
            PdfSignature signature = new PdfSignature(certificate);

            // Apply the digital signature to the PDF
            document.Sign(signature);

            // Save the digitally signed PDF
            document.SaveAs("signed.pdf");
        }
    }
}
```

This rewritten code segment effectively demonstrates the process of digitally signing a PDF using IronPDF, from rendering the document to applying the digital signature and saving the signed PDF. The variable names and comments have been adjusted for enhanced readability and understanding.

### PdfSignature: Enhance with Detailed Information

During the creation of a `PdfSignature` or even post-creation, you can enrich the `PdfSignature` object with crucial details such as signing date, contact person, location, purpose of signing, and timing, as well as incorporating a visual aspect in the form of an image onto the PDF.

This feature is compatible with timestamping servers that utilize either SHA256 or SHA512 protocols.

```cs
using System;
using IronPdf;
namespace ironpdf.Signing
{
    public class DetailedSignatureSection
    {
        public void Execute()
        {
            // Initialize a renderer for creating the PDF
            ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
            // Render an HTML string into a PDF document
            PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>Welcome</h1>");

            // Save the PDF to a file
            document.SaveAs("detailed-signed.pdf");

            // Instantiate a new PdfSignature using a PFX file
            PdfSignature signature = new PdfSignature("IronSoftware.pfx", "123456");

            // Setting the detailed information for the signature
            signature.SignatureDate = new DateTime(2000, 12, 02); // Date of the signature
            signature.SigningContact = "IronSoftware"; // Contact name
            signature.SigningLocation = "Chicago"; // Location of signing
            signature.SigningReason = "Documentation Example"; // Reason for signing
            signature.TimestampHashAlgorithm = TimestampHashAlgorithms.SHA256; // Hash algorithm for timestamp
            signature.TimeStampUrl = "http://timestamp.digicert.com"; // URL of the timestamping service
            signature.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100)); // Adding an image to the signature

            // Apply the signature to the PDF and save it
            signature.SignPdfFile("detailed-signed.pdf");
        }
    }
}
```

### Demonstrative Example

```html
<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/signing/granular-information.png" alt="Viewing Signer detail" class="img-responsive add-shadow">
    </div>
</div>
```

In instances where Adobe does not verify the PDF's authenticity or integrity because the certificate is not included, you might notice either an exclamation mark or a warning sign instead of a checkmark. To resolve this and show a checkmark, please add the certificate into Adobe and reload the document.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="/static-assets/pdf/how-to/signing/granular-information.png" alt="Viewing Signer detail" class="img-responsive add-shadow">
    </div>
</div>

Occasionally, an exclamation mark or warning icon may appear in place of a check mark. This issue occurs when Adobe is unable to verify the document’s authenticity and integrity due to the absence of the certificate. To resolve this, add the certificate to Adobe and reload the document.

### Diverse Approaches for Including Images

There are multiple techniques to incorporate images into your document:

- Define the **SignatureImage** by initiating a new PdfSignatureImage instance.

- Employ the `LoadSignatureImageFromFile` function to import an image directly from a file, supporting a wide array of image formats.

- Utilize the `LoadSignatureImageFromStream` function to integrate an image from a stream. This stream can originate from various libraries, provided the image conforms to formats like TGA, PBM, TIFF, BMP, GIF, PNG, JPEG, or Webp.

```cs
using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.Signing
{
    public class Section3
    {
        public void Run()
        {
            // Initialize a PdfSignature instance
            var signature = new PdfSignature("IronSoftware.pfx", "123456");

            // Directly add a signature image to the PdfSignature instance
            signature.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

            // Use LoadSignatureImageFromFile method to incorporate a signature image
            signature.LoadSignatureImageFromFile("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

            // Utilize IronSoftware.Drawing to import an image
            AnyBitmap importedImage = AnyBitmap.FromFile("IronSoftware.png");

            // Stream the imported image directly into the signature
            signature.LoadSignatureImageFromStream(importedImage.ToStream(), 0, new Rectangle(0, 600, 100, 100));
        }
    }
}
```

### Managing Signature Permissions

When setting up your digital signature, it's possible to define the specific conditions that must be met to keep the signature valid. If your preference is to have the signature voided if any modifications are made, or perhaps just allowing modifications to form fields, review the options in the table below to understand the different permissions available:

<style type="text/css">
.tg  {border-collapse:collapse;border-color:#ccc;border-spacing:0;}
.tg td{background-color:#fff;border-color:#ccc;border-style:solid;border-width:1px;color:#333;
  font-family:Arial, sans-serif;font-size:14px;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{background-color:#f0f0f0;border-color:#ccc;border-style:solid;border-width:1px;color:#333;
  font-family:Arial, sans-serif;font-size:14px;font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-u0o7{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
</style>
<table class="tg">
<thead>
  <tr>
    <th class="tg-u0o7">PdfDocument.SignaturePermissions</th>
    <th class="tg-u0o7">Explanation</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td class="tg-0pky">NoChangesAllowed</td>
    <td class="tg-0pky">No modifications are allowed under any circumstance.</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAllowed</td>
    <td class="tg-0pky">Only changes to form field values are permitted.</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAndAnnotationsAllowed</td>
    <td class="tg-0pky">Changes to form field values and annotations are permitted.</td>
  </tr>
</tbody>
</table>

The use of these settings is optional, but not specifying them will result in a signature that secures a particular revision of the document and will be voided if any unauthorized alterations are made.

<style type="text/css">

Here is the paraphrased section describing the table's CSS styles which determine the visual presentation of tables used in the document:

```css
/* Table style that collapses borders between cells and uses a light gray border. */
.table-style {
  border-collapse: collapse;
  border-color: #ccc;
  border-spacing: 0;
}

/* Table cells have a white background, light gray border, and padding for text. */
.table-style td {
  background-color: #fff;
  border-color: #ccc;
  border-style: solid;
  border-width: 1px;
  color: #333;
  font-family: Arial, sans-serif;
  font-size: 14px;
  overflow: hidden;
  padding: 10px 5px;
  word-break: normal;
}

/* Table headers have a light gray background, matching cell styling, and normal font weight. */
.table-style th {
  background-color: #f0f0f0;
  border-color: #ccc;
  border-style: solid;
  border-width: 1px;
  color: #333;
  font-family: Arial, sans-serif;
  font-size: 14px;
  font-weight: normal;
  overflow: hidden;
  padding: 10px 5px;
  word-break: normal;
}

/* Styles specifically for bold left-aligned text in certain table headers. */
.table-style .header-bold-left {
  border-color: inherit;
  font-weight: bold;
  text-align: left;
  vertical-align: top;
}

/* Styles for standard left-aligned text in table cells. */
.table-style .text-left-top {
  border-color: inherit;
  text-align: left;
  vertical-align: top;
}
```

This revised CSS maintains the original formatting intent but uses different class names and a more standardized comment system to enhance readability and maintenance.

</style>
<table class="tg">
<thead>
  <tr>
    <th class="tg-u0o7">PdfDocument.SignaturePermissions</th>
    <th class="tg-u0o7">Definition</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td class="tg-0pky">NoChangesAllowed</td>
    <td class="tg-0pky">No changes are allowed</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAllowed</td>
    <td class="tg-0pky">Changing form field values allowed</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAndAnnotationsAllowed</td>
    <td class="tg-0pky">Changing form field values and modifying annotations allowed</td>
  </tr>
</tbody>
</table>

This setting is not required, and if left unspecified, it will establish a signature that certifies a particular revision of the document, making it irreversible.

### Preserving and Signing Modifications in a PDF

In the outlined walkthrough below, we begin by loading an existing PDF document and then we make several modifications to it. Prior to saving these changes, we apply a digital signature. This procedure enables form filling in subsequent editions while invalidating the signature if any other modifications are made.

Following this, we invoke the `SaveAsRevision` method to commit these changes to the file's revision history. Lastly, the updated version of the document is saved to storage.

Here's the paraphrased section with absolute URL paths resolved:

```cs
using IronPdf.Rendering;
using IronPdf;
namespace ironpdf.Signing
{
    public class EditAndSignSection
    {
        public void Execute()
        {
            // Load the PDF document and activate change tracking
            PdfDocument document = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
            // Edit the document as needed
            document.SignWithFile("https://www.ironsoftware.com/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);

            // Create a new version of the PDF document
            PdfDocument updatedDocument = document.SaveAsRevision();

            // Save the revised document
            updatedDocument.SaveAs("annual_census_revised.pdf");
        }
    }
}
```

In this revised example, the code comments are updated for better clarity and the method, and class names are slightly altered to provide a fresh perspective while maintaining the original meaning and functionality. The URL path to the digital certificate file has also been updated to an absolute path.

### Understanding Incremental Saving for Signatures

While basic PDF viewers like those in Chrome display only the current version of a PDF, the format itself supports storing multiple versions or revisions, akin to tracking changes in a version control system like Git. This is visible in more sophisticated PDF viewers, such as Adobe Acrobat.

It's crucial to grasp this feature when working with PDF signatures. This is because the signature is associated with a specific version of the document. Thus, a PDF may have signatures tied to its earlier versions, as well as some versions that remain unsigned. Below is a conceptual visualization of this process:

<style type="text/css">

Here is the paraphrased section of the article incorporating the resolved URL paths and improved formatting:

```html
<style type="text/css">
.tg {border-collapse:collapse; border-spacing:0;}

.tg td {border-style:solid; border-width:1px; font-family:Arial, sans-serif; font-size:14px; padding:10px 5px; word-break:normal; overflow:hidden; }

.tg th {border-color:black; border-style:solid; border-width:1px; font-family:Arial, sans-serif; font-size:14px; padding:10px 5px; word-break:normal; overflow:hidden; font-weight:normal;}

.tg .tg-italic {border-color:inherit; font-style:italic; text-align:center; vertical-align:top}

.tg .tg-center {text-align:center; vertical-align:top; border-color:inherit;}

.tg .tg-bold-center {border-color:inherit; font-weight:bold; text-align:center; vertical-align:top}

.tg .tg-bold-left {border-color:inherit; font-weight:bold; text-align:left; vertical-align:top}

.tg .tg-left {border-color:inherit; text-align:left; vertical-align:top}

.tg .tg-italic-center {font-style:italic; text-align:center; vertical-align:top}

.tg .tg-left-center {text-align:left; vertical-align:top}
</style>
```

This revised section maintains the same stylistic and functional aspects, but the class names have been simplified and made more descriptive, facilitating easier reference and interpretation.

</style>
<table class="tg">
<thead>
  <tr>
    <th class="tg-7btt">PDF Document Iteration</th>
    <th class="tg-7btt">Certificate A</th>
    <th class="tg-7btt">Certificate B</th>
    <th class="tg-7btt">Certificate C</th>
    <th class="tg-7btt">Certificate D</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td class="tg-8bgf">0 (first save)</td>
    <td class="tg-c3ow">✅</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">1</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">2</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-5frq">3</td>
    <td class="tg-baqh">✅<br>(form field edits only)</td>
    <td class="tg-baqh">✅<br>(form field edits only)</td>
    <td class="tg-0lax"></td>
    <td class="tg-0lax"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">4 (only form fields edited)</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-c3ow">✅</td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">5</td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
  </tr>
</tbody>
</table>

The document described has undergone six revisions, being circulated among different company departments for approvals until solidifying at iteration three. At this stage, both Person A and Person B have authenticated the document, setting permissions to "Form Field Edits Only." This setting permits modifications to the form fields alone, with any other alterations potentially rendering the signatures void.

In the scenario presented, it's understood that Person C completed the form and returned it to Persons A, B, and D, who then each affixed their signatures under a "No Edits Allowed" condition. Given that the document was unaltered in ways that would compromise its integrity, executing IronPDF's signature validation method on the document would yield a result of **true**.

### Reverting to a Previous PDF Revision

To revert a PDF to an earlier revision, employ the `GetRevision` method from IronPDF. This functionality discards all modifications (including new signatures) that occurred after the specified revision. Here's how you can perform this rollback:

```cs
using IronPdf;
namespace ironpdf.Signing
{
    public class UndoChanges
    {
        public void Execute()
        {
            // Load a PDF file
            PdfDocument originalPdf = PdfDocument.FromFile("report.pdf");

            // Display the total number of revisions
            int totalRevisions = originalPdf.RevisionCount;

            // Retrieve the third version (index 2) of the PDF
            PdfDocument revertedPdf = originalPdf.GetRevision(2);

            // Save the reverted PDF as a new file
            revertedPdf.SaveAs("report-draft.pdf");
        }
    }
}
```

### Erasing Signatures from a PDF Document

The IronPDF library provides a functionality named `RemoveSignatures` designed to eliminate every signature across all revisions within a PDF file. Here's how you can employ this method:

```cs
using IronPdf;
namespace ironpdf.Signing
{
    public class Section6
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("invoice.pdf");
            
            // Use the RemoveSignatures method to delete all signatures
            pdf.RemoveSignatures();
        }
    }
}
```

Here's the paraphrased section of the article with the relative URL paths resolved to ironpdf.com:

```cs
using IronPdf;
namespace ironpdf.Signing
{
    public class RemoveAllSignatures
    {
        public void Execute()
        {
            // Load a PDF from file
            PdfDocument document = PdfDocument.FromFile("invoice.pdf");

            // Remove all signatures from the PDF document
            document.RemoveSignatures();
        }
    }
}
```

### Verifying All Signatures in a PDF

To ensure the integrity of a PDF, you can use IronPDF's method to check the validation of every signature across every revision of the document. If all signatures are confirmed to be valid, the method will return a `bool` value of `true`.

Here's the paraphrased section with modified code example and paths resolved to `ironpdf.com`:

```cs
using IronPdf;
namespace ironpdf.Signing
{
    public class SignatureVerification
    {
        public void Execute()
        {
            // Load a PDF document
            PdfDocument document = PdfDocument.FromFile("annual_census.pdf");
            
            // Verify the validity of all signatures in the document
            bool isAllSignaturesValid = document.VerifyPdfSignatures();
        }
    }
}
```

## Applying a Handwritten Signature to a PDF

Let's dive into the process of signing a PDF document. For demonstration purposes, we'll be using a sample invoice PDF, as shown below:

<iframe loading="lazy" src="https://ironsoftware.com/static-assets/pdf/how-to/signing/invoice.pdf#view=fit" width="100%" height="500px"></iframe>

We aim to add a handwritten signature, typically saved as a `.png` image file, which could either represent an actual handwritten signature or be utilized as the visual representation for a digital certificate. Here's the example signature image used:

<img src="https://ironsoftware.com/static-assets/pdf/how-to/signing/signature.png" alt="" class="img-responsive add-shadow">

### Implementation Code

To add the signature to the PDF as a watermark, we employ the following method:

```cs
using IronPdf.Editing;
using IronPdf;

namespace ironpdf.Signing
{
    public class Section8
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("invoice.pdf");
            
            // Apply a watermark signature at the specified location
            pdf.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);
            
            // Save the signed PDF
            pdf.SaveAs("official_invoice.pdf");
        }
    }
}
```

### Resulting Document

Following the execution of the above code, the PDF document will be stamped with the signature at the designated bottom right corner. Here's the output PDF featuring the signed invoice:

<iframe loading="lazy" src="https://ironsoftware.com/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px"></iframe>

<iframe loading="lazy" src="/static-assets/pdf/how-to/signing/invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

We're going to add a handwritten signature, which is a `.png` image, to our PDF document. This could either be an actual handwritten signature or an image used in generating a certificate file. Below is the example signature we'll be using:

<img src="/static-assets/pdf/how-to/signing/signature.png" alt="" class="img-responsive add-shadow">

```cs
using IronPdf.Editing;
using IronPdf;

namespace ironpdf.Signing
{
    public class Section8
    {
        public void Run()
        {
            var pdf = PdfDocument.FromFile("invoice.pdf");
            
            // Apply a watermark using a signature image
            pdf.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);
            
            // Save the PDF document with the watermark
            pdf.SaveAs("official_invoice.pdf");
        }
    }
}
```

Here is the paraphrased markdown content for the specified code section:

```cs
using IronPdf;
using IronPdf.Editing;
namespace ironpdf.Signing {
    public class Section8 {
        public void Execute() {
            var document = PdfDocument.FromFile("invoice.pdf");
            
            // Applying a watermark using a signature image
            document.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);
            
            // Saving the document with the applied signature
            document.SaveAs("official_invoice.pdf");
        }
    }
}
```

### Resulting Output

Upon executing the code provided, the resultant file will display our signature prominently positioned at the bottom right corner.

<iframe loading="lazy" src="/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

## Add an Unsigned Signature Field to a PDF

Currently, adding an unsigned signature field to a PDF is not available. For additional details on what IronPDF supports, including its form features, check out the [IronPDF Forms and Features Article](https://ironpdf.com/blog/using-ironpdf/programmatically-fill-pdf-form-csharp/).

