# How to Compress PDFs

***Based on <https://ironpdf.com/how-to/pdf-compression/>***


PDF compression involves reducing the size of a PDF (Portable Document Format) document. This is especially helpful to better manage the storage, sharing, and transmission of PDFs, which is critical for large or image-heavy documents.

Embedded images usually take up a large part of a PDF's file size due to their relative size compared to text and other elements. IronPdf provides tools for compressing these images and for slimming down the tree structures often found with tables in PDF documents.

## Compress Images Example

JPEG resizing works in such a way that, at 100% quality, there's hardly any loss of detail, while a setting of 1% results in a very compressed and lower quality image.

- Above 90%: regarded as high-quality
- Between 80%-90%: regarded as medium-quality
- Between 70%-80%: regarded as low-quality

Experiment with different compression levels to see the balance between image quality and file size. Keep in mind that the extent of quality degradation depends on the image type, with some images losing more clarity than others.

```cs
using IronPdf;
namespace ironpdf.PdfCompression
{
    public class Section1
    {
        public void Run()
        {
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            
            PdfDocument pdf = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");
            
            // Apply image compression at 40% quality
            pdf.CompressImages(40);
            
            // Save the compressed PDF
            pdf.SaveAs("compressed.pdf");
        }
    }
}

### Compress Images - Size Comparison

Reduced by **39.24%**!

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-compression/compress-image-compare-size.png" alt="Compress images - size comparison" class="img-responsive add-shadow">
    </div>
</div>

### Understanding Image Compression Options

**ShrinkImage**: Scales down image resolutions based on their visible sizes in the PDF. This method dramatically shrinks the image file size while also lowering quality, making it more optimal for storage and transfer.

**HighQualitySubsampling**: Defines the chroma subsampling technique for image compression. Setting this to "True" uses a 4:4:4 subsampling ratio ensuring no color detail is lost whereas setting it to "False" will use a 4:1:1 ratio greatly reducing file size at a cost of some color detail.

Chroma subsampling efficiently reduces data needed for images by trimming down color quality (chrominance) while keeping brightness quality (luminance) intact. The 4:4:4 ratio preserves every pixel's color information, while the 4:1:1 ratio lowers color resolution for better compression.

## Compress Tree Structure Example

This functionality reduces the size of PDFs by simplifying the tree structure created by Chrome Engine, particularly useful for HTML-generated PDFs with extensive tables. However, it might lessen the effectiveness of text-highlights or extractions for some PDFs without this structure.

Try out the `CompressStructTree` method on a [PDF with table data](https://ironpdf.com/static-assets/pdf/how-to/pdf-compression/table.pdf).

```cs
using IronPdf;
namespace ironpdf.PdfCompression
{
    public class Section2
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("table.pdf");
            
            // Apply tree structure compression
            pdf.CompressStructTree();
            
            // Save the new PDF
            pdf.SaveAs("compressedTable.pdf");
        }
    }
}

### Compress Tree Structure - Size Comparison

Reduced by **67.90%**! This reduction can be even greater for PDFs with more extensive tables.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-compression/compress-tree-structure-compare-size.png" alt="Compress tree structure - size comparison" class="img-responsive add-shadow">
    </div>
</div>

## Advanced Compression Methods

IronPdf's `Compress` method simplifies configuring both image and tree structure compressions for your documents.

```cs
using IronPdf;
namespace ironpdf.PdfCompression
{
    public class Section3
    {
        public void Run()
        {
            PdfDocument pdf = PdfDocument.FromFile("sample.pdf");
            
            CompressionOptions compressionOptions = new CompressionOptions();
            
            // Set image and structure compression parameters
            compressionOptions.CompressImages = true;
            compressionOptions.JpegQuality = 80; // Medium quality
            compressionOptions.HighQualityImageSubsampling = true;
            compressionOptions.ShrinkImages = true;
            
            // Enable tree structure removal
            compressionOptions.RemoveStructureTree = true;
            
            // Apply all compression settings
            pdf.Compress(compressionOptions);
            
            // Save the resultant compressed PDF
            pdf.SaveAs("compressed.pdf");
        }
    }
}

### Explore Available Options

- **CompressImages**: Enables or disables compression of existing images using JPG encoding.
- **RemoveStructureTree**: This reduces document disk usage but could impact text selection in complex PDFs.
- **JpegQuality**: Adjusts the level of JPEG quality for image compression.
- **HighQualityImageSubsampling**: Toggle between high quality (4:4:4 chroma) or reduced size (4:1:1 chroma) image subsampling.
- **ShrinkImages**: Reduces image resolution, minimizing both size and quality of pictures within the PDF.