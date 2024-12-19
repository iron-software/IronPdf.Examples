# Enhancing PDF Functionality with IronPDF: Adding Bookmarks and Outlines

***Based on <https://ironpdf.com/how-to/bookmarks/>***


Incorporating bookmarks (also known as outlines) into your C# projects can significantly improve the document's usability and user experience. PDF outlines serve as a navigational aid, much like a Table of Contents, enabling users to quickly locate important pages within a document. By implementing these features, developers can elevate the document’s accessibility, making it more user-centric.

<h3>Introduction to IronPDF</h3>

----------------------------------

* * *

* * *

## Implementing Outlines & Bookmarks with IronPDF

Outlines, or bookmarks, are a familiar feature in Adobe Acrobat Reader, appearing on the left sidebar and allowing for rapid navigation to critical sections of the PDF.

IronPDF steps up as a comprehensive tool, empowering developers with functionalities for managing outlines in PDFs. You can add, reorder, modify, or delete bookmarks, granting you complete mastery over the PDF layout and structure.

Indexing of pages begins from zero (0-based indexing).

### Implementing a Single Layer of Bookmarks

IronPDF allows for the uncomplicated addition of bookmarks, using the `AddBookmarkAtEnd` method with parameters for the bookmark's name and its page number.

```cs
using IronPdf;

// Create a new PDF or open an existing file.
PdfDocument pdf = PdfDocument.FromFile("existing.pdf");

// Introducing a new bookmark
pdf.Bookmarks.AddBookMarkAtEnd("NameOfBookmark", 0);

// Adding a sub-bookmark under the previous one
pdf.Bookmarks.AddBookMarkAtEnd("NameOfSubBookmark", 1);

// Save the PDF with new bookmarks
pdf.SaveAs("singleLayerBookmarks.pdf");
```

#### View Single-layer Bookmarks Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/bookmarks/singleLayerBookmarks.pdf" width="100%" height="400px">
</iframe>

### Creating Multiple Layers of Bookmarks

IronPDF’s capabilities extend to creating a hierarchical structure of bookmarks, ideal for lengthy and complex documents such as collection of tests, sales records, or archived receipts.

When using `AddBookMarkAtEnd`, an **IPdfBookMark** object is returned, enabling the addition of sub-bookmarks using methods like `Children.AddBookMarkAtStart` or `Children.AddBookMarkAtEnd`.

```cs
using IronPdf;

// Open an existing PDF
PdfDocument pdf = PdfDocument.FromFile("examinationPaper.pdf");

// Main parent bookmark
var mainBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Examination", 0);

// Creating child bookmarks
var date1Bookmark = mainBookmark.Children.AddBookMarkAtStart("Date1", 1);
var paperBookmark = date1Bookmark.Children.AddBookMarkAtStart("Paper", 1);

// More nested bookmarks
paperBookmark.Children.AddBookMarkAtEnd("PersonA", 3);
paperBookmark.Children.AddBookMarkAtEnd("PersonB", 4);

// Second date bookmark
var date2Bookmark = mainBookmark.Children.AddBookMarkAtEnd("Date2", 5);
var computerBookmark = date2Bookmark.Children.AddBookMarkAtStart("Computer", 5);

computerBookmark.Children.AddBookMarkAtEnd("PersonC", 6);
computerBookmark.Children.AddBookMarkAtEnd("PersonD", 7);

// Save the structured document
pdf.SaveAs("multiLayerBookmarks.pdf");
```

#### View Multi-layer Bookmarks Document

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/bookmarks/multiLayerBookmarks.pdf" width="100%" height="400px">
</iframe>

### Retrieving a List of Bookmarks

Navigating IronPDF's bookmark architecture is intuitive, providing efficient access to distinct sections. For instance, in the `multi-layer bookmarks document` example above, hierarchical bookmarking is utilized for organization.

Using the `GetAllBookmarks` function, you can fetch all bookmarks embedded within the PDF, facilitating an insightful review and manipulation of the structure.

```cs
using IronPdf;

// Open a PDF document
PdfDocument pdf = PdfDocument.FromFile("multiLayerBookmarks.pdf");

// Accessing all bookmarks
var mainBookmark = pdf.Bookmarks.GetAllBookmarks();
```

Note, merging PDFs with overlapping bookmarks names could disrupt the bookmarks arrangement.

Only page-index-based bookmarks are recognized; any bookmark linked to other elements will default to an index of **-1**.

Discover methods to generate a Table of Contents from HTML into PDF in our detailed guide here: "[Creating a Table of Contents with IronPDF](https://ironpdf.com/how-to/table-of-contents/)."