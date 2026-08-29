# Utilizing IronPDF in a Remote Container

> Full guide: [Utilizing IronPDF in a Remote Container](https://ironpdf.com/get-started/ironpdfengine-docker/)

The IronPdfEngine serves as an independent service capable of managing PDF creation, modification, and reading activities. The IronPDF Docker configuration is prepared to deploy with versions of IronPDF (v2023.2.x and higher), facilitating the resolution of any deployment challenges developers might face with IronPDF.

## Benefits of Hosting IronPDF in a Separate Container

IronPDF operates using sizable binaries from Chrome and Pdfium, which typically demand several hundred megabytes of space. Additionally, it depends on various other system components being present on the host machine.

Deploying IronPDF in its dedicated container significantly reduces the footprint on your client's systems, requiring only a minimal amount of space in megabytes.

### Simplifying Deployment

Configuring an environment or container with all necessary dependencies can be a complex task. By opting for the IronPDF Docker container, you ensure that IronPDF is already installed and configured to operate correctly. This approach eliminates common issues related to deployment and dependencies, simplifying your setup process.

## Version Compatibility

The version tag of IronPDF Docker is directly derived from the specific release of IronPdfEngine. It is crucial to note that this versioning is distinct and does not coincide with the standard IronPDF library versions.

For every release of IronPDF, a corresponding version of IronPdfEngine is established. It is imperative that the versions of IronPDF and IronPdfEngine match meticulously when using Docker.

For instance, IronPDF tailored for Java version `2023.2.1` necessitates the IronPdfEngine version `2023.2.1`. Using discordant versions of IronPdfEngine and IronPDF is not permissible.

<hr>

---
## Utilizing IronPDF Docker

### Installation of IronPDF

Incorporate the `IronPdf.Slim` Nuget package into your project by using the following link:

[https://www.nuget.org/packages/IronPdf.Slim/](https://www.nuget.org/packages/IronPdf.Slim/)

**Note: The packages `IronPdf`, `IronPdf.Linux`, and `IronPdf.MacOs` also contain the `IronPdf.Slim` package.**

For a more lightweight application, opt for the `IronPdf.Slim` package alone. The `IronPdf.Native.Chrome.xxx` package is obsolete, and you may safely remove it from your project.

### Identifying the Necessary Docker Container Version

Typically, the Docker version of IronPDF aligns with its current version on NuGet. Use the following C# code segment to determine the exact version:

```csharp
string ironPdfEngineVersion = IronPdf.Installation.IronPdfEngineVersion;
```

### Configuration of IronPDF Docker Container

#### Configuring Without Docker Compose

To run the docker container using the determined version:

* Ensure Docker is installed on your system.

**Steps for Configuration:**

1. Visit the Docker Hub page for IronPDF at [https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine](https://hub.docker.com/r/ironsoftwareofficial/ironpdfengine).
2. Pull the latest or a specific version of the `ironsoftwareofficial/ironpdfengine` image:

```shell
docker pull ironsoftwareofficial/ironpdfengine
```

Alternatively, for a specific version:

```shell
docker pull ironsoftwareofficial/ironpdfengine:2025.3.6
```

3. Execute the following command to run the `ironsoftwareofficial/ironpdfengine` docker container. This will start the container in the background on port 33350:

```shell
docker run -d -p 33350:33350 -e IRONPDF_ENGINE_LICENSE_KEY=MY_LICENSE_KEY ironsoftwareofficial/ironpdfengine:2025.3.6
```

#### Configuring With Docker Compose

Establish a Docker network to allow the IronPdfEngine and your application to communicate. Ensure `IronPdfEngine` is operational before your application starts by setting 'depends_on'.

**Configuration Steps:**

1. Start by creating a `docker-compose.yml` file. Use the following structure as a guide:

```yml
version: '3.6'
services:
  myironpdfengine:
    container_name: ironpdfengine
    image: ironsoftwareofficial/ironpdfengine:latest
    ports:
      - '33350:33350'
    networks:
      - ironpdf-network
  myconsoleapp:
    container_name: myconsoleapp
    build:
      context: ./MyConsoleApp/
      dockerfile: Dockerfile
    networks:
      - ironpdf-network
    depends_on:
      myironpdfengine:
        condition: service_started
networks:
  ironpdf-network: 
    driver: 'bridge'
```

1. Configure your application (myconsoleapp) to connect to IronPdfEngine at "myironpdfengine:33350".
2. Deploy using Docker Compose with the command:

```shell
docker compose up --detach --force-recreate --remove-orphans --timestamps
```

### Establishing a Connection to IronPdfEngine

Execute your IronPDF tasks by linking to the IronPdfEngine running in a Docker container like this:

```csharp
using IronPdf;
using IronPdf.GrpcLayer;

// Set up the Docker container configuration
var config = IronPdfConnectionConfiguration.Docker;
config.Host = "localhost";
IronPdf.Installation.ConnectToIronPdfHost(config);

// Process HTML to PDF conversion
ChromePdfRenderer renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>Welcome to IronPDF Docker!</h1>");
pdf.SaveAs("ironpdf.pdf");
```

---

### Types of Connections

IronPdf offers various connection types tailored to suit different application needs. Below is a breakdown of the available connection types:

**LocalExecutable**: Suitable for local setups, this connection type allows your application to communicate with an IronPdfEngine server executing locally. An example use case could be a desktop application like a billing system that generates PDF documents right on your computer without necessitating cloud interaction.

**Docker**: Ideal for containerized environments, this connection is specified when the IronPdfEngine needs to operate within a Docker container, either hosted on your premises or in a cloud infrastructure.

**RemoteServer**: This connection type is designed for situations where the IronPdfEngine is hosted in a cloud environment. It requires a complete URL, inclusive of the HTTP or HTTPS protocol, to establish a connection to a cloud-based instance of IronPdfEngine, such as one running inside a Docker container.

**Custom**: Offering the highest level of flexibility, the Custom connection type permits developers to define their own gRPC communication channels. This can be accomplished by either initiating a new `Grpc.Core.Channel` or by using `Grpc.Net.Client.GrpcChannel.ForAddress(System.String)` to create a bespoke channel, thus providing unparalleled control over the gRPC interactions.

### .NET Framework with NetFrameworkChannel

When working with the .NET Framework, the setup for gRPC differs due to the framework's unique requirements.

Make sure to install the [**Grpc.Core**](https://www.nuget.org/packages/grpc.core) NuGet package. This setup will utilize a specialized gRPC channel that extends **Grpc.Core.ChannelBase**.

Here, we will outline how to set up a custom connection channel to generate and store a PDF using IronPDFEngine.

If the sample code provided does not function correctly, consider eliminating the `<http>` or `<https>` prefix from the address.

It's important to note that calling `pdf.Dispose` is necessary in this implementation.

```csharp
using IronPdf;

// Example demonstrating the use of IronPdf with gRPC in a .NET Framework environment.

// Step 1: Set up the connection to utilize a locally running IronPdfEngine executable
var config = IronPdf.GrpcLayer.IronPdfConnectionConfiguration.Executable;

// Step 2: Establish connection with the IronPDF host using the above configuration
IronPdf.Installation.ConnectToIronPdfHost(config);

// Step 3: Instantiate a PDF renderer
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();

// Step 4: Convert an HTML string into a PDF document
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("Hello world");

// Step 5: Save the generated PDF file on disk
document.SaveAs("output.pdf");

// Step 6: Dispose of the PDF document to free resources
document.Dispose();
```

Each part of the code snippet is commented to provide a clear step-by-step guide for implementing the .NET Framework application with IronPdf via gRPC. This structure outlines initializing the configuration, connecting to the IronPDF host, creating a PDF from HTML content, and then cleaning up resources efficiently.

#### Utilizing a Custom Communication Channel with IronPDF

An alternate strategy for configuring IronPDF involves deploying the `WithCustomChannel` function available in the `IronPdf.GrpcLayer` namespace.

The `WithCustomChannel` method accepts two arguments: your custom gRPC channel referred to as `customChannel`, and a `metadata` object. By default, the `metadata` argument is optional and initialized to `null`.

```csharp
using IronPdf;
using IronPdf.GrpcLayer;
using Grpc.Core;

// Create a custom gRPC channel tailored to .NET Framework applications
var customChannel = new Channel("123.456.7.8:80", ChannelCredentials.SecureSsl);

// Optionally, you can add metadata headers as needed for customization
var headerMetadata = new Metadata
{
    { "Authorization", "Bearer your_token_here" }
};

// Set up IronPDF to use a custom channel with optional metadata
var pdfConfig = IronPdfConnectionConfiguration.WithCustomChannel(customChannel, headerMetadata);
IronPdf.Installation.ConnectToIronPdfHost(pdfConfig);

// Create a new PDF renderer instance and generate a PDF
ChromePdfRenderer pdfRenderer = new ChromePdfRenderer();
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("Hello world");

// Save the generated PDF to a file
document.SaveAs("output.pdf");

// Proper cleanup is necessary to ensure efficient memory management
document.Dispose();
```

<hr>

## Setting Up IronPdfEngine on AWS ECS

### Preparation Steps

* Begin by accessing the previously outlined steps for pulling the IronPdfEngine Docker image in the ["Setup IronPDF for Docker Container"](https://ironsoftware.com/csharp/ocr/docs/setup-ironpdf-for-docker-container/) section.
* Ensure you're equipped with an active AWS account capable of managing ECS.

### Configuration Guide

1. **ECS Cluster Creation**: Start by creating an ECS Cluster. The AWS documentation offers a detailed guide on establishing a cluster for both Fargate and External launch types. You can find this resource [here](https://docs.aws.amazon.com/AmazonECS/latest/userguide/create-cluster-console-v2.html).

2. **Task Definition**: Next, set up a task definition by following these simplified steps provided by AWS [here](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/create-task-definition.html).

   Recommended configurations include:
   - **AWS Fargate** as the launch type.
   - A minimal resource allocation of 1 vCPU and 2 GB of RAM; increase these based on the nature of your PDF tasks or traffic demands.
   - **Network mode**: awsvpc 
   - **Port mappings**: Ensure these are properly configured as shown:
     ```json
     {
       "containerPort": 33350,
       "hostPort": 33350,
       "protocol": "tcp",
       "appProtocol": "grpc"
     }
     ```
   - **Image URI**: Input the DockerHub path to the desired IronPdfEngine version (e.g., "ironsoftwareofficial/ironpdfengine:2024.1.20").
   - Configure **AWS Permission** and **Networking** as per your specific requirements.
   - Activating **Amazon CloudWatch** for logging is advisable for easier troubleshooting.
   - **Container startup order** needs careful consideration if deploying your application in the same task definition.

3. **Launching the Task Definition**: Once your task definition is ready, decide if you'll run it as a **Task** or **Service**. Consult the [service creation guide](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/create-service-console-v2.html) for more details.

### Post-Deployment Tips

Make use of your now operational IronPdfEngine in AWS and consider how to scale based on your specific workload and demand, keeping in mind that IronPdfEngine currently does not support horizontal scaling. More details on this limitation can be found on the [IronPdfEngine Limitation page](https://ironsoftware.com/csharp/ocr/docs/get-started/ironpdfengine/#anchor-ironpdfengine-limitation).

This setup allows your applications with PDF processing capabilities directly within your AWS infrastructure.

## Setting Up IronPdfEngine on Azure Container Instances

### Prerequisites

Before diving into the setup, ensure that you have the IronPdfEngine Docker image already pulled. Refer to the earlier section titled [Setup IronPDF for Docker Container](https://ironsoftware.com/get-started/ironpdfengine/#anchor-setup-ironpdf-for-docker-container) for instructions on how to do this. Additionally, you will need an active Azure Account.

### Configuration Steps

1. **Initialize an Azure Container**: Begin by creating a container instance by following the [quickstart guide for deploying a container in Azure via the Azure portal](https://learn.microsoft.com/en-us/azure/container-instances/container-instances-quickstart-portal).

   Recommended Configuration:
  
   - **Image source**: Choose 'Other registry'.
   - **Image**: Use the Docker Hub image `ironsoftwareofficial/ironpdfengine:2024.1.20`.
   - **OS type**: Select 'Linux'.
   - **Size**: A minimum configuration of 1 vCPU and 2 GiB of memory is advised, although more may be required based on your specific needs.
   - **Port**: Set the TCP port to 33350.

2. **Completion**: Once configuration is complete, your IronPdfEngine should be operational within your newly setup Azure Container Instances.

Note: Azure Container Instances do not support horizontal scaling. Limitations are detailed further in the [IronPdfEngine Limitation](https://ironsoftware.com/get-started/ironpdfengine/#anchor-ironpdfengine-limitation) documentation.

## Accessing IronPdfEngine in AWS ECR Public Gallery

### Prerequisite

* Ensure Docker is installed on your system.

### Configuration Steps

1. Visit the AWS ECR Public Gallery for IronPdfEngine: [https://gallery.ecr.aws/v1m9w8y1/ironpdfengine](https://gallery.ecr.aws/v1m9w8y1/ironpdfengine)
2. Download the desired IronPdfEngine image:

```shell
docker pull https://gallery.ecr.aws/v1m9w8y1/ironpdfengine
```

Alternatively, to get a specific version:

```shell
docker pull https://gallery.ecr.aws/v1m9w8y1/ironpdfengine:2023.12.6
```

3. Start the IronPdfEngine container. Run the following command to initialize the container which allows it to operate in the background on port 33350:

```shell
docker run -d -p 33350:33350 ironsoftwareofficial/ironpdfengine
```

For guidance on configuring the IronPdf client to work with IronPdfEngine, refer to the section "Update the Code to Use IronPdfEngine" on [this page](https://ironsoftware.com/csharp/pdf/docs/questions/get-started/ironpdfengine/#anchor-ironpdfengine).

## Access IronPdfEngine via Online Marketplaces

We've simplified the initial setup for IronPdfEngine by making it available on both the Azure and AWS online marketplaces.

### Azure Marketplace

#### Quickly Start with IronPdfEngine on Azure

Deploying IronPdfEngine through Azure Marketplace simplifies the integration process, offering a straightforward setup for your projects. 

![Azure Marketplace Deployment](https://ironsoftware.com/static-assets/pdf/how-to/pull-run-ironpdfengine/azure-marketplace.webp)

**How to Set Up:**

1. Visit the [IronPDF Docker Container on Azure Marketplace](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/ironsoftwarecoltd1682560478296.ironpdf-docker-container-v1?tab=Overview). Choose "Get It Now" followed by "Continue."
2. Proceed through the setup steps including "Basics," "Cluster Details," and "Application Details" to set up the Kubernetes service.
3. Once set up is complete, from the side menu, choose Kubernetes resources > Run command. Then execute the following:

```shell
kubectl get services
```

The Kubernetes command center interface is shown in the image below, where you can receive details about the service status including the external IP address and port numbers.

![Run Kubernetes Command](https://ironsoftware.com/static-assets/pdf/how-to/pull-run-ironpdfengine/azure-market-run-command.webp)

With the service details, you can configure your IronPdfEngine connections effectively.

```csharp
using IronPdf;
using IronPdf.GrpcLayer;

IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";

var configuration = new IronPdfConnectionConfiguration
{
    ConnectionType = IronPdfConnectionType.RemoteServer,
    Host = "http://48.216.143.233",
    Port = 80
};
IronPdf.Installation.ConnectToIronPdfHost(configuration);

var renderer = new ChromePdfRenderer();
PdfDocument pdf = renderer.RenderHtmlAsPdf("<h1>testing</h1>");
pdf.SaveAs("output.pdf");
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <a href="https://azuremarketplace.microsoft.com/en-us/marketplace/apps/ironsoftwarecoltd1682560478296.ironpdf-docker-container-v1?tab=Overview"><img src="/static-assets/pdf/how-to/pull-run-ironpdfengine/azure-marketplace.webp" alt="Azure Marketplace" class="img-responsive add-shadow"></a>
    </div>
</div>

**Configuration Steps**

1. Visit the [IronPDF Docker Container on Azure Marketplace](https://azuremarketplace.microsoft.com/en-us/marketplace/apps/ironsoftwarecoltd1682560478296.ironpdf-docker-container-v1?tab=Overview). Select "Get It Now" followed by "Continue."

2. Fill out the "Basics", "Cluster Details", and "Application Details" sections to set up the Kubernetes service.

3. After the deployment finishes, go to the left sidebar, choose Kubernetes resources > Run command, and execute the following command:

```shell
kubectl get services
```

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="/static-assets/pdf/how-to/pull-run-ironpdfengine/azure-market-run-command.webp" alt="Kubernetes service - run command" class="img-responsive add-shadow">
    </div>
</div>

Using the details of the `EXTERNAL-IP` and `PORT(S)`, you can correctly establish a connection to the IronPDFEngine.

```csharp
using IronPdf;
using IronPdf.GrpcLayer;

// Set the license key to unlock IronPDF features
IronPdf.License.LicenseKey = "IRONPDF-MYLICENSE-KEY-1EF01";

// Configure a connection to a remote server 
var config = new IronPdfConnectionConfiguration 
{
    ConnectionType = IronPdfConnectionType.RemoteServer,
    Host = "http://48.216.143.233",
    Port = 80
};

// Connect to the IronPdf host using the configured settings
IronPdf.Installation.ConnectToIronPdfHost(config);

// Initialize a PDF renderer and generate a PDF from HTML
var pdfRenderer = new ChromePdfRenderer();
PdfDocument document = pdfRenderer.RenderHtmlAsPdf("<h1>testing</h1>");

// Save the generated PDF to a file
document.SaveAs("output.pdf");
```

### AWS Marketplace

<div style="text-align:center">
  <div style="display:inline-block">
     <a href="https://aws.amazon.com/marketplace/pp/prodview-t66wmni5ri7ve?sr=0-1&ref_=beagle&applicationId=AWSMPContessa"><img src="https://ironpdf.com/static-assets/pdf/how-to/pull-run-ironpdfengine/aws-marketplace.webp" alt="AWS Marketplace" style="width:100%; box-shadow:2px 2px 10px #ccc;"></a>
  </div>
</div>

**Getting Started**

1. Navigate to the [IronPdfEngine on the AWS Marketplace](https://aws.amazon.com/marketplace/pp/prodview-t66wmni5ri7ve?sr=0-1&ref_=beagle&applicationId=AWSMPContessa). Click on "Get It Now" followed by "Continue."

2. Approve the Terms of Service.

<div style="text-align:center">
  <div style="display:inline-block">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/pull-run-ironpdfengine/accept-EULA.webp" alt="Accept EULA" style="width:100%; box-shadow:2px 2px 10px #ccc;">
  </div>
</div>

3. Proceed to Configure your setup.

<div style="text-align:center">
  <div style="display:inline-block">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/pull-run-ironpdfengine/subscribe-complete.webp" alt="Subscription confirmation" style="width:100%; box-shadow:2px 2px 10px #ccc;">
  </div>
</div>

4. Begin the software launch process. This stage will provide a command to download the `ironpdfengine` Docker image.

<div style="text-align:center">
  <div style="display:inline-block">
    <img src="https://ironpdf.com/static-assets/pdf/how-to/pull-run-ironpdfengine/launch-this-software.webp" alt="Start software launch" style="width:100%; box-shadow:2px 2px 10px #ccc;">
  </div>
</div>

For example:

```shell
aws ecr get-login-password \
    --region us-east-1 | docker login \
    --username AWS \
    --password-stdin 000000000000.dkr.ecr.us-east-1.amazonaws.com
CONTAINER_IMAGES="000000000000.dkr.ecr.us-east-1.amazonaws.com/iron-software/ironpdfengine:2024.1.15"    
for i in $(echo $CONTAINER_IMAGES | sed "s/,/ /g"); do docker pull $i; done
```

5. Deploy the `ironpdfengine` container. Use the following command to launch the container in the background on port 33350:

```shell
docker run -d -p 33350:33350 000000000000.dkr.ecr.us-east-1.amazonaws.com/iron-software/ironpdfengine:2024.1.15
```

## Monitoring the Health of IronPdfEngine

Ensuring the operational stability of your Docker Container is essential for maintaining a reliable and scalable production environment. The capability to monitor the IronPdfEngine Docker container's health is invaluable for developers, providing them the opportunity to restart the service in the event of a failure, optimize resource allocation during peak demand, and continuously supervise the application's integrity.

To conduct a health check of the IronPdfEngine, a gRPC request can be sent to the designated port of the IronPdfEngine, usually port `33350`, to confirm its response and functionality.

### gRPC Health Monitoring for IronPdfEngine

IronPdfEngine complies with the conventional gRPC health checking protocol, which is structured as follows:

```protobuf
message HealthCheckRequest {
 string service = 1; // Specifies the service for health verification (e.g., "IronPdfEngine")
}
```

Here, we change the service name to `IronPdfEngine` as we are focusing on this specific service.

For instance, you can utilize [Postman](https://www.postman.com) and JavaScript to dispatch a gRPC request aimed at the local IronPdfEngine service, accessible at the default port 33350.

<div class="content-img-align-center">
  <div class="center-image-wrapper">
    <img src="/static-assets/pdf/how-to/Ironpdfengine-docker/servicestatus.webp" alt="Status" class="img-responsive add-shadow">
  </div>
</div>

-----
As evident from the feedback, the status returned is `SERVING`, signifying that the service is operational and functioning smoothly. Should there be an issue with the container's health, the status would reflect as `NOT_SERVING`.
-----

### Performing Health Checks in Kubernetes Environments

In Kubernetes environments, you can perform health checks using the configuration below to assess if the service is operating correctly:

```yaml
livenessProbe:
  exec:
    command:
      - /bin/grpc_health_probe
      - -addr=:33350
      - -rpc-timeout=5s
``` 

This setup configures a liveness probe that runs a gRPC health check command, ensuring that the service at port `33350` responds within `5` seconds.
