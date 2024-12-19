using IronPdf;
namespace IronPdf.Examples.HowTo.ImageToPdf
{
    public static class Section4
    {
        public static void Run()
        {
            string imagePath = "meetOurTeam.jpg";
            
            ChromePdfRenderOptions options = new ChromePdfRenderOptions()
            {
                HtmlHeader = new HtmlHeaderFooter()
                {
                    HtmlFragment = "<h1 style='color: #2a95d5;'>Content Header</h1>",
                    DrawDividerLine = true,
                },
            };
            
            // Convert an image to a PDF with custom header
            PdfDocument pdf = ImageToPdfConverter.ImageToPdf(imagePath, options: options);
            
            // Export the PDF
            pdf.SaveAs("imageToPdfWithHeader.pdf");
        }
    }
}