# Implementing & Deploying IronPDF .NET on AWS Lambda

***Based on <https://ironpdf.com/get-started/aws/>***


## 1. Initialize AWS Lambda with a .NET 5 Container Template

Begin by reading the initial section of this official AWS documentation: [.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images).

## 2. Include Required Packages

To execute Chrome in this specific AWS setting, include the necessary dependencies.

Update your Docker file as per the following guidelines:

### AWS Lambda with .NET 5

<script src="https://gist.github.com/ironsoftwarebuild/7f2265f7751240398fb532bd318fc90c.js"></script>

### AWS Lambda with .NET 7

<script src="https://gist.github.com/ironsoftwarebuild/ea399e109586f3ac29ebd43d1d0f6285.js"></script>

### AWS Lambda with .NET 8

<script src="https://gist.github.com/ironsoftwarebuild/b700ca3ee47f405c257e72b2f8a33d52.js"></script>

## 3. Install IronPDF (Linux) NuGet Package

Proceed to install `IronPdf.Linux` with the following steps:

1. Right-click on References in Solution Explorer, navigate to Manage NuGet Packages.
2. Click on Browse and type `IronPdf.Linux`.
3. Choose the correct package and proceed with the installation.

## 4. Update FunctionHandler Code

This code snippet demonstrates creating a PDF document from a webpage [https://ironpdf.com/](https://ironpdf.com/) and saving it locally to `/tmp`. To make the PDF accessible, upload it to a service such as Amazon S3.

Configuring the temporary storage directory is essential when utilizing IronPDF on AWS Lambda. Use the **TempFolderPath** and **CustomDeploymentDirectory** parameters for settings.

```csharp
public Casing FunctionHandler(string input, ILambdaContext context)
{
    try
    {
        context.Logger.LogLine($"BEGIN FunctionHandler RequestId: {context.AwsRequestId} Input: {input}");

        var temporaryAwsPath = @"/tmp/"; // Location for temporary storage on AWS

        //[optional] Un-comment the lines below to enable IronPDF logging if troubleshooting is required
        //IronPdf.Logging.Logger.EnableDebugging = true;
        //IronPdf.Logging.Logger.LogFilePath = temporaryAwsPath;
        //IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

        // Configure the license key
        IronPdf.License.LicenseKey = "YOUR_LICENSE_KEY";

        // Disable GPU when using Chrome
        IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;

        // Set IronPDF temporary and deployment directories
        IronPdf.Installation.TempFolderPath = temporaryAwsPath;
        IronPdf.Installation.CustomDeploymentDirectory = temporaryAwsPath;

        // Automatically configure Linux and Docker dependencies
        IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;

        context.Logger.LogLine($"initializing IronPdf.ChromePdfRenderer");
        var renderer = new IronPdf.ChromePdfRenderer();

        context.Logger.LogLine($"generating PDF");
        using var pdfDoc = renderer.RenderUrlAsPdf("https://ironpdf.com/");

        var uniqueId = Guid.NewGuid();
        var filePath = $"/tmp/{input}_{uniqueId}.pdf"; // path to save the file

        context.Logger.LogLine($"writing PDF to: {filePath}");
        pdfDoc.SaveAs(filePath);

        //Optional step to upload the PDF file to a service like Amazon S3

        context.Logger.LogLine($"PROCESS COMPLETED SUCCESSFULLY!");
    }
    catch (Exception e)
    {
        context.Logger.LogLine($"[ERROR] In FunctionHandler: {e.Message}");
    }

    return new Casing(input?.ToLower(), input?.ToUpper());
}
```

## 5. Enhance Memory and Timeout Settings

Given that IronPDF might require more time and memory than the default AWS Lambda settings, configure them in `aws-lambda-tools-defaults.json` as per your requirements. In this context, we recommend setting it to 512 MB and 330 seconds.

```json
"function-memory-size" : 512, 
"function-timeout"     : 330,
```

Adjust these settings directly via the Lambda management console, referring to the detailed guide here: [Configuring AWS Lambda functions](https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console).

## 6. Deployment

To deploy your function, follow the latter section of the '[.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/)' documentation.

## 7. Test Your Solution

Activate and test your Lambda function either using the [Lambda console](https://console.aws.amazon.com/lambda) or through the [AWS Toolkit for Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/lambda-creating-project-in-visual-studio.html).