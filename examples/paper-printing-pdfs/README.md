---

<div class="alert alert-info iron-variant-1" role="alert">
	Introducing <a href="https://ironsoftware.com/csharp/print/">IronPrint</a>, the new .NET library from Iron Software, designed for universal compatibility across various operating systems including Windows, macOS, Android, and iOS. <a href="https://ironsoftware.com/csharp/print/docs/">Start using IronPrint</a> today!
</div>

Print a PDF directly by using the default printer on your computer. Depending on your choice, the Windows printing interface may appear, or you can opt for silent printing with different overloads provided by the `IronPdf.PdfDocument.Print` method.

Additional printing setups can be configured through the native .NET `PrintDocument` object, which can be accessed using the `IronPdf.PdfDocument.GetPrintDocument` method. Remember to include a reference to the `System.Drawing.dll` assembly to utilize this method.