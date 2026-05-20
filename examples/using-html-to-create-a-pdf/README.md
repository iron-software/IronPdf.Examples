***Based on <https://ironpdf.com/examples/using-html-to-create-a-pdf/>***

IronPDF allows you to create brand new PDF files from simple HTML strings within your .NET applications, supporting languages like C#, F#, and VB.NET. Utilizing the `ChromePdfRenderer` class ensures that the PDF documents rendered from HTML strings are [pixel-perfect](https://ironpdf.com/how-to/pixel-perfect-html-to-pdf/). IronPDF's robust [HTML to PDF conversion](https://ironpdf.com/tutorials/html-to-pdf/) capabilities enable the creation of high-quality PDF documents that meet specific requirements.

Here are the four steps to convert an HTML string into a PDF:

1. **Import the IronPDF Library**: Start by including the library in your project.
2. **Initialize the `ChromePdfRenderer`**: Create a new instance of this class.
3. **Render HTML as PDF**: Use the `RenderHtmlAsPdf` method to convert your HTML string into a PDF.
4. **Save the PDF**: Use the `PdfDocument.SaveAs` method to save your PDF document.

Below is a more detailed breakdown of each step:

To start converting an HTML string to a PDF using C#, make sure to set up the IronPDF library correctly in your project. This entails adding `using IronPdf` at the beginning of your code, granting you access to the necessary classes for HTML to PDF conversion. For secure operations, `Installation.EnableWebSecurity = true` (though this line was omitted from the provided example) typically configures settings to restrict local disk access and cross-origin requests.

The example shows how to instantiate the `ChromePdfRenderer`, which manages the HTML to PDF conversion process. The `RenderHtmlAsPdf` function converts an HTML string (`"<h1>Hello World</h1>"`) to a PDF, which is subsequently saved to a disk using the `SaveAs` method.

For more complex scenarios, IronPDF can process HTML content with external resources like images, CSS, and JavaScript. By employing the `BasePath` parameter, you can specify the directory containing these resources. The final PDF, inclusive of the external assets, is saved using the same `SaveAs` method. This example showcases IronPDF's capability to efficiently generate PDFs from both straightforward and intricate HTML content programmatically.

For further guidance on converting HTML strings to PDFs in C#, visit [Learn to Convert HTML Strings to PDF in C# with IronPDF](https://ironpdf.com/how-to/html-string-to-pdf/).