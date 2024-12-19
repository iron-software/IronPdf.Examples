using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section24
    {
        public static void Run()
        {
            var pdf = new PdfDocument("/assets/example.pdf");
            
            // Apply one stamp to all pages
            pdf.ApplyStamp(myStamper);
            
            // Apply one stamp to a specific page
            pdf.ApplyStamp(myStamper, 0);
            
            // Apply one stamp to specific pages
            pdf.ApplyStamp(myStamper, new[] { 0, 3, 5 });
            
            // Apply a stamp array to all pages
            pdf.ApplyMultipleStamps(stampArray);
            
            // Apply a stamp array to a specific page
            pdf.ApplyMultipleStamps(stampArray, 0);
            
            // Apply a stamp array to specific pages
            pdf.ApplyMultipleStamps(stampArray, new[] { 0, 3, 5 });
            
            // And some Async versions of the above
            await pdf.ApplyStampAsync(myStamper, 4);
            await pdf.ApplyMultipleStampsAsync(stampArray);
            
            // Additional Watermark apply method
            string html = "<h1> Example Title <h1/>";
            int rotation = 0;
            int watermarkOpacity = 30;
            pdf.ApplyWatermark(html, rotation, watermarkOpacity);
        }
    }
}