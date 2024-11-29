# How to Document and Utilize PDF Revision Histories

***Based on <https://ironpdf.com/how-to/revision-history/>***


Tracking changes in a PDF forms a crucial function when managing document workflows, especially in collaborative environments. It ensures each alteration is recorded—detailing the author and the time of the modification—and is especially handy when integrated with digital signatures. IronPDF supports this functionality by allowing you to navigate through different versions of a PDF and revert to any previous state if needed.

## Implement and Authenticate PDF Revisions

The process below illustrates opening a PDF, performing edits, and signing it before saving. This example sets signature permissions to permit only form-filling for subsequent modifications, as other types of edits will compromise the signature.

We'll execute the `SaveAsRevision` method to record the revision history, then save the updated document to a file.

To optimize the performance of PDF exports, the `TrackChanges` setting is initially off. You must turn it on (`true`) to enable the incremental saving feature.

```cs
using IronPdf.Rendering;
using IronPdf;
namespace ironpdf.RevisionHistory
{
    public class EditAndSignSection
    {
        public void Execute()
        {
            // Load PDF with change tracking enabled
            PdfDocument document = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
            // Perform various edits...
            document.SignWithFile("/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);
            
            PdfDocument revisedDocument = document.SaveAsRevision();
            
            revisedDocument.SaveAs("annual_census_2.pdf");
        }
    }
}
```

### Grasping Incremental Saving in Signature Contexts

Though some PDF viewers like Chrome might display only the latest version, PDFs inherently can maintain ancestral versions akin to a Git repository. This multi-version capacity is more apparent in sophisticated viewers like Adobe Acrobat.

Signing a PDF applies only to the visible iteration. Therefore, each signed PDF could carry signatures that pertain to its current or previous iterations. Here’s a visual representation:

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-8bgf{border-color:inherit;font-style:italic;text-align:center;vertical-align:top}
.tg .tg-baqh{text-align:center;vertical-align:top}
.tg .tg-c3ow{border-color:inherit;text-align:center;vertical-align:top}
.tg .tg-7btt{border-color:inherit;font-weight:bold;text-align:center;vertical-align:top}
.tg .tg-fymr{border-color:inherit;font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-0pky{border-color:inherit;text-align:left;vertical-align:top}
.tg .tg-5frq{font-style:italic;text-align:center;vertical-align:top}
.tg .tg-0lax{text-align:left;vertical-align:top}
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
    <td class="tg-8bgf">0 (initial save)</td>
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
    <td class="tg-c3ow"></td