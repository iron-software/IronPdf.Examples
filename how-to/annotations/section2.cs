using IronPdf;
using IronPdf.Annotations;
using System.Linq;

PdfDocument pdf = PdfDocument.FromFile("annotation.pdf");

// Retrieve annotation collection
PdfAnnotationCollection annotationCollection = pdf.Annotations;

// Select the first annotation
TextAnnotation annotation = (TextAnnotation)annotationCollection.First();

// Edit annotation
annotation.Title = "New title";
annotation.Contents = "New content...";
annotation.X = 150;
annotation.Y = 800;

pdf.SaveAs("editedAnnotation.pdf");