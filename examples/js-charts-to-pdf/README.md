***Based on <https://ironpdf.com/examples/js-charts-to-pdf/>***

Documents that incorporate graphs, such as those used for mathematical or statistical analysis, can effectively utilize IronPDF for display. IronPDF robustly supports JavaScript within its [`HTML to PDF conversion`](https://ironpdf.com/tutorials/html-to-pdf/) process, which includes advanced capabilities for rendering canvases and charts.

The `IronPdf.ChromePdfRenderer` extends these capabilities even further by facilitating the rendering of 3D charts and polygons.

Below is a demonstration of how you can convert charts, canvases, and 3D elements into a PDF format:

The following chart types are well-supported:

- C3.js
- D3.js
- Highcharts

Additionally, IronPDF's [Pixel-Perfect Chrome Rendering](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/) leverages complete JavaScript compatibility, enhancing its prowess in producing chart and graph-intensive documents.

The `ChromePdfRenderer` provides a variety of output customization options for the HTML-to-PDF conversion process, including choices for Paper-Size, DPI, and headers and footers, as well as other Chromium-specific browser configuration settings.

Furthermore, the integration of WebGL enables robust and efficient rendering of not only 3D charts but also complex 3D polygon visuals.