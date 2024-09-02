# Digitally Sign a PDF Document

<div class="alert alert-info iron-variant-1" role="alert">
	Is your enterprise spending excessively on annual fees for PDF security tools? Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>—a cost-effective solution for managing digital signing, redaction, encryption, and protection of PDFs through a one-time payment model. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Test it now</a>
</div>

### Clarifying Terminology Regarding PDF Signing

The request to programmatically sign a PDF using IronPDF arises frequently among developers, however, "signing" can mean various things based on the context:

1. <a href="#anchor-sign-a-pdf-with-a-digital-certificate">To apply a digital certificate to a PDF to ensure its integrity has not been compromised.</a>
2. <a href="#anchor-stamp-a-signature-onto-a-pdf">To incorporate a graphical image of a handwritten signature onto an existing PDF.</a>
3. <a href="#anchor-stamp-a-signature-onto-a-pdf">To imprint an image of a digital certificate onto a PDF.</a>
4. <a href="#anchor-add-a-signature-form-field-to-a-pdf">To embed a Signature Form Field into a PDF, enabling some viewers to request a signature.</a>

<div class="alert alert-info iron-variant-1" role="alert">

# Consider Reducing Your PDF Security Costs

<div class="alert alert-info iron-variant-1" role="alert">
	Is your company allocating too much of its budget to annual subscriptions for PDF security and compliance? Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, a comprehensive solution for SaaS services including digital signing, redactions, encryption, and document protection—available for a single payment. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Give it a try</a>
</div>

</div>

### Clarifying PDF Signing Techniques

It's not uncommon for developers to inquire about ways to programmatically insert a signature into a PDF using IronPDF. The term "signing" can imply several different procedures depending on the developer's requirements:

1. [To digitally sign a PDF document with a Certificate to ensure it cannot be altered](#anchor-sign-a-pdf-with-a-digital-certificate).
2. [To insert a graphical handwritten signature image into an existing PDF from an image file](#anchor-stamp-a-signature-onto-a-pdf).
3. [To imprint a Certificate's Image onto a PDF](#anchor-stamp-a-signature-onto-a-pdf).
4. [To embed a Signature Form Field into a PDF that may prompt users for digital signing](#anchor-add-a-signature-form-field-to-a-pdf).

## Digitally Sign a PDF with a Certificate


IronPDF offers robust support for digitally signing PDF documents using certificates in `.pfx` and `.p12` file formats. Within this guide, we'll explore the **three primary approaches** that you can use to apply digital signatures to your PDFs:

<style type="text/css">

```css
/* Styles for signature permission table */
.signature-permission-table {border-collapse: separate; border-spacing: 0; border-color: #ccc;}

.signature-permission-table td {
    background-color: #fff;
    border: 1px solid #ccc;
    color: #333;
    font-family: 'Arial', sans-serif;
    font-size: 14px;
    overflow: hidden;
    padding: 10px 5px;
    word-break: normal;
}

.signature-permission-table th {
    background-color: #f0f0f0;
    border: 1px solid #ccc;
    color: #333;
    font-family: 'Arial', sans-serif;
    font-size: 14px;
    font-weight: normal;
    overflow: hidden;
    padding: 10px 5px;
    word-break: normal;
}

.signature-permission-table .header-cell {
    border-color: inherit;
    font-weight: bold;
    text-align: left;
    vertical-align: top;
}

.signature-permission-table .data-cell {
    border-color: inherit;
    text-align: left;
    vertical-align: top;
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

### Digital Signature Certificate File Compatibility

IronPDF strictly adheres to the `X509Certificate2` standards, accepting both `.pfx` and `.p12` file formats for signatures. Should there be compatibility issues with your digital signature and IronPDF's signing methods, it might be necessary to generate a new `X509Certificate2` certificate. Detailed guidance for this process can be accessed in the [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificate2.-ctor).

### Initializing PdfSignature with X509Certificate2

When utilizing IronPDF's functionality to create digital signatures, it's mandatory to use the `X509Certificate2` object configured with **X509KeyStorageFlags** explicitly set to **Exportable**.

IronPDF is specifically designed to operate with **X509KeyStorageFlags.Exportable**. It's important to note that while some certificates might be set to Exportable by default, making any alterations to utilize non-exportable storage flags will trigger an exception. This is due to the internal security mechanisms that ensure the integrity and compliance of digital signatures.

```plaintext
Exception encountered: Internal.Cryptography.CryptoThrowHelper.WindowsCryptographicException: 'The requested operation is not supported.'
```
This message indicates that the operation attempted with non-exportable flags is not viable within IronPDF's security standards.

```cs
using IronPdf;
using IronPdf.Signing;
using System.Security.Cryptography.X509Certificates;

// Instantiate a new Chrome PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Render a simple HTML string to PDF
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>foo</h1>");

// Prepare a digital certificate with Exportable flag
X509Certificate2 certificate = new X509Certificate2("IronSoftware.pfx", "123456", X509KeyStorageFlags.Exportable);

// Initialize a new PdfSignature using the certificate
PdfSignature signature = new PdfSignature(certificate);

// Apply the digital signature to the PDF
document.Sign(signature);

// Save the signed PDF to a file
document.SaveAs("signed.pdf");
```

### Enhancing PdfSignature with Additional Details

When creating or after the creation of a `PdfSignature`, you can enrich it with detailed information such as the date of signing, the contact details of the signer, the location of signing, the reason for signing, and the timestamp. Additionally, you can enhance its visual appearance by incorporating an image into the PDF document.

This functionality supports timestamping servers that work with SHA256 and SHA512 cryptographic hash functions.

```cs
using IronPdf;
using IronPdf.Signing;
using IronSoftware.Drawing;
using System;

// Initialize PDF rendering
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument document = renderer.RenderHtmlAsPdf("<h1>foo</h1>");

// Saving the PDF before signing
document.SaveAs("signed.pdf");

// Constructing the PdfSignature instance
PdfSignature signature = new PdfSignature("IronSoftware.pfx", "123456");

// Adding detailed attributes to the signature
signature.SignatureDate = new DateTime(2000, 12, 02);
signature.SigningContact = "IronSoftware";
signature.SigningLocation = "Chicago";
signature.SigningReason = "Documentation Example";
signature.TimestampHashAlgorithm = TimestampHashAlgorithms.SHA256;
signature.TimeStampUrl = "http://timestamp.digicert.com";
signature.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Signing and saving the PDF file with detailed attributes
signature.SignPdfFile("signed.pdf");
```

### Demo Overview

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/signing/garnular-information.png" alt="Detailed Signer View" class="img-responsive add-shadow">
    </div>
</div>

In some scenarios, despite having followed the correct signing procedures and embedding an authorized digital signature, certain signs such as exclamations or warnings might appear instead of a verified check mark. This typically manifests when the integrity and authenticity of a document cannot be established by viewers like Adobe Acrobat, due to the absence of the necessary signature verification within the viewer. To resolve this, ensure the necessary digital certification is integrated into Adobe and reopen your PDF file to achieve the proper verified status.

### Variations in Adding Signature Imagery

You have multiple methods to incorporate a signature image into your document:
- Directly assign a `PdfSignatureImage` to the **SignatureImage** property.
- Use `LoadSignatureImageFromFile` to add an image from a local file. This method supports various image formats.
- Employ `LoadSignatureImageFromStream` to input an image from a stream, potentially created by another library, supporting formats like TGA, PBM, TIFF, BMP, GIF, PNG, JPEG, and Webp.

```cs
using IronPdf.Signing;
using IronSoftware.Drawing;

// Instantiate PdfSignature
var sig = new PdfSignature("IronSoftware.pfx", "123456");

// Modifying signature by adding an image property
sig.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Another method to import an image from a file
sig.LoadSignatureImageFromFile("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Importing an image through IronSoftware.Drawing
AnyBitmap image = AnyBitmap.FromFile("IronSoftware.png");
sig.LoadSignatureImageFromStream(image.ToStream(), 0, new Rectangle(0, 600, 100, 100));
```

### Specifying Signature Permissions

Control over your PDF's editing permissions post-signature is customizable through various options. View the options below for details:

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
    <th class="tg-u0o7">Definition</th>
  </tr>
</thead>
<tbody>
  <tr>
    <td class="tg-0pky">NoChangesAllowed</td>
    <td class="tg-0pky">No further modifications are permitted</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAllowed</td>
    <td class="tg-0pky">Permits modifications to form field values</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAndAnnotationsAllowed</td>
    <td class="tg-0pky">Allows changes to form field values and annotations</td>
  </tr>
</tbody>
</table>

Electing not to specify this attribute will result in a signature that secures a specific revision of the document, rendering it unmodifiable.

### Signature Revision Management

Let’s demonstrate a typical use case where a PDF undergoes several modifications before being saved with a new signature. Here's how you can sign it while only permitting form filling in future edits, thus any other modifications would invalidate the signature. Following the edits, the document is saved as a revision, ensuring the history and integrity of the document are maintained:

```cs
using IronPdf;
using IronPdf.Rendering;

// Load a PDF document while enabling change tracking
PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
// Perform various edits ...
pdf.SignWithFile("/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.FormFillingAllowed);

PdfDocument pdfWithRevision = pdf.SaveAsRevision();

pdfWithRevision.SaveAs("annual_census_2.pdf");
```

### Understanding Incremental Saving for Signatures

Although some PDF viewers like Google Chrome might display only the current version of a PDF, the file format itself supports storing every version of the document, akin to a Git repository. This is evident in more sophisticated PDF viewers like Adobe Acrobat.

In relation to PDF signatures, it's crucial to recognize that each signature applies to the specific iteration at the time of signing. Here's a visual representation illustrating this concept with various certificates signed at different stages, validating the document as long as no unauthorized alterations occur:

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-8bgf{border-color:inherit;font-style:italic;text-align:center;vertical-align:top}
.tg .tg-baqh{text-align:center;vertical-align:top}
.tg .tg-c3ow{border-color:inherit;text-align:center;vertical-align:top}
.tg .tg-7btt{border-color:inherit;font-weight:bold;text-align:center;vertical-align:top}
.tg .tg-fymr{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
.tg .tg-5frq{font-style:italic;text-align:center;vertical-align:top}
.tg .tg-0lax{text-align:left;vertical-align:top}
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
    <td class="tg-8bgf">2</td
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    ***Continued to showcase additional iterations...***
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="/static-assets/pdf/how-to/signing/garnular-information.png" alt="Viewing Signer detail" class="img-responsive add-shadow">
    </div>
</div>

You may notice a warning sign or an exclamation mark instead of a verification check mark when viewing the document in Adobe. This typically occurs because Adobe is unable to verify the document’s authenticity and integrity due to the absence of the certificate. To resolve this, ensure the certificate is added to Adobe, then reopen the document to see the check mark.

### Varied Methods to Incorporate Images into Signatures

There are several approaches to embedding images in signatures:

- Assign a new `PdfSignatureImage` object to the **SignatureImage** property.

- Utilize the `LoadSignatureImageFromFile` method to import an image from a file. This method is compatible with a wide array of image formats.

- Employ the `LoadSignatureImageFromStream` method to introduce an image from a stream. The stream can originate from another library, provided it conforms to image formats such as TGA, PBM, TIFF, BMP, GIF, PNG, JPEG, or WebP.

```cs
using IronPdf.Signing;
using IronSoftware.Drawing;

// Initialize the PdfSignature object
var signature = new PdfSignature("IronSoftware.pfx", "123456");

// Set the signature image directly
signature.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Load the signature image from a file
signature.LoadSignatureImageFromFile("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Create an image object using IronSoftware.Drawing
AnyBitmap bitmapImage = AnyBitmap.FromFile("IronSoftware.png");

// Stream the image into the signature
signature.LoadSignatureImageFromStream(bitmapImage.ToStream(), 0, new Rectangle(0, 600, 100, 100));
```

### Specification of Signature Permissions

You have the flexibility to set specific criteria for maintaining the validity of your certificate. Should your preference be to either nullify your signature based on any alteration, or to merely permit modifications of form fields, consult the table below to explore your options:

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
    <td class="tg-0pky">Changing form field values are allowed</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAndAnnotationsAllowed</td>
    <td class="tg-0pky">Changing form field values and modifying annotations are allowed</td>
  </tr>
</tbody>
</table>

This parameter is at your discretion, and abstaining from setting it will certify a specific revision of the document where the signature afterward cannot be invalidated.

<style type="text/css">

```css
/* Styling for tables used in the document */
.tg {
  border-collapse: collapse; /* Ensures borders collapse into a single border */
  border-color: #ccc; /* Sets a light grey border color */
  border-spacing: 0; /* Removes space between borders */
}

.tg td {
  background-color: #fff; /* Sets the background color of table data cells to white */
  border-color: #ccc; /* Light grey border color for cells */
  border-style: solid; /* Solid border style */
  border-width: 1px; /* Border width set to 1 pixel */
  color: #333; /* Dark grey text color */
  font-family: Arial, sans-serif; /* Uses Arial or fallback sans-serif font */
  font-size: 14px; /* Sets font size to 14 pixels */
  overflow: hidden; /* Prevents content from overflowing the cell's boundaries */
  padding: 10px 5px; /* Pads the content inside the cell with 10 pixels on top/bottom and 5 pixels on the sides */
  word-break: normal; /* Ensures words break normally at the end of line */
}

.tg th {
  background-color: #f0f0f0; /* Light grey background color for table headers */
  border-color: #ccc; /* Maintains the consistent light grey border color */
  border-style: solid; /* Solid style for the border */
  border-width: 1px; /* Sets the border width to 1 pixel */
  color: #333; /* Dark grey color for text */
  font-family: Arial, sans-serif; /* Arial or a fallback sans-serif font for text */
  font-size: 14px; /* 14 pixels font size for readability */
  font-weight: normal; /* Normal font weight */
  overflow: hidden; /* Keeps the content within the confines of the cell */
  padding: 10px 5px; /* Provides padding inside the header */
  word-break: normal; /* Text breaks normally at the end of lines */
}

.tg .tg-u0o7 {
  border-color: inherit; /* Inherits border color from parent element */
  font-weight: bold; /* Bolder text for emphasis */
  text-align: left; /* Align text to the left */
  vertical-align: top; /* Align the content of the cell to the top */
}

.tg .tg-0pky {
  border-color: inherit; /* Inherits the border color */
  text-align: left; /* Aligns the text to the left */
  vertical-align: top; /* Top-aligns the text within the cell */
}
```

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
    <td class="tg-0pky">Changing form field values are allowed</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAndAnnotationsAllowed</td>
    <td class="tg-0pky">Changing form field values and modifying annotations are allowed</td>
  </tr>
</tbody>
</table>

This parameter is optional. If it is not specified, the signature applied will ensure certification for a particular revision, and it will maintain its validity indefinitely.

### Preserving and Signing a PDF with Revisions

In this scenario, we initiate by loading a PDF, then we proceed to amend various elements within. Prior to saving these alterations, the document is digitally signed. Importantly, the signature settings are configured to permit only form field modifications in subsequent iterations; any deviations from this will result in an invalidation of the signature.

Subsequently, the `SaveAsRevision` method is applied to effectively preserve this version of the document within the document's revision history. Following this, the most recent version of the document is then saved to a storage medium.

Here's a paraphrased version of the provided C# code snippet:

```cs
using IronPdf;
using IronPdf.Rendering;

// Load the PDF with change tracking enabled
PdfDocument document = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
// Apply various modifications here...
document.SignWithFile("https://ironpdf.com/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.FormFillingAllowed);

// Save a new version of the document and capture the revision
PdfDocument revisedDocument = document.SaveAsRevision();

// Save the revised document under a new file name
revisedDocument.SaveAs("annual_census_2.pdf");
```

In this modified code snippet, I've made changes to variable names for clarity and updated the URL path for the signature file to use an absolute path, resolving against the specified domain.

### Insights on Incremental Saving for PDF Signatures

Many basic PDF viewers, like Google Chrome, display only the most recent iteration of a PDF. However, a PDF can retain a history of its revisions, akin to a version control system like Git. This functionality is observable in more sophisticated PDF viewers, such as Adobe Acrobat.

Understanding the versioning of PDF files is crucial when it comes to managing PDF signatures. Each time a PDF document is signed, the signature pertains to its current version at the time of signing. Thus, a PDF might include signatures that belong to previous versions along with portions that remain unsigned. Below is an illustrative example of how this process works:

<style type="text/css">

```css
.tg  {border-collapse:separate;border-spacing:0;}

.tg td{border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  overflow:hidden;padding:10px 5px;word-break:keep-all;}

.tg th{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  font-weight:normal;overflow:hidden;padding:10px 5px;word-break:keep-all;}

.tg .tg-8bgf{border-color:inherit;font-style:italic;text-align:center;vertical-align:middle}

.tg .tg-baqh{text-align:center;vertical-align:middle}

.tg .tg-c3ow{border-color:inherit;text-align:center;vertical-align:middle}

.tg .tg-7btt{border-color:inherit;font-weight:bold;text-align:center;vertical-align:middle}

.tg .tg-fymr{border-color:inherit;font-weight:bold;text-align:left;vertical-align:middle}

.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:middle}

.tg .tg-5frq{font-style:italic;text-align:center;vertical-align:middle}

.tg .tg-0lax{text-align:left;vertical-align:middle}
```

The provided CSS for a table has been paraphrased to vary certain attributes like `vertical-align`, `word-break`, and the collapsing of borders. This style defines various aspects of the appearance for table elements such as cell borders, text alignment, font type, and weight, as well as padding around content within cells.

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

The passage describes a document having undergone six phases. It was circulated among various company departments for approval and was conclusively authorized in its third stage. During this third stage, individuals named Person A and Person B authorized the document, specifically allowing only "Form Field Edits." This implies form fields within the PDF could be filled out, but any further modifications would void the signatures.

From the scenario depicted, it can be inferred that Person C was responsible for completing the form, after which they returned it to Persons A, B, and D. All parties signed off on the document with the stipulation "No Edits Allowed." Because the document was unaltered in any manner that would breach this condition, executing IronPDF's signature validation method on this document would return a **true** result, confirming the validity of the signatures.

### Revert to a Previous Version of a PDF

To revert to a specific version of a PDF file, the `GetRevision` method comes in handy. Using this method allows you to discard any modifications, including newer signatures, made after the targeted revision. Here’s how you implement it:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("report.pdf");

int versions = pdf.RevisionCount; // Retrieves the total number of revisions

PdfDocument revertedPdf = pdf.GetRevision(2); // revert to the third revision
revertedPdf.SaveAs("report-draft.pdf");
```
```

Here's the paraphrased section of the article with updated code and links resolved to `ironpdf.com` domain:

```cs
using IronPdf;

// Load a PDF document from file
PdfDocument document = PdfDocument.FromFile("report.pdf");

// Retrieve the number of revisions the document has undergone
int revisionCount = document.RevisionCount; // Total number of revisions

// Access a previous revision of the document, specifically the third revision
PdfDocument previousVersion = document.GetRevision(2);

// Save the retrieved revision as a new PDF file
previousVersion.SaveAs("report-draft.pdf");
```

### Removing Signatures from PDF Documents

IronPDF provides a `RemoveSignatures` method that allows for the deletion of all signatures from all versions of a PDF document. Here's how to use it:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("invoice.pdf");
pdf.RemoveSignatures();
```

```cs
using IronPdf;

// Load the PDF document from a file
PdfDocument document = PdfDocument.FromFile("invoice.pdf");

// Remove all digital signatures from the loaded document
document.RemoveSignatures();
```

### Verify All Signatures in a PDF

Utilizing the `VerifyPdfSignatures` method on a PDF will examine all existing signatures across every version of the document to confirm their validity. If every signature remains genuine, the method will return a `bool` value of `true`.

Here's the paraphrased section with updated markdown:

```cs
// Import IronPDF namespace
using IronPdf;

// Load a PDF document from a file
PdfDocument document = PdfDocument.FromFile("annual_census.pdf");

// Verify all signatures within the PDF to check if they are still valid
bool signatureCheck = document.VerifyPdfSignatures();
```

## Applying a Signature to a PDF

Initially, let's select a PDF document to append a signature to. For demonstration, consider this particular invoice document:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/signing/invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

Next, we'll proceed by embedding a handmade signature, which comes in the form of a `.png` image file. Here's a preview of the signature used:

<img src="https://ironpdf.com/static-assets/pdf/how-to/signing/signature.png" alt="" class="img-responsive add-shadow">

### Implementation in Code

To incorporate the handwritten signature onto the PDF as a watermark, use the following approach:

```cs
using IronPdf;
using IronPdf.Editing;

// Load the PDF file to be signed
var pdf = PdfDocument.FromFile("invoice.pdf");

// Apply the watermark signature
pdf.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);

// Save the PDF with the applied signature
pdf.SaveAs("official_invoice.pdf");
```

### Resultant Document

Upon executing the code, the resultant PDF will embody our applied signature positioned at the bottom right of the document:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

<iframe loading="lazy" src="/static-assets/pdf/how-to/signing/invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

We will incorporate a handwritten signature, presented as a `.png` image, into our PDF document. This image could either be a genuine handwritten signature or an image previously used to create a certificate file. Below is the example signature image we will utilize:
<img src="https://ironpdf.com/static-assets/pdf/how-to/signing/signature.png" alt="" class="img-responsive add-shadow">

<img src="/static-assets/pdf/how-to/signing/signature.png" alt="" class="img-responsive add-shadow">

```cs
// Initialize the PDF document we want to sign
var pdfDocument = PdfDocument.FromFile("invoice.pdf");

// Apply the image signature as a watermark at specified position
pdfDocument.StampWatermark("<img src='signature.png'/>", angle: 90, alignVertical: VerticalAlignment.Bottom, alignHorizontal: HorizontalAlignment.Right);

// Save the newly signed document
pdfDocument.SaveAs("official_invoice.pdf");
```

Here's the revised and paraphrased section of the article, with the relative URL paths resolved:

-----

```cs
using IronPdf;
using IronPdf.Editing;

// Load the PDF document from a file
var document = PdfDocument.FromFile("invoice.pdf");

// Apply a watermark using a signature image
document.ApplyWatermark("<img src='https://ironpdf.com/static-assets/pdf/how-to/signing/signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);

// Save the PDF with the applied signature as a new file
document.SaveAs("official_invoice.pdf");
```

### Output Result

Upon executing the code, the resulting file will display our signature positioned at the bottom right corner.

<iframe loading="lazy" src="/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

## Adding an Unsigned Signature Field to a PDF

Currently, this feature is not available. For further details on how IronPDF handles forms, refer to the [Programmatically Fill PDF Forms in C#](https://ironpdf.com/blog/using-ironpdf/programmatically-fill-pdf-form-csharp/) article.

