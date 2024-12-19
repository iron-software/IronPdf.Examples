# How to Add and Edit PDF Annotations

***Based on <https://ironpdf.com/how-to/annotations/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Save time and resources by switching to IronSecureDoc for PDF security needs including digital signing, redaction, encryption, and more—all through a one-time fee service. Learn more and access IronSecureDoc resources with these links:
    <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc Solutions</a> and <a href="https://ironsoftware.com/enterprise/securedoc/docs/">IronSecureDoc Documentation</a>
</div>

Annotations in PDFs serve as a medium for users to append comments, notes, or supplementary data to distinct sections of the document. This feature is key for enhancing the user experience by facilitating richer collaboration and communication.

---

**Begin with IronPDF!**

---

## Example of Adding Annotations

Annotations in PDFs are similar to "sticky note" comments, placed on PDF pages using the `Add` method under the **Annotations** property.

Page indexes operate on a zero-based index system.

```cs
using IronPdf;
using IronPdf.Annotations;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Annotation Example</h1>");

// Instantiate a new PDF annotation object on a desired page index
TextAnnotation annotation = new TextAnnotation(0)
{
    Title = "Note Title",
    Contents = "Detailed description and comments go here...",
    X = 50,
    Y = 700,  // Position the annotation at coordinates X=50, Y=700
};

// Append the annotation
pdf.Annotations.Add(annotation);
pdf.SaveAs("NewAnnotation.pdf");  // Save the PDF with annotations
```

#### Visualizing a PDF with Annotations

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/annotation.pdf" width="100%" height="400px">
</iframe>

The displayed PDF can be viewed in the Chrome browser.

---

## Retrieve and Modify Annotations Example

Modifying PDF annotations after retrieving them is crucial for boosting collaboration through increased precision and usability. Accessing and updating annotation properties can be managed via the **Annotations** property.

```cs
using IronPdf;
using IronPdf.Annotations;
using System.Linq;

PdfDocument pdf = PdfDocument.FromFile("annotation.pdf");

// Access all annotations
PdfAnnotationCollection annotationCollection = pdf.Annotations;

// Select an existing annotation
TextAnnotation annotation = (TextAnnotation)annotationCollection.First();

// Modify annotation details
annotation.Title = "Updated Title";
annotation.Contents = "Updated content details...";
annotation.X = 150;  // New X position
annotation.Y = 800;  // New Y position

pdf.SaveAs("ModifiedAnnotation.pdf");
```

#### PDF Showcasing an Edited Annotation

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/editedAnnotation.pdf" width="100%" height="400px">
</iframe>

This modified annotation can be viewed using the Chrome browser.

---

## How to Remove Annotations from PDFs

Effortlessly eliminate unwanted or outdated annotations with methods like `RemoveAt`, `RemoveAllAnnotationsForPage`, and `Clear`.

### Removing a Specific Annotation

To delete a particular annotation, use the `RemoveAt` method and specify the index relevant to the annotation array.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");

// Specify the annotation index to remove
pdf.Annotations.RemoveAt(1);

pdf.SaveAs("DeletedAnnotation.pdf");
```

#### Displaying the Removal of an Annotation from a PDF

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

View this PDF in the Chrome browser to see the annotation removal.

### Bulk Removal of Annotations

For deleting all annotations on a specified page or within the entire document, employ `RemoveAllAnnotationsForPage` and `Clear` respectively.

```cs
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");

// Command to remove all annotations from a specific page
pdf.Annotations.RemoveAllAnnotationsForPage(0);

// Command to clear all annotations from the document
pdf.Annotations.Clear();

pdf.SaveAs("AllAnnotationsRemoved.pdf");
```