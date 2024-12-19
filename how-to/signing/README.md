# Digitally Secure Your PDF Documents

***Based on <https://ironpdf.com/how-to/signing/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Are you spending too much annually on PDF security and compliance subscriptions? Consider <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc by Iron Software</a> as a cost-effective solution for managing your SaaS needs such as digital signatures, redaction, encryption, and protection - all via a one-time fee. Learn more at <a href="https://ironsoftware.com/enterprise/securedoc/docs/">IronSecureDoc Documentation</a>.
</div>

## Key Clarifications: PDF Document Signing

The topic of digitally signing PDFs often leads to confusion among developers using IronPDF. The term 'signing' can mean different things:

1. <a href="#anchor-sign-a-pdf-with-a-digital-certificate">Digitally signing a PDF with a certificate for security from tampering.</a>
2. <a href="#anchor-stamp-a-signature-onto-a-pdf">Applying a graphical representation of a handwritten signature as an image to a PDF.</a>
3. <a href="#anchor-stamp-a-signature-onto-a-pdf">Embedding an image of a certificate in a PDF.</a>
4. <a href="#anchor-add-a-signature-form-field-to-a-pdf">Incorporating a form field in a PDF that prompts users to sign digitally.</a>

<h3>Initiating with IronPDF</h3>

<div class="alert alert-info iron-variant-1" role="alert">

If your company is facing high expenses due to annual fees for PDF security and compliance, you might want to evaluate IronSecureDoc from Iron Software. This service offers comprehensive management of SaaS capabilities including digital signatures, redaction, encryption, and protection, all available for a singular payment. Learn more about this solution by visiting the [IronSecureDoc page](https://ironsoftware.com/enterprise/securedoc/) and enhance your knowledge by exploring the [IronSecureDoc Documentation](https://ironsoftware.com/enterprise/securedoc/docs/).

</div>

## Clarifying PDF Signing Terminology

A frequent query from developers involves how to use IronPDF to insert a signature into a PDF document programmatically. The term 'signing' can vary in meaning depending on the developer's intention:

1. [Digitally sign a PDF document with a Certificate to guarantee its integrity](#anchor-sign-a-pdf-with-a-digital-certificate).
2. [Embed a graphical handwritten signature image into an existing PDF from an image file](#anchor-stamp-a-signature-onto-a-pdf).
3. [Stamp a Certificate's Image onto a PDF](#anchor-stamp-a-signature-onto-a-pdf).
4. [Insert a Signature Form Field into a PDF, enabling certain PDF viewers to prompt users for a signature](#anchor-add-a-signature-form-field-to-a-pdf).

<h3>Get started with IronPDF</h3>

# Add a Watermark Signature to a PDF

***Based on <https://ironpdf.com/how-to/signing/>***


When you need to apply a handwritten signature as a watermark to a PDF, IronPDF makes this process straightforward. For demonstration purposes, let's use a hypothetical invoice PDF as the document to be signed.

Here's the sample signature we intend to use, displayed in image format:

![Sample Signature](https://ironpdf.com/static-assets/pdf/how-to/signing/signature.png)

## Sample Code

The code snippet below will guide you through the steps of applying the `.png` image as a watermark signature to the selected PDF:

```cs
using IronPdf;
using IronPdf.Editing;

// Load the PDF document
var pdfDoc = PdfDocument.FromFile("invoice.pdf");

// Apply a watermark image to the PDF
pdfDoc.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);

// Save the modified PDF with the signature applied
pdfDoc.SaveAs("official_invoice.pdf");
```

## Resulting Document

After executing the code, a new PDF file will be generated which includes the signature positioned at the bottom right:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

In this way, IronPDF allows you to seamlessly integrate signature images into your documents, enhancing their authenticity and professionalism.

## Digitally Signing PDFs with a Certificate

IronPDF offers robust support for digitally signing PDF documents using certificates in `.pfx` and `.p12` file formats. This guide showcases the **three principal techniques** used to apply digital signatures to PDF files:

<style type="text/css">

```css
.tg {
    border-collapse: collapse;
    border-color: #ccc; /* Sets the border color */
    border-spacing: 0; /* Removes the space between borders */
}

.tg td {
    background-color: #fff; /* Background color of table cells */
    border-color: #ccc; /* Border color */
    border-style: solid; /* Style of border */
    border-width: 1px; /* Border width */
    color: #333; /* Text color */
    font-family: Arial, sans-serif; /* Font of the text */
    font-size: 14px; /* Font size */
    overflow: hidden; /* Prevents content from overlapping */
    padding: 10px 5px; /* Cell padding */
    word-break: normal; /* Text wrapping behavior */
}

.tg th {
    background-color: #f0f0f0; /* Header background color */
    border-color: #ccc; /* Border color */
    border-style: solid; /* Style of border */
    border-width: 1px; /* Border width */
    color: #333; /* Text color */
    font-family: Arial, sans-serif; /* Typeface setting */
    font-size: 14px; /* Font size */
    font-weight: normal; /* Font weight, overwrites the usual bold for table headers */
    overflow: hidden; /* Ensures content doesn't spill out */
    padding: 10px 5px; /* Padding inside of header cells */
    word-break: normal; /* Ensures words are not split at the end of the line */
}

.tg .tg-u0o7 {
    border-color: inherit; /* Inherit border color from parent element */
    font-weight: bold; /* Bold text style */
    text-align: left; /* Text alignment */
    vertical-align: top; /* Align text to the top of the cell */
}

.tg .tg-fymr {
    border-color: inherit; /* Inherits the border color */
    font-weight: bold; /* Bold text formatting */
    text-align: left; /* Aligned to the left */
    vertical-align: top; /* Vertical alignment to top */
}

.tg .tg-0pky {
    border-color: inherit; /* Inherits the border color */
    text-align: left; /* Sets text alignment to the left */
    vertical-align: top; /* Vertical alignment to the top of the cell */
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

### Supported Digital Signature Certificate Formats

IronPDF adheres strictly to the `X509Certificate2` standards and accommodates both `.pfx` and `.p12` signature formats. Should there be a case where your signature cannot be directly utilized via IronPDF's signing functionalities, it becomes necessary to establish an `X509Certificate2` certificate. Guidance on creating this certificate is available on the [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificate2.-ctor).

### Creating a `PdfSignature` from an `X509Certificate2`

IronPDF allows you to utilize `X509Certificate2` objects for signing documents, provided that these objects have the **X509KeyStorageFlags** configured as **Exportable**.

- It's important to note that IronPDF exclusively supports the **X509KeyStorageFlags.Exportable** configuration for certificates. Certificates configured this way by default will seamlessly integrate with IronPDF. However, attempting to utilize certificates with non-exportable flags will trigger a specific exception: `Internal.Cryptography.CryptoThrowHelper.WindowsCryptographicException` with the message "The requested operation is not supported."

Here is the paraphrased section from the article:

```cs
using IronPdf;
using IronPdf.Signing;
using System.Security.Cryptography.X509Certificates;

// Initializing the PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>foo</h1>");

// Constructing certificate with exportable keys
X509Certificate2 certificate = new X509Certificate2("IronSoftware.pfx", "123456", X509KeyStorageFlags.Exportable);

// Configuring the PDF signature using the certificate
PdfSignature signature = new PdfSignature(certificate);

// Applying the digital signature to the PDF
document.Sign(signature);

// Saving the signed PDF
document.SaveAs("signed.pdf");
```

### Enhance Your PdfSignature with Detailed Information

Upon creating a `PdfSignature` or adding to an existing one, you can enrich the signature with critical details. The attributes you can include are the signing date, contact details, geographical location, rationale behind the signature, and even incorporating a visual representation through an image. This addition not only provides a robust description but also visually authenticates the document.

This functionality also accommodates timestamping, supporting both SHA256 and SHA512 protocols, ensuring your PDF's integrity within secured timeframes.

Below is the paraphrased section of the article:

```cs
using IronPdf;
using IronPdf.Signing;
using IronSoftware.Drawing;
using System;

// Initialize a PDF renderer to create a PDF document
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example Header</h1>");

// Save the initial PDF document
pdf.SaveAs("initial_signed.pdf");

// Initialize a PdfSignature object with your digital certificate
var signature = new PdfSignature("IronSoftware.pfx", "123456");

// Set detailed information for the signature
signature.SignatureDate = new DateTime(2000, 12, 02);
signature.SigningContact = "Contact@IronSoftware.com";
signature.SigningLocation = "Chicago, USA";
signature.SigningReason = "Documentation Example";
signature.TimestampHashAlgorithm = TimestampHashAlgorithms.SHA256;
signature.TimeStampUrl = "http://timestamp.digicert.com";
signature.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new IronSoftware.Drawing.Rectangle(0, 600, 100, 100));

// Apply the signature to the PDF and save the signed document
signature.SignPdfFile("final_signed.pdf");
``` 

This snippet highlights how to use IronPDF's `PdfSignature` object to add detailed signature data like date, contact info, and location to a PDF. The digital certificate and its details are utilized to create a signature that is then applied to the PDF, and the final signed document is saved under a new filename.

### Visual Demonstration

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/signing/granular-information.png" alt="Viewing Signer detail" class="img-responsive add-shadow">
    </div>
</div>

Despite valid signing certificates, when a PDF is opened in Adobe, it might display a warning or an exclamation mark rather than a check mark because Adobe is unable to verify the document's authenticity and integrity without the certificate being added directly. To resolve this and get the check mark upon opening in Adobe, simply add your certificate to Adobe's list and re-open the document.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="/static-assets/pdf/how-to/signing/granular-information.png" alt="Viewing Signer detail" class="img-responsive add-shadow">
    </div>
</div>

It's possible that you'll notice a warning sign or an exclamation mark rather than a verification check mark when viewing the document in Adobe. This occurs if Adobe is unable to verify the document's authenticity and integrity due to the absence of the certificate. To resolve this, import the certificate into Adobe and then reopen the document to see the check mark.

### Various Methods to Incorporate Images into Signatures

There are several approaches to embedding images into signatures:

- Assign a new `PdfSignatureImage` object to the **SignatureImage** property.
  
- Employ the `LoadSignatureImageFromFile` function to upload an image from a file. This method is compatible with a range of image formats.

- Utilize the `LoadSignatureImageFromStream` function for importing an image from a stream. This technique supports importing image streams from external libraries that match the formats TGA, PBM, TIFF, BMP, GIF, PNG, JPEG, and Webp.

Below is the paraphrased version of the provided C# section from the article. The URL paths for images have been resolved to the `ironpdf.com` domain.

```cs
using IronPdf.Signing;
using IronSoftware.Drawing;

// Instantiate a PdfSignature object
PdfSignature signature = new PdfSignature("IronSoftware.pfx", "123456");

// Assign a signature image using the SignatureImage property
signature.SignatureImage = new PdfSignatureImage("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Add an image to the signature by using the LoadSignatureImageFromFile method
signature.LoadSignatureImageFromFile("IronSoftware.png", 0, new Rectangle(0, 600, 100, 100));

// Load an image into the signature using the IronSoftware.Drawing library
AnyBitmap imageFromLibrary = AnyBitmap.FromFile("IronSoftware.png");

// Stream the loaded image into the signature
signature.LoadSignatureImageFromStream(imageFromLibrary.ToStream(), 0, new Rectangle(0, 600, 100, 100));
```

### Signature Permissions

You have the ability to define specific conditions to maintain the validity of your digital signature. For different levels of document modification permissions after signing, please consult the table below for detailed options: 

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
    <td class="tg-0pky">Absolutely no changes permitted</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAllowed</td>
    <td class="tg-0pky">Only changes to form field values are permitted</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAndAnnotationsAllowed</td>
    <td class="tg-0pky">Modifications to form fields and annotations are permitted</td>
  </tr>
</tbody>
</table>

Specifying signature permissions is optional, and by default, a signature will certify a particular document revision which cannot be invalidated by further changes.

<style type="text/css">

```html
<style type="text/css">
.tg  {border-collapse:collapse;border-color:#ccc;margin: 0 auto;}
.tg td{background-color:#fff;border-color:#ccc;border-style:solid;border-width:1px;color:#333;
  font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;word-break:normal; text-align: center;}
.tg th{background-color:#f0f0f0;border-color:#ccc;border-style:solid;border-width:1px;color:#333;
  font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px; text-align: center;}
.tg .tg-u0o7{border-color:inherit;font-weight:bold;vertical-align:middle;}
.tg .tg-0pky{border-color:inherit;vertical-align:top;}
</style>
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
    <td class="tg-0pky">Changing form field values allowed</td>
  </tr>
  <tr>
    <td class="tg-0pky">FormFillingAndAnnotationsAllowed</td>
    <td class="tg-0pky">Changing form field values and modifying annotations allowed</td>
  </tr>
</tbody>
</table>

This parameter is optional. If not specified, the signature will apply only to a specific version of the document and will be considered irrevocable.

Here is the paraphrased section of the article, with the links resolved to the specified domain (ironpdf.com):

### Revision and Digital Signature Process for PDFs

In this example, we demonstrate the process of opening a PDF, making several modifications, and then digitally signing the document to certify those changes. The signature will be configured to permit only filling out forms in future modifications, as any other alterations will void the signature.

After these steps, we utilize the `SaveAsRevision` function to retain this version in the document’s revision log. Finally, we proceed to finalize and store this newly signed and edited document on your local drive.

Below is the paraphrased section of the article about signing a revised version of a PDF document using IronPDF, with all references to images and URLs resolved against ironpdf.com:

-----
```cs
using IronPdf;
using IronPdf.Rendering;

// Load the PDF document and activate change tracking
PdfDocument document = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
// Assume changes were made to the PDF here...
document.SignWithFile("https://ironpdf.com/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);

// Save the current state of the document as a new revision
PdfDocument revisedDocument = document.SaveAsRevision();

// Save the new, signed revision to a file
revisedDocument.SaveAs("annual_census_2.pdf");
```

### Understanding Incremental Saving for Signatures

PDF files resemble version control systems like Git in their ability to preserve multiple iterations of the document. While some PDF viewers, such as those found in Chrome, only display the latest version, more sophisticated readers like Adobe Acrobat can access earlier versions.

It's crucial to understand this dynamic when working with PDF signatures. Signing a document applies only to the iteration at hand. Thus, a PDF might carry signatures from previous versions, have iterations without any signatures, or a combination of both. Here’s an illustration of how this concept plays out:

<style type="text/css">

Here is the paraphrased section:

```html
<style type="text/css">
.tg {border-collapse: collapse; margin: 0;}
.tg td {font-family: Arial, sans-serif; font-size: 14px; padding: 10px 5px; border-style: solid; border-width: 1px; overflow: hidden; word-break: normal;}
.tg th {font-family: Arial, sans-serif; font-size: 14px; font-weight: normal; padding: 10px 5px; border-color: black; border-style: solid; border-width: 1px; overflow: hidden;}
.tg .tg-7btt {font-weight: bold; text-align: center; border-color: inherit;}
.tg .tg-0pky {text-align: left; border-color: inherit;}
.tg .tg-fymr {font-weight: bold; text-align: left; border-color: inherit;}
.tg .tg-8bgf {text-align: center; border-color: inherit; font-style: italic; vertical-align: top;}
.tg .tg-c3ow {text-align: center; border-color: inherit; vertical-align: top;}
.tg .tg-baqh {text-align: center; vertical-align: top;}
.tg .tg-5frq {text-align: center; border-color: inherit; font-style: italic; vertical-align: top;}
.tg .tg-0lax {text-align: left; vertical-align: top;}
</style>
```

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

The section provided illustrates a scenario where a document undergoes six separate iterations. Initially, the document circulates across various company departments for approval, culminating at the third iteration. At this stage, both Person A and Person B applied their signatures with specific conditions labeled as "Form Field Edits Only". This designation permits the modification of form fields within the document, but any further alterations would void their signatures.

Moreover, it is inferred that Person C completed the required form fields and returned the updated document to Persons A, B, and D. This trio subsequently endorsed the document with a "No Edits Allowed" condition. Given that there were no disqualifying alterations made to the document after their signatures, executing IronPDF's signature verification method would confirm the document's authenticity with a return value of `true`.

### Reverting to a Previous PDF Revision

To revert to an earlier version of a PDF document, employ the `GetRevision` method. This function discards all subsequent modifications, including newer signatures, effectively restoring the PDF to its selected historical state. Here's how to implement it:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("report.pdf");

// Retrieve the number of revisions
int versions = pdf.RevisionCount;

// Retrieve a specific revision of the document
PdfDocument rolledBackPdf = pdf.GetRevision(2);

// Save the reverted document to a new file
rolledBackPdf.SaveAs("report-draft.pdf");
```

Here's the paraphrased section of the code from the article with appropriate comments and modifications:

```cs
using IronPdf;

// Load the PDF from file
PdfDocument originalPdf = PdfDocument.FromFile("report.pdf");

// Retrieve the total number of revisions in this PDF
int totalRevisions = originalPdf.RevisionCount;

// Access a previous version of the PDF (Revision number 2)
PdfDocument revertedPdf = originalPdf.GetRevision(2);

// Save the reverted PDF as a draft version
revertedPdf.SaveAs("report-draft.pdf");
```

### Clearing All Signatures from a PDF

IronPDF offers a convenient feature through its `RemoveSignatures` method, which allows the removal of all signatures across every version of a PDF file. Here's how to use it:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("invoice.pdf");
pdf.RemoveSignatures();
```

Below is the paraphrased content based on your requirements, with relative URL paths resolved to `ironpdf.com`:

---

```cs
// Utilizing IronPdf namespace
using IronPdf;

// Loading an existing PDF document
PdfDocument existingPdf = PdfDocument.FromFile("invoice.pdf");

// Removing all signatures from the PDF
existingPdf.RemoveSignatures();
```

### Validating All Signatures in a PDF

Utilizing the signature verification function on a PDF will scan through each signature from every version of the document to confirm their validity. If all signatures remain authentic, it will yield a `bool` value of `true`.

Here's the paraphrased section of the article:

```cs
using IronPdf;

// Load the PDF document from the specified file
PdfDocument document = PdfDocument.FromFile("annual_census.pdf");

// Check if all the digital signatures in the document are still valid
bool areSignaturesValid = document.VerifyPdfSignatures();
```

## Imprinting a Signature onto a PDF

To begin with, let's consider a PDF document that needs signing. For illustration, we'll use the following example invoice:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/signing/invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

This section of the document will be adorned with a handwritten signature, which typically comes in the form of a `.png` image file. This is the sample signature that will be utilized:
<img src="https://ironpdf.com/static-assets/pdf/how-to/signing/signature.png" alt="" class="img-responsive add-shadow">

### Implementing the Code

To add the signature as a watermark to the aforementioned PDF, utilize the following block of code:

```cs
using IronPdf;
using IronPdf.Editing;

// Load the PDF document
var pdf = PdfDocument.FromFile("invoice.pdf");

// Apply the watermark with the signature image at a specific position
pdf.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);

// Save the PDF with the signature applied
pdf.SaveAs("official_invoice.pdf");
```

### Viewing the Result

After executing the above code, the resulting file will display the signature placed strategically at the bottom right corner:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

<iframe loading="lazy" src="/static-assets/pdf/how-to/signing/invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

We're going to embed a `.png` image of a handwritten signature into our PDF. This image might represent a physical signature or could have been utilized in crafting a digital certificate. Below is the example of the signature we'll be using:
<img src="https://ironpdf.com/static-assets/pdf/how-to/signing/signature.png" alt="" class="img-responsive add-shadow">

<img src="/static-assets/pdf/how-to/signing/signature.png" alt="" class="img-responsive add-shadow">

```cs
using IronPdf;
using IronPdf.Editing;

// Load the PDF document
var pdfDocument = PdfDocument.FromFile("invoice.pdf");

// Apply a watermark signature image to the bottom right of the PDF
pdfDocument.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);

// Save the modified PDF
pdfDocument.SaveAs("official_invoice.pdf");
```

Here's the paraphrased content of the specified section, with all relative URL paths resolved to `ironpdf.com`:

```cs
using IronPdf;
using IronPdf.Editing;

// Load the PDF document from file
PdfDocument invoicePdf = PdfDocument.FromFile("invoice.pdf");

// Apply a watermark signature image to the PDF
invoicePdf.ApplyWatermark("<img src='signature.png'/>", 90, VerticalAlignment.Bottom, HorizontalAlignment.Right);

// Save the modified PDF document under a new name
invoicePdf.SaveAs("official_invoice.pdf");
```

### Output Result

Upon executing the code, the resultant file will display our signature at the lower right corner:

<iframe loading="lazy" src="/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px">
</iframe>

## Adding an Unsigned Signature Field to a PDF Document

Currently, IronPDF does not yet offer the capability to add an unsigned signature field to PDF files. For further insights into what IronPDF does support regarding form handling and features, please visit the [IronPDF Forms and Features Article](https://ironpdf.com/blog/using-ironpdf/programmatically-fill-pdf-form-csharp/).

