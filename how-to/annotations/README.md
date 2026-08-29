# How to Add and Edit PDF Annotations

> Full guide: [How to Add and Edit PDF Annotations](https://ironpdf.com/how-to/annotations/)


<div class="alert alert-info iron-variant-1" role="alert">
Businesses looking to reduce their annual expenses on PDF security and compliance should consider <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>. IronSecureDoc offers solutions for digital signing, redaction, encryption, and protection without recurring subscription fees. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">View IronSecureDoc Documentation</a>
</div>

Annotations are powerful tools for adding comments, reminders, or extra details to specific parts of a document. They foster better collaboration and communication when working with PDF files, allowing users to annotate, comment, and provide context on shared documents.

## Quickstart: How to Add Annotations to PDFs using IronPDF

This quick guide illustrates how to easily insert text annotations into a PDF document with IronPDF in C#. With just a few lines of code, developers can add comments or notes, increasing document interactivity and enhancing collaboration. Begin by loading the PDF and applying the `AddTextAnnotation` method to insert text annotations swiftly.

```cs
PdfDocument.FromFile("input.pdf")
    .Annotations.Add(new TextAnnotation(0) { Title="Note", Contents="Review this section.", X=50, Y=700 })
    .SaveAs("annotated.pdf");
```

<hr class="separator">

## Add Annotations Example

PDF annotations enable the addition of comments in a "sticky note" fashion to PDF pages. Annotations can be added programmatically using the `Add` method on the **Annotations** property. Remember that all page indexes are zero-based.

```csharp
using IronPdf;
using IronPdf.Annotations;

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Annotation</h1>");

// Instantiate a TextAnnotation object for a specific page index
TextAnnotation annotation = new TextAnnotation(0)
{
    Title = "Annotation example",
    Contents = "Here is a detailed comment added as an annotation...",
    X = 50,
    Y = 700,
};

// Append the annotation to the PDF
pdf.Annotations.Add(annotation);
pdf.SaveAs("annotation.pdf");
```

#### PDF with an Annotation

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/annotation.pdf" width="100%" height="400px">
</iframe>

The above PDF document with an annotation can be viewed using the Chrome browser.

<hr class="separator">

## Retrieve and Edit Annotations Example

Enhancing PDF annotations aids in boosting collaboration by making documents clearer, more precise, and user-friendly. Access the annotation collection via the **Annotations** property and modify properties such as Title, Contents, X, Y, etc., to update them.

```csharp
using IronPdf;
using IronPdf.Annotations;
using System.Linq;

PdfDocument pdf = PdfDocument.FromFile("annotation.pdf");

// Access the collection of annotations
PdfAnnotationCollection annotationCollection = pdf.Annotations;

// Select the first in the list
TextAnnotation annotation = (TextAnnotation)annotationCollection.First();

// Modify the selected annotation
annotation.Title = "Updated title";
annotation.Contents = "Updated content...";
annotation.X = 150;
annotation.Y = 800;

pdf.SaveAs("editedAnnotation.pdf");
```

#### PDF with an Edited Annotation

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/editedAnnotation.pdf" width="100%" height="400px">
</iframe>

The edited annotation in the PDF document can be previewed using the Chrome browser.

<hr class="separator">

## Remove Annotation Example

The following methods: `RemoveAt`, `RemoveAllAnnotationsForPage`, and `Clear`, facilitate the easy removal of obsolete or unwarranted annotations.

### Remove a Single Annotation

The `RemoveAt` method allows for the deletion of a single annotation, identified by its index in the annotation collection.

```csharp
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");

// Specify the index to remove a single annotation
pdf.Annotations.RemoveAt(1);

pdf.SaveAs("removeSingleAnnotation.pdf");
```

#### Removed a Single Annotation on PDF

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

The deletion of a single annotation can be viewed in the PDF document using the Chrome browser.

### Remove All Annotations

For removing all annotations from a particular page, employ the `RemoveAllAnnotationsForPage` method and indicate the page index. To erase all annotations within the entire document, simply use the `Clear` method available on the **Annotations** property.

```csharp
using IronPdf;

PdfDocument pdf = PdfDocument.FromFile("multipleAnnotation.pdf");

// Erase all annotations on a designated page and then all annotations in the document
pdf.Annotations.RemoveAllAnnotationsForPage(0);
pdf.Annotations.Clear();

pdf.SaveAs("removeAllAnnotation.pdf");
```

Explore more possibilities with our tutorial page here: [Edit PDFs](https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/)