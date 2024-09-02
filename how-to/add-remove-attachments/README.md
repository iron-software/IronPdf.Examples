# Manipulating PDF Attachments with IronPdf

Attachments within a PDF are separate files or data embedded in the PDF itself, distinct from the visible text, images, and formatting. These embedded files can be diverse, such as images, documents, or spreadsheets, and are typically used to provide additional reference material or data accessible within the PDF.

Handling attachments in IronPdf is designed to be clear-cut and user-friendly.

## Example of Adding an Attachment

To embed a file into a PDF, begin by loading the file into a **byte []** array, using the `File.ReadAllBytes` method. Once the file is in **byte []** format, you can embed it into the PDF with the `AddAttachment` method as follows:

```cs
using IronPdf;
using System.IO;

// Import the file as a byte array
byte[] fileData = File.ReadAllBytes(@"path/to/file");

// Load an existing PDF
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Embed the file as an attachment
pdf.Attachments.AddAttachment("Example", fileData);

// Save the modified PDF
pdf.SaveAs("addAttachment.pdf");
```

When using the `AddAttachment` method, it returns a **PdfAttachment** object for later reference or removal, if necessary.

Once the PDF is saved, you can access the attachment through the toolbar of any PDF viewer. For example, in Google Chrome's PDF Viewer, the attachment feature appears as demonstrated in the following image:

![Attachment Preview](https://ironpdf.com/static-assets/pdf/how-to/add-remove-attachments/attachment-example.png)

Clicking on the attachment allows you to save it locally.

## Example of Removing an Attachment

Removing an attachment is just as straightforward. Use the `RemoveAttachment` method, which requires a reference to the desired attachment. This reference can be obtained from the **Attachments** property of the document. Here's how you can perform this task:

```cs
using IronPdf;
using System.Linq;

// Load the PDF with the previously added attachment
PdfDocument pdf = PdfDocument.FromFile("addAttachment.pdf");

// Retrieve the collection of current attachments
PdfAttachmentCollection retrieveAttachments = pdf.Attachments;

// Remove the first attachment found
pdf.Attachments.RemoveAttachment(retrieveAttachments.First());

// Save the new version of the PDF without the attachment
pdf.SaveAs("removeAttachment.pdf");
```

After removal, if you open the modified PDF in a viewer, the attachment will no longer be present:

![Attachment Preview](https://ironpdf.com/static-assets/pdf/how-to/add-remove-attachments/removeattachment-example.png)