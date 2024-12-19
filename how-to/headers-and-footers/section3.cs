using IronSoftware.Drawing;
using IronPdf;
namespace IronPdf.Examples.HowTo.HeadersAndFooters
{
    public static class Section3
    {
        public static void Run()
        {
            // Create text header
            TextHeaderFooter textHeader = new TextHeaderFooter
            {
                CenterText = "Center text", // Set the text in the center
                LeftText = "Left text", // Set left-hand side text
                RightText = "Right text", // Set right-hand side text
                Font = IronSoftware.Drawing.FontTypes.ArialBoldItalic, // Set font
                FontSize = 16, // Set font size
                DrawDividerLine = true, // Draw Divider Line
                DrawDividerLineColor = Color.Red, // Set color of divider line
            };
        }
    }
}