using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section26
    {
        public static void Run()
        {
            HtmlStamper logoStamper = new HtmlStamper
            {
                VerticalOffset = new Length(15, MeasurementUnit.Percentage),
                HorizontalOffset = new Length(1, MeasurementUnit.Inch)
                // set other properties...
            };
        }
    }
}