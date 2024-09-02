# Managing PDF Metadata

PDF metadata encompasses descriptive details about the document, such as title, author, subject, keywords, and various date-related information. This metadata enhances the searchability and indexing of PDFs across databases and on the internet.

## Example: Setting and Modifying Metadata

With IronPDF, adjusting a PDF's basic metadata fields is a simple task. Just interact with the **MetaData** property to alter these settings.

```cs
using IronPdf;
using System;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata Example</h1>");

// Setting various metadata fields
pdf.MetaData.Author = "Iron Software";
pdf.MetaData.CreationDate = DateTime.Today;
pdf.MetaData.Creator = "IronPDF";
pdf.MetaData.Keywords = "PDF, Metadata, IronPDF";
pdf.MetaData.ModifiedDate = DateTime.Now;
pdf.MetaData.Producer = "IronPDF";
pdf.MetaData.Subject = "Tutorial on Metadata";
pdf.MetaData.Title = "Guide to PDF Metadata with IronPDF";

pdf.SaveAs("example-metadata.pdf");
```

### View the Resulting PDF

Open the document properties from the viewer menu to check the metadata.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/metadata/pdf-with-metadata.pdf" width="100%" height="400px">
</iframe>

## Manipulating Metadata Dictionary

Use the `GetMetaDataDictionary` and `SetMetaDataDictionary` methods from IronPDF to fetch and modify the full metadata dictionary. This approach allows the addition of non-standard metadata properties. 

```cs
using IronPdf;
using System.Collections.Generic;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Advanced Metadata</h1>");

Dictionary<string, string> updatedMetadata = new Dictionary<string, string>();
updatedMetadata.Add("Title", "Detailed Article");
updatedMetadata.Add("Author", "IronPDF Team");

// Updating the metadata dictionary
pdf.MetaData.SetMetaDataDictionary(updatedMetadata);

// Retrieving the metadata for verification
Dictionary<string, string> metadataEntries = pdf.MetaData.GetMetaDataDictionary();
```

### Output PDF

Check the updated metadata by accessing the document properties from the viewer menu.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/metadata/set-and-get-metadata-dictionary.pdf" width="100%" height="400px">
</iframe>

## Custom Metadata: Adding, Modifying, and Removing

IronPDF allows for the integration of custom metadata properties that may not be typically visible in standard PDF viewers.

### Add and Modify Custom Metadata

```cs
using IronPdf;
using IronPdf.MetaData;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Custom Metadata</h1>");

PdfCustomMetadataProperties customProperties = pdf.MetaData.CustomProperties;

// Adding a new custom metadata entry
customProperties.Add("exampleKey", "initialValue");

// Modifying the custom metadata
customProperties["exampleKey"] = "updatedValue";
```

### Deleting Custom Metadata

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Remove Metadata</h1>");

// Adding and then preparing to remove the custom metadata
pdf.MetaData.CustomProperties.Add("temporaryKey", "temporaryValue");

// Two methods to remove custom metadata
pdf.MetaData.RemoveMetaDataKey("temporaryKey");
pdf.MetaData.CustomProperties.Remove("temporaryKey");
```

This demonstrates the robust capabilities of IronPDF in customizing PDF metadata according to specific requirements.