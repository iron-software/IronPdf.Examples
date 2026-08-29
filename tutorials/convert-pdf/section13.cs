using IronPdf.Font;
using IronPdf;
namespace IronPdf.Examples.Tutorial.ConvertPdf
{
    public static class Section13
    {
        public static void Run()
        {
            // This snippet is a member of a larger component from the accompanying README, not a standalone program.
            // Kept verbatim; see README.md for the full context.
            // [Parameter]
            // public IEnumerable<PersonInfo> persons { get; set; }
            // public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();
            //
            // protected override async Task OnInitializedAsync()
            // {
            // persons = new List<PersonInfo>
            // {
            // new PersonInfo { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
            // new PersonInfo { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
            // new PersonInfo { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
            // };
            // }
            // private async void PrintToPdf()
            // {
            // ChromePdfRenderer renderer = new ChromePdfRenderer();
            //
            // // Apply text footer
            // renderer.RenderingOptions.TextFooter = new TextHeaderFooter()
            // {
            // LeftText = "{date} - {time}",
            // DrawDividerLine = true,
            // RightText = "Page {page} of {total-pages}",
            // Font = IronSoftware.Drawing.FontTypes.Arial,
            // FontSize = 11
            // };
            //
            // Parameters.Add("persons", persons);
            //
            // // Render razor component to PDF
            // PdfDocument pdf = renderer.RenderRazorComponentToPdf<Person>(Parameters);
            //
            // File.WriteAllBytes("razorComponentToPdf.pdf", pdf.BinaryData);
            // }
        }
    }
}