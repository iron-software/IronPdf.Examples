# Managing and Storing PDF Revision History

***Based on <https://ironpdf.com/how-to/revision-history/>***


PDF revision history is an essential feature that allows tracking of amendments made to a PDF document over time. This function is crucial in environments where multiple collaborators need to maintain documentation of edits, noting who altered the content and when these changes were executed.

IronPDF integrates features that support the management of PDF revisions, enabling users to revert to previous versions of a document, especially useful in adherence to digital signatures.

## Quickstart: Implementing PDF Revisions with IronPDF

IronPDF simplifies the process for managing and preserving PDF document revisions within your C# applications. This short guide illustrates how easy it is to save different versions of a document using the `SaveAsRevision` method from IronPDF, thereby streamlining the tracking and management of PDF modifications. Start with loading a PDF document and save each iteration as a unique revision, ensuring comprehensive archival of changes.

```cs
// Title: How to Easily Save PDF Revisions
var pdf = IronPdf.PdfDocument.FromFile("example.pdf");
pdf.SaveAsRevision("revision1.pdf");
```

### Basic Workflow in 5 Steps

1. [Install the C# Library to Manage PDF Revision History with IronPDF](https://ironpdf.com/)
2. Apply the `SaveAsRevision` method to generate different versions of the PDF.
3. Use the `GetRevision` method to access specific revisions.
4. Check the `RevisionCount` property to determine how many revisions exist.
5. Advance to save and output your revised PDF.

## Version Control and Signature Integration in PDFs

Consider this example where we load a PDF, perform several modifications, and sign it just before saving. When setting up the signature, the permission for form-filling is specified as the only allowed modification post-signing; any additional changes will compromise the signature's validity.

Next, we will preserve this change history by employing `SaveAsRevision` and subsequently save the modified file locally.

This method enhances PDF export efficiency, though for activating incremental saves, the `TrackChanges` option must be set to true.

```csharp
// Importing and setting up PDF for editing and tracking changes
using IronPdf;
using IronPdf.Rendering;

PdfDocument pdf = PdfDocument.FromFile("annual_census.pdf", TrackChanges: ChangeTrackingModes.EnableChangeTracking);
// Different edits are performed here...
pdf.SignWithFile("/assets/IronSignature.p12", "password", null, IronPdf.Signing.SignaturePermissions.AdditionalSignaturesAndFormFillingAllowed);

PdfDocument pdfWithRevision = pdf.SaveAsRevision();
pdfWithRevision.SaveAs("annual_census_2.pdf");
```

### Deep Dive into Incremental Saving for PDF Signatures

Some PDF viewers, like Chrome, display only the current version of the document; however, PDFs can store earlier versions akin to a repository's commit history seen in systems like Git. Advanced PDF viewers like Adobe Acrobat will exhibit these versions.

When signing PDFs, it's critical to recognize that the signature applies to the present version of the document. Your PDF might have signatures on previous iterations or may include subsequent unsigned versions.

The table below showcases an example of a document going through multiple iterations. In this document, different operations like signing and form field editing have been conducted across various versions:

```html
<!-- Table showcasing revision tracking with signatures and form field edits -->
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
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">1</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"></td
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
    <td class="tg-baqh"><br>(form field edits only)</td>
    <td class="tg-baqh"><br>(form field edits only)</td>
    <td class="tg-0lax"></td>
    <td class="tg-0lax"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">4 (form fields altered)</td>
    <td class="tg-0pky"></td>
    <td class="tg-0pky"></td>
    <td class="tg-c3ow"></td>
    <td class="tg-0pky"></td>
  </tr>
  <tr>
    <td class="tg-8bgf">5</td>
    <td class="tg-c3ow"><br>(no subsequent edits permissible)</td>
    <td class="tg-c3ow"><br>(no subsequent edits permissible)</td>
    <td class="tg-c3ow"></td>
    <td class="tg-c3ow"><br>(no subsequent edits permissible)</td>
  </tr>
</tbody>
</table>
```

## Reverting to a Previous PDF Revision

To revert to an earlier version of a PDF document, utilize the `GetRevision` method. This action disregards any subsequent changes including newer signatures, effectively rolling the document back to a specified revision.

```csharp
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("report.pdf");

int versions = pdf.RevisionCount; // Retrieve the total number of revisions

PdfDocument rolledBackPdf = pdf.GetRevision(2); // Navigate to the desired revision
rolledBackPdf.SaveAs("report-draft.pdf");
```