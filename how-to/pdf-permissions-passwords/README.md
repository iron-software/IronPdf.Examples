# Setting Passwords and Permissions on PDF Files

***Based on <https://ironpdf.com/how-to/pdf-permissions-passwords/>***


<div class="alert alert-info iron-variant-1" role="alert">
Reduce your business expenditure on annual PDF security subscriptions. Look into <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> for a comprehensive suite of SaaS management solutions like digital signatures, encryption, redaction, and file protection — all available for a single purchase. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">View IronSecureDoc Documentation</a>
</div>

Password protecting a PDF encrypts the document, preventing unauthorized entry. There are typically two types of passwords: a user (open) password that someone needs to view the document and an owner (permissions) password, which set limits on printing, editing, and other functionalities.

IronPDF delivers full-spectrum support for securing your PDF files with intricate security and meta-data options, such as unprintable settings, read-only mode, and encryption using 128-bit security - all encapsulated in a robust password protection facility.

## Quickstart: Implementing Passwords and Permissions with IronPDF

Start securing your PDF documents swiftly with IronPDF. Below, we demonstrate how you can assign user and owner passwords and establish permissions to block unauthorized printing. By following these steps, you'll enhance the security of your PDF documents, making sure your confidential information stays protected. IronPDF simplifies embedding potent security into your C# .NET applications.

```cs
:title=Effortlessly Secure Your PDFs
var pdf = IronPdf.PdfDocument.FromFile("document.pdf");
pdf.SecuritySettings.OwnerPassword = "owner123";
pdf.SecuritySettings.UserPassword = "user123";
pdf.SecuritySettings.Permissions = IronPdf.Security.Permissions.NoPrinting;
pdf.SaveAs("secured_document.pdf");
```

## Password Protection for a PDF

Here’s how to secure a PDF using IronPDF, illustrated with an [example PDF](https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/unprotected.pdf). In this example, we will add a password, **password123**.

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Secret Information:</h1> Hello World");

// Set a password to edit the PDF
pdf.SecuritySettings.OwnerPassword = "123password";

// Set a password to open the PDF
pdf.SecuritySettings.UserPassword = "password123";

pdf.SaveAs("protected.pdf");
```

Now you can view the new password-protected [PDF here](https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/protected.pdf) using the password **password123**.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/protected.pdf" width="100%" height="500px">
</iframe>

## Accessing a Password-Protected PDF

Learn how to open a PDF with a password using the `PdfDocument.FromFile` method by supplying the correct password to unlock the document.

```csharp
using IronPdf;

var pdf = PdfDocument.FromFile("protected.pdf", "password123");

//... process PDF tasks

pdf.SaveAs("protected_2.pdf"); // Save as a different file
```

## Advanced Security and Permissions Options

The `PdfDocument` object allows further custom settings like setting the **Author** or **ModifiedDate**. You may also block User Annotations, Printing, and more as demonstrated below:

```csharp
using IronPdf;

// Open or create an encrypted PDF
var pdf = PdfDocument.FromFile("protected.pdf", "password123");

// Configure security settings
pdf.SecuritySettings.RemovePasswordsAndEncryption();
pdf.SecuritySettings.MakePdfDocumentReadOnly("secret-key");
pdf.SecuritySettings.AllowUserAnnotations = false;
pdf.SecuritySettings.AllowUserCopyPasteContent = false;
pdf.SecuritySettings.AllowUserFormData = false;
pdf.SecuritySettings.AllowUserPrinting = IronPdf.Security.PdfPrintSecurity.FullPrintRights;

// Output the secured PDF
pdf.SaveAs("secured.pdf");
```

Behavior of document passwords:
- **No password set**: Copy/paste remains disabled.
- **User password set**: Proper password entry enables copy/paste.
- **Owner password set**: User password alone does not allow copy/paste; however, the correct owner password does.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-permissions-passwords/permissions.webp" alt="Permissions window" class="img-responsive add-shadow">
    </div>
</div>

Explore more on predefined and customizable metadata in this detailed guide: "[How to Set and Edit PDF Metadata](https://ironpdf.com/how-to/metadata/)."

Discover more possibilities by visiting our tutorial: [Sign and Secure PDFs](https://ironpdf.com/tutorials/csharp-pdf-security-complete-tutorial/).