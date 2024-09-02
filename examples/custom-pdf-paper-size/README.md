When developing PDF documents with IronPDF, it's crucial to ensure they display and print effectively. This involves setting the appropriate virtual and real-world paper sizes.

In our discussion here, we'll guide you through the process of incorporating custom paper sizes into your PDF initiatives.

IronPDF boasts an array of nearly 50 predefined paper sizes, as well as the ability to accommodate an infinite number of custom dimensions, ensuring a perfect fit for any requirement or situation in which your PDF might be used. You can customize PDF outputs in various sizes, which are measurable in either inches or millimeters.

The class `PdfPaperSize` enumerates the virtual sizes targeted for the PDF, correlating them to their respective real-world dimensions.

To create PDFs with custom sizes in inches or millimeters, you can utilize the methods below:

- `Renderer.RenderingOptions.SetCustomPaperSizeInInches`
- `Renderer.RenderingOptions.SetCustomPaperSizeInMillimeters`

Additionally, the method `Renderer.RenderingOptions.PaperSize` allows you to apply our precise custom preset sizes, now accurate down to 1 micron.