# Setting Passwords and Permissions on PDF Files

<div class="alert alert-info iron-variant-1" role="alert">
	Is your organization looking to cut expenses on annual subscriptions for PDF security? Explore <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, offering a one-time purchase solution for services like digital signing, redaction, and encryption. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Explore the features here</a>.
</div>

Password protection ensures that access to the document is limited to authorized users. This usually involves two kinds of passwords: the user password (or open password) needed to read the document, and the owner password (or permissions password) that manages permissions like editing and printing.

IronPDF delivers comprehensive support for both password protection and permission settings on PDF documents. Whether it's applying non-printable, read-only, or encrypted statuses to your PDFs, leveraging 128-bit encryption for security, or enabling password protection, IronPDF has you covered.

## Apply a Password to a PDF

Below is an instance where we aim to secure an [example PDF](https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/unprotected.pdf) using IronPDF. We will implement a code that assigns the password **password123**.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Confidential Info:</h1> Greetings");

// Setting the password for editing the PDF
pdf.SecuritySettings.OwnerPassword = "123password";

// Establishing the password for opening the PDF
pdf.SecuritySettings.UserPassword = "password123";

pdf.SaveAs("protected.pdf");
```

View the secured PDF by entering the password **password123** in the viewer below.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/protected.pdf" width="100%" height="500px">
</iframe>

## Accessing a Password-Protected PDF

To open a password-protected PDF, use the `PdfDocument.FromFile` method, which has an optional password parameter. Input the correct password to open the document.

```cs
using IronPdf;

var pdf = PdfDocument.FromFile("protected.pdf", "password123");

//... various PDF operation actions

pdf.SaveAs("protected_2.pdf"); // Saving it as a different file
```

## Advanced Security and Permission Adjustments

The **PdfDocument** object also allows setting metadata like **Author** and **ModifiedDate**. Further, it enables controlling permissions such as disallowing user annotations or printing as demonstrated below:

```cs
using IronPdf;

// Either open an encrypted PDF or create a new one from HTML
var pdf = PdfDocument.FromFile("protected.pdf", "password123");

// Adjust file security settings
// The next lines make the PDF read-only and restrict copy & paste and printing capabilities
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// The finalized PDF is then saved securely
pdf.SaveAs("secured.pdf");
```

The behavior of these permission settings is conditioned by the presence of passwords. For instance, disabling the **AllowUserCopyPasteContent** without any password keeps the copy/paste blocked, setting a user password enables it upon authentication, and an owner password fully controls the access to copy/paste functionality.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/permissions.webp" alt="Permissions window" class="img-responsive add-shadow">
    </div>
</div>

For additional insights, check out the related topic on how to [Adjust and Customize PDF Metadata](https://ironpdf.com/how-to/metadata/).