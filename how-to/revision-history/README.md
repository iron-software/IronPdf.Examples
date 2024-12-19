# Managing and Editing PDF Revision Histories with IronPDF

***Based on <https://ironpdf.com/how-to/revision-history/>***


PDF revision histories are crucial for tracking modifications in a PDF document, especially in collaborative settings where identifying who altered what and when is necessary. This is valuable across various industries where document integrity and revision traceability are essential.

IronPDF extends this functionality by enabling the management of revision histories and the ability to revert to specific versions in the context of digital signatures.

## Initialize IronPDF

--------

## Managing and Signing PDF Revisions

Below, we demonstrate how to load a PDF, apply changes, and then digitally sign it. We set the signing permissions to allow only form-filling on future modifications; other types of edits will void the signature. After editing, we employ `SaveAsRevision` to record the revision, then save the modified document to a local drive.

To enhance the efficiency of the PDF export, the `TrackChanges` option is set to false. To leverage the incremental save feature, it must be set to true.

```cs
using IronPdf;
using IronPdf.Rendering;

// Load PDF and activate change tracking
PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
// Perform edits...
pdf.SignWithFile("/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);

PdfDocument revisedPdf = pdf.SaveAsRevision();

revisedPdf.SaveAs("annual_census_2.pdf");
```

### Insights on Incremental Saving with Signatures

Different PDF viewers like Google Chrome display only the current version, but PDFs can store all past versions of the document akin to a version control system. This functionality can be observed in more sophisticated PDF viewers such as Adobe Acrobat.

The signing process is applied to the active version of a document, and it's important to note that there can be iterations with or without signatures, as illustrated below:

```html
<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;}
.tg td{border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;border-color:black;overflow:hidden;padding:10px 5px;word-break:normal;border-collapse:separate;}
.tg th{font-size:14px;font-weight:normal;overflow:hidden;padding:10px 5px;}
.tg .tg-8bgf{font-style:italic;text-align:center;vertical-align:top}
.tg .tg-baqh{text-align:center;vertical-align:top}
.tg .tg-c3ow{text-align:center;vertical-align:top}
.tg .tg-7btt{font-weight:bold;text-align:center;vertical-align:top}
.tg .tg-fymr{font-weight:bold;text-align:left;vertical-align:top}
.tg .tg-0pky{text-align:left;vertical-align:top}
.tg .tg-5frq{font-style:italic;text-align:center;vertical-align:top}
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
    <td class="tg-8bgf">0 (initial)</td>
    <td class="tg-c3ow">✅</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td>
  </tr>
  ...
  <tr>
    <td class="tg-8bgf">5</td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
  </tr>
</tbody>
</table>
```

## Reverting to a Previous Revision

To roll back to an earlier revision of a PDF, use `GetRevision`. This function discards any subsequent changes, including new signatures. Here's how to perform it:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("report.pdf");

int totalRevisions = pdf.RevisionCount; // Fetch the total number of revisions

PdfDocument previousPdf = pdf.GetRevision(2);
previousPdf.SaveAs("report-draft.pdf");
```

This example demonstrates reverting to the second revision and saving it as a separate file.