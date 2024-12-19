# Introduction to IronPdfEngine

***Based on <https://ironpdf.com/tutorials/what-is-ironpdfengine/>***


IronPdfEngine is a gRPC server tailored for performing various PDF operations with IronPDF, including creation, modification, and retrieval of documents. This standalone C# .NET application operates independently of the .NET runtime, enhancing its deployment flexibility.

## Getting Started with IronPDF

## Rationale Behind IronPdfEngine

### 1. Language Expansion Capabilities

IronPdfEngine operates without needing the .NET runtime, allowing the extension of IronPdf functionalities to other programming languages such as Java and Node.js.

### 2. Deployment Flexibility

IronPdfEngine provides an alternative deployment method where it runs independently of your main applications. This separation means that your applications no longer need to integrate hefty Chrome and Pdfium binaries, significantly reducing their overall footprint.

## IronPdfEngine Docker Overview

### Description of IronPdfEngine Docker

IronPdfEngine Docker is a pre-configured, ready-to-use Docker image that encapsulates the IronPdfEngine and exposes it on port 33350 by default to facilitate connections from IronPDF clients.

### Purpose of IronPdfEngine Docker

- **Deployment Simplification:** IronPdfEngine Docker eradicates common deployment and dependency issues.
- **Reduction in Application Size:** Utilizing IronPdfEngine Docker can trim down the size of your applications.
- **Shared PDF Server Functionality:** Multiple application instances can utilize a singular IronPdfEngine, acting as a centralized PDF server.

### How to Access IronPdfEngine Docker

- [Docker Hub](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine)
- [Amazon ECR Public Gallery](https://gallery.ecr.aws/v1m9w8y1/ironpdfengine)

### Utilization in Various IronPDF Libraries

- The use of IronPdfEngine is optional for IronPdf in .NET and Python.
- IronPdf for Java and Node.js require the IronPdfEngine. By default, these implementations will initiate a subprocess that hosts IronPdfEngine locally at `localhost:33305`. Alternatively, the IronPdfEngine Docker can be operated independently.

## Constraints of IronPdfEngine

- IronPdfEngine currently does not support horizontal scaling (managing load balance across multiple instances) because it retains the processed PDF binaries in server memory and communicates with clients using `PdfDocumentId`. This design minimizes bandwidth usage and maximizes processing speed.
- Remote operation of IronPdfEngine Docker necessitates the accessibility of its designated port.
- When operating on a Linux x64 (Debian) system using the official `ubuntu:22.04` based images, the PDF output might slightly differ from local executions due to OS discrepancies.
- IronPdfEngine Docker is based on Linux and hence requires a Linux Containers daemon. Windows users should select `Switch to Linux Containers`.
- The IronPdfEngine binaries are platform-specific and built for individual platforms.
- Cross-version compatibility is not supported.