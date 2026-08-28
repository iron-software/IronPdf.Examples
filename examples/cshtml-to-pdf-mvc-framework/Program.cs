using IronPdf;

// PM > Install-Package IronPdf.Extensions.Mvc.Framework

// This snippet is an action from the ASP.NET MVC controller the page describes, not a standalone program.
// Kept verbatim; see README.md for the full context.
// public ActionResult Persons()
// {
//     var persons = new List<Person>
//     {
//     new Person { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
//     new Person { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
//     new Person { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
//     };
//     if (HttpContext.Request.HttpMethod == "POST")
//     {
//         // Provide the path to your view file
//         var viewPath = "~/Views/Home/Persons.cshtml";
//         ChromePdfRenderer renderer = new ChromePdfRenderer();
//
//         // Render Razor view to PDF document
//         PdfDocument pdf = renderer.RenderView(this.HttpContext, viewPath, persons);
//         Response.Headers.Add("Content-Disposition", "inline");
//
//         // View the PDF
//         return File(pdf.BinaryData, "application/pdf");
//     }
//     return View(persons);
// }
//
