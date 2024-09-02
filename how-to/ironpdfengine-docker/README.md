# Deploying the IronPDF Docker Container

<blockquote class="double-style">Applicable only for IronPDF version 2023.2.x and later</blockquote>

IronPdfEngine is a gRPC service capable of creating, editing, and processing PDFs.

The IronPDF Docker solution provides readily deployable Docker services compatible with IronPDF versions 2023.2.x and newer. It is designed to address common deployment challenges associated with IronPDF.

## Purpose

IronPDF utilizes Chrome and Pdfium binaries, which are large (several hundred megabytes) and require numerous dependencies on the host system.

Leveraging this Docker-based approach significantly reduces the footprint of these dependencies on client machines.

### Resolving Deployment Challenges

Setting up a proper environment or container to include all necessary dependencies can be cumbersome. With the IronPDF Docker container, IronPDF is pre-installed and configured to function correctly, freeing you from the typical deployment and dependency hassles.

## Version Compatibility

The version tag of the IronPDF Docker image correlates directly with the IronPdfEngine version, not the IronPDF core product version. 

Each version of IronPDF has a corresponding version of IronPdfEngine, and these versions must align when deploying the IronPDF Docker container.

For example, the `IronPDF for Java` version `2023.2.1` must use IronPdfEngine version `2023.2.1`. Mismatches between these versions are not permitted.

## Utilizing IronPDF Docker

### Step 1 - Installation

Integrate the IronPdf.Slim package from Nuget into your application.

[https://www.nuget.org/packages/IronPdf.Slim/](https://www.nuget.org/packages/IronPdf.Slim/)

More info: [https://ironpdf.com/docs/](https://ironpdf.com/docs/)

**Note: The `IronPdf`, `IronPdf.Linux`, and `IronPdf.MacOs` packages also include IronPdf.Slim.** 

It’s recommended to install only IronPdf.Slim to minimize your app's size. The `IronPdf.Native.Chrome.xxx` package is now obsolete and can be removed.

### Step 2 - Select the Proper Container Version

IronPDF Docker versions should align with the latest IronPDF versions available on NuGet. Verify the version explicitly if needed:

```cs
string ironPdfEngineVersion = IronPdf.Installation.IronPdfEngineVersion;
```

### Step 3 - Deploying IronPDF on Docker

#### Step 3.i - Without Docker Compose

Execute the following commands to run the specific version of IronPDF Docker:

```
docker network create -d bridge --attachable --subnet=172.19.0.0/16 --gateway=172.19.0.1 ironpdf-network

docker run -d -e IRONPDF_ENGINE_LICENSE_KEY=MY_LICENSE_KEY --network=ironpdf-network --ip=172.19.0.2 --name=ironpdfengine --hostname=ironpdfengine -p 33350:33350 ironsoftwareofficial/ironpdfengine:2023.2.1
```

Port 33350 is utilized as the default internal port for IronPdfEngine.

IronPDF Docker is now operational!

#### Step 3.ii - Using Docker Compose

Configure your Docker Compose environment using the following example:

```yaml
version: "3.3"

services:
  ironpdfengine:
    container_name: ironpdfengine
    image: ironsoftwareofficial/ironpdfengine:latest
    networks:
      ironpdf-network:
        ipv4_address: 172.19.0.2
  myconsoleapp:
    container_name: myconsoleapp
    build:
      context: ./MyConsoleApp/
      dockerfile: Dockerfile
    networks:
      ironpdf-network:
        ipv4_address: 172.19.0.3
    depends_on:
      ironpdfengine:
        condition: service_started

networks:
  ironpdf-network:
    driver: bridge
    ipam:
      config:
        - subnet: 172.19.0.0/16
          gateway: 172.19.0.1
```

Execute the setup with:

```bash
docker compose up --detach --force-recreate --remove-orphans --timestamps
```

### Step 4 - Configure the IronPDF Client

Incorporate this configuration line:

```cs
using IronPdf.GrpcLayer;

var config = new IronPdfConnectionConfiguration();
config.ConnectionType = IronPdfConnectionType.Docker;
IronPdf.Installation.ConnectToIronPdfHost(config);
```

### Step 5 - Execution

Execute your IronPDF based code and it will now interface with the IronPdfEngine hosted in a Docker container!

#### Sample Client Code

```cs
using IronPdf;
using IronPdf.GrpcLayer;

var config = new IronPdfConnectionConfiguration();
config.ConnectionType = IronPdfConnectionType.Docker;
IronPdf.Installation.ConnectToIronPdfHost(config);

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF Docker!<h1>");
pdf.SaveAs("ironpdf.pdf");
```