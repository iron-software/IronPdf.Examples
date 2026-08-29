using IronPdf;
namespace IronPdf.Examples.HowTo.Openai
{
    public static class Section1
    {
        public static void Run()
        {
            // PdfAIEngine ships in IronPdf.Extensions.AI, which this project does not reference.
            // Kept verbatim; see README.md for the full context.
            // // Install-Package IronPdf.Extensions.AI
            // await IronPdf.AI.PdfAIEngine.Summarize("input.pdf", "summary.txt", azureEndpoint, azureApiKey);
        }
    }
}