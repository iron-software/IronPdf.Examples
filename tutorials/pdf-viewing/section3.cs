using IronPdf;
namespace IronPdf.Examples.Tutorial.PdfViewing
{
    public static class Section3
    {
        public static void Run()
        {
            <?xml version="1.0" encoding="UTF-8" ?>
            <Shell ...
                xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
                xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                ...>
              <TabBar x:Name="AppTabBar">
                  <Tab Title="Home">
                    <ShellContent ContentTemplate="{DataTemplate local:MainPage}" Route="MainPage"/>
                  </Tab>
                  <Tab Title="PDF Viewer">
                    <ShellContent ContentTemplate="{DataTemplate local:PdfViewerPage}" Route="PDFViewer"/>
                </Tab>
              </TabBar>
            </Shell>
        }
    }
}