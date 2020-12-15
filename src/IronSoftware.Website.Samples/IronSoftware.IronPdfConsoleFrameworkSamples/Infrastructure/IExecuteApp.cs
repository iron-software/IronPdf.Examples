namespace IronSoftware.IronPdfConsoleFrameworkSamples.Infrastructure
{
    interface IExecuteApp
    {
        string OutputPath { get; set; }
        void Run();
    }
}
