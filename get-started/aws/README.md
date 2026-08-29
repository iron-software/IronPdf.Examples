# Executing & Deploying IronPDF .NET on AWS Lambda

> Full guide: [Executing & Deploying IronPDF .NET on AWS Lambda](https://ironpdf.com/get-started/aws/)


<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/amazon-web-services--v1.png">
        </div>
    </div>
</div>

## Step 1: Setting up AWS Lambda with a .NET 5 Container

For a detailed guide on this setup, please consult the first section of the official AWS documentation here: [.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/).

## Step 2: Include Necessary Dependencies

These specific dependencies are needed for running Chrome under this AWS configuration.

Update your Docker file as per the following specifics:

### Using .NET 5 with AWS Lambda

<script src="https://gist.github.com/ironsoftwarebuild/7f2265f7751240398fb532bd318fc90c.js"></script>

### Using .NET 7 with AWS Lambda

<script src="https://gist.github.com/ironsoftwarebuild/ea399e109586f3ac29ebd43d1d0f6285.js"></script>

### Using .NET 8 with AWS Lambda

<script src="https://gist.github.com/ironsoftwarebuild/b700ca3ee47f405c257e72b2f8a33d52.js"></script>

## Step 3: Install IronPDF (Linux) Package

To include `IronPdf.Linux` in your solution:

1. Right-click on References and choose Manage NuGet Packages in the Solution Explorer.
2. Browse and search for `IronPdf.Linux`.
3. Select the package and proceed to install.

## Step 4: Update the FunctionHandler Code

The following code sample will generate a PDF from the webpage at <https://ironpdf.com/> and save it locally to `/tmp`. To access the PDF, consider uploading it to a service such as AWS S3.

Configuring the temporary folder is crucial when using IronPDF on AWS Lambda. Employ the **TempFolderPath** and **CustomDeploymentDirectory** for adjustments.

```csharp
public Casing FunctionHandler(string input, ILambdaContext context)
{
    try
    {
        context.Logger.LogLine($"START FunctionHandler RequestId: {context.AwsRequestId} Input: {input}");

        var temporaryDirectory = @"/tmp/"; // Location of AWS temporary storage

        // Setting IronPDF license key
        IronPdf.License.LicenseKey = "YOUR_LICENSE_KEY";

        // Adjust settings for Chrome rendering in a headless environment
        IronPdf.Installation.ChromeGpuMode = IronPdf.Engines.Chrome.ChromeGpuModes.Disabled;

        // Set up temporary and deployment directories for IronPDF
        IronPdf.Installation.TempFolderPath = temporaryDirectory;
        IronPdf.Installation.CustomDeploymentDirectory = temporaryDirectory;

        // Configure dependencies for Linux and Docker environments automatically
        IronPdf.Installation.LinuxAndDockerDependenciesAutoConfig = true;

        context.Logger.LogLine($"Instance of IronPdf.ChromePdfRenderer initiated");
        var pdfRenderer = new IronPdf.ChromePdfRenderer();

        context.Logger.LogLine($"Begin PDF rendering process");
        using var pdfDocument = pdfRenderer.RenderUrlAsPdf("https://ironpdf.com/");

        var documentId = Guid.NewGuid();
        var pdfFilename = $"{temporaryDirectory}{input}_{documentId}.pdf"; // Designate file storage path at /tmp

        context.Logger.LogLine($"PDF storage at: {pdfFilename}");
        pdfDocument.SaveAs(pdfFilename);

        // Optional: code to upload the PDF to a cloud service like AWS S3.

        context.Logger.LogLine($"Process Complete!");
    }
    catch (Exception e)
    {
        context.Logger.LogLine($"[ERROR] FunctionHandler: {e.Message}");
    }

    return new Casing(input?.ToLower(), input?.ToUpper());
}
```

## Step 5: Optimize Memory and Execution Time

IronPDF operations may demand more resources than the AWS Lambda default allowances. Adjust these settings in the `aws-lambda-tools-defaults.json` file as shown below. For instance, set memory to 512 MB and timeout to 330 seconds.

```json
{
    "function-memory-size": 512,
    "function-timeout": 330
}
```

You can also adjust these directly via the Lambda console as detailed in the [Configuring AWS Lambda functions](https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console) guide.

## Step 6: Deploy and Test

Please adhere to the latter sections of the '[.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/)' documentation for deploying and testing your function.

## Step 7: Activation

You can trigger the Lambda function via the [Lambda console](https://console.aws.amazon.com/lambda) or through Visual Studio by employing the [AWS Toolkit for Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/lambda-creating-project-in-visual-studio.html).