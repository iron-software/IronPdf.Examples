***Based on <https://ironpdf.com/examples/annotations/>***

<div class="alert alert-info iron-variant-1" role="alert">
  Your company may be allocating unnecessary funds towards annual PDF security and compliance subscriptions. Take a look at <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, which offers a comprehensive suite of services including digital signing, redaction, encryption, and protection, all via a one-time purchase. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Review the IronSecureDoc Documentation</a>
</div>

PDF annotations can enhance your documents by adding "sticky note"-like comments to the pages. The `IronPDF.PdfDocument.AddTextAnnotation` method and the `PdfDocument.TextAnnotation` class facilitate the addition of annotations through code. The supported features for text annotations are extensive, including options for color, size, opacity, icons, and editing capabilities.

# How to Insert PDF Annotations in .NET

1. Acquire and install the C# library to enable PDF annotation.
2. Open an existing document or create a new PDF within your .NET application.
3. Initialize a `TextAnnotation` class and tailor its attributes as needed.
4. Employ the `AddTextAnnotation` method to apply the prepared annotation to the PDF.
5. Save the updated PDF to a designated location.