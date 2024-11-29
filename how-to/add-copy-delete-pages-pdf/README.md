***Based on <https://ironpdf.com/how-to/add-copy-delete-pages-pdf/>***

## How to Add, Copy, and Delete Pages in PDFs

Modifying pages in a PDF involves several processes including adding new content like images, text, or existing pages, copying existing pages within the same or different PDFs, and deleting unnecessary pages.

IronPDF simplifies these tasks, offering an efficient way to manage PDF pages conveniently.

## Add Pages to a PDF

Incorporating a page into a PDF file is straightforward and can be achieved with minimal code. For illustration, consider merging a cover page with a report PDF. Here, the `Merge` method combines both. Below are the two example PDFs used in this tutorial: [download coverPage.pdf](https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/coverPage.pdf) and [download contentPage.pdf](https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/contentPage.pdf).

```cs
using IronPdf;
namespace ironpdf.AddCopyDeletePagesPdf
{
    public class Section1
    {
        public void Run()
        {
            // Load the cover page document
            PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");
            
            // Load the main content document
            PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");
            
            // Combines both documents into one
            PdfDocument finalPdf = PdfDocument.Merge(coverPage, contentPage);
            
            // Save the newly created document
            finalPdf.SaveAs("pdfWithCover.pdf");
        }
    }
}
```

When executed, this code creates a merged PDF document, placing the cover at the beginning:

<iframe src="https://ironpdf.com/static-assets/pdf/how-to/add-copy-delete-pages-pdf/pdfWithCover.pdf#view=fit" width="100%" height="500px">
</iframe>

Alternatively, to insert the cover page at a specific position in the PDF document, use the `InsertPdf` method. This code places 'coverPage.pdf' at the start of 'contentPage.pdf':

```cs
using IronPdf;
namespace ironpdf.AddCopyDeletePagesPdf
{
    public class Section2
    {
        public void Run()
        {
            // Load the cover page document
            PdfDocument coverPage = PdfDocument.FromFile("coverPage.pdf");
            
            // Load the main content page
            PdfDocument contentPage = PdfDocument.FromFile("contentPage.pdf");
            
            // Insert the cover page at the beginning of the content page
            contentPage.InsertPdf(coverPage, 0);
        }
    }
}
```

<hr>

## Copy Pages from a PDF

To replicate pages from a PDF, employ the `CopyPage` or `CopyPages` methods to copy one or multiple pages respectively. These methods return a new **PdfDocument** that includes the copied pages.

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.AddCopyDeletePagesPdf
{
    public class Section3
    {
        public void Run()
        {
            // Open a PDF from which to copy pages
            PdfDocument myReport = PdfDocument.FromFile("report_final.pdf");
            
            // Create a new PDF containing the first page
            PdfDocument copyOfPageOne = myReport.CopyPage(0);
            
            // Create a new PDF containing the first three pages
            PdfDocument copyOfFirstThreePages = myReport.CopyPages(new List<int> { 0, 1, 2 });
        }
    }
}
```

<hr>

## Delete Pages in a PDF

To remove pages from a PDF, utilize the `RemovePage` or `RemovePages` methods for singular or multiple pages, respectively.

```cs
using System.Collections.Generic;
using IronPdf;
namespace ironpdf.AddCopyDeletePagesPdf
{
    public class Section4
    {
        public void Run()
        {
            // Open the PDF to remove pages from
            PdfDocument pdf = PdfDocument.FromFile("full_report.pdf");
            
            // Remove the first page
            pdf.RemovePage(0);
            
            // Remove multiple specified pages
            pdf.RemovePages(new List<int> { 2, 3 });
        }
    }
}
```