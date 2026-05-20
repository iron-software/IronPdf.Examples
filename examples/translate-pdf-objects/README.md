***Based on <https://ironpdf.com/examples/translate-pdf-objects/>***

When you need to reposition a text, image, or shape within a PDF, IronPDF provides an efficient way to directly manipulate the object's position using our library tools.

In this coding tutorial, we'll demonstrate how you can easily move objects within the PDF Document Object Model (DOM) using IronPDF.


<div class="examples__featured-snippet">
    <h2>5-Step Tutorial to Move PDF Objects</h2>
    <ol>
        <li>ChromePdfRenderer renderer = new ChromePdfRenderer();</li>
        <li>PdfDocument pdf = renderer.RenderHtmlAsPdf("Sample Text");</li>
        <li>var objects = pdf.Pages.First().ObjectModel.TextObjects.First();</li>
        <li>objects.Translate = new System.Drawing.PointF(100, -100);</li>
        <li>pdf.SaveAs("moved.pdf");</li>
    </ol>
</div>
```

## Detailed Code Walkthrough

Initially, we create an instance of `ChromePdfRenderer` and use the `RenderHtmlAsPdf` to convert an HTML string into a PDF document.

Next, we navigate the structure of the rendered PDF. We select the first page by calling `Pages.First`, and then access the `ObjectModel`, which allows us to delve into the `TextObjects` collection. This collection houses all instances of `TextObject` found in the PDF. We then choose the first object in this collection to work with.

With the selected `TextObject` now in hand – in our example, it identifies the text "Sample Text" – we modify its `Translate` property by setting a new `PointF(X, Y)`. This modification moves the text 100 units rightward and 100 units upward on the X and Y axes respectively.

Upon repositioning the text, we save the updated document using the `SaveAs` method, storing it as "moved.pdf".

[Enjoy Comprehensive Guidance on Manipulating PDF DOM - Access Our Detailed Guide Here!](https://ironpdf.com/how-to/access-pdf-dom-object/)