using IronPdf;
namespace IronPdf.Examples.HowTo.DocxToPdf
{
    public static class Section2
    {
        public static void Run()
        {
            internal class RecipientsDataModel
            {
                public string Date { get; set; }
                public string Location{ get; set; }
                public string Recipients_Name { get; set; }
                public string Contact_Us { get; set; }
            }
        }
    }
}