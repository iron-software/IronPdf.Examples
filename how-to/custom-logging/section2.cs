public class CustomLoggerClass : ILogger
{
    private readonly string categoryName;

    public CustomLoggerClass(string categoryName)
    {
        this.categoryName = categoryName;
    }

    public IDisposable BeginScope<TState>(TState state)
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel)
    {
        return true;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    {
        if (!IsEnabled(logLevel))
        {
            return;
        }

        // Implement your custom logging logic here.
        string logMessage = formatter(state, exception);

        // You can use 'logLevel', 'eventId', 'categoryName', and 'logMessage' to log the message as needed.
        // For example, you can write it to a file, console, or another destination.

        // Example: Writing to the console
        Console.WriteLine($"[{logLevel}] [{categoryName}] - {logMessage}");
    }
}