using IronPdf.Annotations;
using IronPdf;
namespace IronPdf.Examples.HowTo.Annotations
{
    public static class Section1
    {
        public static void Run()
        {
            var pdf = PdfDocument.FromFile("input.pdf");

            // Add returns void, so it cannot be chained.
            pdf.Annotations.Add(new IronPdf.Annotations.TextAnnotation(0)
            {
                Title = "Note",
                Contents = "Review this section.",
                X = 50,
                Y = 700
            });
            pdf.SaveAs("annotated.pdf");
        }
    }
}