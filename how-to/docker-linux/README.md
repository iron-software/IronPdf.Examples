# Integrating IronPDF with Docker Containers

***Based on <https://ironpdf.com/how-to/docker-linux/>***


IronPDF now fully supports Docker on .NET Standard, inclusive of Azure Docker Containers compatible with both Linux and Windows platforms.

Interested in setting up IronPDF in a standalone Docker container? Discover more through our [IronPDF Engine tutorials guide](https://ironpdf.com/tutorials/what-is-ironpdfengine/).

<div class="container-fluid">
    <div class="row">
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/docker--v1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/fluency/96/000000/azure-1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/linux--v1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/amazon-web-services--v1.png">
        </div>
        <div class="col-md-2">
            <img src="https://img.icons8.com/color/96/000000/windows-logo--v1.png">
        </div>
    </div>
</div>

## Benefits of Docker on Azure

Docker Containers on Azure provide superior enterprise scalability and broader permissions compared to regular WebApps, enabling the rendering of SVG fonts due to system-level access to GDI+ graphics.

## Getting Started with IronPDF and Linux in Docker

New to Docker with .NET? We recommend this excellent resource on [setting up Docker debugging and integration with Visual Studio projects](https://docs.microsoft.com/en-us/visualstudio/containers/edit-and-refresh?view=vs-2019).

Be sure to also explore our [IronPDF Linux Setup and Compatibility Guide](https://ironpdf.com/how-to/linux/).

### Recommended Linux Docker Distributions

For optimal configuration of IronPDF, consider using the following 64-bit Linux distributions:

- Ubuntu 22
- Ubuntu 20
- Ubuntu 18
- Debian 11
- Debian 10 _(Preferred by Microsoft Azure)_
- CentOS 8
- Amazon AWS Linux 2 ([IronPDF AWS Lambda Setup Guide](https://ironpdf.com/how-to/creating-pdfs-csharp-amazon-aws-lambda/))

For Docker images, utilize Microsoft's [Official Docker Images for .NET](https://hub.docker.com/_/microsoft-dotnet-runtime/). For other distributions, manual configuration might be necessary. Refer to our ["Linux Manual Setup"](https://ironpdf.com/how-to/linux/#linux-manual-setup) guide.

Included below are Docker files for Ubuntu and Debian: