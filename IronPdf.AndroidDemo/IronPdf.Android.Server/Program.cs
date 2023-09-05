using IronPdfEngine;
using IronPdfEngineService;

/*
 * --- Azure App Service Configuration ---
 *
 * Linux Docker w/ .NET 7.0
 *
 * HTTP20_ONLY_PORT             = 80
 * BLOB_STORAGE_CONNECTION      = <your blob storage connection string>
 * BLOB_STORAGE_CONTAINER       = <your blob storage container name>
 */
IronPdfServiceHandler.AssertVersion = false;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection_str = Environment.GetEnvironmentVariable("BLOB_STORAGE_CONNECTION");
var container_name = Environment.GetEnvironmentVariable("BLOB_STORAGE_CONTAINER");
builder.Services.AddGrpc();
builder.Services.AddSingleton<IObjectStore>(x =>
    new RemoteObjectStore(connection_str, container_name));

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<IronPdfServiceHandler>();
app.MapGet("/", () => $"Welcome to the IronPdf gRPC service (build {DateTime.Now}) Please use a client application to connect to IronPdf using host 'https://basicgrpcservice.azurewebsites.net' and port 80.");

app.Run();