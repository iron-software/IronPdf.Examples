# How to Manage PDF Metadata

***Based on <https://ironpdf.com/how-to/metadata/>***


Metadata within a PDF document encompasses various descriptive details about the document, including its title, author, subject, keywords, and creation and modification dates. This metadata enhances the document's indexing capabilities within databases and improves its visibility on internet searches.

***

<h3>Introduction to IronPDF</h3>

***

## Example: Setting and Modifying Metadata

IronPDF makes it simple to adjust the metadata of your PDF documents. By accessing the **MetaData** property, you can easily change these details.

```cs
using IronPdf;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");

// Modify the specific metadata properties using the MetaData class.
pdf.MetaData.Author = "Iron Software";
pdf.MetaData.CreationDate = DateTime.Today;
pdf.MetaData.Creator = "IronPDF";
pdf.MetaData.Keywords = "ironsoftware,ironpdf,pdf";
pdf.MetaData.ModifiedDate = DateTime.Now;
pdf.MetaData.Producer = "IronPDF";
pdf.MetaData.Subject = "Understanding Metadata";
pdf.MetaData.Title = "Exploring Metadata with IronPDF";

pdf.SaveAs("enhanced-pdf-metadata.pdf");
```

### Viewing the Updated PDF

To inspect the updated metadata, click the three vertical dots in your PDF reader and navigate to "Document properties."

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/metadata/pdf-with-metadata.pdf" width="100%" height="400px"></iframe>

## Managing Metadata Through a Dictionary

To manage the metadata more flexibly, IronPDF allows you to interact with a dictionary of metadata. This approach facilitates the addition of custom metadata items.

```cs
using IronPdf;
using System.Collections.Generic;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");

Dictionary<string, string> updatedMetadata = new Dictionary<string, string>();
updatedMetadata.Add("Title", "IronPDF Metadata Guide");
updatedMetadata.Add("Author", "Iron Software");

// Apply the new metadata dictionary
pdf.MetaData.SetMetaDataDictionary(updatedMetadata);

// Fetch and review the metadata
Dictionary<string, string> metadataDetails = pdf.MetaData.GetMetaDataDictionary();
```

### Viewing Metadata in the PDF

To see the assigned metadata, access "Document properties" in your PDF reader by clicking the three dots icon.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/metadata/set-and-get-metadata-dictionary.pdf" width="100%" height="400px"></iframe>

## Adding, Modifying, and Removing Custom Metadata

Beyond standard metadata, IronPDF enables the inclusion of custom metadata properties which might not typically be shown in standard PDF viewers.

### How to Add and Modify Custom Metadata

This process involves using the **CustomProperties** property for adding or changing custom metadata values.

```cs
using IronPdf;
using IronPdf.MetaData;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");

PdfCustomMetadataProperties customMetadata = pdf.MetaData.CustomProperties;

// Insert a new custom metadata entry
customMetadata.Add("uniqueKey", "initialValue");

// Update the value of an existing entry
customMetadata["uniqueKey"] = "updatedValue";
```

### Removing Custom Metadata

IronPDF provides two methods to eliminate custom metadata from a PDF.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");

// Initially add a custom property to demonstrate deletion
pdf.MetaData.CustomProperties.Add("toBeRemoved", "sampleValue");

// Example methods to remove a custom metadata entry
pdf.MetaData.RemoveMetaDataKey("toBeRemoved"); // First method
pdf.MetaData.CustomProperties.Remove("toBeRemoved"); // Second method
```