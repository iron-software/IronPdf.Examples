# PDF Compression Techniques

***Based on <https://ironpdf.com/how-to/pdf-compression/>***


PDF compression is a technique used to decrease the size of Portable Document Format (PDF) files, facilitating easier storage, transfer, and sharing. This is particularly useful for files containing large amounts of data or numerous high-resolution images.

Images often constitute the bulk of a PDF's file size due to their inherently large data size compared to text or other elements. IronPdf is equipped with functionality that compresses these images and streamlines the tree structures associated with tables in PDF documents.

<h3>Getting Started with IronPDF</h3>

----

## Example: Compressing Images

When adjusting the JPEG quality during compression:
- Values of 90% and higher are typically seen as high-quality.
- Values between 80% to 90% offer medium-quality.
- Values ranging from 70% to 80% are seen as low-quality.

Experiment with different compression settings to find a balance between image quality and file size reduction. Keep in mind that the degree of quality loss can vary depending on the image.

```cs
using IronPdf;

ChromePdfRenderer renderer = new ChromePdfRenderer();

PdfDocument pdfDocument = renderer.RenderUrlAsPdf("https://en.wikipedia.org/wiki/Main_Page");

// Applying image compression on the PDF
pdfDocument.CompressImages(40);

pdfDocument.SaveAs("compressed.pdf");
```

### Image Compression: Size Reduction

Achieved a significant reduction of **39.24%** in file size!

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-compression/compress-image-compare-size.png" alt="Compression of images shows significant size reduction" class="img-responsive add-shadow">
    </div>
</div>

### Details on Image Compression Techniques

**ShrinkImage**: This function downsizes the image resolution relative to its actual size within the PDF, greatly reducing both the size and quality for better storage and lesser bandwidth usage.

**HighQualitySubsampling**: This controls the chroma subsampling used in image compression. Setting this option to "True" uses 4:4:4 chroma subsampling for high-quality images with full color detail, while "False" selects 4:1:1, reducing some color details for a smaller image size.

Chroma subsampling is a method used in digital image compression that savages file size by selectively lowering the resolution of the color information (chrominance) while preserving the brightness detail (luminance).

In a "4:4:4" configuration, every pixel maintains its color data, preserving color details. In "4:1:1", the color data is sampled at a lower resolution, which curtails color detail but decreases file size more significantly.

<hr>

## Example: Compressing PDF Tree Structure

This functionality is designed to minimize the document structure built by the Chrome Engine, which can be extensive in PDFs transformed from HTML with dense table content. Note, not all PDF engines generate this structure, which can lead to variable effectiveness.

This method might impact functionalities such as text highlighting or extraction for some documents.

Explore compression on a structured PDF using the following approach:

```cs
using IronPdf;

PdfDocument document = PdfDocument.FromFile("table.pdf");

// Apply tree structure compression
document.CompressStructTree();

document.SaveAs("compressedTable.pdf");
```

### Tree Structure Compression: Size Reduction Analysis

Achieved a reduction of **67.90%** in file size, with potential for greater reduction in larger documents.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/pdf-compression/compress-tree-structure-compare-size.png" alt="Tree structure compression significantly reduces file size" class="img-responsive add-shadow">
    </div>
</div>

## Advanced PDF Compression Methods with IronPDF

IronPdf's `Compress` method combines options for image and tree structure compression into a single, efficient function.

```cs
using IronPdf;

PdfDocument examplePdf = PdfDocument.FromFile("sample.pdf");

CompressionOptions options = new CompressionOptions();

// Set up image compression
options.CompressImages = true;
options.JpegQuality = 80;
options.HighQualityImageSubsampling = true;
options.ShrinkImages = true;

// Set up structural compression
options.RemoveStructureTree = true;

examplePdf.Compress(options);

examplePdf.SaveAs("compressed.pdf");
```

### Understanding the Compression Options

- **CompressImages**: Determines if images should be compressed using JPG encoding (default is false).
- **RemoveStructureTree**: This option reduces PDF size significantly but may affect text selection in complex documents.
- **JpegQuality**: Sets the JPEG quality for image compression, ranging from 1 to 100 (default is 42).
- **HighQualityImageSubsampling**: Opt between 444 chroma subsampling for high-quality images and 411 for reduced size.
- **ShrinkImages**: Decreases image resolution to significantly lessen both file size and quality.