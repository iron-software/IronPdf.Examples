using IronPdf;
namespace IronPdf.Examples.HowTo.Openai
{
    public static class Section1
    {
        public static void Run()
        {
            :title=Summarize any PDF with AI in just one line!
            // Install-Package IronPdf.Extensions.AI
            await IronPdf.AI.PdfAIEngine.Summarize("input.pdf", "summary.txt", azureEndpoint, azureApiKey);
        }
    }
}