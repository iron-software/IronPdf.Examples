# Run IronPDF in a Docker Container

***Based on <https://ironpdf.com/get-started/ironpdfengine-docker/>***


IronPDF provides a standalone Docker container, known as IronPdfEngine, designed to create, manage, and process PDFs effortlessly. With support for versions 2023.2.x and newer, IronPDF Docker aims to simplify deployment by resolving common issues encountered with traditional IronPDF setups.

## Benefits of Isolating IronPDF in a Docker Container

IronPDF operates using substantial Chrome and Pdfium binaries, making it large in size. This, coupled with additional dependencies, can result in significant resource consumption.

### Eliminate Deployment Complexities

Configuring a suitable environment for all necessary dependencies can be challenging. Leveraging the IronPDF Docker container, with IronPDF pre-configured, ensures operational reliability and eradicates common setup problems.

## Version Compatibility

The IronPDF Docker container uses a specific tagging system aligned with IronPdfEngine versions, which differs from the standard IronPDF library versions. Each IronPDF library version correlates with an explicit IronPdfEngine tag, and mismatches between these versions are not permissible.

For instance, `IronPDF for Java` version `2023.2.1` corresponds exactly with IronPdfEngine version `2023.2.1`.

## Implementing IronPDF in Docker

### Step 1 - Installation

Start by integrating the IronPdf.Slim Nuget package into your project from [Nuget](https://www.nuget.org/packages/IronPdf.Slim/).

Fore more information, visit [IronPDF Documentation](https://ironpdf.com/docs/).

_Important: All variants of IronPDF packages include IronPdf.Slim. Discontinue using the `IronPdf.Native.Chrome.xxx` package if previously utilized._

### Step 2 - Verify Container Version

Typically, the IronPDF version for Docker reflects the latest on NuGet. Confirm this via manual verification:

```cs
using IronPdf;

namespace ironpdf.IronpdfengineDocker
{
    public class VersionCheck
    {
        public void Run()
        {
            string ironPdfEngineVersion = IronPdf.Installation.IronPdfEngineVersion;
        }
    }
}
```

### Step 3 - Deploy the Docker Container

#### Sub-step 3.i - Setup without Docker Compose

Execute the docker run command corresponding to the correct IronPDF version:

```bash
# First, create a network for Docker

***Based on <https://ironpdf.com/get-started/ironpdfengine-docker/>***

docker network create -d bridge --attachable --subnet=172.19.0.0/16 --gateway=172.19.0.1 ironpdf-network

# Now run the container

***Based on <https://ironpdf.com/get-started/ironpdfengine-docker/>***

docker run -d -e IRONPDF_ENGINE_LICENSE_KEY=YOUR_LICENSE_KEY --network=ironpdf-network --ip=172.19.0.2 --name=ironpdfengine --hostname=ironpdfengine -p 33350:33350 ironsoftwareofficial/ironpdfengine:2023.2.1
```

_Port 33350 serves as the standard node for IronPdfEngine._

#### Sub-step 3.ii - Configuration with Docker Compose

Construct your Docker Compose environment as follows:

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

Execute your Docker Compose scenario using:

```bash
docker compose up --detach --force-recreate --remove-orphans --timestamps
```

### Step 4 - Client Configuration

Integrate the following configuration for your IronPDF client setup:

```cs
using IronPdf.GrpcLayer;
using IronPdf;

namespace ironpdf.IronpdfengineDocker
{
    public class ClientSetup
    {
        public void Run()
        {
            var config = new IronPdfConnectionConfiguration();
            config.ConnectionType = IronPdfConnectionType.Docker;
            IronPdf.Installation.ConnectToIronPdfHost(config);
        }
    }
}
```

### Step 5 - Execution

Now you can utilize IronPDF within your application, effectively using the IronPdfEngine hosted in Docker:

#### Sample Client Test

```cs
using IronPdf.GrpcLayer;
using IronPdf;

namespace ironpdf.IronpdfengineDocker
{
    public class DockerTest
    {
        public void Run()
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