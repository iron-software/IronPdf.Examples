using IronSoftware.IronPdfConsoleFrameworkSamples.Infrastructure;
using System;
using System.IO;
using System.Linq;

namespace IronSoftware.IronPdfConsoleFrameworkSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(IExecuteApp);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.IsClass);
            foreach (var app in types)
            {                
               var process= ((IExecuteApp)Activator.CreateInstance(app));
                process.OutputPath = $@"Outputs\{app.Name}";
                if(!Directory.Exists($@"{Directory.GetCurrentDirectory()}\{process.OutputPath}"))
                {
                    Directory.CreateDirectory($@"{Directory.GetCurrentDirectory()}\{process.OutputPath}");
                }
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} Start {app.Name}");
                process.Run();
                Console.WriteLine($"{DateTime.Now.ToLongTimeString()} End {app.Name}");
                Console.WriteLine("--------------------------------------------------------------");
            }
        }
    }
}
