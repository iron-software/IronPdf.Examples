# Utilizing IronPDF in a Remote Docker Container

***Based on <https://ironpdf.com/get-started/ironpdfengine-docker/>***


IronPdfEngine functions as a self-sufficient service capable of handling the creation, manipulation, and retrieval of PDF documents. Docker containers pre-configured for IronPDF are available, compatible from version v2023.2.x onwards, aimed at helping developers overcome frequent deployment challenges related to IronPDF.

## Benefits of Isolating IronPDF in a Docker Container

IronPDF relies on extensive binaries from Chrome and Pdfium, which are large—in the realm of hundreds of megabytes. Additionally, it depends on numerous system dependencies.

This architecture means that deploying IronPDF in a standalone container significantly reduces the footprint on client systems.

### Simplifying Deployment

Setting up a local environment to include all necessary dependencies can be daunting. By utilizing the IronPDF Docker container, these components are already configured and ready to perform, ensuring a smooth and trouble-free deployment process.

## Versioning Conventions

Each version of IronPDF has a matching IronPdfEngine Docker tag which must align with the IronPDF version used in your environment.

For instance, `IronPDF for Java` version `2023.2.1` should match IronPdfEngine version `2023.2.1`. Version mismatches between IronPdfEngine and IronPDF are not supported.

## Deploying IronPDF with Docker

### Step 1 - Integration of IronPDF

Integrate IronPdf.Slim from NuGet into your project.

[https://www.nuget.org/packages/IronPdf.Slim/](https://www.nuget.org/packages/IronPdf.Slim/)

| More details at: [https://ironpdf.com/docs/](https://ironpdf.com/docs/)

**Note: The `IronPdf`, `IronPdf.Linux`, and `IronPdf.MacOs` packages include the `IronPdf.Slim`.** For minimized application size, it's recommended to just use `IronPdf.Slim`.

### Step 2 - Identify the Appropriate Container Version

The version for the IronPDF Docker offering is directly taken from the latest NuGet listing of IronPDF.

To manually verify the version, use:

```cs
string ironPdfEngineVersion = IronPdf.Installation.IronPdfEngineVersion;
```

### Step 3 - Configuring IronPDF in a Docker Container

#### Without Docker Compose:

Deploy the container with a specific version:

Example for `IronPDF for Docker version e.g. 2023.2.1`:

```bash
docker network create -d bridge --attachable --subnet=172.19.0.0/16 --gateway=172.19.0.1 ironpdf-network

docker run -d -e IRONPDF_ENGINE_LICENSE_KEY=MY_LICENSE_KEY --network=ironpdf-network --ip=172.19.0.2 --name=ironpdfengine --hostname=ironpdfengine -p 33350:33350 ironsoftwareofficial/ironpdfengine:2023.2.1
```

The port `33350` serves as the standard internal port for IronPdfEngine.

#### Using Docker Compose:

Create your Docker Compose setup as per this template:

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

Execute the following to start your services:

```bash
docker compose up --detach --force-recreate --remove-orphans --timestamps
```

### Step 4 - Setting Up the IronPDF Client Configuration

Include this code snippet:

```cs
using IronPdf.GrpcLayer;

var config = new IronPdfConnectionConfiguration();
config.ConnectionType = IronPdfConnectionType.Docker;
IronPdf.Installation.ConnectToIronPdfHost(config);
```

### Step 5 - Execution

Now execute your IronPDF related operations; the application will communicate with the IronPdfEngine running inside the Docker container.

#### Example Client Code

```cs
using IronPdf;
using IronPdf.GrpcLayer;

var config = new IronPdfConnectionConfiguration();
config.ConnectionType = IronPdfConnectionType.Docker;
IronPdf.Installation.ConnectToIronPdfHost(config);

ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF Docker!</h1>");
pdf.SaveAs("ironpdf.pdf");
```