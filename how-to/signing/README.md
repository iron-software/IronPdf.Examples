# A Developer's Guide to Digitally Signing PDFs with C&num;

***Based on <https://ironpdf.com/how-to/signing/>***


Applying a signature to PDF documents is frequently required in software applications, and the concept of "signing" can vary widely. Some scenarios demand the application of a secure, tamper-resistant digital signature with a security certificate. In other cases, it may involve imprinting a document with a visual, handwritten signature or incorporating an interactive form field for digital signatures.

This comprehensive tutorial is designed for C# developers using the [IronPDF for .NET library](https://ironpdf.com/) to address these varying requirements. We will explore the processes involved in implementing a robust `X509Certificate2` digital signature, embedding graphical signatures, and setting up interactive signature fields to ensure your PDFs remain authoritative, secure, and professional.

## Quickstart: Effortlessly Digitally Sign a PDF Using IronPDF

Kickstart your integration of digital signing with IronPDF in a few simple steps. This instruction outlines the use of a `.pfx` certificate to validate and apply a digital signature to a PDF, guaranteeing the document’s integrity and authenticity. Here’s how to easily incorporate digital signatures into your projects, enhancing the security and reliability of your PDF handling capabilities.

```cs
// Instantly add a digital signature to a PDF document.
new IronPdf.Signing.PdfSignature("certificate.pfx", "password").SignPdfFile("input.pdf");
```

## Digitally Signing a PDF Using a Certificate

To ensure the authenticity and integrity of a PDF, you can use a digital certificate file, like `.pfx` or `.p12`. This method certifies that the PDF remains unchanged after it's been signed.

IronPDF's API makes it easy to digitally sign PDFs. It offers various methods to handle the signing process, centered around the `PdfSignature` class. This class efficiently handles the digital certificate and all related signature metadata.

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
<td class="tg-0pky"><code>Sign</code></td>
<td class="tg-0pky">Signs a PDF with a <strong><code>PdfSignature</code> object</strong> that you create and configure.</td>
</tr>
<tr>
<td class="tg-0pky"><code>SignWithFile</code></td>
<td class="tg-0pky">Signs a PDF using a digital signature certificate file (<code>.pfx</code> or <code>.p12</code>) located on disk.</td>
</tr>
<tr>
<td class="tg-0pky"><code>SignWithStore</code></td>
<td class="tg-0pky">Signs a PDF with a digital signature from your computer's certificate store, identified by its <strong>thumbprint ID</strong>.</td>
</tr>
</tbody>
</table>

### Utilizing an X509Certificate2 Object

To achieve full control over your digital signatures, instantiate an `X509Certificate2` object using your digital certificate file. IronPDF is fully compatible with the `X509Certificate2` standard, offering a secure and dependable approach for implementing digital signatures. It's important to set the `X509KeyStorageFlags` to `Exportable` when you create the certificate instance. This setting is essential because it allows the cryptographic APIs to utilize the private key in the signing process.

```shell
# Install the IronPdf package in your project.

***Based on <https://ironpdf.com/how-to/signing/>***

/Install-Package IronPdf
```

```csharp
using IronPdf;
using IronPdf.Signing;
using System.Security.Cryptography.X509Certificates;

// Initialize a new PDF using HTML content as an example.
var pdfBuilder = new ChromePdfRenderer();
var document = pdfBuilder.RenderHtmlAsPdf("<h1>Signed Document</h1><p>This document has now been secured with a digital signature.</p>");

// Import the digital certificate used for signing, along with its passphrase.
// It is essential to set X509KeyStorageFlags.Exportable to enable access to the certificate's private key.
var certificate = new X509Certificate2("IronSoftware.pfx", "123456", X509KeyStorageFlags.Exportable);

// Generate a PdfSignature instance utilizing the imported certificate.
var digitalSignature = new PdfSignature(certificate);

// Execute the signature method to sign the PDF.
document.Sign(digitalSignature);

// Store the finalized PDF with the applied digital signature securely.
document.SaveAs("Signed.pdf");
```

The preceding script initiates by creating a straightforward PDF. It proceeds to load a `.pfx` certificate into an `X509Certificate2` object, effectively encapsulating the digital identity. This object is then utilized to construct a `PdfSignature`, which is subsequently used to sign the PDF document using the `pdf.Sign` method. The signed document is then saved securely. For further details on the `X509Certificate2` class and its functionality, you can consult the official [Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificate2.-ctor "null").

### Enhancing Digital Signatures with Detailed Metadata

Digital signatures encompass more than merely the certificate—they can be enriched with extensive metadata that furnishes additional context. This enriches the signature with details such as the location where the signing took place, the reason for the signature, contact specifics, and timestamps from reliable authorities.

Incorporating such comprehensive attributes greatly enhances the auditability of a document and furnishes those verifying the signature with crucial insights. Moreover, IronPDF accommodates modern timestamping services that leverage robust hash algorithms like `SHA256` and `SHA512`.

Here is the paraphrased section, with resolved URLs for relative paths:

```csharp
using IronPdf;
using IronPdf.Signing;
using IronSoftware.Drawing;
using System;

// Initiating the loading of a pre-existing PDF file that requires signing.
var pdfDocument = PdfDocument.FromFile("invoice.pdf");

// Instantiating a PdfSignature using the certificate file along with its password.
var digitalSignature = new PdfSignature("IronSoftware.pfx", "123456");

// Incorporating rich metadata into the digital signature for an extensive audit trail.
digitalSignature.SignatureDate = DateTime.Now;
digitalSignature.SigningContact = "legal@ironsoftware.com";
digitalSignature.SigningLocation = "Chicago, USA";
digitalSignature.SigningReason = "Contractual Agreement";

// Embedding a secure timestamp provided by a certified Time Stamp Authority (TSA).
// This timestamp acts as cryptographic evidence of the exact signing time.
digitalSignature.TimeStampUrl = new Uri("[http://timestamp.digicert.com](http://timestamp.digicert.com)");
digitalSignature.TimestampHashAlgorithm = TimestampHashAlgorithms.SHA256;

// Setting up a visual representation for the digital signature.
digitalSignature.SignatureImage = new PdfSignatureImage("assets/visual-signature.png", 0, new Rectangle(350, 750, 200, 100));

// Executing the signing of the PDF using the signature details specified.
pdfDocument.Sign(digitalSignature);

// Storing the signed PDF with its comprehensive digital signature details.
pdfDocument.SaveAs("DetailedSignature.pdf");
```

In certain PDF viewers, a warning symbol may appear if the signing certificate isn't recognized by the system's trusted store. For the symbol to change to a green checkmark, indicating trustworthiness, you must add the certificate to the viewer's list of trusted identities.

## Adding Visual Elements to a Digital Signature

A digital signature, while securely embedded within a PDF document, often benefits from a visual component such as a corporate logo, a scanned signature, or other graphic elements. IronPDF simplifies the process of incorporating these images into a `PdfSignature`.

Images can be seamlessly integrated from various sources, either directly from a file or dynamically through a stream, and can be accurately positioned on any part of the PDF's pages. IronPDF supports a wide range of image formats, including PNG, JPEG, GIF, BMP, TIFF, and WebP, to suit diverse visual requirements.

Here's the paraphrased section:

```csharp
using IronPdf.Signing;
using IronSoftware.Drawing;

// This section illustrates different approaches to incorporating an image into a PDF's digital signature.

// Initialize a PdfSignature object.
var signature = new PdfSignature("IronSoftware.pfx", "123456");

// Specify the location and dimensions of the signature image on the document's first page.
var signatureRect = new Rectangle(350, 750, 200, 100);

// Method 1: Assign the SignatureImage property directly.
signature.SignatureImage = new PdfSignatureImage("https://ironpdf.com/assets/visual-signature.png", 0, signatureRect);

// Method 2: Utilize the LoadSignatureImageFromFile method to assign the image.
signature.LoadSignatureImageFromFile("https://ironpdf.com/assets/visual-signature.png", 0, signatureRect);

// Method 3: Import an image from a stream. This method is effective for images created in-memory.
AnyBitmap img = AnyBitmap.FromFile("https://ironpdf.com/assets/visual-signature.png");
using (var imgStream = img.ToStream())
{
    signature.LoadSignatureImageFromStream(imgStream, 0, signatureRect);
}

// Once the signature image has been set up, integrate it into a PDF document.
var pdfDocument = PdfDocument.FromFile("invoice.pdf");
pdfDocument.Sign(signature);
pdfDocument.SaveAs("VisualSignature.pdf");
```

This example demonstrates three equal methods for incorporating a visual element into a digital signature. Whether the image is stored on your device or held in memory, you can effortlessly imprint it within the PDF as a part of the signing procedure. This effectively connects the invisible security of cryptography with the tangible approval indicated by a visible document signature.

## Managing Access Post-Signature with IronPDF

Once a document has been signed, controlling subsequent modifications becomes crucial. With IronPDF, you can define the permissible changes—if any—through the `SignaturePermissions` enumeration. Depending on the requirement, this could range from fully locking the document to just allowing form field edits.

Implementing these permissions with IronPDF is vital for governing the document's lifecycle. By setting restrictions on what can be altered post-signature, you ensure the document retains its validity and integrity. Any unauthorized modifications will render the existing signatures invalid, thus safeguarding the document's secure status.

<style type="text/css"> .tg {border-collapse:collapse;border-color:#ccc;border-spacing:0;} .tg td{background-color:#fff;border-color:#ccc;border-style:solid;border-width:1px;color:#333; font-family:Arial, sans-serif;font-size:14px;overflow:hidden;padding:10px 5px;word-break:normal;} .tg th{background-color:#f0f0f0;border-color:#ccc;border-style:solid;border-width:1px;color:#333; font-family:Arial, sans-serif;font-size:14px;font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;} .tg .tg-u0o7{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top} .tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top} </style>

<table class="tg"> <thead> <tr> <th class="tg-u0o7"><code>SignaturePermissions</code> Member</th> <th class="tg-u0o7">Definition</th> </tr> </thead> <tbody> <tr> <td class="tg-0pky"><code>NoChangesAllowed</code></td> <td class="tg-0pky">No changes of any kind are permitted. The document is effectively locked.</td> </tr> <tr> <td class="tg-0pky"><code>FormFillingAllowed</code></td> <td class="tg-0pky">Only filling in existing form fields and signing is allowed.</td> </tr> <tr> <td class="tg-0pky"><code>AnnotationsAndFormFillingAllowed</code></td> <td class="tg-0pky">Allows form filling, signing, and creating or modifying annotations.</td> </tr> </tbody> </table>

### Handling and Signing a Designated PDF Revision

Just like a version control system which archives each modification, PDFs are capable of recording a sequence of changes, referred to as incremental saving. This feature is especially vital in situations where the PDF needs to undergo various approval stages before finalization. Every signature is linked to a particular revision of the document to ensure the signature’s validity through different editing phases.

In the illustrated scenario below, we start by loading a PDF document, performing some modifications, and proceed to sign the document at its current state. This signature permits only the filling of forms in future revisions. We employ the `SaveAsRevision` method to solidify this current version into the document's revision history before finalizing with a save operation.

Here's the paraphrased section with resolved relative URL paths for the links and images, formatted in markdown:

```csharp
using IronPdf.Signing;

// Initialize a PDF with the ability to track changes.
var pdfDocument = PdfDocument.FromFile("annual_census.pdf", ChangeTrackingModes.EnableChangeTracking);

// Example placeholder: Here, you can modify the PDF by adding text, filling out forms, or annotating.
// Example usage: pdfDocument.Annotations.Add(new TextAnnotation("Sample Text"));

// For convenience, use the SignWithFile method to certify the document's current state.
// Configuration allows additional signatures and enables form filling post-signing.
pdfDocument.SignWithFile(
    "assets/IronSignature.p12", 
    "password",
    SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed
);

// Commit the current version of the document as a unique revision within the historical log.
PdfDocument snapshotWithRevisions = pdfDocument.SaveAsRevision();

// Output the fully revision-tracked PDF to a new file.
snapshotWithRevisions.SaveAs("annual_census_signed.pdf");
``` 

In this paraphrasing, I opted for different variable names and slightly rearranged the explanatory comments while keeping the technical accuracy intact. The revised code maintains the function and intent of the original snippets, catering to the needs of developers using IronPDF's PDF signing features.

Grasping the concept of incremental saves is crucial for handling sophisticated PDF processes. Simple PDF viewers may only display the latest document version, but advanced applications like Adobe Acrobat can unveil an entire history of document revisions. These tools show detailed records of who signed the document at each stage and any modifications made prior to each signature. With IronPDF, developers are provided with complete control over managing these data layers and revisions.

For enterprises that navigate intricate document management systems emphasizing high security and strict compliance, a robust, integrated solution is often necessary. Iron Software presents the Iron Suite, available at [https://ironsoftware.com/suite/](https://ironsoftware.com/suite/), which not only features IronPDF for signature applications and editing but also includes additional libraries that support a broad spectrum of document processing activities. This suite is offered as a comprehensive one-time acquisition, simplifying the integration of advanced document management capabilities into business operations.

### Managing and Verifying Signatures Over Multiple Document Revisions

PDF files often accrue several signatures through various updates. IronPDF equips developers with functionality for efficiently controlling these accumulated signatures and revision histories.

- **Reverting to a Past Revision**: Utilize the `GetRevision` method to restore a PDF to a previously saved state, effectively removing all later edits and signatures.

- **Authenticating All Signatures**: Use the `VerifySignatures` function to authenticate every signature on each revision of a document. It confirms the genuineness only if all signatures are validated and no unauthorized modifications have been noted.

- **Eliminating All Signatures**: The `RemoveSignatures` feature expunges every digital signature from every version of the PDF, resulting in a pristine, signature-free document.

```csharp
// Open a PDF that has several signatures from different revisions.
var pdfDocument = PdfDocument.FromFile("multi_signed_report.pdf");

// Assess the authenticity of all existing signatures in all document revisions.
bool isValidAllSignatures = pdfDocument.VerifySignatures();
Console.WriteLine($"All signatures are valid: {isValidAllSignatures}");

// If there are multiple revisions, revert to the original version (first in the list).
if (pdfDocument.RevisionCount > 1)
{
    PdfDocument originalRevision = pdfDocument.GetRevision(0);
    originalRevision.SaveAs("report_original_version.pdf");
}

// Eliminate all digital signatures from the document to generate an unsigned version.
pdfDocument.RemoveSignatures();
pdfDocument.SaveAs("report_no_signatures.pdf");
```

## Stamping a Handwritten Signature onto a PDF

In certain cases, the objective is not to secure a document with a cryptographic digital signature but rather to imprint it with a visual, often electronic, such as a scanned handwritten signature. This process is commonly known as stamping, and it can be achieved effortlessly using IronPDF's `Watermark` or `Stamp` capabilities.

Here's an example that begins with a standard invoice PDF and incorporates a `.png` file that represents a handwritten signature.

<iframe loading="lazy" src="/static-assets/pdf/how-to/signing/invoice.pdf#view=fit" width="100%" height="500px"> </iframe>

Below is the updated section of the article, with a newly phrased narrative and resolved URLs for images:

-----
_The initial version of the invoice PDF prior to the addition of a signature._

The forthcoming signature image for application is displayed below:

![An image of a handwritten signature](https://ironpdf.com/static-assets/pdf/how-to/signing/signature.png)

_A representative image of a handwritten signature._

The subsequent code snippet demonstrates the utilization of the `Watermark` property to impress this image onto the bottom-right corner of the PDF document:

```csharp
using IronPdf.Editing;

// Open the PDF document to modify.
var pdfDocument = PdfDocument.FromFile("invoice.pdf");

// Construct an HtmlStamp with the signature image.
var signatureHtmlStamp = new HtmlStamp("<img src='https://ironpdf.com/assets/signature.png'/>")
{
    // Set the positioning and styling of the stamp.
    VerticalAlignment = VerticalAlignment.Bottom,
    HorizontalAlignment = HorizontalAlignment.Right,
    Margin = 10, // Margin from the document edge.
    Opacity = 90 // Set partial transparency.
};

// Stamp the signature onto every page of the PDF.
pdfDocument.ApplyStamp(signatureHtmlStamp);

// Save the adjusted PDF as a new file.
pdfDocument.SaveAs("official_invoice.pdf");
```

### Result of Stamping a Signature on a PDF

Following the execution of the provided code, the image of the signature is successfully imprinted onto the document, resulting in a visually authenticated invoice. This graphical representation enhances the appearance of the document while maintaining its professionalism.

Visual confirmation of the signature can be viewed here in the stamped invoice:

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px"> </iframe>

_The finalized PDF showcasing the stamped signature image in the lower-right corner._

<iframe loading="lazy" src="/static-assets/pdf/how-to/signing/official_invoice.pdf#view=fit" width="100%" height="500px"> </iframe>

Here is your paraphrased section:

-----
_The completed document now displays the handwritten signature image impressively stamped in the lower right corner._

## Integrating an Interactive Signature Form Field into a PDF

For documents requiring end-users to sign directly within a PDF viewer such as Adobe Acrobat, incorporating an interactive signature form field is a practical solution. This feature establishes a clickable box on the document, inviting users to sign using their digital signature.

To achieve this, simply instantiate a `SignatureFormField` and integrate it into the PDF's array of form fields. You possess complete authority over defining its position and dimensions on the document.

```csharp
using IronPdf.Forms;
using IronSoftware.Drawing;

// Begin by generating a new PDF document where we can insert the signature field.
var pdfRenderer = new ChromePdfRenderer();
var pdfDocument = pdfRenderer.RenderHtmlAsPdf("<h1>Please Sign Below</h1>");

// Set up the details for the signature form field.
string signatureFieldName = "ClientSignature";
int page = 0; // This will be placed on the first page.
var signatureArea = new Rectangle(50, 200, 300, 100); // Coordinates (x, y) and dimensions (width, height).

// Instantiate the SignatureFormField object.
var formField = new SignatureFormField(signatureFieldName, page, signatureArea);

// Embed the signature field into the PDF's form structure.
pdfDocument.Form.Add(formField);

// Finalize the document by saving it with the interactive signature field included.
pdfDocument.SaveAs("interactive_signature.pdf");
```

Upon opening the PDF, users encounter an interactive, clickable signature field, enabling them to sign the document using their digital identity. For further details on crafting and managing interactive forms, peruse our [guide on creating PDF forms](https://ironpdf.com/how-to/create-forms/).

![Unsigned signature](https://ironpdf.com/static-assets/pdf/how-to/signing/unsigned-signature.webp)
_This image depicts a programmatically added, unsigned interactive signature field in a PDF._

## Extracting the Signer's Common Name from Verified Signatures

To fetch the common name of the person who signed a document using their certificate, you can utilize the `VerifiedSignature` class. This class provides access to the `SignerName` property, which represents the signer's name. Here's how you can effectively retrieve this information:

```csharp
using IronPdf;
using System;

// Load the PDF document containing signatures
var pdf = PdfDocument.FromFile("multi_signed_report.pdf");

// Retrieve a list of `VerifiedSignature` objects from the document
pdf.GetVerifiedSignatures().ForEach(signature =>
{
    // Output the SignerName from each `VerifiedSignature`
    Console.WriteLine($"SignatureName: {signature.SignerName}");
});
```

The provided code snippet demonstrates the process of loading a PDF document and extracting the names of all signers using the `GetVerifiedSignatures` method. It then iterates over these signatures, printing each signer's common name to the console. The `SignerName` property pulls this information from the certificate's Subject Distinguished Name (SubjectDN), and will show a null response if the CN (Common Name) field is missing.

Here's the paraphrased section of the article with enhanced code comments and any relative URLs fully resolved:

```csharp
using IronPdf;
using System;

// Load the signed PDF to inspect its signatures
var pdfDocument = PdfDocument.FromFile("multi_signed_report.pdf");

// Retrieve all the verified signatures from the PDF and iterate through them
pdfDocument.GetVerifiedSignatures().ForEach(verifiedSignature =>
{
    // Display the name of the signer for each verified signature found in the document
    Console.WriteLine($"SignatureName: {verifiedSignature.SignerName}");
});
```

After loading the signed PDF document, we apply the `GetVerifiedSignatures` method to gather a collection of `VerifiedSignature` instances from the file, and then we display the `SignerName` of each signature.

Be aware that this information comes from the certificate’s Subject Distinguished Name (SubjectDN). If the CN (Common Name) field is missing in the certificate, the `SignerName` will return null.

## Next Steps

This tutorial has illustrated the robust and adaptable features of IronPDF for PDF signing tasks. Whether it’s enforcing secure digital signatures, controlling document revisions, embedding visual signatures, or integrating interactive signature forms, IronPDF delivers an all-encompassing and easy-to-use API for these needs.

To delve deeper into what IronPDF can offer, download the IronPDF library for .NET [here](https://ironpdf.com/download-modal) and secure a [free trial license](https://ironpdf.com/trial-license) to explore its full range of capabilities in your development projects.

Curious about more functionalities? Visit our detailed guide on securing and signing PDF files with C#: [Sign and Secure PDFs](https://ironpdf.com/tutorials/csharp-pdf-security-complete-tutorial/).

