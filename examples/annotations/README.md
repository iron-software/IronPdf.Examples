***Based on <https://ironpdf.com/examples/annotations/>***

<div class="alert alert-info iron-variant-1" role="alert">
	Is your organization spending excessively on annual PDF security and compliance subscriptions? Take a look at <a href="https://ironsoftware.com/enterprise/securedoc/">IronSecureDoc</a>, which offers a comprehensive range of services for handling SaaS applications, including digital signing, redaction, encryption, and protection with a one-time fee structure. <a href="https://ironsoftware.com/enterprise/securedoc/docs/">Read more about IronSecureDoc</a>
</div>

PDF annotations enable users to attach commentaries akin to "sticky notes" onto pages within a PDF document. The `IronPDF.PdfDocument.AddTextAnnotation` method alongside the `PdfDocument.TextAnnotation` class facilitates the programmatic addition of annotations. This capability supports advanced features like adjustment of text color, size, opacity, icons, and the ability to edit these annotations.

# How to Implement PDF Annotation in .NET

1. Incorporate the C# library to enable PDF annotations.
2. Either open an existing PDF or generate a new one using .NET.
3. Establish a `TextAnnotation` object and tailor its properties.
4. Deploy the `AddTextAnnotation` function to apply your crafted annotation onto the PDF.
5. Save the updated PDF to your chosen directory.