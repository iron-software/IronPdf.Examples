# Enhancing User Experience with PDF Bookmarks and Outlines

***Based on <https://ironpdf.com/how-to/bookmarks/>***


Integrating PDF bookmarks, often referred to as outlines, into your C# projects can significantly improve usability and the overall user experience (UX). These bookmarks act as a navigational aid, similar to a Table of Contents, enabling users to swiftly navigate to crucial sections of the document. Implementing PDF outlines is an effective way to make your documents more user-friendly.

## Quickstart: How to Inject Bookmarks into Your PDF using C#

Kick off your journey with IronPDF and streamline the process of embedding bookmarks in your PDF documents. This guide provides a step-by-step approach to load an existing PDF, insert bookmarks for seamless navigation, and save the enhanced document. This is ideal for developers eager to boost PDF capabilities in their C# applications quickly and efficiently.

```cs
:title=Instant PDF Bookmark Addition
var doc = new IronPdf.PdfDocument("example.pdf");
doc.Bookmarks.AddBookMarkAtEnd("Chapter 1", 1);
doc.SaveAs("bookmarked.pdf");
```

## Detailed Guide: Adding and Managing Outlines and Bookmarks

In platforms like Adobe Acrobat Reader, bookmarks (also known as outlines) appear in the sidebar, offering a handy shortcut to significant document sections.

IronPDF empowers you to manage PDF bookmarks effectively. Whether it’s adding new bookmarks, rearranging them, editing their properties, or removing them, IronPDF gives you complete control over how your PDFs are structured.

All pages are indexed starting from zero.

### Implementing a Single Layer of Bookmarks

Inserting a bookmark using IronPDF is a simple and direct process. Utilize the `AddBookmarkAtEnd` method by providing the name of the bookmark and the respective page index. Here's how you can do it:

```csharp
using IronPdf;

// Either create a new PDF or modify an existing one
PdfDocument document = PdfDocument.FromFile("existing.pdf");

// Add a primary bookmark
document.Bookmarks.AddBookMarkAtEnd("SectionTitle", 0);

// Add a secondary bookmark under the primary
document.Bookmarks.AddBookMarkAtEnd("SubSectionTitle", 1);

document.SaveAs("singleLayerBookmarks.pdf");
```

#### Single-layer Bookmarks Example

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/bookmarks/singleLayerBookmarks.pdf" width="100%" height="400px">
</iframe>

### Creating Multiple Layers of Bookmarks

IronPDF facilitates the creation of nested bookmarks, ideal for organizing large documents like a collection of exam papers, sales reports, or receipts. This hierarchical bookmarking is crucial for maintaining order and navigability in sizable PDF files.

The usage of the `AddBookMarkAtEnd` method returns an **IPdfBookMark** object which can be used to structure a tree of bookmarks. Here’s an illustration of adding multiple layers of bookmarks:

```csharp
using IronPdf;

// Open your existing PDF
PdfDocument doc = PdfDocument.FromFile("examinationPaper.pdf");

// Create a master bookmark
var examBookmark = doc.Bookmarks.AddBookMarkAtEnd("Examination", 0);

// Establish a hierarchical structure of bookmarks
var date1Bookmark = examBookmark.Children.AddBookMarkAtStart("Date1", 1);
var paperBookmark = date1Bookmark.Children.AddBookMarkAtStart("PaperType", 1);
paperBookmark.Children.AddBookMarkAtEnd("CandidateA", 3);
paperBookmark.Children.AddBookMarkAtEnd("CandidateB", 4);

var date2Bookmark = examBookmark.Children.AddBookMarkAtEnd("Date2", 5);

var computerExamBookmark = date2Bookmark.Children.AddBookMarkAtStart("ComputerTest", 5);
computerExamBookmark.Children.AddBookMarkAtEnd("CandidateC", 6);
computerExamBookmark.Children.AddBookMarkAtEnd("CandidateD", 7);

doc.SaveAs("multiLayerBookmarks.pdf");
```

#### Multi-layer Bookmarks Example

<iframe loading="lazy" src="https://ironpdf.com/static-assets/pdf/how-to/bookmarks/multiLayerBookmarks.pdf" width="100%" height="400px">
</iframe>

### Accessing the Bookmarks

IronPDF simplifies viewing and navigating through a PDF’s bookmark structure. Consider the multi-layer bookmarks example mentioned above:

The root bookmark, "Examination," has a `Children` attribute pointing to the "Date1" and "Date2" bookmarks with further subdivisions. To extract a list of all bookmarks for analysis or manipulation, you can use the `GetAllBookmarks` method.

```csharp
using IronPdf;

// Open the desired PDF
PdfDocument document = PdfDocument.FromFile("multiLayerBookmarks.pdf");

// Fetch all bookmarks
var bookmarks = document.Bookmarks.GetAllBookmarks();
```

Bookmarks originating from pages are supported, while those from other elements are set with a page index of `-1`.

For further instruction on creating a dynamic Table of Contents from HTML to PDF, review our article: "[Creating a Table of Contents with IronPDF](https://ironpdf.com/how-to/table-of-contents/)."

Explore additional functionalities on our tutorial page: [Organize your PDFs - Complete Tutorial](https://ironpdf.com/tutorials/organize-pdfs-complete-tutorial/).