***Based on <https://ironpdf.com/examples/set-temp-path/>***

IronPDF, like many software solutions, generates temporary files during the creation, editing, and rendering of PDF projects. These files are essential for processing and are typically used to store data temporarily. To simplify management of these files, IronPDF allows you to customize the location of the temporary folder and other settings related to your temp PDF files, enhancing ease of use.

Here's a guide on how to specify the temporary PDF file path for your projects.

In the global installation and setup settings for all instances of IronPDF, you can modify the `IronPdf.Installation.TempFolderPath`. This allows customization of the storage path for temporary files, although it's worth noting that some third-party packages may default to using the system's Environmental Temp Path Directory.

To set the Temp Path Environmental Variable across the application in C#, you should do this at the application's startup.

It's advisable to remove temporary files once your project is completed. Failure to delete these files will lead to their accumulation in the temp folder, which can eventually lead to clutter and storage issues.

For additional details on how to manage temporary files and other advanced configurations, please visit the [IronPDF Temporary File Management page](https://ironpdf.com/examples/set-temp-path/).