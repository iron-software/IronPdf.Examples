# Generate PDFs with IronPDF on AWS Lambda

## 1. Set Up AWS Lambda with a .NET 5 Container

For setup instructions, refer to this section in AWS’s official guide: [NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/).

## 2. Configure Package Dependencies

To ensure Chrome's compatibility in the AWS environment, update your Docker file as suggested here:

<script src="https://gist.github.com/ironsoftwarebuild/7f2265f7751240398fb532bd318fc90c.js"></script>

## 3. Install IronPDF (Linux) NuGet Package

To install `IronPdf.Linux`:

1. Right-click 'References' in the Solution Explorer, and select 'Manage NuGet Packages'.
2. Go to the Browse tab, search for `IronPdf.Linux`.
3. Choose the package and click on 'Install'.

## 4. Update FunctionHandler Code

Below is a code snippet to generate a PDF from a webpage (like [IronPDF](https://ironpdf.com/)) and store it temporarily locally. To preserve the output, upload it to a service such as Amazon S3.

```csharp
public Casing FunctionHandler(string input, ILambdaContext context)
{
    context.Logger.LogLine($"Initializing FunctionHandler RequestId: {context.AwsRequestId}, Input: {input}");

    //[optional] Uncomment below lines for debugging issues
    //IronPdf.Logging.Logger.EnableDebugging = true;
    //IronPdf.Logging.Logger.LogFilePath = "/tmp/";
    //IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

    string awsTmpPath = "/tmp/"; // Temporary storage path on AWS

    // Configure IronPDF settings
    IronPdf.License.LicenseKey = "YOUR_LICENSE_KEY";
    IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;
    IronPdf.Installation.TempFolderPath = awsTmpPath;
    IronPdf.Installation.CustomDeploymentDirectory = awsTmpPath;
    IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;

    context.Logger.LogLine("Creating PDF renderer");
    var renderer = new IronPdf.ChromePdfRenderer();

    context.Logger.LogLine("Generating PDF");
    using var pdfDoc = renderer.RenderUrlAsPdf("https://ironpdf.com/");
    var guid = Guid.NewGuid();
    var fileName = $"{awsTmpPath}/{input}_{guid}.pdf"; // File name for the PDF

    context.Logger.LogLine($"Saving PDF with name: {fileName}");
    pdfDoc.SaveAs(fileName);

    context.Logger.LogLine("PDF generated and saved successfully!");

    return new Casing(input?.ToLower(), input?.ToUpper());
}
public record Casing(string Lower, string Upper);
```

## 5. Enhance Memory and Timeout Settings

Increase the default memory and timeout settings for Lambda, crucial for IronPDF operations, as outlined below or through the AWS Lambda management console:

```csharp
"function-memory-size" : 512, 
"function-timeout"     : 330,
```

Refer to AWS's guide for more details: [Configuring Lambda Functions](https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console).

## 6. Deployment

Follow the steps in the second part of the AWS guide on [.NET 5 Lambda with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/) to publish and validate your function.

## 7. Testing Your Function

Activate and test your function via the [AWS Lambda Console](https://console.aws.amazon.com/lambda) or through Visual Studio using the [AWS Toolkit for Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/lambda-creating-project-in-visual-studio.html).