# How to Add and Edit PDF Annotations

<div class="alert alert-info iron-variant-1" role="alert">
	Is your business overspending on annual PDF security services? Switch to <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a> for integrated solutions in digital signing, redaction, encryption, and protection at a one-off cost. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Give it a try</a>
</div>

Annotations in PDFs are essential for adding remarks, notes, or extra information to distinct parts of a document, fostering better teamwork and communication. This functionality is crucial for annotating, commenting, and contextualizing contents in a collaborative environment.

## Example of Adding Annotations

The capability to insert annotations akin to "sticky notes" into PDF documents can be achieved using the `Add` method from the **Annotations** property. All pages in the document are indexed starting from zero.

```cs
using IronPdf;
using IronPdf.Annotations;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Annotation</h1>");

// Instantiate a PDF annotation object on the first page
TextAnnotation annotation = new TextAnnotation(0)
{
    Title = "Note Title",
    Contents = "Extended comment in form of a 'sticky note'...",
    X = 50,
    Y = 700,
};

// Insert the annotation into the PDF
pdf.Annotations.Add(annotation);
pdf.SaveAs("annotatedPDF.pdf");
```

#### PDF Displaying an Annotation

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/annotation.pdf" width="100%" height="400px">
</iframe>

You can view the annotated document using the Chrome browser.

<hr class="separator">

## Example of Retrieving and Editing Annotations

Enhancing collaboration through the precise and clear amendment of PDF annotations is seamless by accessing and modifying their properties. Utilize the **Annotations** property to fetch and adjust annotations effectively.

```cs
using IronPdf;
using IronPdf.Annotations;
using System.Linq;

PdfDocument pdf = PdfDocument.FromFile("annotation.pdf");

// Fetch the collection of annotations
PdfAnnotationCollection annotations = pdf.Annotations;

// Choose the very first annotation in the collection
TextAnnotation annotation = annotations.First() as TextAnnotation;

// Modify the selected annotation
annotation.Title = "Updated Title";
annotation.Contents = "Revised content...";
annotation.X = 150;
annotation.Y = 800;

pdf.SaveAs("updatedAnnotation.pdf");
```

#### PDF Showing an Edited Annotation

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/editedAnnotation.pdf" width="100%" height="400px">
</iframe>

This edited PDF can also be viewed in Chrome browser.

<hr class="separator">

## Example of Removing Annotations

Annotations can be removed effortlessly, whether individually or in bulk, with methods like `RemoveAt`, `RemoveAllAnnotationsForPage`, and `Clear`.

### Removing a Single Annotation

Use the `RemoveAt` method to delete an annotation at a specified index.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");

// Target and remove an annotation by index
pdf.Annotations.RemoveAt(1);

pdf.SaveAs("singleRemovedAnnotation.pdf");
```

#### Single Annotation Removal Displayed on PDF

<div class="competitors-section__wrapper-even-1">
    <div class="competitors__card" style="width: 48%;">
        <iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/multipleAnnotation.pdf#zoom=70" width="100%" height="400px" align="left"></iframe>
        <p class="competitors__download-link" style="color: #181818; font-style: italic;">
            Before
        </p>
    </div>
    <div class="competitors__card" style="width: 48%;">
        <iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/removeSingleAnnotation.pdf#zoom=70" width="100%" height="400px" align="right"></iframe>
        <p class="competitors__download-link" style="color: #181818; font-style: italic;">
            After
        </p>
    </div>
</div> 

This display is also viewable in the Chrome browser.

### Removing All Annotations

To eliminate all annotations on a specific page or throughout the entire document, use the `RemoveAllAnnotationsForPage` or `Clear` methods, respectively.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");

// Remove all annotations from a specific page
pdf.Annotations.RemoveAllAnnotationsForPage(0);

// Clear all annotations from the document
pdf.Annotations.Clear();

pdf.SaveAs("allRemovedAnnotations.pdf");
```