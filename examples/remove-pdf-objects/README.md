> Full guide: [Remove PDF objects](https://ironpdf.com/examples/remove-pdf-objects/?utm_source=github)

Modifying a PDF document by selectively removing elements can be challenging. Nevertheless, IronPDF equips developers with a straightforward method to access and manipulate the PDF's Document Object Model (DOM).

The following demonstration will guide you through the process of programmatically deleting specific objects, like images or text, from a PDF file using a few simple code lines.


<div class="examples__featured-snippet">
    <h2>Simple Steps to Delete Objects from PDFs</h2>
    <ol>
        <li>PdfDocument document = PdfDocument.FromFile("sampleObjectsWithImages.pdf");</li>
        <li>var pageObjects = document.Pages.First().ObjectModel;</li>
        <li>pageObjects.ImageObjects.RemoveAt(0);</li>
        <li>document.SaveAs("updated.pdf");</li>
    </ol>
</div>

## Breakdown of the Code

Initially, we load a PDF file through the `FromFile` method, which opens a specified PDF document and assigns it to a variable.

Next, we target the objects on the initial page of the PDF by using `Pages.First`, which fetches the first page. We then look at the `ObjectModel` collection, which holds all the objects of that particular page.

To delete an object, we pinpoint the specific collection within the ObjectModel that we're interested in. Here, we're focusing on eliminating an image from the `ImageObjects` collection. By invoking the `RemoveAt` method with an index of 0, we remove the first image in the collection. It's crucial to remember that collections use zero-based indexing, so the first element is always index zero.

Lastly, we store the altered PDF—now without the removed object—into a new file by using `SaveAs`.

[How to access the PDF DOM object](https://ironpdf.com/how-to/access-pdf-dom-object/?utm_source=github)