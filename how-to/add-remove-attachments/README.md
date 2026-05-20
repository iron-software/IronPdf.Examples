# Managing PDF Attachments with IronPDF

***Based on <https://ironpdf.com/how-to/add-remove-attachments/>***


Attachments in a PDF are additional files or data stored within the PDF, separate from the main content which typically displays text, images, and formatting. These added files might be in the form of images, document files, spreadsheets, among others. They are particularly useful for including extraneous data or reference materials directly within a PDF.

## Quickstart: Embedded Attachments in PDFs

Using IronPDF, it's straightforward to integrate files into your PDF documents as attachments. This introductory guide walks you through the steps to embed a file into an existing PDF. Start by loading your PDF, apply the `AddAttachment` method, and then save the enriched document. This inclusion allows anyone with a PDF reader to access your added files directly.

```cs
:title=Efficient Handling of PDF Attachments
var pdf = IronPdf.PdfDocument.FromFile("example.pdf");
pdf.Attachments.AddAttachment("file.txt", System.IO.File.ReadAllBytes("file.txt"));
pdf.SaveAs("updated.pdf");
```

## How to Add an Attachment

To attach a file, first read it into your application as a `byte[]`, which is easily done using the `File.ReadAllBytes` method. Once loaded as a **byte array**, the file can be added into a PDF using the `AddAttachment` method like this:

```csharp
using IronPdf;
using System.IO;

// Loading the attachment
byte[] fileData = File.ReadAllBytes(@"path/to/file");

// Loading the PDF document
PdfDocument pdf = PdfDocument.FromFile("sample.pdf");

// Attaching the file to the PDF
pdf.Attachments.AddAttachment("Example", fileData);

pdf.SaveAs("addAttachment.pdf");
```

The method `AddAttachment` produces a **PdfAttachment** object that can be referenced or removed as needed.

Once the document is saved, the added attachment is accessible through the toolbar in any PDF viewing software, such as seen in Google Chrome's PDF Viewer depicted below:

![Viewing Attachments](https://ironpdf.com/static-assets/pdf/how-to/add-remove-attachments/attachment-example.png)

You can interact with this attachment by saving it locally from the viewer.

## Accessing Attached Files

To get binary data of attached files, you can call upon the **Attachments** property of the **PdfDocument**:

```csharp
using IronPdf;
using System.IO;

// Load the PDF with attachments
PdfDocument pdf = PdfDocument.FromFile("addAttachment.pdf");

// Process each attachment
foreach (var attachment in pdf.Attachments)
{
    if (attachment.Name.Contains("Example"))
    {
        // Save the data to a file
        File.WriteAllBytes($"{attachment.Name}.doc", attachment.Data);
    }
}
```

## How to Remove an Attachment

To discard an attachment from a PDF, use the `RemoveAttachment` function. It requires a reference to the attachment, typically accessed via the **Attachments** property shown in the previously saved PDF:

```csharp
using IronPdf;
using System.Linq;

// Load the PDF that has attachments
PdfDocument pdf = PdfDocument.FromFile("addAttachment.pdf");

// Retrieve attachments
PdfAttachmentCollection attachments = pdf.Attachments;

// Detach the first attachment found
pdf.Attachments.RemoveAttachment(attachments.First());

pdf.SaveAs("removeAttachment.pdf");
```

After deletion, when you open the PDF, the attachment will be absent, demonstrating its removal.

![Removed Attachment Preview](https://ironpdf.com/static-assets/pdf/how-to/add-remove-attachments/removeattachment-example.png)

Explore more capabilities of managing PDFs by visiting the tutorial page here: [Comprehensive Guide to Organizing PDFs](https://ironpdf.com/tutorials/organize-pdfs-complete-tutorial/).