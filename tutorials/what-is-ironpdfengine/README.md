# What is IronPdfEngine?

***Based on <https://ironpdf.com/tutorials/what-is-ironpdfengine/>***


IronPdfEngine serves as a gRPC server capable of performing various PDF operations through IronPDF, such as creation, modification, and reading. This application is built on C# .NET as a standalone product, eliminating the requirement for a .NET runtime environment to function.

## Purpose of Developing IronPdfEngine

### 1. Enhancing Language Compatibility

IronPdfEngine's independence from the .NET runtime allows for the expansion of IronPdf's compatibility to include additional programming languages such as Java and Node.js.

### 2. Alternative Deployment Options for IronPdf

IronPdfEngine offers an innovative deployment model where it operates independently of user applications. This isolation means that the user application no longer needs to embed heavy Chrome and Pdfium binaries, enhancing its overall efficiency.

## Deployment Using IronPdfEngine Docker

### Overview of IronPdfEngine Docker

IronPdfEngine Docker features a Docker image that is pre-configured and ready to execute, housing the IronPdfEngine. By default, it opens port 33350 to facilitate connections from IronPdf clients.

### Reasons Behind IronPdfEngine Docker’s Creation

- It resolves various deployment and dependency issues by utilizing the IronPdfEngine Docker container, facilitating streamlined deployments.
- It supports a reduction in application size when using IronPdfEngine Docker.
- It allows multiple application instances to utilize a single IronPdfEngine, serving as a communal PDF server.

### How to Access IronPdfEngine Docker

- [Dockerhub](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine)
- [Amazon ECR Public Gallery](https://gallery.ecr.aws/v1m9w8y1/ironpdfengine)

While using IronPdf for .NET and IronPdf for Python, the use of IronPdfEngine is optional. In contrast, IronPdf for Java and IronPdf for Node.js require IronPdfEngine to function. By default, these will initiate a local subprocess that runs IronPdfEngine (localhost:33305), or alternatively, you can operate IronPdfEngine Docker separately.

## Limitations of IronPdfEngine

- IronPdfEngine currently does not support horizontal scaling, such as load balancing across multiple instances. This is due to the in-memory storage of processing PDF file binaries and the use of PdfDocumentId for server-client communication, which also reduces bandwidth usage and enhances processing speed.
- For remote operation of IronPdfEngine Docker, ensure the accessibility of the IronPdfEngine port.
- When running on Linux x64 (Debian), particularly using the official ubuntu:22.04 based images, the PDF output may differ slightly from local executions due to operating system variations. 
- As IronPdfEngine Docker is Linux-based, it requires a Linux Containers daemon. Windows users should select `Switch to Linux Containers` for compatibility.
- IronPdfEngine's binaries are platform-specific and not cross-platform compatible.
- Cross-version operability is not supported.