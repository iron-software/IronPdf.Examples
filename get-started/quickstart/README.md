***Based on <https://ironpdf.com/get-started/quickstart/>***

<style>
    .main-article {
        h2 {
            margin-bottom: 16px;
        }

```css
/* Adjusts the vertical space below platform-specific guidelines */
#anchor-platform-specific-guides {
    margin-bottom: 24px;
}

/* Sets paragraph styling for plain text elements */
p {
    font: normal 400 16px/1.8 "Gotham-Book";
    color: #181818;
}

/* List item styles in unordered and ordered lists excluding breadcrumbs and line numbers */
ol:not(.linenums):not(.breadcrumb), ul:not(.linenums):not(.breadcrumb) {
    li {
        font: normal 400 16px/1.8 "Gotham-Book";
    }
}

/* Styling for links that relate to other topics */
.related-link {
    strong {
        font: normal 700 16px/1.8 "Gotham-Bold";
    }

    a {
        font: normal 700 14px/1.4 "Gotham-Bold";
        color: #2A95D5;
        transition: all 0.2s ease;
        
        i {
            font-size: 12px;
        }

        &:has(i):hover {
            color: #E01A59;
            
            i {
                transform: translateX(4px);
            }
        }
    }
}

/* Standard styling for horizontal rule to create separation */
hr {
    height: 1px;
    background-color: #E7EEF0;
    color: #E7EEF0;
    margin-top: 40px;
    margin-bottom: 40px;
    border: none;
    opacity: 1;
}

/* Specific styles for content block including a call-to-action */
.code-content-with-cta {
    margin-top: 24px;

    h2 {
        display: none;
    }

    ol:not(.linenums):not(.breadcrumb) {
        list-style-type: none;

        li:not(:last-child) {
            display: none;
        }

        h3 {
            display: none;
        }

        .code-content-with-cta__cta-text {
            font: normal 400 15px/1.8 "Gotham-Book";
            color: #181818;
        }

        li:last-child {
            margin-top: 0;

            div {
                column-gap: 12px !important;
            }
        }
    }
}

/* Heading styles particular to anchor targets */
h2[id^="anchor-"], h3[id^="anchor-"] {
    font-weight: bold;
    color: #181818;
    padding-top: 0;
    font-size: 20px/18px;
    font-family: "Gotham-Black", "Gotham-Bold";
    line-height: 1.4/1.6;
}

/* Enclosure for troubleshooting tips */
.quick-troubleshooting {
    border-radius: 8px;
    overflow: clip;
    border: 1px solid #D9E5E9;
    margin-top: 24px;
}

/* Styles for tables that display categorized entries */
.classic-table {
    border-collapse: collapse;
    border: none;

    thead {
        tr {
            background-color: #FAFAFB;

            th {
                padding: 12px;
                text-align: start;
                border: 1px solid #D9E5E9;
                font: normal 700 14px/1.4 "Gotham-Bold";

                span {
                    font: normal 700 14px/1.4 "Gotham-Bold";
                    color: #181818;
                }
            }
        }
    }

    tbody {
        tr {
            td {
                padding: 16px 12px;
                border: 1px solid #D9E5E9;
                font: normal 400 16px/1.4 "Gotham-Book";
                color: #181818;

                &:first-child {
                    text-align: start;
                    font: normal 500 16px/1.4 "Gotham-Medium";
                    color: #181818;
                }

                span, ul {
                    font: normal 400 14px/1.4 "Gotham-Book";
                    color: #181818;
                }

                a {
                    font: normal 700 14px/1.4 "Gotham-Bold";
                    color: #2A95D5;
                    text-decoration-line: underline;
                }
            }
        }
    }
}

/* Sectionalized installation modes and corresponding designations */
.install-modes {
    margin-top: 35px;

    .install-mode {
        --border-color: #D9E5E9;
        --header-background: #FAFAFB;
        border: 2px solid var(--border-color);
        border-radius: 8px;
        background-color: #FFF;

        &.install-mode--recommended {
            --border-color: #63C1A0;
            --header-background: #F0FFFA;

            .install-mode__header {
                position: relative;

                .recommended-float {
                    position: absolute;
                    right: 0;
                    top: -45px;  
                }
            }
        }

        .install-mode__header {
            padding: 12px;
            background-color: var(--header-background);
            display: flex;
            flex-direction: column;
            row-gap: 4px;
            border-bottom: 1px solid var(--border-color);
            border-top-left-radius: 8px;
            border-top-right-radius: 8px;

            .install-mode__title {
                font: normal 700 16px/1.6 "Gotham-Bold";
                color: #181818;
                text-align: center;
            }

            .install-mode__subtitle {
                font: normal 400 14px/1.4 "Gotham-Book";
                color: #181818;
                text-align: center;
            }
        }

        .install-mode__body {
            padding: 16px 12px;

            ul {
                font: normal 400 14px/1.8 "Gotham-Book";
                color: #181818;
                padding-left: 1rem;
            }
        }
    }
}

/* Configuration for deployment scenarios and visual hover effects */
.deployment-scenarios {
    margin-top: 16px;

    .deployment-card {
        padding: 12px 16px;
        display: flex;
        align-items: center;
        column-gap: 12px;
        border-radius: 8px;
        border: 1px solid #E7EEF0;
        background-color: #FFF;
        cursor: pointer;
        transition: all 0.2s ease;

        &:hover {
            transform: translateY(-2px);
        }

        .deployment-card__icon {
            display: flex;
            align-items: center;
            justify-content: center;
        }

        .deployment-card__info {
            .deployment-card__title {
                font: normal 500 14px/1.6 "Gotham-Medium";
                color: #181818;
                margin-top: 0;
                margin-bottom: -2.4px;
            }

            .deployment-card__link {
                font: normal 700 14px/1.6 "Gotham-Bold";
                color: #2A95D5;

                i {
                    font-size: 12px;
                }
            }
        }
    }
}
```

</style>

# IronPDF Quickstart Guide

Get started with IronPDF and generate your first PDF within a mere five minutes. Utilizing IronPDF's straightforward API, you can effortlessly convert HTML, DOCX, images, and other formats into flawless PDF files. Here's how to start: 

## 1. Prerequisites

You will need:

- .NET Framework 4.6.2 or newer, or .NET Core 3.1 or higher, or .NET 5+
- [Visual C++ Redistributable](https://docs.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist) for Windows environments.

---

## 2. Installing IronPDF

IronPDF offers a standard local installation. For deployment within Docker or microservices environments, refer to the [Remote Engine Mode Guide](https://ironsoftware.com/csharp/pdf/docs/questions/remote-engine-mode/).

```csharp
:title=Start Creating PDFs Immediately!
// Initialize the PDF renderer
IronPdf.ChromePdfRenderer
       .StaticRenderHtmlAsPdf("<p>Hello World</p>")
       .SaveAs("pixelperfect.pdf");
```

### Installation Options
Navigate through the tabs to explore different installation methods:

<div class="installation-options__container" data-active-tab="1">
    <div class="installation-options__tabs">
        <div class="installation-options__tab" data-tab="1"><span>NuGet Package Manager</span></div>
        <div class="installation-options__tab" data-tab="2"><span>DLL Download</span></div>
    </div>
    <div class="installation-options__info" data-tab="1"></div>
    <div class="installation-options__info" data-tab="2"></div>
</div>

### Using NuGet Package Manager
Navigate to the [IronPDF NuGet Library](https://www.nuget.org/packages/IronPdf)

1. In Solution Explorer, right-click on References.
2. Choose 'Manage NuGet Packages' > 'Browse' and search for IronPdf.

```shell
Install-Package IronPdf
```

### Manual DLL Installation
- Download the [IronPDF DLL Package](https://ironsoftware.com/csharp/pdf/packages/IronPdf.zip).
- Unzip to a preferred location within your Solution directory.
- In Visual Studio Solution Explorer, right-click on 'Dependencies'.
- Choose 'Add Project Reference' > Select 'Browse' to include the DLLs from the unzipped file.

### Platform-Specific Guides
Find detailed installation instructions for different operating systems and environments by following the links below:

<div class="row platform-guides">
    <div class="col-2">
        <a href="https://ironsoftware.com/csharp/pdf/packages/IronPdf.zip" class="platform-guide">
            <div class="platform-guide__icon"><img src="https://ironsoftware.com/csharp/pdf/static-assets/svgs/logo-windows.svg" width="64" height="64" /></div>
            <span class="platform-guide__title">Windows</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironsoftware.com/csharp/pdf/packages/IronPdf.Linux.zip" class="platform-guide">
            <div class="platform-guide__icon"><img src="https://ironsoftware.com/csharp/pdf/static-assets/svgs/logo-linux.svg" width="64" height="64" /></div>
            <span class="platform-guide__title">Linux</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironsoftware.com/csharp/pdf/packages/IronPdf.MacOs.zip" class="platform-guide">
            <div class="platform-guide__icon"><img src="https://ironsoftware.com/csharp/pdf/static-assets/svgs/logo-mac.svg" width="64" height="64" /></div>
            <span class="platform-guide__title">MacOS</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironsoftware.com/csharp/pdf/how-to/docker-linux/" class="platform-guide">
            <div class="platform-guide__icon"><img src="https://ironsoftware.com/csharp/pdf/static-assets/svgs/logo-docker.svg" width="64" height="64" /></div>
            <span class="platform-guide__title">Docker</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironsoftware.com/csharp/pdf/how-to/azure/" class="platform-guide">
            <div class="platform-guide__icon"><img src="https://ironsoftware.com/csharp/pdf/static-assets/svgs/logo-azure.svg" width="64" height="64" /></div>
            <span class="platform-guide__title">Azure</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironsoftware.com/csharp/pdf/how-to/creating-pdfs-csharp-amazon-aws-lambda/" class="platform-guide">
            <div class="platform-guide__icon"><img src="https://ironsoftware.com/csharp/pdf/static-assets/svgs/logo-aws.svg" width="64" height="64" /></div>
            <span class="platform-guide__title">AWS</span>
        </a>
    </div>
</div>

---

## 3. Applying Your License Key

Upon purchasing [IronPDF licenses](https://ironsoftware.com/csharp/pdf/licensing/) or starting a 30-day trial, you'll receive a license key via email. Make sure to insert this key at the beginning of your application:

```csharp
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

Explore further details on IronPDF licensing [here](https://ironsoftware.com/csharp/pdf/licensing/).

---

Continue following the guide to see how you can create your very first PDF, exploring options like blank PDF creation, converting HTML to PDF, and more!

<p style="margin-bottom: 40px;">Install IronPDF and create your first PDF in just five minutes. With its simple API, you can convert HTML, DOCX, images, and more into pixel-perfect PDFs.</p>

## 1. Requirements

- Requires .NET Framework version 4.6.2 or higher, .NET Core 3.1 or higher, or .NET 5 or higher
- [Visual C++ Redistributable](https://docs.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist) is necessary for Windows installations.

<hr>

## 2. Install IronPDF

IronPDF can be installed locally with ease. For deployments using Docker or microservices, refer to the [Remote Engine Mode Guide](https://ironpdf.com/get-started/ironpdfengine/).

Here’s a revised version of the code snippet, with updated code comments and a slightly modified approach:

```cs
:title=Begin creating PDFs instantly!
// Initialize a ChromePDFRenderer to render HTML as PDF
var pdfRenderer = new IronPdf.ChromePdfRenderer();

// Convert simple HTML string to a PDF document
pdfRenderer.StaticRenderHtmlAsPdf("<p>Hello World</p>")
           // Save the generated PDF to a file
           .SaveAs("PerfectPixel.pdf");
```

<div class="installation-options__container" data-active-tab="1">
    <div class="installation-options__tabs">
        <div class="installation-options__tab" data-tab="1">
            <span>NuGet Package Manager</span>
        </div>
        <div class="installation-options__tab" data-tab="2">
            <span>DLL Download</span>
        </div>
    </div>
    <div class="installation-options__info" data-tab="1"></div>
    <div class="installation-options__info" data-tab="2"></div>
</div>

<div id="nuget-package-manager-start"></div>
Go to the [IronPDF NuGet library:](https://www.nuget.org/packages/IronPdf)

Here's the paraphrased section of the article, with updated URL paths:

-----
1. Navigate to the Solution Explorer, then perform a right-click on "References".
 
2. Choose 'Manage NuGet Packages', click on 'Browse', and then search for "IronPdf".

Here's the paraphrased section of the article, with the relative URL path resolved:

```shell
dotnet add package IronPdf
```

<div id="nuget-package-manager-end"></div>

<div id="dll-download-start"></div>
- Download [IronPDF DLL package](/packages/IronPdf.zip)
- Unzip the ZIP file for your OS to a location within your Solution directory
- In Visual Studio Solution Explorer, right-click on 'Dependencies'
- 'Add Project Reference' > Select 'Browse' to include all the DLLs extracted from the zip.

<p class="related-link"><strong>RELATED:</strong> <a href="/get-started/advanced-installation-nuget/">More on configuration settings <i class="fa-solid fa-arrow-right"></i></a></p>
<div id="dll-download-end"></div>

### Guides for Specific Platforms

Explore tailored installation guides for various platforms, ensuring optimal setup and integration of IronPDF in your preferred environment.

```html
<style>
    .platform-guides {
        .platform-guide {
            padding: 12px 16px;
            border: 1px solid #D9E5E9;
            background-color: #FFF;
            border-radius: 8px;
            display: flex;
            align-items: center;
            flex-direction: column;
            row-gap: 4px;
            transition: all 0.2s ease;

            &:hover {
                box-shadow: 0 4px 12px 0 rgba(24, 24, 24, 0.08);
            }

            .platform-guide__icon {
                display: flex;
                align-items: center;
                justify-content: center;
            }

            .platform-guide__title {
                font: normal 500 12px/1.35 "Gotham-Medium";
                color: #181818;
            }
        }
    }
</style>

<div class="row platform-guides">
    <div class="col-2">
        <a href="https://ironpdf.com/packages/IronPdf.zip" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-windows.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">Windows</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironpdf.com/packages/IronPdf.Linux.zip" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-linux.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">Linux</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironpdf.com/packages/IronPdf.MacOs.zip" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-mac.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">MacOS</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironpdf.com/how-to/docker-linux/" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-docker.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">Docker</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironpdf.com/how-to/azure/" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-azure.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">Azure</span>
        </a>
    </div>
    <div class="col-2">
        <a href="https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="https://ironpdf.com/static-assets/svgs/logo-aws.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">AWS</span>
        </a>
    </div>
</div>
```
This section provides an easy gateway to gather all necessary resources for setting up IronPDF on different platforms including Windows, Linux, MacOS, Docker, Azure, and AWS. Each link directs you to a downloadable package specific to each platform, complete with installation instructions and essential files.

<style>
    .platform-guides {
        .platform-guide {
            padding: 12px 16px;
            border: 1px solid #D9E5E9;
            background-color: #FFF;
            border-radius: 8px;
            display: flex;
            align-items: center;
            flex-direction: column;
            row-gap: 4px;
            transition: all 0.2s ease;

```css
&:hover {
    box-shadow: 0 4px 12px 0 rgba(24, 24, 24, 0.1); /* Slightly altering the opacity for subtle difference */
}

.platform-guide__icon {
    display: flex;
    align-items: center; /* Ensures content is centered vertically */
    justify-content: center; /* Ensures content is centered horizontally */
}

.platform-guide__title {
    font: normal 500 12px/1.35 "Gotham-Medium"; /* Medium weight font */
    color: #181818; /* Dark gray color for readability */
}
```

</style>

<div class="row platform-guides">
    <div class="col-2">
        <a href="/packages/IronPdf.zip" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="/static-assets/svgs/logo-windows.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">Windows</span>
        </a>
    </div>
    <div class="col-2">
        <a href="/packages/IronPdf.Linux.zip" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="/static-assets/svgs/logo-linux.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">Linux</span>
        </a>
    </div>
    <div class="col-2">
        <a href="/packages/IronPdf.MacOs.zip" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="/static-assets/svgs/logo-mac.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">MacOS</span>
        </a>
    </div>
    <div class="col-2">
        <a href="/how-to/docker-linux/" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="/static-assets/svgs/logo-docker.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">Docker</span>
        </a>
    </div>
    <div class="col-2">
        <a href="/how-to/azure/" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="/static-assets/svgs/logo-azure.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">Azure</span>
        </a>
    </div>
    <div class="col-2">
        <a href="/how-to/creating-pdfs-csharp-amazon-aws-lambda/" class="platform-guide">
            <div class="platform-guide__icon">
                <img src="/static-assets/svgs/logo-aws.svg" alt="" width="64" height="64" />
            </div>
            <span class="platform-guide__title">AWS</span>
        </a>
    </div>
</div>

<hr>

## 3. Implementing Your License Key

Upon acquiring an [IronPDF license](https://ironpdf.com/licensing/) or initiating a 30-day trial, you will receive a license key via email. Ensure you insert this key at the beginning of your application to activate your license.

```csharp
// Set your IronPDF license key for activation
IronPdf.License.LicenseKey = "YOUR-IRONPDF-LICENSE-KEY";
```

<p class="related-link"><a href="/licensing/">View IronPDF Licensing <i class="fa-solid fa-arrow-right"></i></a></p>

<hr>

## 4. Initial PDF Creation

Explore how IronPDF empowers you to generate PDFs or convert various formats like HTML, DOCX, RTF, Markdown, and images into fully-fidelity PDF documents. [Learn about additional PDF conversion options here](https://ironpdf.com/licensing/).

Begin by adding the following at the top of your `.cs` file:

```csharp
using IronPdf;
```

Within the panel for PDF creation options, you have several methods to initiate your first PDF document:

### Create a Blank PDF

Start by defining a new `PdfDocument` object with specified dimensions, which instantly prepares a blank PDF ready to be customized to your needs.

```csharp
using IronPdf;

PdfDocument pdf = new PdfDocument(270, 270);
pdf.SaveAs("blankPage.pdf");
```

### Convert HTML String to PDF

Utilize the `ChromePdfRenderer.RenderHtmlAsPdf` function to convert HTML content into a PDF document using the integrated Chromium rendering engine.

```csharp
using IronPdf;

IronPdf.ChromePdfRenderer
       .StaticRenderHtmlAsPdf("<p>Hello Word</p>")
       .SaveAs("string-to-pdf.pdf");
```

For more detailed instructions, check out [Converting HTML String to PDF in C#](https://ironpdf.com/how-to/html-string-to-pdf/).

### Transform DOCX Files to PDF

With IronPDF's `DocxToPdfRenderer`, you can seamlessly convert DOCX files into customizable PDFs directly within your .NET applications.

```csharp
using IronPdf;

DocxToPdfRenderer renderer = new DocxToPdfRenderer();
PdfDocument pdf = renderer.RenderDocxAsPdf("Modern-chronological-resume.docx");
pdf.SaveAs("pdfFromDocx.pdf");
```

For further reading, visit [Converting Microsoft Word documents to PDF in C#](https://ironpdf.com/how-to/docx-to-pdf/).

<p class="related-link">IronPDF helps you create PDFs or convert HTML, DOCX, RTF, Markdown, and images to PDF with full fidelity. <a href="/licensing/">Explore more types of PDF conversions <i class="fa-solid fa-arrow-right"></i></a></p>

```csharp
using IronPdf;
```

Here's the paraphrased section of the article where the IronPDF namespace is included:

```csharp
// Include the IronPdf library in your application
using IronPdf;
```

<div class="installation-options__container" data-active-tab="1">
    <div class="installation-options__tabs">
        <div class="installation-options__tab" data-tab="1">
            <span>Create a Blank PDF</span>
        </div>
        <div class="installation-options__tab" data-tab="2">
            <span>Convert HTML String to PDF</span>
        </div>
        <div class="installation-options__tab" data-tab="3">
            <span>Convert DOCX to PDF</span>
        </div>
    </div>
    <div class="createfirstpdf__info" data-tab="1"></div>
    <div class="createfirstpdf__info" data-tab="2"></div>
    <div class="createfirstpdf__info" data-tab="3"></div>
</div>

<div id="create-a-blank-pdf-start"></div>
The simplest way to create a PDF object uses just the width and height. This `PdfDocument` constructor creates a blank PDF, ready for customization.

Here's the paraphrased section of the article with resolved URL paths:

```csharp
using IronPdf;

// Initialize a new blank PDF with specified dimensions
PdfDocument newPdf = new PdfDocument(270, 270);  // Set both width and height to 270 pixels
newPdf.SaveAs("blankPage.pdf");  // Save the newly created blank PDF with the name "blankPage.pdf"
```

<div id="create-a-blank-pdf-end"></div>

<div id="convert-html-string-to-pdf-start"></div>
Using `ChromePdfRenderer.RenderHtmlAsPdf` method, you can transform any HTML (including HTML5) into a PDF using the embedded Chromium engine.

```csharp
// Reference IronPdf namespace to access PDF creation features
using IronPdf;

// Using the Chrome renderer from IronPDF to convert HTML to PDF
var pdfRenderer = new IronPdf.ChromePdfRenderer();
// Render a simple "Hello Word" HTML string to a PDF document
pdfRenderer.StaticRenderHtmlAsPdf("<p>Hello Word</p>")
            .SaveAs("string-to-pdf.pdf");  // Save the generated PDF to a file named 'string-to-pdf.pdf'
```

<p class="related-link"><strong>RELATED HOW-TO ARTICLE:</strong> <a href="/how-to/html-string-to-pdf/">How to Convert HTML String to PDF in C# <i class="fa-solid fa-arrow-right"></i></a></p>
<div id="convert-html-string-to-pdf-end"></div>

<div id="convert-docx-to-pdf-start"></div>
Convert Word documents to PDF with the `DocxToPdfRenderer` class, you can render DOCX files directly into customizable PDFs for seamless integration into .NET apps.

```csharp
using IronPdf;

// Initialize the converter for DOCX to PDF
DocxToPdfRenderer docToPdfConverter = new DocxToPdfRenderer();
// Generate a PDF document from a DOCX file
PdfDocument document = docToPdfConverter.RenderDocxAsPdf("Modern-chronological-resume.docx");
// Save the generated PDF to a file
document.SaveAs("ConvertedPDFfromDOCX.pdf");
```

<p class="related-link"><strong>RELATED HOW-TO ARTICLE:</strong> <a href="/how-to/docx-to-pdf/">How to Convert Microsoft Word to PDF in C# <i class="fa-solid fa-arrow-right"></i></a></p>
<div id="convert-docx-to-pdf-end"></div>

<hr>

## 5. More Advanced Examples

Beyond basic PDF generation and conversions, IronPDF extends its capabilities to include sophisticated PDF customization techniques.

<div class="installation-options__container" data-active-tab="1">
    <div class="installation-options__tabs">
        <div class="installation-options__tab" data-tab="1">
            <span>Add Headers and Footers</span>
        </div>
        <div class="installation-options__tab" data-tab="2">
            <span>Redact Text</span>
        </div>
        <div class="installation-options__tab" data-tab="3">
            <span>Merge PDFs</span>
        </div>
    </div>
    <div class="advancedexamples__info" data-tab="1"></div>
    <div class="advancedexamples__info" data-tab="2"></div>
    <div class="advancedexamples__info" data-tab="3"></div>
</div>

<div id="add-headers-and-footers-start"></div>
Create text headers or footers by instantiating `TextHeaderFooter`, adding your text, and attaching it to the PDF.

Here's the paraphrased section of the article:

```csharp
using IronPdf;

// Initialize the PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
// Render an HTML string to a PDF document
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>Hello World!</h1>");

// Instantiate the header and footer
TextHeaderFooter header = new TextHeaderFooter
{
    CenterText = "This is the header!",  // Define center text for header
};

TextHeaderFooter footer = new TextHeaderFooter
{
    CenterText = "This is the footer!",  // Define center text for footer
};

// Attach the header and footer to the PDF document
document.AddTextHeaders(header);
document.AddTextFooters(footer);

// Save the document to a file
document.SaveAs("addTextHeaderFooter.pdf");
```

<p class="related-link"><strong>RELATED HOW-TO ARTICLE:</strong> <a href="/how-to/headers-and-footers/">How to Add Headers and Footers <i class="fa-solid fa-arrow-right"></i></a></p>
<div id="add-headers-and-footers-end"></div>

<div id="redact-text-start"></div>
Redact text with ease using `RedactTextOnAllPages` to remove a phrase across the entire document.

```csharp
using IronPdf;

// Load a PDF file
PdfDocument document = PdfDocument.FromFile("novel.pdf");

// Remove the specified phrase 'Alaric' from all the pages
document.RedactTextOnAllPages("Alaric");

// Save the modified document as a new file
document.SaveAs("redacted.pdf");
```

<p class="related-link"><strong>RELATED HOW-TO ARTICLE:</strong> <a href="/how-to/url-to-pdf/">How to Render URL to PDF <i class="fa-solid fa-arrow-right"></i></a></p>
<div id="redact-text-end"></div>

<div id="merge-pdfs-start"></div>
Merge two PDF files in C# with the `Merge` method. Use `ReplaceTextOnAllPages` on any `PdfDocument`, new or imported, to swap old text with new.

```csharp
using IronPdf;

// Instantiate a new renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Convert HTML to PDF
PdfDocument newPdf = pdfRenderer.RenderHtmlAsPdf("<h1>.NET6</h1>");

// Define the text to replace
string originalText = ".NET6";
string updatedText = ".NET7";

// Implement text replacement across the entire document
newPdf.ReplaceTextOnAllPages(originalText, updatedText);

// Save the edited PDF
newPdf.SaveAs("updatedText.pdf");
```

<p class="related-link"><strong>RELATED HOW-TO ARTICLE:</strong> <a href="/how-to/merge-or-split-pdfs/">How to Merge or Split PDFs <i class="fa-solid fa-arrow-right"></i></a></p>
<div id="merge-pdfs-end"></div>

<hr>

## Quick Troubleshooting Guide

This section provides solutions to common issues you might encounter with IronPDF:

<div class="quick-troubleshooting">
    <table class="classic-table">
        <thead>
            <tr>
                <th>Problem</th>
                <th>Solution</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Absence of Visual C++ Runtime</td>
                <td>Ensure the Chrome engine works correctly by installing Visual C++ Redistributable, including both the x86 and x64 versions.</td>
            </tr>
            <tr>
                <td>License recognition issues</td>
                <td>Check the licensing status using the `IronPdf.License.IsLicensed` property and make sure to apply the license before carrying out any IronPDF activities.</td>
            </tr>
            <tr>
                <td>Initial render takes quite some time</td>
                <td>To accelerate startup rendering time, initialize the rendering engines early by invoking `IronPdf.Installation.Initialize()` during your application’s launch sequence.</td>
            </tr>
            <tr>
                <td>Dependencies issues in Linux/Docker</td>
                <td>Automate the installation of necessary dependencies in Linux and Docker deployments by setting `Installation.LinuxAndDockerDependenciesAutoConfig` to true.</td>
            </tr>
        </tbody>
    </table>
</div>

<div class="quick-troubleshooting">
    <table class="classic-table">
        <thead>
            <tr>
                <th>Issue</th>
                <th>Solution</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>Missing Visual C++ Runtime</td>
                <td>Install Visual C++ Redistributable - both x86 and x64 versions required for the Chrome engine</td>
            </tr>
            <tr>
                <td>License not recognized</td>
                <td>Verify with <code>IronPdf.License.IsLicensed</code> property. Ensure license is applied before any IronPDF operations</td>
            </tr>
            <tr>
                <td>Slow first render</td>
                <td>Call <code>IronPdf.Installation.Initialize()</code> at startup to pre-initialize rendering engines</td>
            </tr>
            <tr>
                <td>Linux/Docker dependencies</td>
                <td>Set <code>Installation.LinuxAndDockerDependenciesAutoConfig = true</code> for automatic dependency installation</td>
            </tr>
        </tbody>
    </table>
</div>

<hr>

## Subsequent Actions

<div class="row g-3">
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="https://ironpdf.com/tutorials/csharp-edit-pdf-complete-tutorial/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-pen-to-square"></i>
                </div>
                <span class="next-step__card-text">Edit PDFs</span>
            </div>
            <p class="next-step__card-cta">Discover features <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="https://ironpdf.com/tutorials/organize-pdfs-complete-tutorial/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-sitemap"></i>
                </div>
                <span class="next-step__card-text">Organize PDFs</span>
            </div>
            <p class="next-step__card-cta">Explore features <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="https://ironpdf.com/tutorials/csharp-pdf-security-complete-tutorial/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-pen-field"></i>
                </div>
                <span class="next-step__card-text">Secure & Sign PDFs</span>
            </div>
            <p class="next-step__card-cta">Review features <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
</div>

<hr>

<div class="tutorials-navigation">
    <a href="#" class="tutorials-navigation__cta tutorials-navigation__cta--left" style="visibility: hidden;">
        <i class="fa-solid fa-chevron-left"></i> Installation Summary
    </a>
    <a href="https://ironpdf.com/get-started/installation-overview/" class="tutorials-navigation__cta tutorials-navigation__cta--right">
        Installation Summary <i class="fa-solid fa-chevron-right"></i>
    </a>
</div>

<div class="row g-3">
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="/tutorials/csharp-edit-pdf-complete-tutorial/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-pen-to-square"></i>
                </div>
                <span class="next-step__card-text">Edit PDFs</span>
            </div>
            <p class="next-step__card-cta">See features <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="/tutorials/organize-pdfs-complete-tutorial/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-sitemap"></i>
                </div>
                <span class="next-step__card-text">Organize PDFs</span>
            </div>
            <p class="next-step__card-cta">See features <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
    <div class="col-12 col-md-6 col-xxl-4">
        <a href="/tutorials/csharp-pdf-security-complete-tutorial/" class="next-step__card">
            <div class="next-step__card-info">
                <div class="next-step__card-icon">
                    <i class="fa-duotone fa-solid fa-pen-field"></i>
                </div>
                <span class="next-step__card-text">Sign & Secure PDFs</span>
            </div>
            <p class="next-step__card-cta">See features <i class="fa-solid fa-arrow-right"></i></p>
        </a>
    </div>
</div>

<hr>

<div class="tutorials-navigation">
    <a href="#" class="tutorials-navigation__cta tutorials-navigation__cta--left" style="visibility: hidden;">
        <i class="fa-solid fa-chevron-left"></i>Installation Overview
    </a>
    <a href="/get-started/installation-overview/" class="tutorials-navigation__cta tutorials-navigation__cta--right">
        Installation Overview<i class="fa-solid fa-chevron-right"></i>
    </a>
</div>

<script>
    window.addEventListener("DOMContentLoaded", () => {
        const mainArticle = document.querySelector(".main-article");

        if (mainArticle) {
            // Installation Options
            appendChildrenToTab(mainArticle, "nuget-package-manager-start", "nuget-package-manager-end", "installation-options__info", 1);

            appendChildrenToTab(mainArticle, "dll-download-start", "dll-download-end", "installation-options__info", 2);

            // Create First Pdf
            appendChildrenToTab(mainArticle, "create-a-blank-pdf-start", "create-a-blank-pdf-end", "createfirstpdf__info", 1);

            appendChildrenToTab(mainArticle, "convert-html-string-to-pdf-start", "convert-html-string-to-pdf-end", "createfirstpdf__info", 2);

            appendChildrenToTab(mainArticle, "convert-docx-to-pdf-start", "convert-docx-to-pdf-end", "createfirstpdf__info", 3);

            // More Advanced Examples
            appendChildrenToTab(mainArticle, "add-headers-and-footers-start", "add-headers-and-footers-end", "advancedexamples__info", 1);

            appendChildrenToTab(mainArticle, "redact-text-start", "redact-text-end", "advancedexamples__info", 2);

            appendChildrenToTab(mainArticle, "merge-pdfs-start", "merge-pdfs-end", "advancedexamples__info", 3);

            // Switch tab 
            mainArticle.addEventListener("click", (evt) => {
                const clickedTab = evt.target.closest(".installation-options__tab");

                if (clickedTab) {
                    const container = clickedTab.closest(".installation-options__container");

                    if (container) {
                        container.dataset.activeTab = clickedTab.dataset.tab;
                    }
                }
            });
        }
    });

    function getNodesBetweenMarkers(root, startText, endText) {
        const walker = document.createTreeWalker(root, NodeFilter.SHOW_ELEMENT);

        let start = null, end = null, n;

        while((n = walker.nextNode())) {
            if (!start && n.id === startText) start = n;
            else if (start && n.id === endText) { end = n; break; }
        }

        if (!start 
 !end) return [];

        const between = [];

        for (let cur = start.nextSibling; cur && cur !== end; cur = cur.nextSibling) {
            if (cur.nodeType === Node.ELEMENT_NODE) between.push(cur);
        }

        return between;
    }

    function appendChildrenToTab(mainArticle, start, end, className, tabId) {
        const kids = getNodesBetweenMarkers(mainArticle, start, end);

        if (kids.length > 0) {
            const tab = mainArticle.querySelector(`.${className}[data-tab="${tabId}"]`);

            if (tab) {
                kids.forEach(kid => tab.appendChild(kid));
            }
        }

    }
</script>

