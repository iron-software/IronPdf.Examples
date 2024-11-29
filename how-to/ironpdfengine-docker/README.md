# Deploying Your Own IronPDF Docker Container

***Based on <https://ironpdf.com/how-to/ironpdfengine-docker/>***


> **Compatibility Note**: Only compatible with IronPDF version 2023.2.x and newer.

The `IronPdfEngine` is a gRPC-based service crafted to manage the creation, modification, and reading of PDF documents.

The IronPDF Docker image provides a ready-to-use solution for deploying IronPDF versions 2023.2.x and above, solving common deployment issues encountered with IronPDF.


## Purpose

IronPDF functions require the Google Chrome and Pdfium binaries, which are substantially large (hundreds of megabytes) and depend on multiple external dependencies.

Using a Docker container, the footprint of these dependencies on the client side is drastically minimized.

### Eliminate Deployment Complexities

Setting up environments or containers to include all needed dependencies can be challenging. The IronPDF Docker container comes with IronPDF pre-configured, ensuring functionality without the hassle of managing dependencies.

## Versioning

The Docker tag for IronPDF corresponds to the respective `IronPdfEngine` version, which is different from the IronPDF library version itself.

Each release of IronPDF has a matching `IronPdfEngine` version. It's essential that these versions align. For instance, `IronPDF for Java` version `2023.2.1` must use `IronPdfEngine version` `2023.2.1`. Version discrepancies between IronPdfEngine and IronPDF are not permissible.

## Utilizing IronPDF Docker Container

### Step 1 - Installation

Incorporate the `IronPdf.Slim` NuGet package into your project. 

[Install IronPdf.Slim from NuGet](https://www.nuget.org/packages/IronPdf.Slim/)

For further details, visit the [IronPDF Documentation](https://ironpdf.com/docs/)

> **Note:** Packages like `IronPdf`, `IronPdf.Linux`, and `IronPdf.MacOs` all include `IronPdf.Slim`. It's recommended to use only `IronPdf.Slim` to reduce application size. You can safely remove `IronPdf.Native.Chrome.xxx` from your project since it is no longer required.

### Step 2 - Confirm Docker Container Version

The default version for IronPDF in Docker will be aligned with the IronPDF version currently available on NuGet.

You can manually verify the version as following:
```cs
using IronPdf;
namespace ironpdf.IronpdfengineDocker
{
    public class VerifyVersion
    {
        public void Execute()
        {
            string ironPdfEngineVersion = IronPdf.Installation.IronPdfEngineVersion;
        }
    }
}
```

### Step 3 - Configuring Docker Deployment

#### Sub-step 3.i - Deployment without Docker Compose

Deploy the container using the version identified previously:

```sh
docker network create -d bridge --attachable --subnet=172.19.0.0/16 --gateway=172.19.0.1 ironpdf-network

docker run -d -e IRONPDF_ENGINE_LICENSE_KEY=MY_LICENSE_KEY --network=ironpdf-network --ip=172.19.0.2 --name=ironpdfengine --hostname=ironpdfengine -p 33350:33350 ironsoftwareofficial/ironpdfengine:2023.2.1
```

IronPDF is now operational within the Docker container at port 33350!

#### Sub-step 3.ii - Using Docker Compose

Prepare your Docker Compose file as below:

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

Subsequently, launch your Docker composition:

```bash
docker compose up --detach --force-recreate --remove-orphans --timestamps
```

### Step 4 - Set Up your IronPDF Client

Include this configuration in your project:

```cs
using IronPdf.GrpcLayer;
using IronPdf;
namespace ironpdf.IronpdfengineDocker
{
    public class ConfigureClient
    {
        public void Execute()
        {
            var config = new IronPdfConnectionConfiguration();
            config.ConnectionType = IronPdfConnectionType.Docker;
            IronPdf.Installation.ConnectToIronPdfHost(config);
        }
    }
}
```

### Step 5 - Execution

Execute your PDF manipulation tasks. Your application is now connected to the IronPdfEngine Docker instance!

#### Example Client Code

```cs
using IronPdf.GrpcLayer;
using IronPdf;
namespace ironpdf.IronpdfengineDocker
{
    public class PerformTasks
    {
        public void Execute()
        {
            var config = new IronPdfConnectionConfiguration();
            config.ConnectionType = IronPdfConnectionType.Docker;
            IronPdf.Installation.ConnectToIronPdfHost(config);
            
            ChromePdfRenderer renderer = new ChromePdfRenderer();
            PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Hello IronPDF Docker!<h1>");
            pdf.SaveAs("ironpdf.pdf");
        }
    }
}
```