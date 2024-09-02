# Managing and Tracking PDF Revision History

PDF revision history is a crucial feature that allows seamless collaboration on documents by tracking and documenting changes over time. This becomes especially important when multiple stakeholders are involved, ensuring each change is recorded, along with details of the contributors and the timing of edits.

IronPdf excels in this area by providing robust capabilities to manage revision histories and revert to earlier versions of a document, especially within the context of digital signatures.

## Editing and Signing a PDF Revision

Consider the scenario where a PDF document undergoes editing, and you need to lock in those changes with a signature. Additionally, you would restrict post-signature modifications to only form filling to prevent invalidation of the signature. Here’s how you can accomplish this:

After making edits, commit the changes into the document’s revision history and then securely save the modified file. This preserves the edit history, enabling incremental saves that align with IronPdf's performance optimizations.

```cs
using IronPdf;
using IronPdf.Rendering;

// Load the PDF and enable change tracking
PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf", new PdfOptions { TrackChanges = ChangeTrackingModes.EnableChangeTracking });
// Insert various edits here...
pdf.SignWithFile("/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.FormFillingAllowed);

// Commit this version to the revision history
PdfDocument pdfWithRevision = pdf.SaveAsRevision();

// Save the updated document
pdfWithRevision.SaveAs("annual_census_2.pdf");
```

### Incremental Saving and Signatures

It's important to note that while some PDF viewers, like the Chrome browser, might display only the current version of a PDF, the document can store multiple versions, much like a version control system in software development. Tools like Adobe Acrobat are adept at displaying these versions.

Signing a PDF affects only the current version. Therefore, each version could either have signatures or remain unsigned depending on the actions taken at that stage. Below is a visualization of how signatures are applied across different iterations of a document:

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
    <td class="tg-8bgf">0 (first save)</td>
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
    <td class="tg-c3ow"></td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-5frq">3</td>
    <td class="tg-baqh">✅<br>(form field edits only)</td>
    <td class="tg-baqh">✅<br>(form field edits only)</td>
    <td class="tg-0lax"></td>
    <td class="tg-0lax"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">4 (only form fields edited)</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-c3ow">✅</td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">5</td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow">✅<br>(no further edits allowed)</td>
  </tr>
</tbody>
</table>

## Reverting to a Previous PDF Revision

To revert a PDF to an earlier version, effectively discarding any subsequent changes including newly added signatures, you can utilize the `GetRevision` method in IronPdf. Here is how you perform this action:

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("report.pdf");

int versions = pdf.RevisionCount; // Check how many revisions exist

// Revert to the desired prior version of the PDF
PdfDocument rolledBackPdf = pdf.GetRevision(2);
rolledBackPdf.SaveAs("report-draft.pdf");
```