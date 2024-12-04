# Modifying PDF Pages in .NET

***Based on <https://ironpdf.com/how-to/transform-pdf-pages/>***


In .NET, modifying a PDF page refers to the process of applying different operations which alter how content is displayed on the page. These modifications can range from scaling (adjusting the page size) to translating (shifting the content on the page).

## PDF Page Modifications

The `Transform` feature enables the adjustment of the content's appearance through moving and resizing operations. It's important to note that these actions modify only how the content is presented and do not alter the actual dimensions of the physical page. Below is an example that demonstrates how to use the `Transform` method on a [simple PDF document](https://ironpdf.com/static-assets/pdf/how-to/transform-pdf-pages/basic.pdf).

```cs
using IronPdf;
namespace ironpdf.TransformPdfPages
{
    public class Section1
    {
        public void Execute()
        {
            PdfDocument pdfDoc = PdfDocument.FromFile("basic.pdf");
            
            // Applying transformations: translation x=50, y=50, scale x=0.8, y=0.8
            pdfDoc.Pages[0].Transform(50, 50, 0.8, 0.8);
            
            pdfDoc.SaveAs("modifiedPage.pdf");
        }
    }
}
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/transform-pdf-pages/transform.webp" alt="Modifying PDF pages" class="img-responsive add-shadow">
    </div>
</div>