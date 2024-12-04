using IronPdf;
namespace ironpdf.CsharpEditPdfCompleteTutorial
{
    public class Section26
    {
        public void Run()
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