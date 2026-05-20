***Based on <https://ironpdf.com/examples/threading/>***

IronPDF offers a robust, thread-safe PDF generation capability, especially efficient in multi-threading environments using the `ChromePdfRenderer` class. This functionality ensures efficient management of large-scale or batch PDF generation tasks concurrently, avoiding common concurrency issues such as thread blocking.

## Multi-Threaded PDF Generation Steps

The initial step in the multi-threaded PDF creation process involves instantiating a new `ChromePdfRenderer`. This renderer taps into IronPDF's advanced [rendering engine](https://ironpdf.com/how-to/ironpdf-2021-chrome-rendering-engine-eap/), renowned for its ability to deliver precise and high-quality PDF outputs. Following this, a new List of string type, named **htmlStrings**, is prepared, filled with HTML content destined for PDF conversion in a multi-threaded setup.

The next phase leverages asynchronous programming to efficiently process the HTML content into PDF files. Using the `htmlStrings.Select(html => renderer.RenderHtmlAsPdfAsync(html))` statement, the method iterates over each HTML string, employing the `RenderHtmlAsPdfAsync` method from the renderer to initiate the conversion. The `Task.WhenAll()` function is then utilized to consolidate these asynchronous tasks into a single task that completes when all individual conversions are done, delivering a new array of `PdfDocument` objects.

To finalize, the generated PDFs are collected. Using `await task`, the method ensures that all asynchronous rendering tasks are fully completed before gathering the resulting `PdfDocument` array. The `ToList()` method then transforms this array into a List, referred to as **pdfList**, which facilitates easier manipulation and utilization of the generated PDF documents.

[Discover more about Async PDF Rendering with IronPDF](https://ironpdf.com/how-to/async)