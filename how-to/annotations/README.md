# How to Add and Edit PDF Annotations

***Based on <https://ironpdf.com/how-to/annotations/>***


<div class="alert alert-info iron-variant-1" role="alert">
	Is your organization overspending on annual fees for PDF security and compliance tools? Look into <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, which offers comprehensive management of services such as digital signing, redaction, encryption, and document protection, all available via a one-time investment. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Read more about IronSecureDoc</a>
</div>

Annotations in PDF documents are essential for adding comments, reminders, or supplementary information at specific document spots, enhancing collaborative communication and streamlining the review process.

## Example: Adding Annotations

You can embed "sticky note" style comments within a PDF by using the `Add` method from the **Annotations** property of a document. Remember, pages in the document are zero-indexed.

```cs
using IronPdf.Annotations;
using IronPdf;
namespace ironpdf.Annotations
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Annotation</h1>");
            
            // Instantiate a text annotation at a specified page index
            TextAnnotation annotation = new TextAnnotation(0)
            {
                Title = "Annotation Title",
                Contents = "Detailed explanation of the sticky note...",
                X = 50,
                Y = 700,
            };
            
            // Adding the annotation to the PDF
            pdf.Annotations.Add(annotation);
            pdf.SaveAs("myAnnotatedPDF.pdf");
        }
    }
}
```

#### Viewing a PDF with Annotations

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/annotation.pdf" width="100%" height="400px">
</iframe>

You can view the annotated PDF in any modern web browser.

<hr class="separator">

## Example: Retrieving and Editing Annotations

Enhance collaboration by fine-tuning the clarity, accuracy, and relevance of PDF annotations. Modify existing annotations by accessing them through the **Annotations** property and update pertinent details like Title, Contents, Position, etc.

```cs
using System.Linq;
using IronPdf;
namespace ironpdf.Annotations
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("myAnnotatedPDF.pdf");
            
            // Accessing the collection of annotations
            PdfAnnotationCollection annotations = pdf.Annotations;
            
            // Retrieve the first annotation for editing
            TextAnnotation editAnnotation = (TextAnnotation)annotations.First();
            
            // Update annotation details
            editAnnotation.Title = "Updated Title";
            editAnnotation.Contents = "Updated annotation content...";
            editAnnotation.X = 150;
            editAnnotation.Y = 800;
            
            pdf.SaveAs("updatedAnnotation.pdf");
        }
    }
}
```

#### PDF Displaying an Edited Annotation

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/annotations/editedAnnotation.pdf" width="100%" height="400px">
</iframe>

This edited annotation can be viewed with a Chrome browser.

<hr class="separator">

## Example: Removing Annotations

For removing outdated or unnecessary annotations, use the methods `RemoveAt`, `RemoveAllAnnotationsForPage`, and `Clear`.

### Removing an Individual Annotation

To delete a specific annotation, employ the `RemoveAt` method along with the necessary index.

```cs
using IronPdf;
namespace ironpdf.Annotations
{
    public class Section3
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("multiAnnotatedPDF.pdf");
            
            // Deleting an annotation by index
            pdf.Annotations.RemoveAt(1);
            
            pdf.SaveAs("afterDeletion.pdf");
        }
    }
}
```

#### PDF Before and After Removing an Annotation

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

These annotations can be viewed in the Chrome browser.

### Removing All Annotations

To clear annotations from a specific page or the entire document, use `RemoveAllAnnotationsForPage` for singular page removal, or `Clear` to delete all annotations in the document.

```cs
using IronPdf;
namespace ironpdf.Annotations
{
    public class Section4
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("multiAnnotatedPDF.pdf");
            
            // Removing all annotations from a specified page
            pdf.Annotations.RemoveAllAnnotationsForPage(0);
            
            // Clearing out all annotations in the document
            pdf.Annotations.Clear();
            
            pdf.SaveAs("clearAllAnnotations.pdf");
        }
    }
}
```