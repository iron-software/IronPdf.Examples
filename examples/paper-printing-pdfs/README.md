***Based on <https://ironpdf.com/examples/paper-printing-pdfs/>***

Explore the new .NET printing library from Iron Software, **IronPrint**, which supports a diverse range of operating systems including Windows, macOS, Android, and iOS. Learn more about IronPrint and how you can get started by visiting:

- [Learn More About IronPrint - The .NET Printing Library by Iron Software](https://ironsoftware.com/csharp/print/)
- [Discover How to Get Started with IronPrint](https://ironsoftware.com/csharp/print/docs/)

**Printing a PDF using IronPrint** is straightforward. You can send a PDF to the default printer on your computer. Depending on your settings, Windows print UI dialogs might appear, or you can choose to print silently by utilizing various overloads of the `IronPdf.PdfDocument.Print` method.

For more advanced printing capabilities, `IronPdf.PdfDocument.GetPrintDocument` method connects to the native .NET Framework `PrintDocument` object. To leverage this functionality, an assembly reference to `System.Drawing.dll` must be added to your project.