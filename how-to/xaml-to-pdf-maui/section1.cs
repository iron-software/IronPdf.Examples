using IronPdf;
namespace IronPdf.Examples.HowTo.XamlToPdfMaui
{
    public static class Section1
    {
        public static void Run()
        {
            <Button
            x:Name="PrintToPdfBtn"
            Text="Print to pdf"
            SemanticProperties.Hint="Click to print page as PDF"
            Clicked="PrintToPdf"
            HorizontalOptions="Center" />
        }
    }
}