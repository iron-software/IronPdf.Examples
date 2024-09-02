# Introduction to IronPdfEngine

IronPdfEngine is an independent gRPC server designed specifically for handling various IronPDF operations including the creation, modification, and processing of PDF documents. This unique solution is developed as a self-contained C# .NET application, eliminating the need for the .NET runtime. 

## Purpose Behind IronPdfEngine

### 1. Extending IronPdf Accessibility

Thanks to its independence from the .NET runtime, IronPdfEngine enhances the flexibility of IronPdf, allowing it to integrate with other programming environments such as Java and Node.js, thereby broadening its usability across different programming communities.

### 2. Alternative Deployment Options for IronPdf

IronPdfEngine offers the advantage of standalone operation, meaning it can run separately from your main applications. This modular approach reduces your application's footprint by not requiring the inclusion of Chrome and Pdfium binaries within each deployment.

## Deploying IronPdfEngine via Docker

### Overview of IronPdfEngine Docker

IronPdfEngine Docker simplifies the deployment process by providing a pre-configured Docker image that hosts the IronPdfEngine. It is readily available for use and listens on port 33350 by default, facilitating easy connectivity for IronPdf clients.

### Rationale for IronPdfEngine Docker

- **Simplified Deployment:** IronPdfEngine Docker eliminates the complexities of deployment and dependency management, ensuring a smoother integration process.
- **Reduced Application Size:** By running IronPdfEngine in Docker, the overall size of your application is decreased significantly.
- **Shared Resource Efficiency:** Multiple application instances can utilize a single IronPdfEngine instance hosted as a centralized PDF server.

### Acquiring IronPdfEngine Docker

- [Dockerhub](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine)
- [Amazon ECR Public Gallery](https://gallery.ecr.aws/v1m9w8y1/ironpdfengine)

### Utilization within Various Platforms

While using IronPdfEngine is optional with IronPdf for .NET and IronPdf for Python, it becomes mandatory for IronPdf for Java and IronPdf for Node.js. These implementations typically run IronPdfEngine as a local subprocess (localhost:33305) or alternatively via a separate IronPhpEngine Docker.

## Limitations of IronPdfEngine

- **Scaling Constraints:** Currently, IronPdfEngine does not support horizontal scaling or load balancing across multiple instances. It operates with an in-memory storage model for PDF files and utilizes PdfDocumentId for efficient server-client communication, which also boosts speed and reduces bandwidth consumption.
- **Remote Deployment Requirements:** For remote operations, ensure the accessibility of the IronPdfEngine Docker port.
- **Operating System Specific Output:** When running IronPdfEngine Docker on Linux x64 platforms (Debian) using Ubuntu 22.04 based images, the resulting PDFs might display slight variations compared to local executions due to different OS behaviors.
- **Container Compatibility:** IronPdfEngine Docker requires a Linux Containers daemon on Windows ('Switch to Linux Containers' option).
- **Platform-Specific Builds:** IronPdfEngine binaries are tailored specifically for each platform, maintaining performance and compatibility.
- **Version Compatibility:** Cross-version operations are not supported with IronPdfEngine.

This summary provides insights into the versatility and practical deployment options of IronPdfEngine, facilitating its integration into diverse environments while optimizing performance and resource usage.