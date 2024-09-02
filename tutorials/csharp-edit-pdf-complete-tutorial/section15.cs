// Create a new PDF or edit an existing document.
PdfDocument pdf = PdfDocument.FromFile("existing.pdf");

// Add bookmark
pdf.Bookmarks.AddBookMarkAtEnd("Author's Note", 2);
pdf.Bookmarks.AddBookMarkAtEnd("Table of Contents", 3);

// Store new bookmark in a variable to add nested bookmarks to
var summaryBookmark = pdf.Bookmarks.AddBookMarkAtEnd("Summary", 17);

// Add a sub-bookmark within the summary
var conclusionBookmark = summaryBookmark.Children.AddBookMarkAtStart("Conclusion", 18);

// Add another bookmark to end of highest-level bookmark list
pdf.Bookmarks.AddBookMarkAtEnd("References", 20);

pdf.SaveAs("existing.pdf");