
// PM > Install-Package IronPdf.Extensions.Mvc.Core

public async Task<IActionResult> Persons()
{
    var persons = new List<Person>
    {
    new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
    new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
    new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
    };
    if (_httpContextAccessor.HttpContext.Request.Method == HttpMethod.Post.Method)
    {
        ChromePdfRenderer renderer = new ChromePdfRenderer();

        // Render View to PDF document
        PdfDocument pdf = renderer.RenderRazorViewToPdf(_viewRenderService, "Views/Home/Persons.cshtml", persons);
        Response.Headers.Add("Content-Disposition", "inline");

        // Output PDF document
        return File(pdf.BinaryData, "application/pdf", "viewToPdfMVCCore.pdf");
    }
    return View(persons);
}
