# Managing PDF Metadata with IronPDF

***Based on <https://ironpdf.com/how-to/metadata/>***


PDF metadata consists of details that describe the document, such as the title, author, subject, keywords, creation and modification dates, among others. Effective management of metadata enhances a PDF's discoverability and organization in databases and on the web.

***

***

## Example: Setting and Modifying Metadata

IronPDF simplifies modifying metadata fields in PDF documents. You can manipulate these fields by accessing the `MetaData` property.

```cs
using System;
using IronPdf;
namespace ironpdf.Metadata
{
    public class MetadataExample
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata Example</h1>");

            // Set metadata fields using the MetaData class.
            pdf.MetaData.Author = "Iron Software";
            pdf.MetaData.CreationDate = DateTime.Today;
            pdf.MetaData.Creator = "IronPDF";
            pdf.MetaData.Keywords = "ironsoftware, ironpdf, pdf";
            pdf.MetaData.ModifiedDate = DateTime.Now;
            pdf.MetaData.Producer = "IronPDF";
            pdf.MetaData.Subject = "PDF Metadata Manipulation";
            pdf.MetaData.Title = "Understanding IronPDF Metadata";

            pdf.SaveAs("enhanced-metadata.pdf");
        }
    }
}
```

### Viewing Metadata in a PDF

To inspect the metadata of a PDF, navigate to the Document Properties through the menu symbolized by three vertical dots.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/metadata/pdf-with-metadata.pdf" width="100%" height="400px">
</iframe>

## Metadata Retrieval and Modification in IronPDF

`GetMetaDataDictionary` allows extraction of metadata from a PDF, and `SetMetaDataDictionary` provides a method to overwrite or add metadata entries.

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.Metadata
{
    public class MetadataDictionaryExample
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument document = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");

            var metadataUpdates = new Dictionary<string, string>
            {
                {"Title", "Detailed Article"},
                {"Author", "Iron Software"}
            };

            // Update metadata dictionary
            document.MetaData.SetMetaDataDictionary(metadataUpdates);

            // Retrieve updated metadata
            var metaDataInfo = document.MetaData.GetMetaDataDictionary();
        }
    }
}
```

### Viewing Updated Metadata

Access the Document Properties through the vertical menu dots to see the updated metadata.

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/metadata/set-and-get-metadata-dictionary.pdf" width="100%" height="400px">
</iframe>

## Handling Custom Metadata Entries

IronPDF lets you add, modify, and delete custom metadata fields which are generally not visible in standard PDF viewers.

### Adding and Modifying Custom Metadata

```cs
using IronPdf.MetaData;
using IronPdf;
namespace ironpdf.Metadata
{
    public class CustomMetadataExample
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Metadata</h1>");
            
            PdfCustomMetadataProperties customProperties = pdf.MetaData.CustomProperties;
            
            // Add a custom metadata property
            customProperties.Add("exampleKey", "initialValue");
            
            // Modify the custom metadata property
            customProperties["exampleKey"] = "updatedValue";
        }
    }
}
```

### Removing Custom Metadata

You have multiple ways to erase custom metadata entries, either directly from the `CustomProperties` or by using specific methods provided by IronPDF.

```cs
using IronPdf;
namespace ironpdf.Metadata
{
    public class RemoveCustomMetadataExample
    {
        public void Execute()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Remove Metadata</h1>");
            
            // Add then remove a custom metadata property
            pdf.MetaData.CustomProperties.Add("temporaryInfo", "temporaryValue");
            
            // Demonstrating two removal methods
            pdf.MetaData.CustomProperties.Remove("temporaryInfo");
            pdf.MetaData.RemoveMetaDataKey("temporaryInfo");
        }
    }
}
```
This brief provides an introduction to managing PDF metadata with IronPDF, facilitating the handling of both standard and custom metadata entries.