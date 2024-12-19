using IronPdf;
namespace IronPdf.Examples.HowTo.RazorToPdfBlazorServer
{
    public static class Section1
    {
        public static void Run()
        {
            @page "/Person"
            @using BlazorSample.Data;
            @using IronPdf;
            @using IronPdf.Extensions.Blazor;
            <h3>Person</h3>
            
            @code {
                [Parameter]
                public IEnumerable<PersonInfo> persons { get; set; }
                public Dictionary<string, object> Parameters { get; set; } = new Dictionary<string, object>();
            
                protected override async Task OnInitializedAsync()
                {
                    persons = new List<PersonInfo>
                    {
                        new PersonInfo { Name = "Alice", Title = "Mrs.", Description = "Software Engineer" },
                        new PersonInfo { Name = "Bob", Title = "Mr.", Description = "Software Engineer" },
                        new PersonInfo { Name = "Charlie", Title = "Mr.", Description = "Software Engineer" }
                    };
                }
                private async void PrintToPdf()
                {
                    ChromePdfRenderer renderer = new ChromePdfRenderer();
            
                    // Apply text footer
                    renderer.RenderingOptions.TextFooter = new TextHeaderFooter()
                        {
                            LeftText = "{date} - {time}",
                            DrawDividerLine = true,
                            RightText = "Page {page} of {total-pages}",
                            Font = IronSoftware.Drawing.FontTypes.Arial,
                            FontSize = 11
                        };
            
                    Parameters.Add("persons", persons);
            
                    // Render razor component to PDF
                    PdfDocument pdf = renderer.RenderRazorComponentToPdf<Person>(Parameters);
            
                    File.WriteAllBytes("razorComponentToPdf.pdf", pdf.BinaryData);
                }
            }
            
            <table class="table">
                <tr>
                    <th>Name</th>
                    <th>Title</th>
                    <th>Description</th>
                </tr>
                @foreach (var person in persons)
                {
                    <tr>
                        <td>@person.Name</td>
                        <td>@person.Title</td>
                        <td>@person.Description</td>
                    </tr>
                }
            </table>
            
            <button class="btn btn-primary" @onclick="PrintToPdf">Print to Pdf</button>
        }
    }
}