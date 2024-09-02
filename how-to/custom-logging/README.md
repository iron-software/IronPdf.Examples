# Implementing Custom Logging in C&num;

Custom logging is the technique of developing a logging mechanism that is specifically tailored to meet the unique needs and requirements of an application or system. This involves constructing and utilizing log files to capture information, events, and messages that are produced by the software throughout its operational process.

## Example of Implementing Custom Logging

To enable custom logging, set the `LoggingMode` property to `IronSoftware.Logger.LoggingModes.Custom`. Then, assign your custom logger class to the `CustomLogger` property.

```cs
IronSoftware.Logger.LoggingMode = IronSoftware.Logger.LoggingModes.Custom;
IronSoftware.Logger.CustomLogger = new MyLogger("application_logs");
```

By doing this, all IronPdf log entries will be rerouted to the `MyLogger` instance. The content of the messages stays the same; they are simply passed on to your custom logging tool. The behavior of this tool in handling these messages depends on how it's designed by its creator. Below is an example illustrating how to implement such a custom logger.

```cs
public class MyLogger : ILogger
{
    private readonly string logCategory;

    public MyLogger(string logCategory)
    {
        this.logCategory = logCategory;
    }

    public IDisposable BeginScope<TState>(TState state)
    {
        // Not implemented: scope management can be added here if needed
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        // Always enables logging regardless of the log level
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    {
        // Checks if the logging is enabled at this level
        if (!IsEnabled(logLevel))
        {
            return;
        }

        // Execute the custom logging procedure here
        string logEntry = formatter(state, exception);

        // Utilize 'logLevel', 'eventId', 'logCategory', and 'logEntry' to log the information as necessary
        // For instance, the log could be recorded in a file, display on the console, or sent to an alternative destination

        // Example: Outputting the log to the console
        Console.WriteLine($"Level: {logLevel}, Category: {logCategory}, Event ID: {eventId}, Message: {logEntry}");
    }
}
```

In this logger class, I've included additional details in the log messages as shown in the example.

<div class="content-img-align-center">
    <div class="center-image-wrapper">
         <img src="https://ironpdf.com/static-assets/pdf/how-to/custom-logging/console-window.webp" alt="Console window display" class="img-responsive add-shadow">
    </div>
</div>