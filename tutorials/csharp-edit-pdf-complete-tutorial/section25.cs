using IronPdf;
namespace IronPdf.Examples.Tutorial.CsharpEditPdfCompleteTutorial
{
    public static class Section25
    {
        public static void Run()
        {
            new Length(value: 5, unit: MeasurementUnit.Inch); // 5 inches
            
            new Length(value: 25, unit: MeasurementUnit.Pixel);// 25px
            
            new Length(); // 0% of the page dimension because value is defaulted to zero and unit is defaulted to percentage
            
            new Length(value: 20); // 20% of the page dimension
        }
    }
}