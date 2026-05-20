# IronPdf.Examples

Runnable C# examples for [IronPDF](https://ironpdf.com/), a .NET PDF library that converts HTML to PDF and generates, edits, and extracts PDF content.

## Install

```bash
dotnet add package IronPdf
```

## Quickstart

```csharp
using IronPdf;

var renderer = new ChromePdfRenderer();
var pdf = renderer.RenderHtmlAsPdf("<h1>Hello, PDF!</h1>");
pdf.SaveAs("hello.pdf");
```

That produces a working PDF on the first run. To render from other sources, swap `RenderHtmlAsPdf` for `RenderUrlAsPdf(url)`, `RenderHtmlFileAsPdf(path)`, or use `ImageToPdfConverter.ImageToPdf(image)`.

For production use, set a license key via `License.LicenseKey = "YOUR-KEY"`. Without one, generated PDFs include a watermark.

## What's in this repo

Each folder contains a self-contained .NET project you can open and run:

- `examples/` — focused snippets demonstrating individual features
- `get-started/` — minimal first projects covering installation and basic rendering
- `how-to/` — task-oriented guides for specific PDF operations
- `quickstart/` — end-to-end project scaffolds
- `tutorials/` — longer walkthroughs combining multiple features
- `IronPdf.AI/` — examples integrating IronPDF with RAG and AI document workflows
- `IronPdf.AndroidDemo/` — server-side IronPDF deployment for use by Android clients

## Common tasks covered

- HTML, URL, and image to PDF conversion
- Merging, splitting, and rearranging existing PDFs
- Headers, footers, watermarks, and page numbering
- Digital signatures and PDF/A compliance
- Password protection and security metadata
- Form filling and form data extraction
- Rendering PDFs from ASP.NET Core, Blazor, and .NET MAUI

## Platform support

.NET 8, 7, 6, 5, .NET Core, .NET Standard, and .NET Framework. Windows, macOS, Linux, Docker, Azure, and AWS Lambda. See the [installation docs](https://ironpdf.com/docs/questions/installation/) for environment-specific notes.

## Documentation and support

- Full documentation: [ironpdf.com/docs](https://ironpdf.com/docs/)
- API reference: [ironpdf.com/object-reference/api](https://ironpdf.com/object-reference/api/)
- Issues with these examples: file directly on this repository
- Product support: [support@ironsoftware.com](mailto:support@ironsoftware.com)

## About

This repository is maintained by [Iron Software](https://ironsoftware.com/). IronPDF is a commercial library — see [licensing](https://ironpdf.com/licensing/) for terms and trial details.