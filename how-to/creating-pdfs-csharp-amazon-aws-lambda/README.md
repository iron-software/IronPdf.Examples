# Leveraging IronPDF to Generate PDFs on AWS Lambda

***Based on <https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/>***


## 1. Setting Up AWS Lambda with a .NET 5 Container

We recommend checking out the initial segment of this [official AWS documentation](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/) which details how to use .NET 5 with AWS Lambda in container images.

## 2. Incorporating Package Dependencies

For Chrome compatibility in the AWS environment, the following modifications to your Docker file are necessary:

### For .NET 5 in AWS Lambda

```html
<script src="https://gist.github.com/ironsoftwarebuild/7f2265f7751240398fb532bd318fc90c.js"></script>
```

### For .NET 7 in AWS Lambda

```html
<script src="https://gist.github.com/ironsoftwarebuild/ea399e109586f3ac29ebd43d1d0f6285.js"></script>
```

### For .NET 8 in AWS Lambda

```html
<script src="https://gist.github.com/ironsoftwarebuild/b700ca3ee47f405c257e72b2f8a33d52.js"></script>
```

## 3. Installing IronPDF (Linux) NuGet Package

To integrate `IronPdf.Linux`:

1. Right-click on References in the Solution Explorer, navigate to Manage NuGet Packages.
2. Click on Browse and type `IronPdf.Linux` in the search bar.
3. Select and install the package.

## 4. Adjusting the FunctionHandler Code

In this example, we create a PDF from the [IronPDF website](https://ironpdf.com/) and store it in the `/tmp` directory. To view this PDF, you must transfer it to a service like S3.

Here’s an essential configuration for the temporary folder when utilizing IronPDF on AWS Lambda: use **TempFolderPath** and **CustomDeploymentDirectory** properties.

```csharp
public Casing FunctionHandler(string input, ILambdaContext context)
{
    try
    {
        context.Logger.LogLine($"START FunctionHandler RequestId: {context.AwsRequestId} Input: {input}");

        var awsTemporaryStorage = @"/tmp/";

        // Uncomment the following lines to enable logging if troubleshooting is required
        // IronPdf.Logging.Logger.EnableDebugging = true;
        // IronPdf.Logging.Logger.LogFilePath = awsTemporaryStorage;
        // IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

        // Set your license key
        IronPdf.License.LicenseKey = "YOUR_LICENSE_KEY";

        // Disable Chrome GPU as AWS Lambda doesn't support GPU
        IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;

        // Configure IronPDF temporary path and deployment directories
        IronPdf.Installation.TempFolderPath = awsTemporaryStorage;
        IronPdf.Installation.CustomDeploymentDirectory = awsTemporaryStorage;

        // Automate Linux and Docker dependencies configuration
        IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;

        context.Logger.LogLine($"initializing IronPdf.ChromePdfRenderer");
        var renderer = new IronPdf.ChromePdfRenderer();

        context.Logger.LogLine($"generating PDF");
        using var pdfDoc = renderer.RenderUrlAsPdf("https://ironpdf.com/");

        var fileGuid = Guid.NewGuid();
        var pdfFilePath = $"/tmp/{input}_{fileGuid}.pdf"; // Store file in /tmp

        context.Logger.LogLine($"file saved: {pdfFilePath}");
        pdfDoc.SaveAs(pdfFilePath);

        // Option to upload the PDF to a cloud service such as AWS S3

        context.Logger.LogLine($"COMPLETE!");
    }
    catch (Exception e)
    {
        context.Logger.LogLine($"[ERROR] FunctionHandler: {e.Message}");
    }

    return new Casing(input?.ToLower(), input?.ToUpper());
}
```

## 5. Configuring Lambda for Enhanced Performance

IronPDF may require more resources than what Lambda provides by default. Specify higher values in `aws-lambda-tools-defaults.json` such as 512 MB for memory and 330 seconds for timeout:

```csharp
"function-memory-size": 512,
"function-timeout": 330,
```

Further configuration can be adjusted via the Lambda console as detailed in the [AWS Lambda Memory Configuration Guide](https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console).

## 6. Deploying the Function

Follow the steps found in the latter part of the ['NET 5 AWS Lambda Support with Container Images'](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/) guide to deploy and evaluate your Lambda function.

## 7. Testing Your Implementation

Activate your Lambda function either through the [AWS Lambda Console](https://console.aws.amazon.com/lambda) or within Visual Studio by using the [AWS Toolkit for Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/lambda-creating-project-in-visual-studio.html). Start exploring the capabilities of your newly configured service.