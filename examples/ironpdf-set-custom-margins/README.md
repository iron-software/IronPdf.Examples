***Based on <https://ironpdf.com/examples/ironpdf-set-custom-margins/>***

IronPDF provides the flexibility to manipulate margins to any specified value via the `RenderingOptions`. When using the `ChromePdfRenderer`, the output settings for HTML to PDF conversion include parameters such as paper size, DPI, and options for adding headers and footers, along with various Chromium-based browser configurations. Additionally, this functionality allows for the customization of margins.

The following example illustrates how to customize margins in your PDF documents using IronPDF, an effective tool for creating and editing PDFs within .NET frameworks. For additional insights into IronPDF and its features, refer to the [IronPDF official website](https://www.ironpdf.com/).

Margins can be adjusted and defined either in millimeters or inches. For instance, you can set the bottom margin of the PDF page to zero millimeters for producing edge-to-edge and professional printing outputs.

Although the standard margin setting defaults to `25`, you have the flexibility to tailor the top, bottom, left, and right margins individually to achieve the desired layout and appearance.