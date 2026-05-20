# Implementing IronPDF in AWS Lambda for PDF Generation

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***


## 1. Set Up AWS Lambda with .NET 5 Container Image

For guidance on setting up a .NET 5 container image with AWS Lambda, refer to AWS's official documentation: [.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/).

## 2. Dependency Installation

To enable Chrome functionality in the AWS environment, follow these steps to modify the Dockerfile:

### Using .NET 5 in AWS Lambda

<script src="https://gist.github.com/ironsoftwarebuild/7f2265f7751240398fb532bd318fc90c.js"></script>

```dockerfile
# Base Image -- .NET 5

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

FROM public.ecr.aws/lambda/dotnet:5.0

# Transfer application code

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

COPY "bin/Release/net5.0/linux-x64/publish" /var/task

# Installing necessary Chrome dependencies

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

RUN yum install -y atk cups-libs libXcomposite libXcursor libXdamage libXext \
    libXi libXtst pango alsa-lib at-spi2-atk gtk3 libdrm libgbm
```

### Using .NET 7 in AWS Lambda

<script src="https://gist.github.com/ironsoftwarebuild/ea399e109586f3ac29ebd43d1d0f6285.js"></script>

```dockerfile
# Base Image -- .NET 7

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

FROM public.ecr.aws/lambda/dotnet:7.0

# Transfer application code

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

COPY "bin/Release/net7.0/linux-x64/publish" /var/task

# Installing necessary Chrome dependencies

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

RUN yum install -y atk cups-libs libXcomposite libXcursor libXdamage libXext \
    libXi libXtst pango alsa-lib at-spi2-atk gtk3 libdrm libgbm
```

### Using .NET 8 in AWS Lambda

<script src="https://gist.github.com/ironsoftwarebuild/b700ca3ee47f405c257e72b2f8a33d52.js"></script>

```dockerfile
# Base Image -- .NET 8

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

FROM public.ecr.aws/lambda/dotnet:8.0

# Transfer application code

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

COPY "bin/Release/net8.0/linux-x64/publish" /var/task

# Installing necessary Chrome dependencies

***Based on <https://ironpdf.com/how-to/__unlisted__creating-pdfs-csharp-amazon-aws-lambda__/>***

RUN yum install -y atk cups-libs libXcomposite libXcursor libXdamage libXext \
    libXi libXtst pango alsa-lib at-spi2-atk gtk3 libdrm libgbm
```

## 3. Installing IronPDF NuGet Package on Linux

Install the `IronPdf.Linux` package:

1. Right-click References in the Solution Explorer and navigate to Manage NuGet Packages.
2. Use the Browse tab to search for `IronPdf.Linux`.
3. Select and install the package.

## 4. Update FunctionHandler Code

The subsequent example demonstrates the creation of a PDF from the IronPDF website using AWS Lambda and storing it locally in `/tmp`. You may need to transfer the PDF to another location, such as AWS S3, post-creation.

```csharp
using System;
using Amazon.Lambda.Core;
using IronPdf;

public class PdfCreator
{
    // Entry point for the Lambda function
    public Casing FunctionHandler(string input, ILambdaContext context)
    {
        var tempPath = @"/tmp/"; // AWS temp directory
        var pdfRenderer = new ChromePdfRenderer
        {
            TempDirectory = tempPath,
            LoggingMode = IronPdf.Logging.Logger.LoggingModes.None
        }; 
        
        try
        {
            context.Logger.LogLine($"Beginning PDF generation for input: {input}");
            var pdf = pdfRenderer.RenderUrlAsPdf("https://ironpdf.com/");
            var outputPath = $"{tempPath}{input}_{Guid.NewGuid()}.pdf";
            
            pdf.SaveAs(outputPath);
            context.Logger.LogLine($"PDF stored at: {outputPath}");
        }
        catch (Exception ex)
        {
            context.Logger.LogLine($"Error occurred: {ex.Message}");
        }

        return new Casing(input.ToLower(), input.ToUpper());
    }
}
```

## 5. Enhance Memory and Timeout Settings

Adjust `aws-lambda-tools-defaults.json` to better accommodate IronPDF's requirements. Example settings might be 512 MB for memory and 330 seconds for timeout.

```json
{
    "function-memory-size": 512,
    "function-timeout": 330
}
```

For further details on Lambda memory settings, consult the [AWS Lambda Memory Configuration Guide](https://docs.aws.amazon.com/lambda/latest/dg/configuration-function-common.html#configuration-memory-console).

## 6. Deploying Your Function

Follow the guidelines in the later sections of the '[.NET 5 AWS Lambda Support with Container Images](https://aws.amazon.com/blogs/developer/net-5-aws-lambda-support-with-container-images/)' for deploying and verifying your Lambda function.

## 7. Testing Your Implementation

You can initiate your Lambda function through the [AWS Lambda Console](https://console.aws.amazon.com/lambda) or from within Visual Studio using the [AWS Toolkit for Visual Studio](https://docs.aws.amazon.com/toolkit-for-visual-studio/latest/user-guide/lambda-creating-project-in-visual-studio.html).