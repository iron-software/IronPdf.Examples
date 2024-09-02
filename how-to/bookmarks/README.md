# Managing PDF Bookmarks and Outlines in C#

Incorporating bookmarks, also known as outlines, into your C# application enhances the document's usability, essentially functioning as a navigational aid. These outlines allow users to quickly navigate to important sections, similar to a Table of Contents, making the document more user-friendly and accessible.

## Example: Adding Outlines & Bookmarks

Bookmarks, visible within the sidebar of Adobe Acrobat Reader, enhance document navigation by marking important parts of a PDF. IronPDF offers comprehensive tools allowing developers to manipulate these bookmarks in various ways, such as adding, editing, rearranging, or deleting them, thus providing full control over a document’s structure and organization.

All page indexes are zero-based.

### Implementing a Single Layer of Bookmarks

Inserting a bookmark using IronPDF is a simple task. Employ the `AddBookmarkAtEnd` method, which necessitates specifying the bookmark's name along with its associated page index.

```cs
using IronPdf;

// Initialize a new PDF or modify an existing document.
PdfDocument pdf = PdfDocument.FromFile("existing.pdf");

// Append a primary bookmark
pdf.Bookmarks.AddBookMarkAtEnd("PrimaryBookmark", 0);

// Append a secondary bookmark
pdf.Bookmarks.AddBookMarkAtEnd("SecondaryBookmark", 1);

pdf.SaveAs("singleLayerBookmarks.pdf");
```

#### Document with Single-layer Bookmarks

<iframe src="https://ironpdf.com/static-assets/pdf/how-to/bookmarks/singleLayerBookmarks.pdf" width="100%" height="400" loading="lazy"></iframe>

### Creating Multiple Layers of Bookmarks

IronPDF enables the addition of bookmarks in a hierarchical structure, beneficial for documents with a complex organization, such as various collections of documents or reports compounded into one PDF.

Using the `AddBookMarkAtEnd` method, which returns an `IPdfBookMark` object, enables adding nested bookmarks.

```cs
using IronPdf;

// Open an existing PDF document
PdfDocument pdf = PdfDocument.FromFile("examinationPaper.pdf");

// Start with a primary bookmark
var examBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Examination", 0);

// Nest bookmarks for each date
var date1Bookmark = examBookmark.Children.AddBookMarkAtStart("Date1", 1);

// Add specific test types
var testBookmark = date1Bookmark.Children.AddBookMarkAtStart("Test", 1);
testBookmark.Children.AddBookMarkAtEnd("ParticipantA", 3);
testBookmark.Children.AddBookMarkAtEnd("ParticipantB", 4);

// Proceed to the next date
var date2Bookmark = examBookmark.Children.AddBookMarkAtEnd("Date2", 5);

// Test details for second date
var test2Bookmark = date2Bookmark.Children.AddBookMarkAtStart("Lab", 5);
test2Bookmark.Children.AddBookMarkAtEnd("ParticipantC", 6);
test2Bookmark.Children.AddBookMarkAtEnd("ParticipantD", 7);

pdf.SaveAs("multiLayerBookmarks.pdf");
```

#### Document with Multi-layer Bookmarks

<iframe src="https://ironpdf.com/static-assets/pdf/how-to/bookmarks/multiLayerBookmarks.pdf" width="100%" height="400" loading="lazy"></iframe>

### Retrieving a List of Bookmarks

IronPDF facilitates the extraction and viewing of bookmarks within a PDF. Navigation through the bookmark hierarchy is intuitive, providing quick access to various document sections. For instance, in the multi-layer bookmark setup described earlier:

The first-level "Examination" bookmark contains branches to "Date1" and "Date2", with "Date1" connecting next to "Date2" and containing its own sub-levels.

To gather all existing bookmarks in the document:

```cs
using IronPdf;

// Open an existing PDF document
PdfDocument pdf = PdfDocument.FromFile("multiLayerBookmarks.pdf");

// Retrieve and list all bookmarks
var bookmarks = pdf.Bookmarks.GetAllBookmarks();
```

Merging two PDFs with identical bookmark names might disrupt the list order.

Bookmarks are typically linked to page indexes; otherwise, they are assigned a default index value of **-1**.

Further explore creating interactive and navigable PDFs from HTML content in our guide to adding a Table of Contents: "[How to Add Table of Contents](https://ironpdf.com/how-to/table-of-contents/)."