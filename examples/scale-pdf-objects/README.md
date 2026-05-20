***Based on <https://ironpdf.com/examples/scale-pdf-objects/>***

IronPDF grants developers the capability to programmatically scale PDF objects, allowing for sophisticated adjustment of components like text and images within a PDF. This is achieved without having to alter the original document or create a new one.

With the IronPDF library at hand, scaling elements in a PDF becomes a straightforward process, as demonstrated in the example below.


<div class="examples__featured-snippet">
    <h2>5-Step Code to Scale PDF Objects</h2>
    <ol>
        <li>string html = @"&lt;img src='[Image](https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTi8LuOR6_A98euPLs-JRwoLU7Nc31nVP15rw&s)'&gt;";</li>
        <li>PdfDocument pdf = renderer.RenderHtmlAsPdf(html);</li>
        <li>ImageObject image = pdf.Pages.First().ObjectModel.ImageObjects.First();</li>
        <li>image.Scale = new System.Drawing.PointF(0.7f, 0.7f);</li>
        <li>pdf.SaveAs("scaled_image.pdf");</li>
    </ol>
</div>
```

## Code Explanation

In this example, we commence by constructing an HTML string containing an `<img>` tag to embed an image. Subsequently, we employ the `RenderHtmlAsPdf` method to convert this HTML string into a `PdfDocument`.

Next, to locate the `ImageObject` that was recently embedded, we navigate through the document’s hierarchy: beginning with the first page of the PDF, accessed with `Pages.First`, and proceed to delve into its `ObjectModel`. This model houses the structured content of the page. We then proceed to the `ImageObjects` collection, select the first entry, and store it in a variable.

To adjust the image size, we set a new `PointF` to the `Scale` property. In this context, we scale the image to 70% of its original dimensions on both the x and y axes. It is important to note that scaling factors greater than one enlarge the image, whereas factors smaller than one reduce its size. Furthermore, non-uniform scaling can be achieved by applying different scaling values to x and y.

After the scale property is amended, the final step involves invoking the `SaveAs` method to save the PDF with the updated scaling.

[Discover How to Effortlessly Scale PDF DOM - Visit Our Guide Now!](https://ironpdf.com/how-to/access-pdf-dom-object/)