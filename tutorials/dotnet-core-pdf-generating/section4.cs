using IronPdf;
namespace ironpdf.DotnetCorePdfGenerating
{
    public class Section4
    {
        public void Run()
        {
            public class ClientServices
            {
                private static ClientModel _clientModel;
                public static void AddClient(ClientModel clientModel)
                {
                    _clientModel = clientModel;
                }
                public static ClientModel GetClient()
                {
                    return _clientModel;
                }
            }
        }
    }
}