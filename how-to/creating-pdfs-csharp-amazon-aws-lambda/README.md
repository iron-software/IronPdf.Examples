# Implementing PDF Generation in AWS Lambda with IronPDF

***Based on <https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/>***


## 1. Setting Up AWS Lambda Using a .NET 5 Container

For initial setup instructions, please consult the AWS guide on integrating [.NET 5 with Lambda via Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/).

## 2. Incorporating Required Packages

To accommodate Chrome's requirements in AWS, adjust your Docker file as per the following configurations:

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

## 3. Adding IronPDF (Linux) NuGet Package

Here’s how to include the `IronPdf.Linux` package:

1. Right-click References in Solution Explorer, then choose Manage NuGet Packages.
2. Use Browse to locate and add the `IronPdf.Linux` package.
3. Confirm and execute the installation.

## 4. Customizing the FunctionHandler Code

Below is how to adapt your Lambda function to generate and store a PDF from the [IronPDF homepage](https://ironpdf.com/) in the `/tmp` directory. Remember to subsequently transfer this PDF to a service like Amazon S3 for storage and retrieval.

```csharp
public Casing FunctionHandler(string input, ILambdaContext context)
{
    try
    {
        context.Logger.LogLine($"START FunctionHandler RequestId: {context.AwsRequestId} Input: {input}");

        var awsTmpPath = @"/tmp/"; // path for temporary storage in AWS

        //Uncomment below for detailed troubleshooting logs
        //IronPdf.Logging.Logger.EnableDebugging = true;
        //IronPdf.Logging.Logger.LogFilePath = awsTmpPath;
        //IronPdf.Logging.Logger.LoggingMode = IronPdf.Logging.Logger.LoggingModes.All;

        //apply your license key here
        IronPdf.License.LicenseKey = "YOUR_LICENSE_KEY";

        //disable Chrome GPU usage
        IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;

        //configure IronPDF to use custom temporary paths
        IronPdf.Installation.TempFolderPath = awsTmpPath;
        IronPdf.Installation.CustomDeploymentDirectory = awsTmpPath;

        //automatically configure Linux and Docker dependencies
        IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;

        context.Logger.LogLine($"Initialized IronPdf.ChromePdfRenderer");
        var Renderer = new IronPdf.ChromePdfRenderer();

        context.Logger.LogLine($"Start rendering PDF");
        using var pdfDoc = Renderer.RenderUrlAsPdf("https://ironpdf.com/");

        var guid = Guid.NewGuid();
        var fileName = $"/tmp/{input}_{guid}.pdf"; // Naming and saving the file

        context.Logger.LogLine($"File saved as: {fileName}");
        pdfDoc.SaveAs(fileName);

        context.Logger.LogLine($"Operation complete. Upload the PDF as needed.");

    }
    catch (Exception e)
    {
        context.Logger.LogLine($"[ERROR] during PDF creation: {e.Message}");
    }

    return new Casing(input?.ToLower(), input?.ToUpper());
}
```

## 5. Allocate More Resources

Given IronPDF’s resource demands, adjust the Lambda settings in `aws-lambda-tools-defaults.json` to provide adequate memory and time.

```json
"function-memory-size" : 512,
"function-timeout"     : 330,
```

For more details on adjusting these settings in the AWS console, see the [AWS Lambda Memory Configuration Guide](https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console).

## 6. Deployment

Refer to the latter sections of the [.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/) documentation to deploy and test your function.

## 7. Testing the Functionality

Activate and test your Lambda function from the [AWS Lambda Console](https://console.aws.amazon.com/lambda) or through the [AWS Toolkit for Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/lambda-creating-project-in-visual-studio.html).