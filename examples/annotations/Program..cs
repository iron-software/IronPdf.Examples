using IronPdf;

// Create a new PDF or load and edit an existing document.
var pdf = PdfDocument.FromFile("existing.pdf");

int pageIndex1 = 0;
int pageIndex2 = 1;

// Create a PDF annotation object on a specified page index
var annotation1 = new IronPdf.Annotations.TextAnnotation(pageIndex1)
{
    Title = "This is the major title 1",
    Contents = "This is the long 'sticky note' comment 1st content...",
    X = 150,
    Y = 200,
    Width = 200,
    Height = 50,
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
    Opacity = 0.9,
    Printable = false,
    Hidden = false,
    OpenByDefault = true,
    ReadOnly = false,
    Rotatable = true
};

var annotation2 = new IronPdf.Annotations.TextAnnotation(pageIndex2)
{
    Title = "This is the major title 2",
    Contents = "This is the long 'sticky note' comment 2nd content...",
    X = 100,
    Y = 150,
    Width = 250,
    Height = 150,
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
    Opacity = 0.9,
    Printable = false,
    Hidden = false,
    OpenByDefault = true,
    ReadOnly = false,
    Rotatable = true
};

var annotation3 = new IronPdf.Annotations.TextAnnotation(pageIndex2)
{
    Title = "This is the major title 3",
    Contents = "This is the long 'sticky note' comment 3rd content...",
    X = 200,
    Y = 150,
    Width = 150,
    Height = 50,
    Icon = IronPdf.Annotations.TextAnnotation.AnnotationIcon.Help,
    Opacity = 0.9,
    Printable = false,
    Hidden = false,
    OpenByDefault = true,
    ReadOnly = false,
    Rotatable = true
};

// Add the annotation "sticky note" within any new or existing PDF.
pdf.Annotations.Add(annotation1); // annotation1 index is 0.
pdf.Annotations.Add(annotation2); // annotation2 index is 1.
pdf.Annotations.Add(annotation3); // annotation3 index is 2.

// Remove a single annotation with specified index
pdf.Annotations.RemoveAt(1); // annotation2 is removed, annotation3 index becomes 1.

// Remove all annotaions on a specified page
pdf.Annotations.RemoveAllAnnotationsForPage(0); // remove all annotaion on page 1, annotation3 index becomes 0.

// Edit a single annotation with specified index
pdf.Annotations[0].Title = "new title for annotation 3";
pdf.Annotations[0].Contents = "This is new comment content of annotation 3";

// Remove all annotaions on the document
pdf.Annotations.Clear();

pdf.SaveAs("existing.pdf");
