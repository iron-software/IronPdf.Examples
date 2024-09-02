using IronPdf;

// Load existing PDF document
PdfDocument pdf = PdfDocument.FromFile("multiLayerBookmarks.pdf");

// Retrieve bookmarks list
var mainBookmark = pdf.Bookmarks.GetAllBookmarks();