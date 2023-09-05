namespace IronSoftware.IronPdfConsoleDotNetCoreSamples.Infrastructure
{
    interface IExecuteApp
    {
        string OutputPath { get; set; }
        void Run();
    }
}
