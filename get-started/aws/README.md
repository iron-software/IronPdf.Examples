# Implementing IronPDF .NET with AWS Lambda

***Based on <https://ironpdf.com/get-started/aws/>***


## 1. Setting Up AWS Lambda with .NET 5 as Container Image

To get started, please review the first section of this official AWS documentation on utilizing container images with .NET 5: [.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/).

## 2. Incorporating Package Dependencies

Additional dependencies are needed to support Chrome in this AWS setting.

Update your Docker file by following these guidelines:

### For AWS Lambda using .NET 5

<script src="https://gist.github.com/ironsoftwarebuild/7f2265f7751240398fb532bd318fc90c.js"></script>

### For AWS Lambda using .NET 7

<script src="https://gist.github.com/ironsoftwarebuild/ea399e109586f3ac29ebd43d1d0f6285.js"></script>

### For AWS Lambda using .NET 8

<script src="https://gist.github.com/ironsoftwarebuild/b700ca3ee47f405c257e72b2f8a33d52.js"></script>

## 3. Installing IronPDF (Linux) NuGet Package

Steps to install `IronPdf.Linux`:

1. In the Solution Explorer, right-click on References and then click on Manage NuGet Packages.
2. Click Browse and type `IronPdf.Linux` into the search bar.
3. Click to select the package and proceed with the installation.

## 4. Adjusting FunctionHandler Code

The function below will generate a PDF from the [Iron Software website](https://ironpdf.com) and save it to `/tmp`. To access this PDF, you'll need to upload it to a service like S3.

Setting the temporary directory is essential for using IronPDF in AWS Lambda. Use both `TempFolderPath` and `CustomDeploymentDirectory` for setup.

```csharp
public Casing FunctionHandler(string input, ILambdaContext context)
{
    try
    {
        var awsTmpPath = @"/tmp/"; // designated AWS temporary directory
        context.Logger.LogLine($"Initiating FunctionHandler RequestId: {context.AwsRequestId} Input: {input}");

        // Uncomment below for enabling logging if troubleshooting is needed
        //IronPdf.Logging.Logger.EnableDebugging = true;
        //IronPdf.Logging.Logger.LogFilePath = awsTmpPath;
        //IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

        // Insert your license key here
        IronPdf.License.LicenseKey = "YOUR_LICENSE_KEY";

        // Disable GPU usage in Chrome
        IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;

        // Configure IronPDF to use the proper temporary paths
        IronPdf.Installation.TempFolderPath = awsTmpPath;
        IronPdf.Installation.CustomDeploymentDirectory = awsTmpPath;

        // Automatically configure dependencies for Linux and Docker
        IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;

        context.Logger.LogLine("Initializing PDF renderer");
        var Renderer = new IronPdf.ChromePdfRenderer();

        context.Logger.LogLine("Starting PDF generation");
        using var pdfDoc = Renderer.RenderUrlAsPdf("https://ironpdf.com/");

        var guid = Guid.NewGuid();
        var fileName = $"/tmp/{input}_{guid}.pdf"; // Define the file path

        context.Logger.LogLine($"PDF saved as: {fileName}");
        pdfDoc.SaveAs(fileName);

        // Optionally upload the PDF file to a cloud service like AWS S3

        context.Logger.LogLine("FunctionHandler completed successfully.");
    }
    catch (Exception e)
    {
        context.Logger.LogLine($"FunctionHandler error: {e.Message}");
    }

    return new Casing(input?.ToLower(), input?.ToUpper());
}
```

## 5. Enhancing Memory and Timeout Settings

For optimal performance with IronPDF, increase both the memory and timeout settings in `aws-lambda-tools-defaults.json`. This example adjusts them to 512 MB and 330 seconds respectively.

```csharp
"function-memory-size" : 512,
"function-timeout"     : 330,
```

Adjustments can also be made directly using the Lambda console, as detailed in the [Configuring AWS Lambda functions](https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console) guide.

## 6. Publishing Your Function

Follow the latter instructions in the '[.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/)' guide to deploy and test your Lambda function.

## 7. Execution

Test the newly created Lambda function via the [Lambda console](https://console.aws.amazon.com/lambda) or by using the [AWS Toolkit for Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/lambda-creating-project-in-visual-studio.html).