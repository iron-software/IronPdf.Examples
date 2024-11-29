# Drawing Text and Bitmaps on PDFs

***Based on <https://ironpdf.com/how-to/draw-text-and-bitmap/>***


Adding text and images onto an existing PDF document is made easy with IronPDF. By integrating this functionality, anyone can enhance PDFs with custom watermarks, logos, and notes, significantly enhancing the document's visual appeal and brand recognition. Moreover, incorporating text and images aids in disseminating information, visualizing data, and creating dynamic forms.

## Example: Adding Text to a PDF

To append text to a PDF while keeping the original content unchanged, use the `DrawText` method from the **PdfDocument** object.

```cs
using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.DrawTextAndBitmap
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Sample Title</h1>");
            
            // Adding text to the PDF
            pdf.DrawText("Inserting this text", FontTypes.TimesNewRoman.Name, FontSize: 12, PageIndex:0, X: 200, Y: 200, Color.Black, Rotation: 0);
            
            pdf.SaveAs("updatedText.pdf");
        }
    }
}
```

### Supported Fonts in IronPDF

You can utilize a variety of fonts available in IronPDF's `FontTypes` class, which includes standards such as Courier, Arial (or Helvetica), Times New Roman, Symbol, and ZapfDingbats. Each font also offers italic, bold, and oblique styles. View the [comprehensive font list in IronPDF](https://ironpdf.com/how-to/manage-fonts/#standard-fonts).

ZapfDingbats, noted for its ability to display unique symbols like ✖❄▲❪ ❫, offers extensive symbology, detailed in the [Wikipedia Zapf Dingbats section](https://en.wikipedia.org/wiki/Zapf_Dingbats).

#### Display of Fonts on PDF

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/draw-text-and-bitmap-fonts.webp" alt="Sample PDF Fonts" class="img-responsive add-shadow">
    </div>
</div>

## Adding Images - Example

IronPDF's `DrawBitmap` method makes it straightforward to embed images in PDFs, similar to the Image Stamper tool. This feature is effective particularly for large images. If you encounter an issue with high-resolution image data conflicting with expected sizes, you can always resort to the Image Stamper capable of handling various image dimensions.

#### Example Image

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/ironSoftware.png" alt="IronSoftware logo image" class="img-responsive add-shadow">
    </div>
</div>

### Implementation Code

```cs
using IronSoftware.Drawing;
using IronPdf;
namespace ironpdf.DrawTextAndBitmap
{
    public class Section2
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Example Heading</h1>");
            
            // Open image from file
            AnyBitmap bitmap = AnyBitmap.FromFile("logo.png");
            
            // Apply the bitmap onto the PDF
            pdf.DrawBitmap(bitmap, 0, 50, 200, 450, 250);
            
            pdf.SaveAs("updatedImage.pdf");
        }
    }
}
```

### Viewing the Resultant PDF

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/draw-text-and-bitmap/drawImage.pdf#view=fit" width="100%" height="500px">
</iframe>

This tutorial provides the essential guidelines and code snippets for incorporating text and bitmap images to your PDFs using IronPDF, enhancing both functionality and aesthetic appeal of your documents.