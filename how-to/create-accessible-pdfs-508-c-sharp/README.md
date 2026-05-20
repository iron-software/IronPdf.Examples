# Creating Accessible PDFs & Compliance with Section 508 Standards

***Based on <https://ironpdf.com/how-to/create-accessible-pdfs-508-c-sharp/>***


IronPDF is committed to supporting Google's efforts to enhance PDF accessibility and compliance with Section 508 standards.

Since 2021, IronPDF has adopted the Google Chromium HTML rendering engine to render PDFs from HTML. This integration leverages the accessibility enhancements that Google has implemented, which you can learn more about [here](https://blog.chromium.org/2020/07/using-chrome-to-generate-more.html).

As the Tagged PDF and PDF/UA standards continue to evolve, IronPDF strives to incorporate these developments as fully as possible. Currently, our tools support exporting documents that comply with the PDF/A-3b standard, which is explained in detail in [our instructional guide on using the PDF/A Archiving export standard with IronPDF](http://ironpdf.com/how-to/pdfa/).

Should you have suggestions on improving our API, please don't hesitate to reach out to our developer support team.

## Quickstart: Generate Accessible PDFs with IronPDF

IronPDF allows developers to effortlessly create PDFs that meet Section 508 compliance standards. This quickstart guide illustrates how to produce accessible PDFs using C# with minimal effort. This method is ideal for developers looking for an easy yet compliant solution for creating accessible PDF documents.

```cs
:title=Ensure your PDF meets Section508 and PDF/UA standards efficiently!
// Creates an accessible PDF from an existing file
IronPdf.PdfDocument.FromFile("input.pdf").SaveAsPdfUA("output‑accessible.pdf");
```