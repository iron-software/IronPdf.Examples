using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section13
    {
        public void Run()
        {
            var renderer = new ChromePdfRenderer
            {
                RenderingOptions =
                {
                    FirstPageNumber = 1, // use 2 if a cover-page  will be appended
            
                    // Add a header to every page easily:
                    TextHeader =
                    {
                        DrawDividerLine = true,
                        CenterText = "{url}",
                        Font = IronSoftware.Drawing.FontTypes.Helvetica,
                        FontSize = 12
                    },
            
                    // Add a footer too:
                    TextFooter =
                    {
                        DrawDividerLine = true,
                        Font = IronSoftware.Drawing.FontTypes.Arial,
                        FontSize = 10,
                        LeftText = "{date} {time}",
                        RightText = "{page} of {total-pages}"
                    }
                }
            };
        }
    }
}