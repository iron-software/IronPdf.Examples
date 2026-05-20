# Managing PDF Metadata with IronPDF

***Based on <https://ironpdf.com/how-to/metadata/>***


PDF metadata encompasses various details about the document such as the document's title, author, subject, keywords, and dates of creation and modification. This metadata enhances the discoverability and organization of PDF files, making them more accessible in databases and on the web.

## Quick Guide: Instant PDF Metadata Modification

With IronPDF, updating the metadata of your PDF files is a breeze. Simply load the PDF, modify the metadata fields like title, author, or keywords, and save the updated file. This tutorial will guide you through the process of efficiently managing your PDF metadata, ensuring your documents are well-structured and easy to locate. 

```cs
:title=Efficiently Edit PDF Metadata
IronPdf.PdfDocument.FromFile("example.pdf")
    .MetaData = new IronPdf.PdfMetaData { 
        Title="NewDocumentTitle", Author="AuthorName", Subject="SampleSubject", Keywords="PDF, edit, metadata", Creator="YourApplication", Producer="IronPDF", CreationDate=DateTime.UtcNow, ModifiedDate=DateTime.UtcNow 
    }
    .SaveAs("new_example.pdf");
```

## Editing and Setting Metadata Example
 
IronPDF simplifies the manipulation of standard metadata fields in PDF documents. Below is how you can use the **MetaData** property to edit these fields.

```csharp
using IronPdf;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example Metadata</h1>");

// Setting metadata fields directly via the MetaData object.
pdf.MetaData.Author = "Developer";
pdf.MetaData.CreationDate = DateTime.UtcNow;
pdf.MetaData.Creator = "IronPDF Sample";
pdf.MetaData.Keywords = "example, pdf";
pdf.MetaData.ModifiedDate = DateTime.UtcNow;
pdf.MetaData.Producer = "IronPDF";
pdf.MetaData.Subject = "Setting Metadata Example";
pdf.MetaData.Title = "Learning IronPDF Metadata";

pdf.SaveAs("example-metadata.pdf");
```

### PDF Metadata Visualization

To inspect the metadata of your document, use the options in any PDF viewer to navigate to the Document Properties view.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/metadata/pdf-with-metadata.pdf" width="100%" height="400px"></iframe>

## Manage and Access Metadata Dictionary

With `GetMetaDataDictionary` and `SetMetaDataDictionary` methods, you can retrieve and edit the metadata dictionary of a PDF. This functionality permits both standard updates and the introduction of custom metadata properties.

```csharp
using IronPdf;
using System.Collections.Generic;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata Dictionary Example</h1>");

Dictionary<string, string> newMetadata = new Dictionary<string, string>();
newMetadata.Add("Title", "IronPDF Tutorial");
newMetadata.Add("Author", "Iron Software");

// Set the metadata dictionary
pdf.MetaData.SetMetaDataDictionary(newMetadata);

// Retrieve the metadata dictionary
Dictionary<string, string> metadataProperties = pdf.MetaData.GetMetaDataDictionary();
```

### Examine PDF Metadata

View the document properties by selecting the appropriate option in your PDF viewer toolbar.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/metadata/set-and-get-metadata-dictionary.pdf" width="100%" height="400px"></iframe>

## Modifying Custom Metadata in PDFs

Beyond the basic metadata, IronPDF allows the inclusion of custom metadata fields that might not be automatically displayed by standard PDF viewers.

### Adding and Modifying Custom Metadata

Here’s how to employ the **CustomProperties** for adding and adjusting custom metadata entries.

```csharp
using IronPdf;
using IronPdf.MetaData;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Custom Metadata</h1>");

PdfCustomMetadataProperties customProperties = pdf.MetaData.CustomProperties;

// Adding a custom metadata property
customProperties.Add("uniqueKey", "initialValue");

// Modifying the custom metadata property
customProperties["uniqueKey"] = "updatedValue";
```

### Removing Custom Metadata

Custom metadata can be removed from your PDF in the following ways:

```csharp
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Removing Metadata</h1>");

// Preparing a custom property for removal
pdf.MetaData.CustomProperties.Add("toBeRemoved", "dummyValue");

// Removing custom metadata: two options
pdf.MetaData.RemoveMetaDataKey("toBeRemoved");
pdf.MetaData.CustomProperties.Remove("toBeRemoved");
```

Explore more possibilities with IronPDF: [Check out our complete PDF security tutorial!](https://ironpdf.com/tutorials/csharp-pdf-security-complete-tutorial/)