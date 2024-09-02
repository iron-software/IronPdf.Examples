IronPDF provides the flexibility to adjust margins to any specific value through its `RenderingOptions`. The `ChromePdfRenderer` allows you to configure various output options for HTML to PDF conversion, including paper size, DPI, and headers and footers, among other Chromium-based browser configurations. Additionally, it supports setting custom margins.

The following example illustrates how to configure custom margins in a PDF document using IronPDF:

Margins can be specified and adjusted in either millimeters or inches. For instance, the bottom margin of the PDF can be set to zero millimeters, which is ideal for borderless and commercial printing purposes.

Nonetheless, the default margin value is set to `25`. To achieve specific layout requirements, you can independently customize the margins on the top, bottom, left, and right of the document.