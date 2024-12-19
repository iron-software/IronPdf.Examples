using IronPdf;
namespace IronPdf.Examples.HowTo.CsharpPdfReports
{
    public static class Section3
    {
        public static void Run()
        {
            CrystalDecisions.Shared.DiskFileDestinationOptions diskOpts = CrystalDecisions.Shared.ExportOptions.CreateDiskFileDestinationOptions();
            
            CrystalDecisions.Shared.ExportOptions exportOpts = new CrystalDecisions.Shared.ExportOptions();
            
            CrystalDecisions.Shared.CharacterSeparatedValuesFormatOptions csvExpOpts = new CrystalDecisions.Shared.CharacterSeparatedValuesFormatOptions();
            
            CrystalDecisions.Shared.HTMLFormatOptions HTMLExpOpts = new CrystalDecisions.Shared.HTMLFormatOptions();
            
            rpt.Load(@"c:\my\report.rpt");
            
            //diskOpts.DiskFileName = "c:\\ReportName.csv";
            
            diskOpts.DiskFileName = @"c:\tmp\html\b.html";
            
            exportOpts.ExportDestinationType = CrystalDecisions.Shared.ExportDestinationType.DiskFile;
            exportOpts.ExportFormatType = CrystalDecisions.Shared.ExportFormatType.HTML40;
            exportOpts.ExportDestinationOptions = diskOpts;
            
            HTMLExpOpts = new HTMLFormatOptions();
            HTMLExpOpts.HTMLBaseFolderName = @"c:\tmp\html\b.html";
            HTMLExpOpts.HTMLEnableSeparatedPages = false;
            HTMLExpOpts.UsePageRange = false;
            HTMLExpOpts.HTMLHasPageNavigator = false;
            
            System.IO.Stream htmlStream;
            
            byte[] htmlByteArray = null;
            
            htmlStream = rpt.ExportThtmlStream(CrystalDecisions.Shared.ExportFormatType.HTML40);
            
            htmlByteArray = new byte[htmlStream.Length];
            
            htmlStream.Read(htmlByteArray, 0, Convert.ToInt32(htmlStream.Length - 1));
            
            System.IO.File.Create(diskOpts.DiskFileName, Convert.ToInt32(htmlStream.Length - 1)).Close();
            
            System.IO.File.OpenWrite(diskOpts.DiskFileName).Write(htmlByteArray, 0, Convert.ToInt32(htmlStream.Length - 1));
            
            System.IO.File.SetAttributes(diskOpts.DiskFileName, System.IO.FileAttributes.Directory);
            
            htmlStream.Close();
            
            IronPdf.ChromePdfRenderer Renderer = new IronPdf.ChromePdfRenderer();
            
            // Add a header to every page easily
            renderer.RenderingOptions.FirstPageNumber = 1;
            renderer.RenderingOptions.TextHeader.DrawDividerLine = true;
            renderer.RenderingOptions.TextHeader.CenterText = "{url}";
            renderer.RenderingOptions.TextHeader.Font = IronSoftware.Drawing.FontTypes.Arial;
            renderer.RenderingOptions.TextHeader.FontSize = 12;
            
            // Add a footer too
            renderer.RenderingOptions.TextFooter.DrawDividerLine = true;
            renderer.RenderingOptions.TextFooter.Font = IronSoftware.Drawing.FontTypes.Arial;
            renderer.RenderingOptions.TextFooter.FontSize = 10;
            renderer.RenderingOptions.TextFooter.LeftText = "{date} {time}";
            renderer.RenderingOptions.TextFooter.RightText = "{page} of {total-pages}";
            
            Renderer.RenderFileAsPdf(diskOpts.DiskFileName).SaveAs("Report.pdf");
            
            Console.WriteLine("Report Written To {0}", Path.GetFullPath(diskOpts.DiskFileName));
        }
    }
}