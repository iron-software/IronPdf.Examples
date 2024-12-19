using IronPdf;
namespace IronPdf.Examples.HowTo.Old_Changed 2021_CsharpPrintPdf Copy
{
    public static class Section4
    {
        public static void Run()
        {
            /**
            PrinttoFile
            anchor-printtofile-method
            **/
            printDocument.PrintToFile(“PathToFile”, false);
        }
    }
}