
// PM > Install-Package IronPdf.Extensions.Razor

using IronPdf.Razor.Pages;

public IActionResult OnPostAsync()
{
    persons = new List<Person>
    {
    new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
    new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
    new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
    };

    ViewData["personList"] = persons;

    ChromePdfRenderer renderer = new ChromePdfRenderer();

    // Render Razor Page to PDF document
    PdfDocument pdf = renderer.RenderRazorToPdf(this);

    Response.Headers.Add("Content-Disposition", "inline");

    return File(pdf.BinaryData, "application/pdf", "razorPageToPdf.pdf");
}
