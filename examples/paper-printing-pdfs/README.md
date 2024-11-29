***Based on <https://ironpdf.com/examples/paper-printing-pdfs/>***

Explore IronPrint, the latest .NET printing library from Iron Software, tailored for a range of platforms including Windows, macOS, Android, and iOS. Discover more about this cutting-edge resource and learn how to begin leveraging IronPrint at [Learn More About IronPrint - The .NET Printing Library by Iron Software](https://ironsoftware.com/csharp/print/) and [Discover How to Get Started with IronPrint](https://ironsoftware.com/csharp/print/docs/).

To print a PDF, you can either send it to the system's default printer, which might show Windows print UI dialogs, or use silent printing by utilizing the overloads of the `IronPdf.PdfDocument.Print` method.

Additional printing configurations can be accessed through the native .NET Framework `PrintDocument` object by using the `IronPdf.PdfDocument.GetPrintDocument` method. This requires adding a reference to `System.Drawing.dll` in your assembly.