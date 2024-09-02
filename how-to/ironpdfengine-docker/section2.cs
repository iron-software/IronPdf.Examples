using IronPdf.GrpcLayer;

var config = new IronPdfConnectionConfiguration();
config.ConnectionType = IronPdfConnectionType.Docker;
IronPdf.Installation.ConnectToIronPdfHost(config);