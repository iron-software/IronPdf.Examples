# Guide to Adding PDF Bookmarks and Outlining in C#

***Based on <https://ironpdf.com/how-to/bookmarks/>***


Adding outlines or bookmarks to your PDFs is an excellent way to improve navigation and enhance the user experience. These outlines act much like a table of contents, enabling quick access to significant sections of the document. Integrating such features in your C# applications can make your PDFs more interactive and user-friendly.

## Example of Adding Outlines & Bookmarks

In applications like Adobe Acrobat Reader, bookmarks are displayed along the left sidebar. These make it easier for users to leap to important parts of the PDF document.

Using IronPDF, developers can not only add but also manage bookmarks with functionalities that include editing, deleting, and rearranging them. This helps in effectively managing the document's structure.

Pages are indexed starting from zero.

### Implementing a Single Bookmark Layer

Creating a new bookmark with IronPDF involves simple steps. You'll need to utilize the `AddBookmarkAtEnd` method, specifying the name for the bookmark and its page index within the document.

```cs
using IronPdf;
namespace IronPdf.Bookmarks
{
    public class BookmarkExample
    {
        public void Execute()
        {
            // Instantiate a PDF document by loading an existing file
            PdfDocument pdf = PdfDocument.FromFile("existing.pdf");
            
            // Append a bookmark
            pdf.Bookmarks.AddBookMarkAtEnd("Chapter1", 0);  // Adding bookmark for first chapter
            
            // Append a sub-bookmark
            pdf.Bookmarks.AddBookMarkAtEnd("IntroSection", 1);  // Introduction section under Chapter 1
            
            pdf.SaveAs("UpdatedWithBookmarks.pdf");  // Save the document with bookmarks
        }
    }
}
```

#### Document with a Single Bookmark Layer

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/bookmarks/singleLayerBookmarks.pdf" width="100%" height="400px">
</iframe>

### Adding Hierarchical Bookmarks

In larger documents, such as those containing multiple reports or varied records, maintaining a structured navigation with IronPDF is straightforward. You can create a bookmark hierarchy that makes complex documents easily navigable.

Below, we add multiple bookmarks to build a structured outline using the `AddBookMarkAtEnd` method which returns an `IPdfBookMark`. This allows the addition of child bookmarks, enhancing navigational structure.

```cs
using IronPdf;
namespace IronPdf.Bookmarks
{
    public class MultipleBookmarksExample
    {
        public void Execute()
        {
            // Open a PDF document
            PdfDocument pdf = PdfDocument.FromFile("complexDocument.pdf");
            
            // Add a main bookmark with children
            var mainBookmark = pdf.Bookmarks.AddBookMarkAtEnd("MainSection", 0);
            
            // Adding sub-bookmarks
            var subsectionBookmark = mainBookmark.Children.AddBookMarkAtStart("Subsection1", 2);
            
            // More nested bookmarks under a subsection
            var detailBookmark = subsectionBookmark.Children.AddBookMarkAtStart("Detail1", 2);
            detailBookmark.Children.AddBookMarkAtEnd("PartA", 4);
            detailBookmark.Children.AddBookMarkAtEnd("PartB", 5);
            
            pdf.SaveAs("StructuredBookmarks.pdf");  // Saving the document with hierarchical bookmarks
        }
    }
}
```

#### Document with Multi-layer Bookmarks

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/bookmarks/multiLayerBookmarks.pdf" width="100%" height="400px">
</iframe>

### Retrieving a List of Bookmarks

IronPDF simplifies the process of accessing and navigating through a document's bookmarks. By using the `GetAllBookmarks` method, you can fetch a complete list of bookmarks, helping in further analysis or modifications.

```cs
using IronPdf;
namespace IronPdf.Bookmarks
{
    public class FetchBookmarks
    {
        public void Execute()
        {
            // Loading the PDF document
            PdfDocument pdf = PdfDocument.FromFile("StructuredBookmarks.pdf");
            
            // Acquiring all bookmarks
            var bookmarksList = pdf.Bookmarks.GetAllBookmarks();  // Retrieves all bookmarks from the document.
        }
    }
}
```

Combining PDFs that contain bookmarks with identical names might disrupt the bookmarks hierarchy.

It is important to note that bookmarks based on page indexes are supported, whereas those linked to document segments might not function as expected, potentially being set to an index of **-1**.

To learn about generating a Table of Contents in a PDF from HTML content, visit the tutorial "[Creating a Table of Contents with IronPDF](https://ironpdf.com/how-to/table-of-contents/)."